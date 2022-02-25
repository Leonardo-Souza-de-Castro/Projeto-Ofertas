import { Component } from 'react';


import logo from '../assets/img/Group 2.svg';
import facebook from '../assets/img/facebook.svg';
import instagram from '../assets/img/instagram.svg'; 
import twitter from '../assets/img/twitter.svg';
import '../assets/css/login.css';


export default class Login extends Component {
    constructor(props) {
        super(props)
        this.state = {
            email: '',
            senha: '',
            mensagemErro: '',
            isLoading: false
        };
    }


    render() {
        return (
            <div>
                <main className="container">
                    <section className="container-login">
                        <div className="box-banner-login">
                            <img src={logo} alt="Banner do Login" />
                        </div>
                        <div className="logos">
                            <img src={facebook} alt="Logo do facebook" />
                            <img src={instagram} alt="Logo do instagram" />
                            <img src={twitter} alt="Logo do twitter" />
                        </div>
                        </section>
                        <section className="container-box-form">
                            <div className="frase">
                                <h2>SEJA<br/> BEM <br/>VINDO.</h2>
                            </div>
                        <div className="box-form">
                            <form className="form" onSubmit={this.efetuarLogin}>
                                <div className="box-input-login">
                                    <div className="email">
                                        <label className="email_usuario" for="nome_usuario">E-mail</label>  
                                        <input className="email_caixa" type="text" placeholder="exemplo@email.com" name="email" value={this.state.email} onChange={this.atualizaStateCampo} />
                                    </div>
                                    <div className="senha">
                                        <label className="senha_usuario" for="senha_usuario">Senha</label>  
                                        <input className="senha_caixa" type="password" placeholder="**********" name="senha" value={this.state.senha} onChange={this.atualizaStateCampo} />
                                    </div>
                                    <span className="Mensagem-erro">{this.state.mensagemErro}</span>
                                    {
                                        this.state.isLoading === true ? <button disabled>Entrando...</button>: <button className="Entrando">Login</button>
                                    }
                                </div>
                            </form>
                        </div>
                     </section>
                </main>
            </div>
        )
    }
}