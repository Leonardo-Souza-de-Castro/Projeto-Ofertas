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

    // efetuarLogin = (evento) => {
    //     evento.preventDefault();

    //     this.setState({ mensagemErro: '', isLoading: true })
    //     axios.post('http://192.168.3.115:5000/api/Login', {
    //         email: this.state.email,
    //         senha: this.state.senha
    //     })
    //         .then(resposta => {
    //             if (resposta.status === 200) {
    //                 localStorage.setItem('usuario-login', resposta.data.token);
    //                 this.setState({ isLoading: false })
    //                 //console.log(localStorage.getItem('usuario-login'))
    //                 switch (parsejwt().role) {
    //                     case '2':
    //                         this.props.history.push('/consultasmedico')
    //                         break;
    //                     case '3':
    //                         this.props.history.push('/consultaspaciente')
    //                         break;
    //                     case '1':
    //                         this.props.history.push('/todasasconsultas')
    //                         break;

    //                     default:
    //                         console.log('Ué cara')
    //                         break;
    //                 }
    //             }
    //         })
    //         .catch(() => {
    //             this.setState({
    //                 mensagemErro: 'Email ou senha invalido',
    //                 isLoading: false,
    //                 email: '',
    //                 senha: ''
    //             }, console.log('deu errado'))
    //         })
    // }

    // atualizaStateCampo = (campo) => {
    //     this.setState({ [campo.target.name]: campo.target.value });
    // };

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
                            <div>
                                <h2>SEJA BEM VINDO.</h2>
                            </div>
                        <div className="box-form">
                            <h1>Login</h1>
                            <form className="form" onSubmit={this.efetuarLogin}>
                                <div className="box-input-login">
                                <label for="nome_usuario">E-mail</label>  
                                    <input type="text" placeholder="exemplo@email.com" name="email" value={this.state.email} onChange={this.atualizaStateCampo} />
                                    <label for="nome_usuario">Senha</label>  
                                    <input type="password" placeholder="**********" name="senha" value={this.state.senha} onChange={this.atualizaStateCampo} />
                                    <span className="Mensagem-erro">{this.state.mensagemErro}</span>
                                    {
                                        this.state.isLoading === true ? <button disabled>Entrando...</button>: <button className="Entrando">Entrar</button>
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