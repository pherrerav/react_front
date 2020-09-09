import { Datatable } from "@o2xp/react-datatable";
import React, { Fragment, useState } from "react";
import ModalForm from "./Modal";
import { CallSplit as CallSplitIcon } from "@material-ui/icons";
import { Icon } from "@material-ui/core";
import { chunk } from "lodash";

// Advanced Example

const TblUsuarios = () => {
  const [modalShow, setModalShow] = useState(false);

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
          id: "age",
          label: "age",
          colSize: "80px",
          editable: true,
          dataType: "number",
          valueVerification: (val) => {
            let error = val > 100 ? true : false;
            let message = val > 100 ? "Value is too big" : "";
            return {
              error: error,
              message: message,
            };
          },
        },
        {
          id: "adult",
          label: "adult",
          colSize: "50px",
          editable: true,
          dataType: "boolean",
          inputType: "checkbox",
        },
        {
          id: "birthDate",
          label: "birth date",
          colSize: "120px",
          editable: true,
          dataType: "date",
          inputType: "datePicker",
          dateFormat: "YYYY-MM-DDTHH:MM:ss",
        },
        {
          id: "color",
          label: "color",
          colSize: "100px",
          editable: true,
          inputType: "select",
          values: ["green", "blue", "brown"],
        },
      ],
      rows: [
        {
          id: "50cf",
          age: 28,
          name: "Kerr Mayo",
          adult: true,
          birthDate: "1972-09-04T11:09:59",
          color: "green",
        },
        {
          id: "209",
          age: 34,
          name: "Freda Bowman",
          adult: true,
          birthDate: "1988-03-14T09:03:19",
          color: "blue",
        },
        {
          id: "2dd81ef",
          age: 14,
          name: "Becky Lawrence",
          adult: false,
          birthDate: "1969-02-10T04:02:44",
          color: "green",
        },
        {
          id: "2sdf456",
          age: 19,
          name: "Lucas Michel",
          adult: true,
          birthDate: "1985-09-10T04:02:44",
          color: "blue",
        },
        {
          id: "qsf24fe5",
          age: 35,
          name: "Jean Vaillant",
          adult: true,
          birthDate: "1985-10-25T04:02:44",
          color: "green",
        },
      ],
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
            setModalShow(true);
          },
        },
      ],
      additionalActions: [
        {
          title: "Editar",
          icon: <Icon className="fa fa-edit" color="primary" />,
          onClick: (rows) => console.log(rows),
        },
      ],
    },
  };
  /*let llenarFormulario = (json) => {
    $.each(json, function (k, v) {
      $(`#${k}`).val(v);
    });
  };*/
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
      <ModalForm show={modalShow} onHide={() => setModalShow(false)} />
      <Datatable
        options={options}
        refreshRows={refreshRows}
        actions={actionsRow}
      />
    </Fragment>
  );
};

export default TblUsuarios;
