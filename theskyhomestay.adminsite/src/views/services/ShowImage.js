import Button from 'react-bootstrap/Button';
import { useState , useEffect } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Services from './index';
import serviceApi from "../../api/serviceAPI";
import {useParams} from "react-router-dom";

function Delete() {
    const [show] = useState(true);
    const {id} = useParams();
    const [service, setService] = useState([]);
    useEffect(() => async () =>{
        const data = await serviceApi.GetById(id);
        setService(data);
    }, []);

    return (
        <>
            <Services />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Ảnh: {service.name}</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                   <img src={service.image} style={{width: "470px"}}></img>
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/services"><Button variant="secondary">Thoát</Button></Link>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default Delete;