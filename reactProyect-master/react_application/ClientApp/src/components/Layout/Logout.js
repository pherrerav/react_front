import React from 'react'
import { Link } from 'react-router-dom'

const Logout = () => {
    return (
        <ul className="navbar-nav ml-auto">
            <Link to="/login">
                <i className="fa fa-sign-out fa-lg"></i>
            </Link>
        </ul>
     );
}

export default Logout