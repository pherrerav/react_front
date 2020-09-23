import React, { Fragment} from 'react';
import NavBar from './NavBar';
import SideBar from './SideBar';
import Footer from './Footer';


const Layout = ({ children }) => {
    return (
        <Fragment>
            <NavBar />
            <SideBar />
                {children}
            <Footer />
        </Fragment>
    );
}
export default Layout;