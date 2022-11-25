import { useEffect, useState } from "react";
import {Link} from "react-router-dom";
import Table from 'react-bootstrap/Table';
import {Button} from "reactstrap"
import serviceApi from "../../api/serviceAPI";

function Services(){
  const [servicesList, setServices] = useState([]);

  useEffect(() => async () =>{
    const data = await serviceApi.GetAll();
    setServices(data);
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
                <h4 className="font-weight-bold mb-3">Danh sách các dịch vụ</h4>
                <Link to="/services/create"><Button color="success"><i class='bx bx-plus' ></i>Thêm dịch vụ</Button></Link>
                <Table className="mt-3" striped bordered hover>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Tên dịch vụ</th>
                      <th>Giá tiền</th>
                      <th>Hình ảnh</th>
                      <th>Thao tác</th>
                    </tr>
                  </thead>
                  <tbody>
                    {servicesList.map((s, key) => (
                      <tr key={s.id}>
                        <td>{key+1}</td>
                        <td>{s.name}</td>
                        <td>{formatter.format(s.price)}</td>
                        <td><Link to={`./${s.id}/image`}><Button className="me-2" color="success"><i class='bx bx-image'></i>Xem ảnh</Button></Link></td>
                        <td>
                          <Link to={`./edit/${s.id}`}><Button className="me-2" color="warning"><i class='bx bxs-edit'></i>Chỉnh sửa</Button></Link>
                          <Link to={`./delete/${s.id}`}><Button color="danger"><i class='bx bx-x-circle'></i>Xóa</Button></Link>
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

export default Services;