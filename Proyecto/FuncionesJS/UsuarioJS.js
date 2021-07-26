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
            alert("Usuario Registrado");
        },
        error: function (data) {
            alert('mal');
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
            alert('Usuario Encontrado');
        },
        error: function (data) {
            alert('mal');
        }
    });

}