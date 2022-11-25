import Button from 'react-bootstrap/Button';
import { useState, useEffect } from "react";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Rooms from './index';
import roomApi from "../../api/roomAPI";
import categoryApi from "../../api/roomCategoryAPI";
import fileApi from "../../api/fileAPI";
import roomImageApi from "../../api/roomImageAPI";
import {useNavigate, useParams} from "react-router-dom";

function Edit() {
    const [show] = useState(true);
    const { register, handleSubmit } = useForm();
    const refresh = useNavigate();
    const [imageFiles, setImageFiles] = useState([]);
    const [oldImageIds, setOldImageIds] = useState([]);
    const {id} = useParams();

    //------------------- Add files onchange input
    function addFiles(files) {
        var isValid = true;
        const newImageFiles = [...imageFiles, ...files];
        if (newImageFiles.length > 10) {
          console.log("Chỉ chọn tối đa 10 hình");
          isValid = false;
        };
        if (isValid) {
          setImageFiles(newImageFiles);
        };
    }

    //----------remove image when click on X icon------------
    function removeImage(index) {
        if (index >= 0 && index < imageFiles.length) {
          const newImageFiles = [...imageFiles];
          newImageFiles.splice(index, 1);
          setImageFiles(newImageFiles);
        }
    }

    useEffect(() => {}, [oldImageIds, imageFiles]);

    //-----------remove old image-----------
    function removeOldImage(imageId) {
        const result = [...oldImageIds];
        result.push(imageId);
        setOldImageIds(result);
    }

    //---------------category--------------
    const [categoriesList, setCategories] = useState([]);
    useEffect(() => async () =>{
        const data = await categoryApi.GetAll();
        setCategories(data);
    }, []);

    //---------------room------------------
    const [room, setRoom] = useState([]);
    useEffect(() => async () =>{
        const data = await roomApi.GetById(id);
        setRoom(data);
    }, []);

    //-------------Remove image------------
    const deleteImage = ( async imageId =>
        await roomImageApi.Detele(imageId)
    );

    //---------------Edit room----------------
    const editRoom =( async (content) => {
        console.log(content)
        content.Id = room.id;
        if(content.Name == "") content.Name = room.name;
        if(content.Price == "") content.Price = room.price;
        if(content.Description == "") content.Description = room.description;
        await roomApi.Edit(content);

        //Add new image
        if(imageFiles.length > 0){
            content.RoomId = room.id;
            content.Description = "Ảnh "+ content.Name;
            imageFiles.forEach(async (image) => {
                const formData = new FormData();
                formData.append("File", image);
                content.Name = await fileApi.Upload(formData, "rooms");
                await roomImageApi.Create(content);
            });
        };

        //remove image
        if(oldImageIds.length > 0){
            console.log(oldImageIds)
            oldImageIds.forEach(async (imageId) => {
                var image = await roomImageApi.GetById(imageId);
                await fileApi.Delete("rooms", image.name);
                await roomImageApi.Delete(imageId);
            })
        };

        refresh(-1);
    });
    
    return (
        <>
            <Rooms />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(editRoom)}>
                    <Modal.Header>
                        <Modal.Title>Chỉnh sửa thông tin phòng</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Control
                            type="text"
                            {...register("Id")}
                            hidden
                        />
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Loại phòng</Form.Label>
                            <Form.Select {...register("CategoryId")} required autoFocus>
                                {categoriesList.map(ca => 
                                    {if(ca.id == room.categoryId)
                                        return <option value={ca.id} selected>{ca.name}</option>
                                    
                                    else 
                                        return <option value={ca.id}>{ca.name}</option>
                                    }
                                )}
                            </Form.Select>
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Tên phòng</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder="Nhập tên phòng"
                                required
                                defaultValue={room.name}
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Giá tiền</Form.Label>
                            <Form.Control
                                type="number"
                                {...register("Price")}
                                placeholder="Nhập giá tiền"
                                min="100000"
                                step="50000"
                                required
                                defaultValue={room.price}
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
                            <Form.Label>Mô tả</Form.Label>
                            <Form.Control 
                                as="textarea" rows={3}
                                type="text"
                                {...register("Description")}
                                placeholder="Nhập mô tả"
                                required
                                defaultValue={room.description}
                            />
                        </Form.Group>
                        <Form.Group controlId="formFile" className="mb-3">
                            <Form.Label>Chọn hình ảnh</Form.Label>
                            <Form.Control 
                                type="file"
                                {...register("Image")}
                                onChange={(e) => addFiles(e.target.files)}
                                accept="image/png, image/jpeg"
                                multiple
                             />
                        </Form.Group>
                    </Modal.Body>
                    {room?.images?.length > 0 &&
                        room?.images
                            ?.filter((x) => !oldImageIds.includes(x.id))
                            ?.map((image, index) => (
                                <div
                                    key={"oldPhotos" + index}
                                    style={{position: "relative", display: "inline-block"}}
                                >
                                    <img src={image.name} alt="Preview" style={{width: "100px", marginLeft: "10px"}}/>
                                    <i onClick={() => removeOldImage(image?.id)} className='bx bx-x-circle' style={{position: "absolute", fontSize: "24px", top: "0", right: "0"}}></i>
                                </div>
                    ))}

                    {imageFiles.length > 0 && imageFiles.map((imageFile, index) => (
                        <div
                            key={"imageFiles" + index}
                            style={{position: "relative", display: "inline-block"}}
                        >
                            <img src={URL.createObjectURL(imageFile)} alt="Preview" style={{width: "100px", marginLeft: "10px"}}/>
                            <i onClick={() => removeImage(index)} className='bx bx-x-circle' style={{position: "absolute", fontSize: "24px", top: "0", right: "0"}}></i>
                        </div>
                    ))}
                    <Modal.Footer>
                        <Link to="/rooms"><Button variant="secondary">Thoát</Button></Link>
                        <Button type="submit" variant="warning">Chỉnh sửa</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Edit;