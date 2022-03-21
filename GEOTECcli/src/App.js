import React from 'react';
import './App.css';
import {BrowserRouter as Router, Route, Switch} from 'react-router-dom'
import ListaProductoComponent from './components/ListaProductoComponent';
import VerProductoComponente from './components/VerProductoComponente';
import BuscarProductoComponente from './components/BuscarProductoComponente';

function App() {
  return (
    <div>
        <Router>
                <div className="container">
                    <Switch> 
                          <Route path = "/" exact component = {ListaProductoComponent}></Route>
                          <Route path = "/item/:Id" component = {VerProductoComponente}></Route>
                          <Route path = "/buscar-producto/:NombreProducto" component = {BuscarProductoComponente}></Route>
                    </Switch>
                </div>
        </Router>
    </div>
    
  );
}

export default App;
