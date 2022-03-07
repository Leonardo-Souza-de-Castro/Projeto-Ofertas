import { Component } from "react";
import axios from "axios";
import MaskedInput from '../services/MaskedInput';

import '../assets/CSS/cadastro_empresa.css'

export default class CadastroONG extends Component {
    constructor(props) {
        super(props)
        this.state = {
            cnpj: '',
            nomeFantasia: '',
            razaoSocial: '',
            email: '',
            senha: '',
            idTipoUsuario: 3,
            idUsuario: 0
        }
    }

    cadastro = (evento) => {
        evento.preventDefault()

        let usuario = {
            email: this.state.email,
            senha: this.state.senha,
            idTipoUsuario: this.state.idTipoUsuario,
        }

        axios.post('http://localhost:5000/api/Usuario', usuario)
            .then(resposta => {
                if (resposta.status === 200) {
                    this.setState({
                        idUsuario: resposta.data
                    })

                    let ong = {
                        idUsuario: this.state.idUsuario,
                        cnpj: this.state.cnpj,
                        nomeFantasia: this.state.nomeFantasia,
                        razaoSocial: this.state.razaoSocial,
                        // cnae : this.state.cnpj,
                    }
                    axios.post('http://localhost:5000/api/Instituicoes', ong)
                        .then(resposta2 => {
                            if (resposta2.status === 201) {
                                console.log('ong criada')
                                this.props.history.push('/')
                            }
                        }).catch(erro => console.log(erro))
                }
            }).catch(erro => console.log(erro))
    }

    atualizaStateCampo = (campo) => {
        this.setState({ [campo.target.name]: campo.target.value });
    };
    render() {
        return (
            <div className="Fundo_Cadastro">
                <div className="box-cadastro-usuario">
                    <h1>ONG's</h1>
                    <form onSubmit={this.cadastro} className="formulario-cadastro-usuario">
                        <div className="container-formulario">
                            <div className="coluna1">
                                <div className="box-input">
                                    <span className="campo">E-mail</span>
                                    <input type="email" placeholder="exemplo@email.com" className="input-cadastro-usuario" name="email" value={this.state.email} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Senha</span>
                                    <input type="password" placeholder="senha" className="input-cadastro-usuario" name="senha" value={this.state.senha} onChange={this.atualizaStateCampo} />
                                </div>
                            </div>
                            <div className="coluna1">
                                <div className="box-input">
                                    <span className="campo">Nome</span>
                                    <input type="text" placeholder="Nome da ONG" className="input-cadastro-usuario" name="nomeFantasia" value={this.state.nomefantasia} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Razão Social</span>
                                    <input type="text" placeholder="Nome da ONG" className="input-cadastro-usuario" name="razaoSocial" value={this.state.razaoSocial} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">CNPJ</span>
                                    <MaskedInput
                                        className="input-cadastro-usuario"
                                        name="cnpj"
                                        mask="99.999.999/9999-99"
                                        value={this.state.cnpj}
                                        onChange={this.atualizaStateCampo}
                                    />
                                </div>
                            </div>
                        </div>
                        <button className="btn-cadastro-usuario">Cadastrar</button>
                    </form>
                </div>
            </div>
        )
    }
}