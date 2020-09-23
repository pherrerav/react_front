import { Datatable } from "@o2xp/react-datatable";
import React, { Fragment, useState } from "react";
import ModalForm from "./Modal";
import { Icon } from "@material-ui/core";
import { chunk } from "lodash";

const TblUsuarios = (props) => {
  const [modalShow, setModalShow] = useState(false);
  const [action, setAction] = useState("Nuevo");
  const [rowselected, setRowSelected] = useState({
    id: "",
    name: "",
    email: "",
    gender: "",
    status: "",
    created_at: "",
    updated_at: "",
  });

  const registroSeleccionado = (registro) => {
    setRowSelected(registro);
    setModalShow(true);
  };

  const options = {
    title: "Usuarios del Sistema",
    stripped: true,
    dimensions: {
      datatable: {
        width: "100%",
        height: "600px",
      },
      row: {
        height: "60px",
      },
    },
    keyColumn: "id",
    font: "Arial",
    data: {
      columns: [
        {
          id: "id",
          label: "id",
          colSize: "150px",
          editable: false,
        },
        {
          id: "name",
          label: "name",
          colSize: "100px",
          editable: true,
          dataType: "text",
          inputType: "input",
        },
        {
          id: "email",
          label: "email",
          colSize: "80px",
          editable: true,
          dataType: "email",
        },
        {
          id: "gender",
          label: "gender",
          colSize: "100px",
          editable: true,
          inputType: "select",
          values: ["Female", "Male"],
        },
        {
          id: "status",
          label: "status",
          colSize: "50px",
          editable: true,
          inputType: "select",
          values: ["Active", "Inactive"],
        },
        {
          id: "created_at",
          label: "Created at",
          colSize: "120px",
          editable: true,
          dataType: "date",
          inputType: "datePicker",
          dateFormat: "YYYY-MM-DDTHH:MM:ss",
        },
        {
          id: "updated_at",
          label: "Updated at",
          colSize: "120px",
          editable: true,
          dataType: "date",
          inputType: "datePicker",
          dateFormat: "YYYY-MM-DDTHH:MM:ss",
        },
      ],
      rows: props.tableData,
    },
    features: {
      canDownload: true,
      canSearch: true,
      canRefreshRows: true,
      canOrderColumns: true,
      rowsPerPage: {
        available: [10, 25, 50, 100],
        selected: 50,
      },
      additionalIcons: [
        {
          title: "Nuevo",
          icon: <Icon className="fa fa-plus-circle" color="primary" />,
          onClick: () => {
            setAction("Nuevo");
            setModalShow(true);
          },
        },
      ],
      additionalActions: [
        {
          title: "Editar",
          icon: <Icon className="fa fa-edit" color="primary" />,
          onClick: (rows) => {
            setAction("Editar");
            registroSeleccionado(rows);
          },
        },
      ],
    },
  };

  const actionsRow = ({ type, payload }) => {
    console.log(type);
    console.log(payload);
  };

  const refreshRows = () => {
    const { rows } = options.data;
    const randomRows = Math.floor(Math.random() * rows.length) + 1;
    const randomTime = Math.floor(Math.random() * 4000) + 1000;
    const randomResolve = Math.floor(Math.random() * 10) + 1;
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        if (randomResolve > 3) {
          resolve(chunk(rows, randomRows)[0]);
        }
        reject(new Error("err"));
      }, randomTime);
    });
  };

  return (
    <Fragment>
      <ModalForm
        show={modalShow}
        onHide={() => setModalShow(false)}
        rowselected={rowselected}
        action={action}
      />
      <Datatable
        options={options}
        refreshRows={refreshRows}
        actions={actionsRow}
      />
    </Fragment>
  );
};

export default TblUsuarios;
