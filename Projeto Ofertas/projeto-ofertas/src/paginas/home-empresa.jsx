import logo from '../assets/img/logo-branca.svg'
import perfil from '../assets/img/perfil.svg'

import { Component } from 'react';
import React from "react";

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

            TipoProduto: [],
            // Finalidade: []
        };
    }

    render() {
        return (
            <div>
                <header className="cabecalhohome">
                    <div className="containerhome">
                        <img src={logo} alt="Logo do nosso site" />
                        <img src={perfil} alt="Perfil" />
                    </div>
                </header>
                <section className='fundo_empresas'>
                <form className='box-cds-produto'>
                    <h1>Cadastro de Produtos</h1>
                    <input type="text" placeholder='Nome do produto' className='input-cadastro' />
                    <input type="date" placeholder='Data de validade' className='input-cadastro' />
                    <input type="text" placeholder='Descrição' className='input-cadastro' />
                    <select>
                        <option value="0">Quantidade</option>
                        <option value="1">5</option>
                        <option value="2">10</option>
                        <option value="3">15</option>
                        <option value="4">20</option>
                        <option value="5">25</option>
                        <option value="6">30</option>
                    </select>
                    <select>
                        <option value="0">Tipo de Produto</option>
                        <option value="1">Alimento</option>
                        <option value="2">Roupa</option>
                    </select>
                    <div>
                    <input type="checkbox"/>
                    <span>Doação</span>
                    </div>
                    
                    <input type="file" id="arquivo" accept="image/png, image/jpeg" />
                </form>
                </section>
                <Rodape/>
            </div>
        )
    }
}