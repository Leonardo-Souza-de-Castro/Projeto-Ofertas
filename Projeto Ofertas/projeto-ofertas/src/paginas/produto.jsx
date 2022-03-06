import { Component } from "react";
import axios from "axios";
import Cabecalho from "../components/header";

import exemplo from "../assets/img/exemplo_produto.png"

import '../assets/CSS/produto.css'

export default class Produto extends Component {
    constructor(props) {
        super(props)
        this.state = {
            IdProduto: '',
            DataValidade: '',
            Nome: '',
            Quantidade: '',
            Imagem: ''
        }
    }

    render() {
        return (
            <div>
                <Cabecalho />
                <section className="container_produto">
                    <div className="container_fundo_produto">
                        <div className="box_foto">
                            <img src={exemplo} alt="" />
                            <span>Data de Validade: 06/03/2022</span>
                        </div>

                        <div className="box_info_produto">
                            <span>Queijo Gorgonzola fracionado</span>
                            <span>R$ 7,50</span>
                            <span>Desconto para Ong: R$0,00</span>
                            <select className='input-cadastro' name="Quantidade" value={this.state.Quantidade} onChange={this.atualizaStateCampo}>
                                <option value="0">Quantidade</option>
                                <option value="1">5</option>
                                <option value="2">10</option>
                                <option value="3">15</option>
                                <option value="4">20</option>
                                <option value="5">25</option>
                                <option value="6">30</option>
                            </select>
                            <button className="btn_reserva">Reservar</button>
                        </div>
                    </div>
                </section>
            </div>
        )
    }
}