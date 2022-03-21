import React, { Component } from 'react'
import ProductoServicio from '../services/ProductoServicio'

class VerProductoComponente extends Component {
    constructor(props) {
        super(props)

        this.state = {
            id: this.props.match.params.id,
            producto: {}
        }
    }

    componentDidMount(){
        ProductoServicio.getBuscarProductos(this.state.id).then( res => {
            this.setState({producto: res.data});
        })
    }

    render() {
        return (
            <div>
                <br></br>
                <div className="container d-flex justify-content-center align-items-center h-100">
                    <div className="row">
                        
                        <div className="col-md-6" key={this.state.producto.id}>
                            <div className="card text-center bg-dark animate__animated animate__fadeInUp">
                                <div className="overflow">
                                    <img src={this.state.producto.imagen} alt="a wallpaper" className="card-img-top" />
                                </div>
                                <div className="card-body text-light">
                                    <h4 className="card-title">{this.state.producto.nombre}</h4>
                                    <p className="card-text text-secondary">
                                    {this.state.producto.nombre
                                        ? this.state.producto.nombre
                                        : "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Magnam deserunt fuga accusantium excepturi quia, voluptates obcaecati nam in voluptas perferendis velit harum dignissimos quasi ex? Tempore repellat quo doloribus magnam."}
                                    </p>
                                </div>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        )
    }
}

export default VerProductoComponente
