////$(document).ready(function (){
////    $('#tablaProductos').DataTable();
////});


function SeleccionaProducto(idProducto, nombreProducto, descripcion, cantidad, precio, descuento) {
    $("NombreProducto").val(nombreProducto)
    $("Cantidad").val(cantidad)
    $("Precio").val(precio)
    $("PorcentajeDescuento").val(descuento)
    $("Descripcion").val(descripcion)
} 
