import {useState, useEffect } from "react";
import {Button} from "reactstrap";
import {Link} from "react-router-dom";
import Form from 'react-bootstrap/Form';
import Modal from 'react-bootstrap/Modal';
import { useForm } from "react-hook-form"
import Table from 'react-bootstrap/Table';
import DatePicker from 'react-datepicker';
import "react-datepicker/dist/react-datepicker.css";
import roomApi from "../../api/roomAPI";

function Bookings(){
    const [show, setShow] = useState(false);
    const [roomsList, setRooms] = useState([]);
    const [selectedCheckInDate, setSelectedCheckInDate] = useState(null);
    const [selectedCheckOutDate, setSelectedCheckOutDate] = useState(null);
    const [detail, setDetail] = useState([]);
    const {handleSubmit } = useForm();

    const startShow = async (roomId) =>{
        const content = {
            FromDate: selectedCheckInDate,
            ToDate: selectedCheckOutDate,
            RoomId: roomId
        }
        
        content.FromDate = new Date(selectedCheckInDate);
        content.FromDate.setDate(content.FromDate.getDate() + 1);
        content.FromDate = content.FromDate.toISOString();
        content.FromDate = content.FromDate.slice(0, content.FromDate.indexOf("T"));

        content.ToDate = new Date(selectedCheckOutDate);
        content.ToDate.setDate(content.ToDate.getDate() + 1);
        content.ToDate = content.ToDate.toISOString();
        content.ToDate = content.ToDate.slice(0, content.ToDate.indexOf("T"));

        var result = await roomApi.GetBookingDetail(content);
        result.forEach(element => {
            element.checkInDate = new Date(element.checkInDate);
            element.checkInDate = element.checkInDate.toLocaleDateString("vi-VN");
    
            element.checkOutDate = new Date(element.checkOutDate);
            element.checkOutDate = element.checkOutDate.toLocaleDateString("vi-VN");
        });
        console.log(result);
        setDetail(result);
        setShow(true); 
    }

    const endShow = () => setShow(false); 

    const checkRoom = async (content) => {
        content.FromDate = new Date(selectedCheckInDate);
        content.FromDate.setDate(content.FromDate.getDate() + 1);
        content.FromDate = content.FromDate.toISOString();
        content.FromDate = content.FromDate.slice(0, content.FromDate.indexOf("T"));

        content.ToDate = new Date(selectedCheckOutDate);
        content.ToDate.setDate(content.ToDate.getDate() + 1);
        content.ToDate = content.ToDate.toISOString();
        content.ToDate = content.ToDate.slice(0, content.ToDate.indexOf("T"));
        var data = await roomApi.Check(content);
        setRooms(data);
    }

    useEffect(() => {}, [roomsList, show, detail]);

    const formatter = new Intl.NumberFormat('vi-VN', {
        style: 'currency',
        currency: 'VND',
    });
    
    return (
        <div>
            <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
                <div style={{height:"100%"}}>
                    <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
                        <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
                            <div className="mt-5 w-100">
                                <h4 className="font-weight-bold mb-3">Qu???n l?? tr???ng th??i ph??ng</h4>
                                <Form onSubmit={handleSubmit(checkRoom)}>
                                    <Table>
                                        <thead>
                                            <tr>
                                                <th>Ng??y check-in:</th>
                                                <th>Ng??y check-out:</th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                                                        <DatePicker
                                                            selected={selectedCheckInDate}
                                                            onChange={(date) => setSelectedCheckInDate(date)}
                                                            // minDate={new Date()}
                                                        />
                                                    </Form.Group>
                                                </td>
                                                <td>
                                                    <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                                                        <DatePicker
                                                            selected={selectedCheckOutDate}
                                                            onChange={(date) => setSelectedCheckOutDate(date)}
                                                            // minDate={new Date()}
                                                        />
                                                    </Form.Group>
                                                </td>
                                                <td>
                                                <Button className="me-2" color="success">Ki???m tra ph??ng</Button>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </Table>
                                </Form>
                                
                                <Table className="mt-3" striped bordered hover>
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>T??n ph??ng</th>
                                            <th>Gi?? ti???n</th>
                                            <th>Tr???ng th??i</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {roomsList?.map((room, key) => (
                                        <tr key={room.id}>
                                            <td>{key+1}</td>
                                            <td>{room.name}</td>
                                            <td>{formatter.format(room.price)}</td>
                                            <td>
                                                {room.state == 2 && (
                                                    <Link to=""><Button className="me-2" color="warning"><i class='bx bxs-edit'></i>?????t ph??ng</Button></Link>
                                                )}

                                                {room.state == 1 && (
                                                    <Button onClick={() => startShow(room.id)} className="me-2" color="success">Xem chi ti???t</Button>
                                                )}
                                            </td>
                                        </tr>
                                        ))}
                                    </tbody>
                                </Table>
                            </div>
                        </div>      
                    </div>
                </div>
            </div>

            <Modal show={show} backdrop="static">
                <Modal.Header>
                    <Modal.Title>Th??ng tin ?????t ph??ng</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    {detail?.map(detail =>
                        <div>
                            <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                            <Form.Label>T??n du kh??ch - S??T</Form.Label>
                            {/* <Form.Control
                                type="text"
                                defaultValue={detail.name}
                                disabled
                            /> */}
                                <h5>{detail.name} - {detail.phoneNumber}</h5>
                            </Form.Group>
                            <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>Email</Form.Label>
                                {/* <Form.Control
                                    type="text"
                                    defaultValue={detail.email}
                                    disabled
                                /> */}
                                <h5>{detail.email}</h5>
                            </Form.Group>
                            <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>CMND/CCCD</Form.Label>
                                {/* <Form.Control
                                    type="text"
                                    defaultValue={detail.ciNo}
                                    disabled
                                /> */}
                                <h5>{detail.ciNo}</h5>
                            </Form.Group>
                            <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
                                <Form.Label>Ng??y ?????n - Ng??y ??i:</Form.Label>
                                {/* <Form.Control
                                    type="text"
                                    defaultValue={detail.checkInDate}
                                    disabled
                                /> */}
                                <h5>{detail.checkInDate} - {detail.checkOutDate}</h5>
                            </Form.Group>
                            <hr></hr>
                            <br></br>
                        </div>
                    )}
                </Modal.Body>
                <Modal.Footer>
                    <Button onClick={endShow} variant="secondary">Tho??t</Button>
                </Modal.Footer>
            </Modal>
        </div>
    );
}

export default Bookings;