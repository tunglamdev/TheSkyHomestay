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
import {useNavigate} from "react-router-dom";
function Create() {
    const [show] = useState(true);
    const { register, handleSubmit } = useForm();
    const refresh = useNavigate();
    const [imageFiles, setImageFiles] = useState([]);
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

    function removeImage(index) {
        if (index >= 0 && index < imageFiles.length) {
          const newImageFiles = [...imageFiles];
          newImageFiles.splice(index, 1);
          setImageFiles(newImageFiles);
        }
    }

    useEffect(() => {}, [imageFiles]);

    //category
    const [categoriesList, setCategories] = useState([]);
    useEffect(() => async () =>{
        const data = await categoryApi.GetAll();
        setCategories(data);
    }, []);

    // const [selectedFile, setSelectedFile] = useState();
    // const [preview, setPreview] = useState();

    // useEffect(() => {
    //     if (!selectedFile) {
    //         setPreview(undefined);
    //         return;
    //     }

    //     const objectUrl = URL.createObjectURL(selectedFile);
    //     setPreview(objectUrl);

    //     return () => URL.revokeObjectURL(objectUrl);
    // }, [selectedFile]);

    // const onSelectFile = e => {
    //     if (!e.target.files || e.target.files.length === 0) {
    //         setSelectedFile(undefined);
    //         return;
    //     };
    //     setSelectedFile(e.target.files);
    // }
    const addImage = (async obj =>
        await roomImageApi.Create(obj)
    );
    const addRoom =( async (content) => {
        content.RoomId = await roomApi.Create(content);
        content.Description = "Ảnh phòng "+ content.Name;

        imageFiles.forEach(async (image) => {
            const formData = new FormData();
            formData.append("File", image);
            content.Name = await fileApi.Upload(formData, "rooms");
            addImage(content);
        });

        refresh(-1);
    });
    
    return (
        <>
            <Rooms />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(addRoom)}>
                    <Modal.Header>
                        <Modal.Title>Thêm phòng mới</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Chọn loại phòng</Form.Label>
                            <Form.Select {...register("CategoryId")} required autoFocus>
                                {categoriesList.map(ca => (
                                    <option value={ca.id}>{ca.name}</option>
                                ))}
                            </Form.Select>
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Nhập tên phòng</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder="Nhập tên phòng"
                                required
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
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Nhập mô tả</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Description")}
                                placeholder="Nhập mô tả"
                                required
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
                                required
                             />
                        </Form.Group>
                    </Modal.Body>
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
                        <Button type="submit" variant="success">Thêm</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Create;