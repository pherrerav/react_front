import React, { useState } from "react";

const TarjetaFruta = (props) => {
  const [cantidad, setCantidad] = useState(0);

  const agregar = () => {
    setCantidad(cantidad + 1);
  };

  const quitar = () => {
    setCantidad(cantidad - 1);
  };

  const limpiar = () => {
    setCantidad((cantidad = 0));
  };

  return (
    <div>
      <h3>{props.name}</h3>
      <div>Cantidad: {cantidad}</div>
      <button onClick={agregar}> + </button>
      <button onClick={quitar}> - </button>
      <button onClick={limpiar}> Limpiar</button>
      <hr />
      <p>$ {props.price}</p>
    </div>
  );
};

export default TarjetaFruta;
