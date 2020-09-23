import React from "react";
import { NavLink } from "react-router-dom";

const SideBar = () => {
  return (
    <aside className="main-sidebar sidebar-dark-danger elevation-4">
      <a href="index3.html" className="brand-link bg-danger">
        <img
          src="dist/img/logo_bac.png"
          alt="AdminLTE Logo"
          className="brand-image"
        />
        <span className="brand-text font-weight-light">AdminLTE 3</span>
      </a>
      <div className="sidebar">
        <div className="user-panel mt-3 pb-3 mb-3 d-flex">
          <div className="image">
            <img
              src="dist/img/usuario.png"
              className="img-circle elevation-2"
              alt="imagen"
            />
          </div>
          <div className="info">
            <a href="hola" className="d-block">
              Hola Usuario
            </a>
          </div>
        </div>
        <nav className="mt-2">
          <ul
            className="nav nav-pills nav-sidebar flex-column"
            data-widget="treeview"
            role="menu"
            data-accordion="false"
          >
            <li className="nav-item has-treeview">
              <a href="/#" className="nav-link active">
                <i className="nav-icon fa fa-dashboard"></i>
                <p>
                  Starter Pages
                  <i className="right fa fa-angle-left"></i>
                </p>
              </a>
              <ul className="nav nav-treeview">
                <li className="nav-item">
                  <NavLink to="/home" className="nav-link">
                    <i className="fa fa-circle-o nav-icon"></i>
                    <p>Principal</p>
                  </NavLink>
                </li>
                <li className="nav-item">
                  <NavLink to="/usuarios" className="nav-link">
                    <i className="fa fa-circle-o nav-icon"></i>
                    <p>Usuario</p>
                  </NavLink>
                </li>
              </ul>
            </li>
            <li className="nav-item">
              <a href="hola" className="nav-link">
                <i className="nav-icon fa fa-th"></i>
                <p>
                  Simple Link
                  <span className="right badge badge-danger">New</span>
                </p>
              </a>
            </li>
          </ul>
        </nav>
      </div>
    </aside>
  );
};
export default SideBar;
