import { useEffect, useState } from "react";
import {Button} from "reactstrap";
import {Link} from "react-router-dom";
import Table from 'react-bootstrap/Table';
import categoryApi from "../../api/roomCategoryAPI";

function Categories(){
  const [categoriesList, setCategories] = useState([]);

  useEffect(() => async () =>{
    const data = await categoryApi.GetAll();
    setCategories(data);
  }, []);
    
  return (
    <div>
      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <div style={{height:"100%"}}>
          <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
            <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
              <div className="mt-5 w-100">
                <h4 className="font-weight-bold mb-3">Danh sách loại phòng</h4>
                <Link to="./create"><Button color="success"><i class='bx bx-plus' ></i>Thêm loại mới</Button></Link>
                <Table className="mt-3" striped bordered hover>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Tên loại phòng</th>
                      <th>Hình ảnh</th>
                      <th>Thao tác</th>
                    </tr>
                  </thead>
                  <tbody>
                    {categoriesList.map((ca, key) => (
                      <tr>
                        <td>{key+1}</td>
                        <td>{ca.name}</td>
                        <td><Link to={`./${ca.id}/image`}><Button className="me-2" color="success"><i class='bx bx-image'></i>Xem ảnh</Button></Link></td>
                        <td>
                          <Link to={`./edit/${ca.id}`}><Button className="me-2" color="warning"><i class='bx bxs-edit'></i>Chỉnh sửa</Button></Link>
                          <Link to={`./delete/${ca.id}`}><Button color="danger"><i class='bx bx-x-circle'></i>Xóa</Button></Link>
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

export default Categories;