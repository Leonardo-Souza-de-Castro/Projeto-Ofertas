import { Component } from "react";
import axios from "axios";
import MaskedInput from '../services/MaskedInput';

import '../assets/CSS/cadastro_empresa.css'

export default class CadastroEmpresa extends Component {
    constructor(props){
        super(props)
        this.state = {
            CNPJ: '',
            CNAE: '',
            email: '',
            senha: '',
            IdTipoUsuario: 1
        }
    }

    atualizaStateCampo = (campo) => {
        this.setState({ [campo.target.name]: campo.target.value });
    };





    render() {
        return (
            <div className="Fundo_Cadastro">
                <div className="box-cadastro-usuario">
                    <h1>Empresa</h1>
                    <form action="" className="formulario-cadastro-usuario">
                        <div className="container-formulario">
                            <div className="coluna1">
                                <div className="box-input">
                                    <span className="campo">E-mail</span>
                                    <input type="email" placeholder="exemplo@email.com" className="input-cadastro-usuario" name="email" value={this.state.email} onChange={this.atualizaStateCampo}/>
                                </div>
                                <div className="box-input">
                                    <span className="campo">Senha</span>
                                    <input type="password" placeholder="senha" className="input-cadastro-usuario" name="senha" value={this.state.senha} onChange={this.atualizaStateCampo}/>
                                </div>
                            </div>
                            <div className="coluna1">
                                <div className="box-input">
                                    <span className="campo">CNEA</span>
                                    <input type="text" placeholder="*******" className="input-cadastro-usuario" name="CNAE" value={this.state.CNAE} onChange={this.atualizaStateCampo}/>
                                </div>
                                <div className="box-input">
                                    <span className="campo">CNPJ</span>
                                    <MaskedInput
                                        className="input-cadastro-usuario"
                                        name="CNPJ"
                                        mask="99.999.999/9999-99"
                                        value={this.state.CNPJ}
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