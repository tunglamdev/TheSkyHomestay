import Button from 'react-bootstrap/Button';
import { useState , useEffect } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Rooms from './index';
import roomApi from "../../api/roomAPI";
import {useParams} from "react-router-dom";

function ShowImage() {
    const [show] = useState(true);
    const {id} = useParams();
    const [room, setRoom] = useState([]);
    useEffect(() => async () =>{
        const data = await roomApi.GetById(id);
        await setRoom(data);
    }, []);

    return (
        <>
            <Rooms />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Ảnh: {room.name}</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    {room.images?.map((img, key) => (
                        <img src={img.name} style={{width: "220px", marginTop: "10px", marginRight:"10px"}}></img>
                    ))}
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/rooms"><Button variant="secondary">Thoát</Button></Link>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default ShowImage;