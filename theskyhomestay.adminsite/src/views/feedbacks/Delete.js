import Button from 'react-bootstrap/Button';
import { useState } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Feedbacks from './index';
import feedbackApi from "../../api/feedbackAPI";
import {useNavigate, useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const refresh = useNavigate();
    const {id} = useParams();

    const deleteFeedback = async () => {
        await feedbackApi.Delete(id);
        refresh(-1);
    }

    return (
        <>
            <Feedbacks />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Xóa loại phòng</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    Feedback bị xóa đi sẽ không hiển thị trên giao diện du khách.
                    Bạn chắc chắn muốn xóa feedback này? 
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/feedbacks"><Button variant="secondary">Thoát</Button></Link>
                    <Button onClick={deleteFeedback} variant="danger">Xóa</Button>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;