import { Component } from "react";
import axios from "axios";
import Cabecalho from "../components/header";

import exemplo from "../assets/img/exemplo_produto.png"

import '../assets/CSS/produto.css'
import '../assets/CSS/reserva.css'

export default class Reserva_Produto extends Component{

    render(){
        return(
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
                            <span>Quantidade Reservada: </span>
                            <div className="box_status_reserva">
                                <hr className="status_reserva"/>
                                <span>Reservado</span>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        )
    }
}