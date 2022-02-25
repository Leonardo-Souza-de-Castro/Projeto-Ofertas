import { Component } from 'react';

import '../assets/css/cadastrar_cliente.css';

export default class Cadastrar extends Component {
    constructor(props) {
        super(props)
        this.state = {
            idProntuario: 0,
            idMedico: 0,
            idStatus: 3,
            idClinica: 0,
            dataConsulta: new Date(),

            listaPacientes: [],
            listaMedicos: [],
            listaClinicas: [],
            isLoading: false
        }
    }

    render() {
        return (
            <div>
                <Header />

                <main>
                    <section className="container-formulario">
                        <h1>Cadastro de Consulta</h1>
                        <form action="" className="box-inputs" onSubmit={this.cadastrarConsulta}>
                            <select name="idProntuario" value={this.state.idProntuario} onChange={this.atualizaStateCampo}>
                                <option value="0" selected disabled>
                                    Selecione o Paciente
                                </option>

                                {this.state.listaPacientes.map((tema) => {
                                    return (
                                        <option key={tema.idProntuario} value={tema.idProntuario}>
                                            {tema.nome}
                                        </option>
                                    );
                                })}
                            </select>
                            <input type="datetime-local" name="dataConsulta" required="required" value={this.state.dataConsulta} onChange={this.atualizaStateCampo} />
                            <select name="idMedico" value={this.state.idMedico} onChange={this.atualizaStateCampo}>
                                <option value="0" selected disabled>
                                    Selecione o Medico
                                </option>

                                {this.state.listaMedicos.map((tema) => {
                                    return (
                                        <option key={tema.idMedico} value={tema.idMedico}>
                                            {tema.nome}
                                        </option>
                                    );
                                })}
                            </select>
                            <select name="idClinica" value={this.state.idClinica} onChange={this.atualizaStateCampo}>
                                <option value="0" selected disabled>
                                    Selecione a Clinica
                                </option>

                                {this.state.listaClinicas.map((tema) => {
                                    return (
                                        <option key={tema.idClinica} value={tema.idClinica}>
                                            {tema.nomeFantasia}
                                        </option>
                                    );
                                })}
                            </select>
                            {
                                this.state.isLoading === true ? <button disabled>Cadastrando...</button> : <button className="Entrando">Cadastrar</button>
                            }
                        </form>
                    </section>
                </main>
            </div>
        )
    }
}