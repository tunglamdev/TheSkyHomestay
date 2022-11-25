import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Services from './index';
import serviceApi from "../../api/serviceAPI";
import {useNavigate, useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const refresh = useNavigate();
    const {id} = useParams();

    const deleteService = async () => {
        await serviceApi.Delete(id);
        refresh(-1);
    }

    return (
        <>
            <Services />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Xóa dịch vụ</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    Bạn chắc chắn muốn xóa dịch vụ này?
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/services"><Button variant="secondary">Thoát</Button></Link>
                    <Button onClick={deleteService} variant="danger">Xóa</Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;