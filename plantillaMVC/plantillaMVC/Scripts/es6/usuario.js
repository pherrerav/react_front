import Swal from 'sweetalert2'

export default APP.usuario = function () {

    let init = () => {
        Swal.fire('Hello world!');
        llenarTblUsuario();
    }
    let llenarTblUsuario = () => {
        $('#tblUsuario').DataTable({
            "bDestroy": true,
            ajax: {
                url: 'Usuario/Index',
                dataType: JSON,
                type: "get",
                "error": function (jqXHR, textStatus, errorThroun) {
                    $("#tblUsuario").DataTable().clear().draw();
                }
            },
            dom: "Bfrtip",
            button: [
                   'excel'
            ],
            columns: [
                {
                    data: 'Id'
                },
                {
                    data: 'CodigoUsuario'
                },
                {
                    data: 'Nombre'
                },
                {
                    data: 'Apellidos'
                },
                {
                    data: 'Estado'
                }
            ]
        });
    }
    return {
        init: init
    }
}()