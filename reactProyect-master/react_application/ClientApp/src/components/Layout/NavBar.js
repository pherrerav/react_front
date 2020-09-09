import React from 'react';
import Logout from './Logout'

const NavBar = () => {
    return (
        <nav className="main-header navbar navbar-expand bg-danger navbar-dark border-bottom">
            <ul className="navbar-nav">
                <li className="nav-item">
                    <a className="nav-link" data-widget="pushmenu" href="hola"><i className="fa fa-bars"></i></a>
                </li>
                <li className="nav-item d-none d-sm-inline-block">
                    <a href="index3.html" className="nav-link">Home</a>
                </li>
                <li className="nav-item d-none d-sm-inline-block">
                    <a href="hola" className="nav-link">Contact</a>
                </li>
            </ul>
            <form className="form-inline ml-3">
                <div className="input-group input-group-sm">
                    <input className="form-control form-control-navbar" type="search" placeholder="Search" aria-label="Search"/>
                    <div className="input-group-append">
                        <button className="btn btn-navbar" type="submit">
                            <i className="fa fa-search"></i>
                        </button>
                    </div>
                </div>
            </form>
            {<Logout/>}
        </nav>
                   
        );
}
export default NavBar;