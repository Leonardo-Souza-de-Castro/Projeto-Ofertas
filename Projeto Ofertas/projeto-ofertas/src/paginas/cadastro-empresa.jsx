import { Component } from "react";
import axios from "axios";

import '../assets/CSS/cadastro_empresa.css'

export default class CadastroEmpresa extends Component {

    render() {
        return (
            <div className="Fundo_Cadastro">
                <div className="box-cadastro-usuario">
                    <h1>Empresa</h1>
                    <form action="" className="formulario-cadastro-usuario">
                        <div className="coluna1">
                            <span>E-mail</span>
                            <input type="email" placeholder="exemplo@email.com" className="input-cadastro-usuario"/>
                            <span>Senha</span>
                            <input type="password" placeholder="senha" className="input-cadastro-usuario"/>
                        </div>
                        <div className="coluna1">
                            <span>CNEA</span>
                            <input type="text" placeholder="*******" className="input-cadastro-usuario"/>
                            <span>CNPJ</span>
                            <input type="text" placeholder="**.***.***/****-**" className="input-cadastro-usuario"/>
                        </div>

                        <button>Cadastrar</button>
                    </form>
                </div>
            </div>
        )
    }
}