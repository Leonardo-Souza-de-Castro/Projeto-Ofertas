import '../assets/CSS/rodape.css'
import { Component } from 'react';

import logo from '../assets/img/logo-branca.svg'
import perfil from '../assets/img/perfil.svg'

import '../assets/CSS/home_empresa.css';

export default class Cabecalho extends Component {
    render() {
        return (
            <header className="cabecalhohomeempresa">
                <div className="containerhome">
                    <img src={logo} alt="Logo do nosso site" />
                    <img src={perfil} alt="Perfil" />
                </div>
            </header>
        )
    }
}