import React from "react";
import '../assets/scss/sidebar.scss';
import '../assets/css/admin.css';
import Sidebar from '../components/Sidebar'
import { Outlet } from "react-router-dom";


const Admin = () => {
  return ( 
    <div className="dashboard d-flex background-image-admin-site" style={{
      padding: '0px 0px 0px 320px',
    }}>

    	<div>
        <Sidebar/>
      </div>

      <div style={{flex:"1 1 auto", display:"flex", flexFlow:"column", height:"100vh", overflowY:"hidden"}}>
        <Outlet/>
      </div>
      
    </div>
  );
}

export default Admin;