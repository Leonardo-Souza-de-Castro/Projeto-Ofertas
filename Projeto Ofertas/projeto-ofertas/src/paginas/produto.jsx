import { Component } from "react";
import axios from "axios";
import Cabecalho from "../components/header";

import exemplo from "../assets/img/exemplo_produto.png"

import '../assets/CSS/produto.css'

export default class Produto extends Component {
    constructor(props) {
        super(props)
        this.state = {
            IdProduto: props.location.state.id,
            DataValidade: '',
            Nome: '',
            Quantidade: '',
            QuantidadeExistente: '',
            Finalidade: '',
            Descricao: '',
            Imagem: ''
        }
    }


    BuscarporId = () => {
        axios.get('http://localhost:5000/api/Produtos/' + this.state.IdProduto)
            .then(resposta => {
                if (resposta.status === 200) {
                    this.setState({
                        DataValidade: resposta.data.dataValidade,
                        Nome: resposta.data.nomeProduto,
                        QuantidadeExistente: resposta.data.quantidade,
                        Descricao: resposta.data.descricao,
                        Finalidade: resposta.data.idFinalidadeNavigation.finalidade1,
                    })
                }
            })
    }

    ReservarProduto = () => {
        let reserva = {
            idUsuario: 9,
            idSituacaoReserva: 1,
            idProduto: this.state.IdProduto,
            quantidadeReservada: 1,
        }

        axios.post('http://localhost:5000/api/Reservas', reserva).then(resposta => {
            if (resposta.status === 201) {
                this.props.history.push('/reserva')
            }
        })
    }


    componentDidMount() {
        this.BuscarporId()
    }

    render() {
        return (
            <div>
                <Cabecalho />
                <section className="container_produto">
                    <div className="container_fundo_produto">
                        <div className="box_foto">
                            <img src={exemplo} alt="" />
                            {/* <span>Data de Validade: {Intl.DateTimeFormat(
                                            "pt-BR", {
                                            year: 'numeric', month: 'numeric', day: 'numeric',
                                            hour: 'numeric', minute: 'numeric',
                                            hour12: false
                                        }).format(new Date(this.state.DataValidade))}</span> */}
                            <span>Data de Validade: {this.state.DataValidade}</span>
                        </div>

                        <div className="box_info_produto">
                            <span>{this.state.Nome}</span>
                            <span>{this.state.Finalidade}</span>
                            <span>{this.state.QuantidadeExistente}</span>
                            {/* <select className='input-cadastro' name="Quantidade" value={this.state.Quantidade} onChange={this.atualizaStateCampo}>
                                <option value="0">Quantidade</option>
                                <option value="1">5</option>
                                <option value="2">10</option>
                                <option value="3">15</option>
                                <option value="4">20</option>
                                <option value="5">25</option>
                                <option value="6">30</option>
                            </select> */}
                            <button className="btn_reserva" onClick={() => this.ReservarProduto()} >Reservar</button>
                        </div>
                    </div>
                </section>
            </div>
        )
    }
}