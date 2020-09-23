import React, { useState, useEffect } from "react";
import axios from "axios";
import TblUsuarios from "./TblUsuarios";

const Usuarios = () => {
  const [tableData, setTableData] = useState();
  useEffect(() => {
    const fetchData = async () => {
      const result = await axios("https://gorest.co.in/public-api/users");
      setTableData(result.data.data);
    };
    fetchData();
  }, []);
  return (
    <div className="content-wrapper">
      <div className="content-header">
        <div className="container-fluid">
          <div className="row mb-2">
            <div className="col-sm-6">
              <h1 className="m-0 text-dark">Usuarios</h1>
            </div>
            <div className="col-sm-6">
              <ol className="breadcrumb float-sm-right">
                <li className="breadcrumb-item">Home</li>
                <li className="breadcrumb-item active">Ususarios</li>
              </ol>
            </div>
          </div>
        </div>
      </div>
      <div className="content">
        <div className="container-fluid">
          <div className="row">
            <div className="col-lg-12">
              <div className="card card-danger card-outline">
                <div className="card-body">
                  <div className="row">
                    <TblUsuarios tableData={tableData} />
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};
export default Usuarios;
