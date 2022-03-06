import { Component } from 'react';
import React from "react";
import {
    BrowserRouter as Router,
    Link,
    Redirect
} from "react-router-dom";

import logo from '../assets/img/logo-branca.svg'
import arara from '../assets/img/arara.png'
import corredor from '../assets/img/corredores.png'
import quem_somos from '../assets/img/quem somos.png'
import assai from '../assets/img/assai.svg'
import carrefour from '../assets/img/carrefour.svg'
import cea from '../assets/img/CeA.svg'
import extra from '../assets/img/extra.svg'
import pernanbucanas from '../assets/img/Pernanbucanas.svg'
import renner from '../assets/img/Renner.svg'

import '../assets/CSS/home_principal.css'

import Footer from '../components/footer.jsx';

export default class Home extends Component {

    render() {
        return (
            <div>
                <header className="cabecalhohome">
                    <div className="containerhome">
                        <img src={logo} alt="Logo do nosso site" />
                        <Link to='/Empresa' className="link_cadastro">Já tem uma conta? Logue</Link>
                        {/* <a className="link_cadastro">Já tem uma conta? Cadastre-se</a> */}
                    </div>
                </header>
                <section className="container_tipos_perfil">
                    <div className="box_conteudo">
                        <h1 className="titulo_perfis">Eu sou...</h1>
                        <div className="box-alinhamento">
                            <div className="box-conteudo-principal">
                                <h2>Empresa</h2>
                                <p>Se você possui uma empresa e veio aqui, pode fazer uma doação para nossas ONG´s parceiras ou colocar seus produtos em oferta em nossa plataforma.</p>
                                <Link to='/cadastroempresa' className='btn_cadastro'>Cadastre-se como empresa</Link>
                            </div>
                            <div className="box-conteudo-principal">
                                <h2>ONG</h2>
                                <p>Se você é uma ONG, tem o direito acessar ofertas de nossas empresas parceiras e de arrecadar doações das mesmas e de pessoas voluntárias.</p>
                                <Link to='/cadastrarong' className='btn_cadastro'>Cadastre-se como ONG</Link>
                            </div>
                            <div className="box-conteudo-principal">
                                <h2>Pessoa Fisica</h2>
                                <p>Se você veio aqui para comprar ou doar, faça seu cadastro aqui e começe a mudar vidas!</p>
                                <Link to='/cadastrarcliente' className='btn_cadastro'>Cadastre-se como pessoa física</Link>
                            </div>
                        </div>
                    </div>
                </section>
                <section className="organizacao_banner">
                    <div className="divisao">
                        <hr className="linha1" />
                        <hr className="linha2" />
                    </div>
                    <div className="banner_info_site">
                        <div className="info_site">
                            <span className="foco_secundario">mais de</span>
                            <span className="foco_principal">2000</span>
                            <span className="foco_secundario">doações</span>
                        </div>
                        <hr className='divisoria' />
                        <div className="info_site">
                            <span className="foco_secundario">mais de</span>
                            <span className="foco_principal">15</span>
                            <span className="foco_secundario">ONG's ajudadas</span>
                        </div>
                        <hr className='divisoria' />
                        <div className="info_site">
                            <span className="foco_secundario">mais de</span>
                            <span className="foco_principal">6</span>
                            <span className="foco_secundario">parcerias</span>
                        </div>
                    </div>
                </section>
                <section className='container_estrutura'>
                    <div className='box_produtos'>
                        <h3>Produtos que podem ser doados ou vendidos em nossa plataforma</h3>
                        <div className='box_info'>
                            <article className='info_produtos'>
                                <img src={arara} alt="Uma arara de uma loja de roupas com um desconto" />
                                <p>Vestuário em geral. Roupas com pequenos defeitos e que não serão vendidas, podem ser doadas para ONG´s que irão ajudar famílias nescessitadas.
                                    Também é possível vender peças que não tem giro com ofertas acimas de 60%.</p>
                            </article>

                            <article className='info_produtos'>
                                <img src={corredor} alt="Coredores de um supermercado" />
                                <p>Alimentos não perecíveis. Produtos que estão próximos a data de validade podem ser vendidos a um preço baixo, tanto para as ONG's como para qualquer pessoa que acessar a nossa plataforma. </p>
                            </article>
                        </div>
                    </div>

                    <div className='box_produtos reduz_tamanho'>
                        <h3 className='titulo_quem'>Quem Somos</h3>
                        <div className='box_quem_somos'>
                            <p>Somos uma plataforma de vendas e doações voltada para usuários de baixa renda. Nossas empresas parceiras podem doar alimentos próximos ao vencimento, peças de vestuário com pequenos defeitos que não serão vendidas. E támbem podem vender seus produtos que não tiveram giro em oferta.</p>
                            <img src={quem_somos} alt="Carrinho de compra com uma tarja de desconto" />
                        </div>
                    </div>

                    <div className='container_marcas'>
                        <h3>Nossas empresas parceiras</h3>
                        <div className='box_marcas'>
                            <img src={assai} alt="Logo Assaí" />
                            <img src={extra} alt="Logo Extra" />
                            <img src={carrefour} alt="Logo Carrefourt" />
                        </div>
                        <div className='box_marcas'>
                            <img src={cea} alt="Logo CeA" />
                            <img src={renner} alt="Logo Renner" />
                            <img src={pernanbucanas} alt="Logo Pernanbucanas" />
                        </div>

                        <button className='botao_sm'>Ver Mais</button>
                    </div>
                </section>

                <Footer/>
            </div>
        )
    }
}