import { useEffect, useState } from "react";
import Table from 'react-bootstrap/Table';
import userApi from "../../api/userAPI";
import Tab from 'react-bootstrap/Tab';
import Tabs from 'react-bootstrap/Tabs';

function Users(){
  const [memberList, setMembers] = useState([]);
  const [guestList, setGuests] = useState([]);

  useEffect(() => async () =>{
    const member = await userApi.GetAllMember();
    const guest = await userApi.GetAllGuest();
    setMembers(member);
    setGuests(guest);

  }, []);
    
  return (
    <div>
      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <div style={{height:"100%"}}>
          <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
            <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
              <div className="mt-5 w-100">
                <h4 className="font-weight-bold mb-3">Danh sách tài khoản du khách</h4>
                <Tabs
                    defaultActiveKey="member"
                    id="uncontrolled-tab-example"
                    className="mb-3"
                >
                    <Tab eventKey="member" title="Danh sách du khách thành viên">
                        <Tab.Container id="left-tabs-example" defaultActiveKey="first">
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
                              {memberList.map((u, key=0) => (
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
                        </Tab.Container>
                    </Tab>
                    <Tab eventKey="guest" title="Danh sách du khách vãng lai">
                        <Tab.Container id="left-tabs-example" defaultActiveKey="first">
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
                              {guestList.map((u, key=0) => (
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
                        </Tab.Container>
                    </Tab>
                </Tabs>
              </div>
            </div>      
          </div>
        </div>
      </div>
    </div>
  );
}

export default Users;