import React, { Fragment } from "react";
import { Modal, Button } from "react-bootstrap";

const ModalForm = (props) => {
  return (
    <Fragment>
      <Modal
        {...props}
        dialogClassName="modal-90w"
        aria-labelledby="example-custom-modal-styling-title"
      >
        <Modal.Header closeButton>
          <Modal.Title id="example-custom-modal-styling-title">
            Custom Modal Styling
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <input type="text" id="id" />
          <input type="text" id="age" />
          <input type="text" id="name" />
          <input type="text" id="adult" />
          <input type="text" id="birthDate" />
          <input type="text" id="color" />
        </Modal.Body>
        <Modal.Footer>
          <Button onClick={props.onHide}>Close</Button>
        </Modal.Footer>
      </Modal>
    </Fragment>
  );
};

export default ModalForm;
