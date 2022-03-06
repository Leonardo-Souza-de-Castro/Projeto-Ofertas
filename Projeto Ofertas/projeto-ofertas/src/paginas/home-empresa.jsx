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
            NomeProduto: '',
            Descricao: '',
            DataValidade: new Date(),
            Quantidade: 0,
            StatusProduto: true,
            Imagem: '',
            Id: 0,

            TipoProduto: [],
            // Finalidade: []
        };
    }

    BuscarTipos() {
        axios.get('https://621f854cce99a7de193f9ef6.mockapi.io/TipoProduto', {

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

        let produto = {
            NomeProduto: this.state.NomeProduto,
            Descricao: this.state.Descricao,
            DataValidade: this.state.DataValidade,
            Quantidade: this.state.Quantidade,
            StatusProduto: this.state.StatusProduto,
            TipoProduto: this.state.TipoProduto
        }

        axios.post('https://621f854cce99a7de193f9ef6.mockapi.io/TipoProduto/5/Produto', produto)
            .then(resposta => {
                if (resposta.status === 201) {
                    console.log('Produto Cadastrado')
                    this.setState({
                        NomeProduto: '',
                        Descricao: '',
                        DataValidade: new Date(),
                        Quantidade: 0,
                        StatusProduto: true,
                        Imagem: '',
                        id: 0,

                        TipoProduto: [],
                        // Finalidade: []
                    });
                }
            })
            .catch((erro) => {
                if (erro.toJSON().status === 401) {
                    this.props.history.push('/login')
                }
                else console.log(erro)
            })
    }

    componentDidMount() {
        this.BuscarTipos()
        console.log(this.state.Id)
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
                        <input type="text" placeholder='Nome do produto' className='input-cadastro' name="NomeProduto" value={this.state.NomeProduto} onChange={this.atualizaStateCampo}/>
                        <input type="date" className='input-cadastro' name="DataValidade" value={this.state.DataValidade} onChange={this.atualizaStateCampo}/>
                        <input type="text" placeholder='Descrição' className='input-cadastro' name="Descricao" value={this.state.Descricao} onChange={this.atualizaStateCampo}/>
                        <select className='input-cadastro' name="Quantidade" value={this.state.Quantidade} onChange={this.atualizaStateCampo}>
                            <option value="0">Quantidade</option>
                            <option value="1">5</option>
                            <option value="2">10</option>
                            <option value="3">15</option>
                            <option value="4">20</option>
                            <option value="5">25</option>
                            <option value="6">30</option>
                        </select>
                        <select className='input-cadastro' name="id" value={this.state.id} onChange={this.atualizaStateCampo}>
                            <option value="0">Tipo de Produto</option>
                            {this.state.TipoProduto.map((tema) => {
                                return (
                                    <option key={tema.id} value={tema.id}>
                                        {tema.TipoProduto}
                                    </option>
                                );
                            })}
                        </select>
                        <div className='check_doacao'>
                            <input type="checkbox" name="StatusProduto" value={this.state.StatusProduto} onChange={this.atualizaStateCampo}/>
                            <span>Doação</span>
                        </div>

                        <input type="file" id="arquivo" accept="image/png, image/jpeg" className='input-cadastro' />

                        <button className='btn_doar'>Adicionar Produto</button>
                    </form>
                </section>
                <Rodape />
            </div>
        )
    }
}