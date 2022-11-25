import { useEffect, useState } from "react";
import {Link} from "react-router-dom";
import Table from 'react-bootstrap/Table';
import {Button} from "reactstrap"
import roomApi from "../../api/roomAPI";

function Rooms(){
  const [roomsList, setRooms] = useState([]);

  useEffect(() => async () =>{
    const data = await roomApi.GetAll();
    setRooms(data);
  }, []);

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
                <h4 className="font-weight-bold mb-3">Danh sách các phòng</h4>
                <Link to="/rooms/create"><Button color="success"><i class='bx bx-plus' ></i>Thêm phòng mới</Button></Link>
                <Table className="mt-3" striped bordered hover>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Tên phòng</th>
                      <th>Giá tiền</th>
                      <th>Hình ảnh</th>
                      <th>Thao tác</th>
                    </tr>
                  </thead>
                  <tbody>
                    {roomsList.map((r, key) => (
                      <tr key={r.id}>
                        <td>{key+1}</td>
                        <td>{r.name}</td>
                        <td>{formatter.format(r.price)}</td>
                        <td><Link to={`./${r.id}/image`}><Button className="me-2" color="success"><i class='bx bx-image'></i>Xem ảnh</Button></Link></td>
                        <td>
                          <Link to={`./edit/${r.id}`}><Button className="me-2" color="warning"><i class='bx bxs-edit'></i>Chỉnh sửa</Button></Link>
                          <Link to={`./delete/${r.id}`}><Button color="danger"><i class='bx bx-x-circle'></i>Xóa</Button></Link>
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
    </div>
  );
}

export default Rooms;