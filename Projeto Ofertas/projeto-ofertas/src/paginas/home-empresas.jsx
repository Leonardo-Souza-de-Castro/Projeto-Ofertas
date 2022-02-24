import { Component } from 'react';
// import { Link } from '@react-navigation/native';

import logo from '../assets/img/logo.svg'

import '../assets/CSS/home_principal.css'

export default class Home extends Component{

    render(){
        return (
            <div>
                <header className="cabecalhohome">
                    <img src={logo} alt="Logo do nosso site" />
                    <a>Já tem uma conta? Cadastre-se</a>
                </header>
                <section>
                    <h1>Quem sou eu?</h1>
                    <div>
                        <div>
                            <h2>Empresa</h2>
                            <p>Se você possui uma empresa e veio aqui, pode fazer uma doação para nossas ONG´s parceiras ou colocar seus produtos em oferta em nossa plataforma.</p>
                        </div>
                        <div>
                        <h2>Ong</h2>
                            <p>Se você é uma ONG, tem o direito acessar ofertas de nossas empresas parceiras e de arrecadar doações das mesmas e de pessoas voluntárias.</p>
                        </div>
                        <div>
                        <h2>Pessoa Fisica</h2>
                            <p>Se você veio aqui para comprar ou doar, faça seu cadastro aqui e começe a mudar vidas!</p>
                        </div>
                    </div>
                </section>
                <hr />
                <hr />
            </div>
        )
    }
}