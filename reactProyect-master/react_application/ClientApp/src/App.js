import React, { Suspense, lazy, Fragment } from 'react';
import { CircleLoader } from 'react-spinners';
import { BrowserRouter as Router, Route, Switch, Redirect  } from 'react-router-dom'
import './custom.css'
import Routes from "./components/Routes"
const Layout = lazy(() => import('./components/Layout'));
const Login = lazy(() => import('./components/Login'));

function App() {
    return (
        <div className="App" >
            <Fragment>
                <Router>
                    <Suspense fallback={<div className="SpinnerLazy"><CircleLoader color='#E4002B' size={100} /></div>} >
                        <Switch>
                            <Route exact path="/">
                                <Redirect to="/login" />
                            </Route>
                            <Route path="/login" component={Login} />
                            <Layout>
                                {Routes.map((route, idx) => {
                                    return route.component ? (
                                        <Route exact
                                            key={idx}
                                            path={route.path}
                                            component={route.name}
                                            render={props => (
                                                <route.component {...props} />
                                            )} />
                                    ) : (null);
                                })}  
                            </Layout>
                        </Switch>
                    </Suspense>
                </Router>              
            </Fragment>
        </div >
    );
}

export default App;
