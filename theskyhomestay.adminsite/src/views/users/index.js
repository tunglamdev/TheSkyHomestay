import { useEffect, useState } from "react";
import Table from 'react-bootstrap/Table';
import userApi from "../../api/userAPI";

function Users(){
  const [userList, setUsers] = useState([]);

  useEffect(() => async () =>{
    const data = await userApi.GetAll();
    setUsers(data);
  }, []);
    
  return (
    <div>
      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <div style={{height:"100%"}}>
          <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
            <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
              <div className="mt-5 w-100">
                <h4 className="font-weight-bold mb-3">Danh sách tài khoản du khách</h4>
                {/* <Link to="/products/add"><Button color="success"><i class='bx bx-plus' ></i>Thêm dịch vụ</Button></Link> */}
                <Table className="mt-3" striped bordered hover>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Tên du khách</th>
                      <th>Số điện thoại</th>
                      <th>CMND/CCCD</th>
                      <th>Email</th>
                    </tr>
                  </thead>
                  <tbody>
                    {userList.map((u, key=0) => (
                      <tr>
                        <td>{key+1}</td>
                        <td>{u.name}</td>
                        <td>{u.phoneNumber}</td>
                        <td>{u.ciNo}</td>
                        <td>{u.email}</td>
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

export default Users;