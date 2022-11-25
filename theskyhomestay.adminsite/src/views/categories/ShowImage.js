import Button from 'react-bootstrap/Button';
import { useState , useEffect } from "react";
import Modal from 'react-bootstrap/Modal';
import { Link } from "react-router-dom";
import Categories from './index';
import categoryApi from "../../api/roomCategoryAPI";
import {useParams} from "react-router-dom";

function ShowImage() {
    const [show] = useState(true);
    const {id} = useParams();
    const [category, setCategory] = useState([]);
    useEffect(() => async () =>{
        const data = await categoryApi.GetById(id);
        setCategory(data);
    }, []);

    return (
        <>
            <Categories />

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Ảnh: {category.name}</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                   <img src={category.image} style={{width: "470px"}}></img>
                </Modal.Body>
                <Modal.Footer>
                    <Link to="/categories"><Button variant="secondary">Thoát</Button></Link>
                </Modal.Footer>
            </Modal>
        </>
    );
}

export default ShowImage;