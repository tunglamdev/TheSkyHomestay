import Button from 'react-bootstrap/Button';
import { useState , useEffect } from "react";
import Form from 'react-bootstrap/Form';
import { useForm } from "react-hook-form"
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Categories from './index';
import categoryApi from "../../api/roomCategoryAPI";
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

    const [category, setCategory] = useState([]);
    useEffect(() => async () =>{
        const data = await categoryApi.GetById(id);
        setCategory(data);
    }, []);

    const updateCategory = async (content) => {
        content.Id = category.id;
        if(content.Image.length == 0) content.Image = "";
        else{
            var oldFileName = category.image.slice(category.image.lastIndexOf('/')+1, category.image.length);
            await fileApi.Delete("categories", oldFileName);
            const formData = new FormData();
            formData.append("File", imageUploadFile);
            content.Image = await fileApi.Upload(formData, "categories");

        }
        await categoryApi.Edit(content);
        refresh(-1);
    }

    return (
        <>
            <Categories />

            <Modal show={show} backdrop="static">
                <Form onSubmit={handleSubmit(updateCategory)}>
                    <Modal.Header>
                        <Modal.Title>Chỉnh sửa thông tin loại phòng</Modal.Title>
                    </Modal.Header>
                    <Modal.Body>
                        <Form.Control
                            type="text"
                            {...register("Id")}
                            hidden
                        />
                        <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>Tên loại phòng</Form.Label>
                            <Form.Control
                                type="text"
                                {...register("Name")}
                                placeholder=""
                                defaultValue={category.name}
                                autoFocus required
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
                        <img src={category.image} style={{width: "100px"}}></img>
                    </Modal.Body>
                    <Modal.Footer>
                        <Link to="/categories"><Button variant="secondary">Thoát</Button></Link>
                        <Button type="submit" variant="warning">Chỉnh sửa</Button>
                    </Modal.Footer>
                </Form>
            </Modal>
        </>
    );
}

export default Update;