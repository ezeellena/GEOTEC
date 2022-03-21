import axios from 'axios';

const PRODUCTO_API_BASE_URL = "https://localhost:44385/api/Products/";

class ProductoServicio {

    getProductos(){
        return axios.get(PRODUCTO_API_BASE_URL + 'GetProductos');
    }
    getDetalleProducto(id){
        return axios.get(PRODUCTO_API_BASE_URL + 'GetProductoDetalle' + '/' + id);
    }
    getBuscarProductos(NombreProducto){
        return axios.post(PRODUCTO_API_BASE_URL + 'BuscarProductos' + '/' + NombreProducto);
    }

}

export default new ProductoServicio()