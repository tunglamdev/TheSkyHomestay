import Button from 'react-bootstrap/Button';
import { useState , useEffect } from "react";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Services from './index';
import serviceApi from "../../api/serviceAPI";
import fileApi from "../../api/fileAPI";
import {useNavigate, useParams} from "react-router-dom";

function Update() {
    const [show] = useState(true);
    const { register, handleSubmit } = useForm();
    const refresh = useNavigate();
    const {id} = useParams();

    const [imageUploadFile, setImageUploadFile] = useState(null);
    const onFileChange = (event) => {
        setImageUploadFile(event.target.files[0]);
    };

    const [service, setService] = useState([]);
    useEffect(() => async () =>{
        const data = await serviceApi.GetById(id);
        setService(data);
    }, []);

    const updateService = async (content) => {
        content.Id = service.id;
        if(content.Price == "") content.Price = service.price;
        if(content.Description == "") content.Description = service.description;
        if(content.Image.length == 0) content.Image = "";
        else{
            var oldFileName = service.image.slice(service.image.lastIndexOf('/')+1, service.image.length);
            await fileApi.Delete("services", oldFileName);
            const formData = new FormData();
            formData.append("File", imageUploadFile);
            content.Image = await fileApi.Upload(formData, "services");
        }
        await serviceApi.Edit(content);
        refresh(-1);
    }

    return (
        <>
            <Services />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(updateService)}>
                    <Modal.Header>
                        <Modal.Title>Chỉnh sửa thông tin dịch vụ</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Control
                            type="text"
                            {...register("Id")}
                            hidden
                        />
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Tên dịch vụ</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder=""
                                defaultValue={service.name}
                                autoFocus required
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Giá tiền</Form.Label>
                            <Form.Control
                                type="number"
                                {...register("Price")}
                                placeholder=""
                                defaultValue={service.price}
                                min="50000"
                                step="10000"
                                required
                            />
                        </Form.Group>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Mô tả</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Description")}
                                placeholder=""
                                defaultValue={service.description}
                                required
                            />
                        </Form.Group>
                        <Form.Group controlId="formFile" className="mb-3">
                            <Form.Label>Hình ảnh</Form.Label>
                            <Form.Control 
                                type="file"
                                {...register("Image")}
                                onChange = {onFileChange}
                                accept="image/png, image/jpeg"
                             />
                        </Form.Group>
                        <img src={service.image} style={{width: "100px"}}></img>
                    </Modal.Body>
                    <Modal.Footer>
                        <Link to="/services"><Button variant="secondary">Thoát</Button></Link>
                        <Button type="submit" variant="warning">Chỉnh sửa</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Update;