import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Categories from './index';
import categoryApi from "../../api/roomCategoryAPI";
import {useNavigate, useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const refresh = useNavigate();
    const {id} = useParams();

    const deleteCategory = async () => {
        await categoryApi.Delete(id);
        refresh(-1);
    }

    return (
        <>
            <Categories />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Xóa loại phòng</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    Bạn chắc chắn muốn xóa loại phòng này? 
                    Tất cả các phòng thuộc loại phòng này sẽ bị xóa?
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/categories"><Button variant="secondary">Thoát</Button></Link>
                    <Button onClick={deleteCategory} variant="danger">Xóa</Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;