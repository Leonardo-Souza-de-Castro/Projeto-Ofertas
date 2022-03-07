import { Component } from "react";
import axios from "axios";
import Cabecalho from "../components/header";
import Rodape from "../components/footer";

import {
    BrowserRouter as Router,
    Link,
    Redirect
} from "react-router-dom";

import exemploo from '../assets/img/oleo.svg'

import '../assets/CSS/listar_produtos.css'

export default class Listar_Produtos extends Component {
    constructor(props) {
        super(props)
        this.state = {
            listaProdutos: []
        }
    }

    listarprodutos = () => {
        axios('http://localhost:5000/api/Produtos').then(resposta => {
            if (resposta.status === 200) {
                this.setState({
                    listaProdutos: resposta.data
                })
            }
        }).catch(erro => console.log(erro))
    };

    componentDidMount() {
        this.listarprodutos()
    }


    render() {
        return (
            <div>
                <Cabecalho />
                <section className="fundo-produtos">
                    <h1 className="titulo-area">Alimentos</h1>

                    <div className="alimentos">

                        <h2 className="finalidade">Doações</h2>
                        {
                            this.state.listaProdutos.map((evento) => {
                                if (evento.idFinalidade === 1 && evento.idTipoProduto !== 2) {

                                    return (
                                        <div className="produto-solo">
                                            <img src={exemploo} alt="" />
                                            <div className="info_produto">
                                            <Link to={{ pathname: '/Produto', state: { id: evento.idProduto } }}><span>{evento.nomeProduto}</span></Link>
                                                <span>{evento.idFinalidadeNavigation.finalidade1}</span>
                                            </div>
                                        </div>
                                    )
                                }
                            })
                        }

                        <h2 className="finalidade">Ofertas</h2>
                        {
                            this.state.listaProdutos.map((evento) => {
                                if (evento.idFinalidade === 2 && evento.idTipoProduto !== 2) {

                                    return (
                                        <div className="produto-solo">
                                            <img src={exemploo} alt="" />
                                            <div className="info_produto">
                                                <Link to={{ pathname: '/Produto', state: { id: evento.idProduto } }}><span>{evento.nomeProduto}</span></Link>

                                                <span>{evento.idFinalidadeNavigation.finalidade1}</span>
                                            </div>
                                        </div>
                                    )
                                }
                            })
                        }
                    </div>

                </section>

                <section className="fundo-produtos">
                    <h1 className="titulo-area">Roupas</h1>
                    <div className="alimentos">

                        <h2 className="finalidade">Doações</h2>
                        {
                            this.state.listaProdutos.map((evento) => {
                                if (evento.idFinalidade === 1 && evento.idTipoProduto !== 1) {

                                    return (
                                        <div className="produto-solo">
                                            <img src={exemploo} alt="" />
                                            <div className="info_produto">
                                            <Link to={{ pathname: '/Produto', state: { id: evento.idProduto } }}><span>{evento.nomeProduto}</span></Link>
                                                <span>{evento.idFinalidadeNavigation.finalidade1}</span>
                                            </div>
                                        </div>
                                    )
                                }
                            })
                        }
                        <h2 className="finalidade">Ofertas</h2>
                        {
                            this.state.listaProdutos.map((evento) => {
                                if (evento.idFinalidade === 2 && evento.idTipoProduto !== 1) {

                                    return (
                                        <div className="produto-solo">
                                            <img src={exemploo} alt="" />
                                            <div className="info_produto">
                                            <Link to={{ pathname: '/Produto', state: { id: evento.idProduto } }}><span>{evento.nomeProduto}</span></Link>
                                                <span>{evento.idFinalidadeNavigation.finalidade1}</span>
                                            </div>
                                        </div>
                                    )
                                }
                            })
                        }
                    </div>
                </section>
                <Rodape />
            </div>
        )
    }
}