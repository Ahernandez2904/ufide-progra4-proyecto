var x = "";

$(document).ready(function () {
    $('#Productos').DataTable();

    $('#Eliminar').on('show.bs.modal', function (e) {
        x = $(e.relatedTarget).data('id');
    });

});




function SeleccionaProducto(idProducto, nombreProducto, descripcion, cantidad, precio, descuento) {
    $("#NombreProducto").val(nombreProducto)
    $("#Cantidad").val(cantidad)
    $("#Precio").val(precio)
    $("#PorcentajeDescuento").val(descuento)
    $("#Descripcion").val(descripcion)
}

function EliminarProducto() {

    $.ajax({
        type: 'POST',
        url: '/Productos/EliminarJS',
        data: {
            ProductoID: x
        },
        dataType: 'json',
        success: function (data) {

        },
        error: function (data) {
            $('#Eliminar').modal('hide');
            location.reload();
        }
    });
}

function ActualizarProducto() {

    $.ajax({
        type: 'POST',
        url: '/Productos/ActualizarJS',
        data: {
            ProductoID: x
        },
        dataType: 'json',
        success: function (data) {
            location.window.href = "ActualizarProducto", "Productos";
        },
        error: function (data) {
            location.window.href = "ActualizarProducto", "Productos";
        }
    });
}

