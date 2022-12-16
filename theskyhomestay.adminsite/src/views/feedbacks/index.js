import { useEffect, useState } from "react";
import {Button} from "reactstrap";
import {Link} from "react-router-dom";
import Table from 'react-bootstrap/Table';
import feedbackApi from "../../api/feedbackAPI";

function Feedbacks(){
  const [feedbackList, setFeedbacks] = useState([]);

  useEffect(() => async () =>{
    const data = await feedbackApi.GetAll();
    setFeedbacks(data);
  }, []);
    
  return (
    <div>
      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <div style={{height:"100%"}}>
          <div style={{padding:"20px 5%",height:"calc(100% - 64px)",overflowY:"scroll"}}>
            <div style={{gridTemplateColumns:"repeat(1, minmax(200px, 700px))"}}>
              <div className="mt-5 w-100">
                <h4 className="font-weight-bold mb-3">Danh sách các lượt feedback</h4>
                <Table className="mt-3" striped bordered hover>
                  <thead>
                    <tr>
                      <th>#</th>
                      <th>Tên du khách</th>
                      <th>Nội dung feedback</th>
                      <th>Số sao</th>
                      <th>Thao tác</th>
                    </tr>
                  </thead>
                  <tbody>
                    {feedbackList.map((fb, key) => (
                      <tr>
                        <td>{key+1}</td>
                        <td>{fb.touristName}</td>
                        <td>{fb.comment}</td>
                        <td>{fb.vote}</td>
                        <td>
                          <Link to={`./delete/${fb.id}`}><Button color="danger">Xóa</Button></Link>
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

export default Feedbacks;