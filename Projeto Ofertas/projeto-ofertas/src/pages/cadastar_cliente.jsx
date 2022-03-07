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
            numero: 0,

            cpf: '',
            nomeCliente: '',
            email: '',
            senha: '',
            nis: '',
            IdTipoUsuario: 2
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

                    let endereco = {
                        idUsuario: this.state.idUsuario,
                        logradouro: this.state.logradouro,
                        numero: this.state.numero,
                        bairro: this.state.bairro,
                        municipio: this.state.municipio,
                        estado: this.state.estado,
                        cep: this.state.cep,
                    }
                    axios.post('http://localhost:5000/api/Enderecos', endereco)
                        .then(resposta2 => {
                            if (resposta2.status === 200) {
                                console.log('Cliente criada')

                                let cliente = {
                                    idUsuario: this.state.idUsuario,
                                    cpf: this.state.cpf,
                                    nomeCliente: this.state.nomeCliente,
                                    nis: this.state.nis,
                                    // cnae : this.state.cnpj,
                                }

                                axios.post('http://localhost:5000/api/Cliente', cliente).then(resposta3 => {
                                    if (resposta3.status === 201) {
                                        console.log('funciona')
                                    }
                                })


                            }

                        }).catch(erro => console.log(erro))
                }
            }).catch(erro => console.log(erro))
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
                        municipio: resposta.data.localidade,
                        // uf: resposta.data.uf,
                        estado: resposta.data.uf,
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
                    <form onSubmit={this.cadastro} className="formulario-cadastro-cliente">
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
                                    <input type="text" placeholder="Nome" className="input-cadastro-usuario" name="nomeCliente" value={this.state.nomeCliente} onChange={this.atualizaStateCampo} />
                                </div>
                                <div className="box-input">
                                    <span className="campo">CPF</span>
                                    <MaskedInput
                                        className="input-cadastro-usuario"
                                        mask="999.999.999-99"
                                        name="cpf"
                                        value={this.state.cpf}
                                        onChange={this.atualizaStateCampo}

                                    />
                                </div>
                                <div className="box-input">
                                    <span className="campo">NIS</span>
                                    <input type="text" placeholder="###########" className="input-cadastro-usuario" name="nis" value={this.state.nis} onChange={this.atualizaStateCampo} />
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