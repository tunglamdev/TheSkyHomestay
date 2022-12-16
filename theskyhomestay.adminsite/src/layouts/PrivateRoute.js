import { Navigate, Outlet } from 'react-router-dom'

const PrivateRoutes = () => {
  var token = localStorage.getItem("token");
  var isAuth = false;
  if(token != undefined) isAuth = true;
  return isAuth ? <Outlet /> : <Navigate to='/account' />
}

export default PrivateRoutes
