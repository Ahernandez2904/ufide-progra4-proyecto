function RegistrarUsuario() {

    var nombre = document.getElementById("nombre").value
    var apellido1 = document.getElementById("apellido1").value
    var apellido2 = $("#apellido2").val();
    var email = $("#email").val();
    var password = $("#password").val();


    $.ajax({
        type: 'POST',
        url: '/Usuario/RegistroUsuarioJS',
        data: {
            nombre: nombre,
            apellido1: apellido1,
            apellido2: apellido2,
            email: email,
            password: password


        },
        dataType: 'json',
        success: function (data) {
          
        },
        error: function (data) {
          
        }
    });

}
function IngresarUsuario() {
    var email = $("#email").val();
    var password = $("#password").val();

    $.ajax({
        type: 'POST',
        url: '/Usuario/IngresoUsuarioJS',
        data: {
            email: email,
            password: password


        },
        dataType: 'json',
        success: function (data) {
        },
        error: function (data) {
        }
    });
}

function ActualizarTiqueteJS(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, Presupuesto, Detalles, TicketID) {
    $.ajax({
        type: 'POST',
        url: '/Usuario/ActualizarTiqueteJS',
        data: {
            Usuario_Empleado_Asig: Usuario_Empleado_Asig,
            Usuario_Cliente: Usuario_Cliente,
            Estado_Ticket: Estado_Ticket,
            Presupuesto: Presupuesto,
            Detalles: Detalles,
            TicketID: TicketID
        },
        dataType: 'json',
        success: function (data) {
        },
        error: function (data) {
        }
    });

}

function logoutJS(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, Presupuesto, Detalles, TicketID) {

    $.ajax({
        type: 'GET',
        url: '/Usuario/logoutJS',
        dataType: 'json',
        success: function (data) {

        },
        error: function (data) {

        }
    });
    location.reload();

}