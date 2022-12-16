import {React, useState} from 'react';
import {
  MDBBtn,
  MDBContainer,
  MDBRow,
  MDBCol,
  MDBCard,
  MDBCardBody,
  MDBInput,
  MDBIcon,
}
from 'mdb-react-ui-kit';
import '../assets/css/login.css';
import logo from '../assets/images/Logo.png';
import { useForm } from "react-hook-form";
import accountApi from "../api/accountAPI";

function App() {
  const [username, setUsername] = useState();
  const [password, setPassword] = useState();
  const {handleSubmit } = useForm();
  const login = async (content) => {
    content.username = username;
    content.password = password;
    await accountApi
      .Login(content)
      .then((response) => {
          console.log(response);
          window.localStorage.setItem("token", response);
          window.location.href = "http://localhost:3000/bookings";
      })
  }
  return (
      <MDBContainer>
        <MDBRow className='d-flex justify-content-center align-items-center h-100'>
          <MDBCol col='12'>
            <MDBCard className='bg-white my-5 mx-auto' style={{borderRadius: '1rem', maxWidth: '500px'}}>
              <MDBCardBody className='p-5 w-100 d-flex flex-column'>

                <div className="d-flex justify-content-center">
                  <img className="" src={logo} style={{width: '220px'}}/>
                </div>

                <h2 className="fw-bold mb-5 mt-3 text-center">Hello Admin!</h2>
                <form onSubmit={handleSubmit(login)}>
                  <MDBInput wrapperClass='mb-4 w-100' label='Địa chỉ email' type='email' size="lg" value={username} onChange={(e) => setUsername(e.target.value)}/>

                  <MDBInput wrapperClass='mb-4 w-100' label='Mật khẩu' type='password' size="lg" value={password} onChange={(e) => setPassword(e.target.value)}/>
                  <div className="d-flex justify-content-center">
                    <MDBBtn size='lg'>Đăng nhập</MDBBtn>
                  </div>
                </form>

                <hr className="mt-5"/>

                <MDBBtn className="mb-2 w-100" size="lg" style={{backgroundColor: '#dd4b39'}}>
                <MDBIcon fab icon="google" className="mx-2"/>Sign in with google</MDBBtn>

                <MDBBtn className="mb-4 w-100" size="lg" style={{backgroundColor: '#3b5998'}}>
                <MDBIcon fab icon="facebook-f" className="mx-2"/>Sign in with facebook</MDBBtn>
                
              </MDBCardBody>
            </MDBCard>
          </MDBCol>
        </MDBRow>
      </MDBContainer>
  );
}

export default App;

