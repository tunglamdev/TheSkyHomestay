import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Categories from './index';
import categoryApi from "../../api/roomCategoryAPI";
import fileApi from "../../api/fileAPI";
import {useNavigate} from "react-router-dom";

function Create() {
    const [show] = useState(true);
    const { register, handleSubmit } = useForm();
    const refresh = useNavigate();

    const [imageUploadFile, setImageUploadFile] = useState(null);
    const onFileChange = (event) => {
        setImageUploadFile(event.target.files[0]);
    };

    const addCategory = async (content) => {
        if(content.Image.length == 0) {
            content.Image = 'default.jpg';
        }
        else{
            const formData = new FormData();
            formData.append("File", imageUploadFile);
            content.Image = await fileApi.Upload(formData, "categories");
        }
        await categoryApi.Create(content);
        refresh(-1);
    }
    
    return (
        <>
            <Categories />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(addCategory)}>
                    <Modal.Header>
                        <Modal.Title>Thêm loại phòng mới</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Tên loại phòng</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder="Nhập tên loại phòng"
                                autoFocus required
                            />
                        </Form.Group>
                        <Form.Group controlId="formFile" className="mb-3">
                            <Form.Label>Chọn hình ảnh</Form.Label>
                            <Form.Control 
                                type="file"
                                {...register("Image")}
                                onChange = {onFileChange}
                                accept="image/png, image/jpeg"
                             />
                        </Form.Group>
                    </Modal.Body>
                    <Modal.Footer>
                        <Link to="/categories"><Button variant="secondary">Thoát</Button></Link>
                        <Button type="submit" variant="success">Thêm</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Create;