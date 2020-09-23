import React, { Fragment, useEffect } from "react";
import { Modal } from "react-bootstrap";
import { useForm } from "react-hook-form";

const ModalForm = (props) => {
  const { register, handleSubmit, setValue } = useForm();
  const onSubmit = (data) => {
    if (props.action === "Editar") alert("Editar");
    else alert("Nuevo");

    //alert(JSON.stringify(data));
  };
  useEffect(() => {
    if (props.rowselected) {
      Object.keys(props.rowselected).map((key, i) => {
        setValue(key, props.rowselected[key]);
      });
    }
  }, [props.rowselected]);

  return (
    <Fragment>
      <Modal
        {...props}
        dialogClassName="modal-90w"
        aria-labelledby="example-custom-modal-styling-title"
      >
        <Modal.Header closeButton>
          <Modal.Title id="example-custom-modal-styling-title">
            Datos de Usuario
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <form onSubmit={handleSubmit(onSubmit)}>
            <input type="hidden" name="id" ref={register} />
            <div className="form-group">
              <label>Nombre</label>
              <input
                name="name"
                placeholder="Name"
                ref={register}
                className="form-control"
              />
            </div>
            <div className="form-group">
              <label>Correo</label>
              <input
                name="email"
                placeholder="Email"
                ref={register}
                className="form-control"
              />
            </div>
            <div className="form-group">
              <label>Genero</label>
              <select ref={register} name="gender" className="form-control">
                <option value="Female">Female</option>
                <option value="Male">Male</option>
              </select>
            </div>
            <div className="form-group">
              <label>Status</label>
              <select ref={register} name="status" className="form-control">
                <option value="Active">Active</option>
                <option value="Inactive">Inactive</option>
              </select>
            </div>
            <div className="form-group">
              <label>Fecha de Creado</label>
              <input
                name="created_at"
                placeholder="Fecha de Creado"
                ref={register}
                className="form-control"
              />
            </div>
            <div className="form-group">
              <label>Fecha de Modificacion</label>
              <input
                name="updated_at"
                placeholder="Fecha de Modificacion"
                ref={register}
                className="form-control"
              />
            </div>
            <hr />
            <button type="submit" className="btn btn-success float-right">
              <i className="fa fa-save"></i>
            </button>
          </form>
        </Modal.Body>
      </Modal>
    </Fragment>
  );
};

export default ModalForm;
