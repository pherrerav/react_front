import React, { Fragment } from 'react'
import { useForm } from 'react-hook-form'
import "./Login.css";
import $ from "jquery";
import { TweenMax, Sine } from 'gsap';
window.$ = $;


const Login = () => {
   
    const { register, errors, handleSubmit } = useForm();
    //const [entradas, setEntradas] = useState([])
    
    async function onSubmit(data) {
        try {        
           window.location.href="/home"
        } catch (e) {
            alert(e.message);
        }
    }  

    const fadeInLogin = () => {
        $('#login-button').fadeOut("slow", function () {
            $("#container").fadeIn();
            TweenMax.from("#container", .4, { scale: 0, ease: Sine.easeInOut });
            TweenMax.to("#container", .4, { scale: 1, ease: Sine.easeInOut });
        });
    }

    const fadeOutLogin = () => {
        TweenMax.from("#container", .4, { scale: 1, ease: Sine.easeInOut });
        TweenMax.to("#container", .4, { left: "0px", scale: 0, ease: Sine.easeInOut });
        $("#container, #forgotten-container").fadeOut(800, function () {
            $("#login-button").fadeIn(800);
        });
    }
    return (
        <Fragment>
            <div className="dark-layer"></div>
            <div id="login-button" onClick={fadeInLogin}>
                <img alt="login" src="https://dqcgrsy5v35b9.cloudfront.net/cruiseplanner/assets/img/icons/login-w-icon.png">
                </img>
                <p>Login</p>
            </div>

            <div id="container">
                <h1>Log In</h1>
                <span className="close-btn" onClick={fadeOutLogin}>
                    <img alt="close" src="https://cdn4.iconfinder.com/data/icons/miu/22/circle_close_delete_-128.png"></img>
                </span>
                <form onSubmit={handleSubmit(onSubmit)}>
                    <i className="fa fa-user"></i>
                    <input
                        type="text"
                        name="usuario"
                        placeholder="Usuario"
                        ref={
                            register({
                                required: { value: true, message: "Campo requerido" }
                            })
                        }
                    />
                    <span className="text-danger text-small d-block mb-2">{errors?.usuario?.message}</span>
                    <i className="fa fa-lock"></i>
                    <input
                        placeholder="Password"
                        type="password"
                        name="password"
                        ref={
                            register({
                                required: { value: true, message: "Campo requerido" }
                            })
                        }
                    />
                    <span className="text-danger text-small d-block mb-2">{errors?.password?.message}</span>
                    
                    <input type="submit" className="btn btn-danger" value="Ingresar" />
                </form>
            </div>
        </Fragment>
    );
}

export default Login