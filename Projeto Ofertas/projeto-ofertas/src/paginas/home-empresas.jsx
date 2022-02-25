import { Component } from 'react';
import React from "react";
import {
    BrowserRouter as Router,
    Link
} from "react-router-dom";

import logo from '../assets/img/logo-branca.svg'

import '../assets/CSS/home_principal.css'

export default class Home extends Component {

    render() {
        return (
            <div>
                <header className="cabecalhohome">
                    <div className="container">
                        <img src={logo} alt="Logo do nosso site" />
                        {/* <Link to='/cadastrar' className="link_cadastro">Já tem uma conta? Cadastre-se</Link> */}
                        <a className="link_cadastro">Já tem uma conta? Cadastre-se</a>
                    </div>
                </header>
                <section className="container_tipos_perfil">
                    <div className="box_conteudo">
                        <h1 className="titulo_perfis">Eu sou...</h1>
                        <div className="box-alinhamento">
                            <div className="box-conteudo-principal">
                                <h2>Empresa</h2>
                                <p>Se você possui uma empresa e veio aqui, pode fazer uma doação para nossas ONG´s parceiras ou colocar seus produtos em oferta em nossa plataforma.</p>
                            </div>
                            <div className="box-conteudo-principal">
                                <h2>ONG</h2>
                                <p>Se você é uma ONG, tem o direito acessar ofertas de nossas empresas parceiras e de arrecadar doações das mesmas e de pessoas voluntárias.</p>
                            </div>
                            <div className="box-conteudo-principal">
                                <h2>Pessoa Fisica</h2>
                                <p>Se você veio aqui para comprar ou doar, faça seu cadastro aqui e começe a mudar vidas!</p>
                            </div>
                        </div>
                    </div>
                </section>
                <div className="divisao">
                    <hr className="linha1" />
                    <hr className="linha2" />
                </div>
                <section className="banner_info_site">
                    <div className="info_site">
                        <span className="foco_secundario">mais de</span>
                        <span className="foco_principal">2000</span>
                        <span className="foco_secundario">doações</span>
                    </div>
                    <hr />
                    <div className="info_site">
                        <span className="foco_secundario">mais de</span>
                        <span className="foco_principal">15</span>
                        <span className="foco_secundario">ONG´s ajudadas</span>
                    </div>
                    <hr />
                    <div className="info_site">
                        <span className="foco_secundario">mais de</span>
                        <span className="foco_principal">6</span>
                        <span className="foco_secundario">parcerias</span>
                    </div>
                </section>
            </div>
        )
    }
}