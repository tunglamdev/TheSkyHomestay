import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Categories from './index';
import roomApi from "../../api/roomAPI";
import {useNavigate, useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const refresh = useNavigate();
    const {id} = useParams();

    const deleteRoom = async () => {
        await roomApi.Delete(id);
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
                    Bạn chắc chắn muốn xóa phòng này?
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/rooms"><Button variant="secondary">Thoát</Button></Link>
                    <Button onClick={deleteRoom} variant="danger">Xóa</Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;