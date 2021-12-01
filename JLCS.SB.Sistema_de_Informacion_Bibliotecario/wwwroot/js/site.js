// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function AlertaSancion() {
    var mensaje;
    var opcion = confirm("Desea Penalizar al Usuario?");
    if (opcion == true) {
        mensaje = "Usuario Penalizado";
        return true;
    } else {
        mensaje = "Has clickado Cancelar";
        return false;
    }
    document.getElementById("ejemplo").innerHTML = mensaje;
}
