import React, { Component } from 'react'
import ProductoServicio from '../services/ProductoServicio'

class ListaProductoComponent extends Component {
    constructor(props) {
        super(props)

        this.state = {
            productos: []
        }
    }

    verProducto(id){
        this.props.history.push(`/item/${id}`);
    }
    buscarProducto(NombreProducto){
        this.props.history.push(`/buscar-producto/${NombreProducto}`);
    }


    componentDidMount(){
        ProductoServicio.getProductos().then((res) => {
            this.setState({ productos: res.data});
        });
    }



    render() {
        return (
            
            <div>
                <div>
                <header>
                <nav class="navbar navbar-light bg-light">
                    <div class="container-fluid">
                    <form class="d-flex">
                    <input class="form-control me-2" type="search" placeholder="Buscar" aria-label="Search"></input> 
                    <button style={{marginLeft: "10px"}} onClick={ () => this.buscarProducto('remera')} className="btn btn-info">View </button>
                   </form>
                    </div>
                </nav>
                </header>
                </div>
                 <br></br>
                 <div className="container d-flex justify-content-center align-items-center h-100">
                    <div className="row">
                        {this.state.productos.map(producto => (
                        <div className="col-md-6" key={producto.id}>
                            <div className="card text-center bg-dark animate__animated animate__fadeInUp">
                                <div className="overflow">
                                    <img src={producto.imagen} alt="a wallpaper" className="card-img-top" />
                                </div>
                                <div className="card-body text-light">
                                    <h4 className="card-title">{producto.nombre}</h4>
                                    <p className="card-text text-secondary">
                                    {producto.nombre
                                        ? producto.nombre
                                        : "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Magnam deserunt fuga accusantium excepturi quia, voluptates obcaecati nam in voluptas perferendis velit harum dignissimos quasi ex? Tempore repellat quo doloribus magnam."}
                                    </p>
                                    <button style={{marginLeft: "10px"}} onClick={ () => this.verProducto(producto.id)} className="btn btn-info">View </button>
                                </div>
                            </div>
                        </div>
                        ))}
                    </div>
                </div>

            </div>
        )
    }
}

export default ListaProductoComponent
