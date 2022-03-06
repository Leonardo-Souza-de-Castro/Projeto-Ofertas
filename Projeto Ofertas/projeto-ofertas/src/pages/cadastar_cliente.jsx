import { Component } from "react";
import axios from "axios";
import MaskedInput from '../services/MaskedInput';

import '../assets/CSS/cadastrar_cliente.css'

export default class CadastroCliente extends Component {
    constructor(props) {
        super(props)
        this.state = {
            cep: '',
            bairro: '',
            logradouro: '',
            municipio: '',
            estado: '',

            CPF: '',
            Nome: '',
            email: '',
            senha: '',
            Nis: '',
            IdTipoUsuario: 0
        }
    }

    buscarendereco = () => {
        console.log(this.state.cep)
        axios.get('https://viacep.com.br/ws/' + this.state.cep + '/json/')
            .then((resposta) => {
                if (resposta.status === 400) {
                    console.log('deu errado')
                    this.setState({
                        cep: '',
                        bairro: '',
                        logradouro: '',
                        municipio: '',
                        estado: '',
                    })
                }
                else {
                    this.setState({
                        bairro: resposta.data.bairro,
                        logradouro: resposta.data.logradouro,
                        municipio: resposta.data.bairro,
                        estado: resposta.data.localidade,
                    })
                }
            })
    }

    atualizaStateCampo = (campo) => {
        this.setState({ [campo.target.name]: campo.target.value });
    };


    render() {
        return (
            <div className="Fundo_Cadastro_cliente">
                <div className="box-cadastro-usuario">
                    <h1>Pessoa</h1>
                    <h2>Cliente</h2>
                    <form action="" className="formulario-cadastro-cliente">
                        <div className="container-formulario-cliente">
                            <div className="coluna2">
                                <div className="box-input">
                                    <span className="campo">CEP</span>
                                    <input type="text" placeholder="#####-###" className="input-cadastro-usuario" name="cep" value={this.state.cep} onChange={this.atualizaStateCampo} onBlur={this.buscarendereco} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Numero</span>
                                    <input type="number" placeholder="Numero da sua Residencia" className="input-cadastro-usuario" name="numero" value={this.state.numero} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Bairro</span>
                                    <input type="text" placeholder="Bairro" className="input-cadastro-usuario" name="bairro" value={this.state.bairro} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Estado</span>
                                    <input type="text" placeholder="Estado" className="input-cadastro-usuario" name="estado" value={this.state.estado} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Logradouro</span>
                                    <input type="text" placeholder="Rua" className="input-cadastro-usuario" name="logradouro" value={this.state.logradouro} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Municipio</span>
                                    <input type="text" placeholder="Rua" className="input-cadastro-usuario" name="municipio" value={this.state.municipio} onChange={this.atualizaStateCampo} />
                                </div>
                            </div>
                            <div className="coluna2">
                                <div className="box-input">
                                    <span className="campo">E-mail</span>
                                    <input type="email" placeholder="exemplo@email.com" className="input-cadastro-usuario" name="email" value={this.state.email} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Senha</span>
                                    <input type="password" placeholder="senha" className="input-cadastro-usuario" name="senha" value={this.state.senha} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">Nome</span>
                                    <input type="text" placeholder="Nome" className="input-cadastro-usuario" name="Nome" value={this.state.Nome} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">CPF</span>
                                    <MaskedInput
                                        className="input-cadastro-usuario"
                                        mask="999.999.999-99"
                                        name="CPF"
                                        value={this.state.CPF}
                                        onChange={this.atualizaStateCampo}

                                    />
                                </div>
                                <div className="box-input">
                                    <span className="campo">NIS</span>
                                    <input type="text" placeholder="###########" className="input-cadastro-usuario" name="Nis" value={this.state.Nis} onChange={this.atualizaStateCampo} />
                                </div>
                            </div>
                        </div>
                        <button className="btn-cadastro-cliente">Cadastrar</button>
                    </form>
                </div>
            </div>
        )
    }
}