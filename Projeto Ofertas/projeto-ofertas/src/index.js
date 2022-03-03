import React from 'react';
import ReactDOM from 'react-dom';
import reportWebVitals from './reportWebVitals';

import './index.css';

import {
  Route,
  BrowserRouter as Router,
  Redirect,
  Switch,
} from 'react-router-dom';

import Home from '../src/paginas/home-principal';
import Login from '../src/pages/login.jsx';
import Home_Empresa from '../src/paginas/home-empresa.jsx';
import NotFound from './paginas/not_found.jsx';
import CadastroEmpresa from './paginas/cadastro-empresa';
// import './assets/css/login.css'

const routing = (
  <Router>
    <div>
      <Switch>
        <Route exact path="/" component={Home} />
        <Route path="/Login" component={Login} />
        <Route path="/Empresa" component={Home_Empresa} />
        <Route path="/CadastroEmpresa" component={CadastroEmpresa} />
        <Route path="/NotFound" component={NotFound} />
        <Redirect to='/NotFound'/>
      </Switch>
    </div>
  </Router>
)

ReactDOM.render(routing, document.getElementById('root'));

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
