import { lazy } from "react";

const Home = lazy(() => import("./Home"));
const Usuarios = lazy(() => import("./Usuarios"));

//const notfound = React.lazy(() => import('./PageNotFound'))
const Routes = [
  { path: "/home", component: Home },
  { path: "/usuarios", component: Usuarios },
  // { component: notfound }
];

export default Routes;
