import { Component } from "react";
import axios from "axios";
import Cabecalho from "../components/header";

import exemplo from "../assets/img/exemplo_produto.png"

import '../assets/CSS/produto.css'
import '../assets/CSS/reserva.css'

export default class Reserva_Produto extends Component{
    // constructor(props) {
    //     super(props)
    //     this.state = {
    //         IdReserva: props.location.state.id,
    //         DataValidade: '',
    //         Nome: '',
    //         Quantidade: '',
    //         QuantidadeExistente: '',
    //         Finalidade: '',
    //         Descricao: '',
    //         Imagem: ''
    //     }
    // }

    // BuscarporId = () => {
    //     axios.get('http://localhost:5000/api/Reservas/' + this.state.IdProduto)
    //         .then(resposta => {
    //             if (resposta.status === 200) {
    //                 this.setState({
    //                     DataValidade: resposta.data.dataValidade,
    //                     Nome: resposta.data.nomeProduto,
    //                     QuantidadeExistente: resposta.data.quantidade,
    //                     Descricao: resposta.data.descricao,
    //                     Finalidade: resposta.data.idFinalidadeNavigation.finalidade1,
    //                 })
    //             }
    //         })
    // }

    // componentDidMount() {
    //     this.BuscarporId()
    // }

    render(){
        return(
            <div>
                <Cabecalho />
                <section className="container_produto">
                    <div className="container_fundo_produto">
                        <div className="box_foto">
                            <img src={exemplo} alt="" />
                            <span>Data de Validade: teste</span>
                        </div>

                        <div className="box_info_produto">
                            <span>{this.state.Nome}</span>
                            <span>R$ 7,50</span>
                            <span>Desconto para Ong: R$0,00</span>
                            <span>Quantidade Reservada: teste</span>
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