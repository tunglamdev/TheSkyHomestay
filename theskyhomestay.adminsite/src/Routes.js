import React from "react";
import {BrowserRouter, Routes, Route } from "react-router-dom";
import Admin from './layouts/Admin';
import Account from './layouts/Account';

import Bookings from './views/bookings/index';

import Categories from "./views/categories/index";
import CategoryCreate from "./views/categories/Create";
import CategoryEdit from "./views/categories/Edit";
import CategoryDelete from "./views/categories/Delete";
import CategoryShowImage from "./views/categories/ShowImage";

import Rooms from "./views/rooms/index";
import RoomCreate from "./views/rooms/Create";
import RoomEdit from "./views/rooms/Edit";
import RoomDelete from "./views/rooms/Delete";
import RoomShowImage from "./views/rooms/ShowImage";
import ImageUpdate from "./components/ImageUpload";

import Services from "./views/services/index";
import ServiceCreate from "./views/services/Create";
import ServiceEdit from "./views/services/Edit";
import ServiceDelete from "./views/services/Delete";
import ServiceShowImage from "./views/services/ShowImage";

import Feedbacks from "./views/feedbacks/index";
import FeedbackDelete from "./views/feedbacks/Delete";

import Users from "./views/users/index";
import Statistic from "./views/statistic/index";
import PrivateRoutes from "./layouts/PrivateRoute";

const URL = () => {

    return (
        <BrowserRouter>
        <Routes>
            <Route element={<PrivateRoutes />}>
                <Route path="/" element={<Admin />}>
                    <Route path="/bookings" element={<Bookings />}/>

                    <Route path="/categories" element={<Categories />}/>
                    <Route path="/categories/create" element={<CategoryCreate />}/>
                    <Route path="/categories/edit/:id" element={<CategoryEdit />}/>
                    <Route path="/categories/delete/:id" element={<CategoryDelete />}/>
                    <Route path="/categories/:id/image" element={<CategoryShowImage />}/>

                    <Route path="/rooms" element={<Rooms />}/>
                    <Route path="/rooms/create" element={<RoomCreate />}/>
                    <Route path="/rooms/edit/:id" element={<RoomEdit />}/>
                    <Route path="/rooms/delete/:id" element={<RoomDelete />}/>
                    <Route path="/rooms/:id/image" element={<RoomShowImage />}/>
                    <Route path="/rooms/updateimage" element={<ImageUpdate />}/>

                    <Route path="/services" element={<Services />}/>
                    <Route path="/services/create" element={<ServiceCreate />}/>
                    <Route path="/services/edit/:id" element={<ServiceEdit />}/>
                    <Route path="/services/delete/:id" element={<ServiceDelete />}/>
                    <Route path="/services/:id/image" element={<ServiceShowImage />}/>

                    <Route path="/feedbacks" element={<Feedbacks />}/>
                    <Route path="/feedbacks/delete/:id" element={<FeedbackDelete />}/>

                    <Route path="/users" element={<Users />}/>

                    <Route path="/statistic" element={<Statistic />}/>
                </Route>
            </Route>
            <Route path="/account" element={<Account />}></Route>
        </Routes>
        </BrowserRouter>
      );
};

export default URL;
