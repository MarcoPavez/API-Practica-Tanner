import { useEffect, useState } from "react";

const UsuarioVista = () => {

    const [usuario, setUsuario] = useState([]);
    const [error, setError] = useState([]);

    useEffect(() => {
        fetch("api/usuario")
            .then(response => response.json())
            .then(responseJson => {
                setUsuario(responseJson);
            })
            .catch(error => {
                setError(error);
            })
    }, [])

    if (error) {
        return <div>Error: {error.message}</div>;
    }

    return (
        <>
            <div className="container">
                <h1>Usuario</h1>
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
                                {usuario.map((item) => (
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

export default UsuarioVista;