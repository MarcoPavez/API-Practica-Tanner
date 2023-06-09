import { useEffect, useState } from "react";

const ProductoVista = () => {
    const [productos, setProductos] = useState([]);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch("api/producto/lista")
            .then(response => response.json())
            .then(responseJson => {
                setProductos(responseJson);
            })
            .catch(error => {
                setError(error);
            });
    }, []); // Provide an empty array as the second argument

    if (error) {
        return <div>Error: {error.message}</div>;
    }

    return (
        <>
            <div className="container">
                <h1>Productos</h1>
                <div className="row">
                    <div className="col-sm-12">
                        <table className="table table-striped">
                            <thead>
                                <tr>
                                    <th>BLablabl</th>
                                    <th>blabla</th>
                                    <th>blabla</th>
                                    <th>blabla</th>
                                    <th>Acciones</th>
                                </tr>
                            </thead>
                            <tbody>
                                {productos.map((item) => (
                                    <tr key={item.idProducto}>
                                        <td>{item.idProducto}</td>
                                        <td>{item.marca}</td>
                                        <td>{item.codigoBarra}</td>
                                        <td>{item.precio}</td>
                                        <td><button></button>
                                            <button></button>
                                        </td>
                                    </tr>
                                ))}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </>
    );
};

export default ProductoVista;
