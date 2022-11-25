import { useEffect, useRef, useState } from 'react';
import { Link, useLocation } from 'react-router-dom';
import logo from '../assets/images/Logo.png';
import 'boxicons';

const sidebarNavItems = [
    {
        display: 'Trang chủ',
        icon: <i class='bx bx-home' ></i>,
        to: '/home',
        section: 'home'
    },
    {
        display: 'Quản lý đặt phòng',
        icon: <i class='bx bx-category' ></i>,
        to: '/bookings',
        section: 'bookings'
    },
    {
        display: 'Quản lý loại phòng',
        icon: <i class='bx bx-category' ></i>,
        to: '/categories',
        section: 'categories'
    },
    {
        display: 'Quản lý các phòng',
        icon: <i class='bx bx-lemon' ></i>,
        to: '/rooms',
        section: 'rooms'
    },
    {
        display: 'Quản lý dịch vụ',
        icon: <i class='bx bx-lemon' ></i>,
        to: '/services',
        section: 'services'
    },
    {
        display: 'Quản lý tài khoản',
        icon: <i className='bx bx-user'></i>,
        to: '/users',
        section: 'users'
    },
]

const Sidebar = () => {
    const [activeIndex, setActiveIndex] = useState(0);
    const [stepHeight, setStepHeight] = useState(0);
    const sidebarRef = useRef();
    const indicatorRef = useRef();
    const location = useLocation();

    useEffect(() => {
        setTimeout(() => {
            const sidebarItem = sidebarRef.current.querySelector('.sidebar__menu__item');
            indicatorRef.current.style.height = `${sidebarItem.clientHeight}px`;
            setStepHeight(sidebarItem.clientHeight);
        }, 50);
    }, []);

    // change active index
    useEffect(() => {
        const curPath = window.location.pathname.split('/')[1];
        const activeItem = sidebarNavItems.findIndex(item => item.section === curPath);
        setActiveIndex(curPath.length === 0 ? 0 : activeItem);
    }, [location]);

    return <div className='sidebar'>
        <div className="sidebar__logo">
            <img src={logo} style={{width: '220px'}}/>
        </div>
        <div ref={sidebarRef} className="sidebar__menu">
            <div
                ref={indicatorRef}
                className="sidebar__menu__indicator"
                style={{
                    transform: `translateX(-50%) translateY(${activeIndex * stepHeight}px)`
                }}
            ></div>
            {
                sidebarNavItems.map((item, index) => (
                    <Link to={item.to} key={index}>
                        <div className={`sidebar__menu__item ${activeIndex === index ? 'active' : ''}`}>
                            <div className="sidebar__menu__item__icon">
                                {item.icon}
                            </div>
                            <div className="sidebar__menu__item__text">
                                {item.display}
                            </div>
                        </div>
                    </Link>
                ))
            }
        </div>
    </div>;
};

export default Sidebar;
