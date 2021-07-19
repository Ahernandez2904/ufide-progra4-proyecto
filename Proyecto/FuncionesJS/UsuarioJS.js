window.onload = Inicio();

function Inicio() {
    document.getElementById("userID").placeholder = "User ID";
    document.getElementById("Correo").placeholder = "Correo";
    document.getElementById("Contrasena").placeholder = "Contraseña";
}

function RegistrarUsuario() {

    var id = document.getElementbyId("userID").value;
    var email = document.getElementbyId("Correo").value;
    var paasword = $("Contrasena").val();

}

