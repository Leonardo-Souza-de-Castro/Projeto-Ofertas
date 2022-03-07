import logo from '../assets/img/logo-branca.svg'
import perfil from '../assets/img/perfil.svg'

import { Component } from 'react';
import React from "react";
import axios from 'axios';

import Rodape from '../components/footer';

import '../assets/CSS/home_empresa.css';

export default class Home_Empresas extends Component {

    constructor(props) {
        super(props)
        this.state = {
            idUsuario: 2,
            idTipoProduto: 0,
            idFinalidade: 0,
            nomeProduto: '',
            descricao: '',
            dataValidade: new Date(),
            quantidade: 0,
            StatusProduto: true,
            imagem: '1450',

            TipoProduto: [],
            // Finalidade: []
        };
    }

    BuscarTipos() {
        axios.get('http://localhost:5000/api/TipoProduto', {

        }).then((resposta) => {
            if (resposta.status === 200) {
                console.log(resposta.data)
                this.setState({ TipoProduto: resposta.data })
                console.log(this.state.TipoProduto)
            }
        }).catch(erro => console.log(erro))
    }

    atualizaStateCampo = (campo) => {

        this.setState({ [campo.target.name]: campo.target.value });
    };


    cadastrarProdutos = (evento) => {
        evento.preventDefault()

        // if (this.state.StatusProduto === true) {
        //     this.setState({ idFinalidade: 1 })
        // }
        // else {
        //     this.setState({ idFinalidade: 2 })
        // }

        let produto = {
            nomeProduto: this.state.nomeProduto,
            descricao: this.state.descricao,
            dataValidade: this.state.dataValidade,
            quantidade: this.state.quantidade,
            idFinalidade: this.state.idFinalidade,
            TipoProduto: this.state.TipoProduto,
            imagem: this.state.imagem
        }

        axios.post('http://localhost:5000/api/Produtos', produto)
            .then(resposta => {
                if (resposta.status === 201) {
                    console.log('Produto Cadastrado')
                    this.setState({
                        idUsuario: 1,
                        idTipoProduto: 0,
                        idFinalidade: 0,
                        nomeProduto: '',
                        descricao: '',
                        dataValidade: new Date(),
                        quantidade: 0,
                        StatusProduto: true,
                        imagem: '1450',

                        TipoProduto: [],
                        // Finalidade: []
                    });
                }
            })
            .catch((erro) => {
                console.log(erro)
            })
    }

    componentDidMount() {
        this.BuscarTipos()
        console.log(this.state.idFinalidade)
        // console.log(this.state.idConsulta)
    }

    render() {
        return (
            <div>
                <header className="cabecalhohomeempresa">
                    <div className="containerhome">
                        <img src={logo} alt="Logo do nosso site" />
                        <img src={perfil} alt="Perfil" />
                    </div>
                </header>
                <section className='fundo_empresas'>
                    <form className='box-cds-produto' onSubmit={this.cadastrarProdutos} action="">
                        <h1>Cadastro de Produtos</h1>
                        <input type="text" placeholder='Nome do produto' className='input-cadastro' name="nomeProduto" value={this.state.nomeProduto} onChange={this.atualizaStateCampo} />
                        <input type="date" className='input-cadastro' name="dataValidade" value={this.state.dataValidade} onChange={this.atualizaStateCampo} />
                        <input type="text" placeholder='Descrição' className='input-cadastro' name="descricao" value={this.state.descricao} onChange={this.atualizaStateCampo} />
                        <select className='input-cadastro' name="quantidade" value={this.state.quantidade} onChange={this.atualizaStateCampo}>
                            <option value="0">Quantidade</option>
                            <option value="1">5</option>
                            <option value="2">10</option>
                            <option value="3">15</option>
                            <option value="4">20</option>
                            <option value="5">25</option>
                            <option value="6">30</option>
                        </select>
                        <select className='input-cadastro' name="idTipoProduto" value={this.state.idTipoProduto} onChange={this.atualizaStateCampo}>
                            <option value="0">Tipo de Produto</option>
                            {this.state.TipoProduto.map((tema) => {
                                return (
                                    <option key={tema.id} value={tema.id}>
                                        {tema.tipoProduto1}
                                    </option>
                                );
                            })}
                        </select>
                        <select className='input-cadastro' name="idFinalidade" value={this.state.idFinalidade} onChange={this.atualizaStateCampo}>
                            <option value="0">Finalidade</option>
                            <option value="1">Doação</option>
                            <option value="2">Venda</option>
                        </select>
                        {/* <div className='check_doacao'>
                            <input type="checkbox" name="StatusProduto" value={this.state.StatusProduto} onChange={this.atualizaStateCampo} />
                            <span>Doação</span>
                        </div> */}

                        <input type="file" id="arquivo" accept="image/png, image/jpeg" className='input-cadastro' />

                        <button className='btn_doar'>Adicionar Produto</button>
                    </form>
                </section>
                <Rodape />
            </div>
        )
    }
}