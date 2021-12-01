// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function AlertaDevolucion() {
    var mensaje;
    var opcion = confirm("Desea Registrar Devolucion de Libro?");
    if (opcion == true) {
        mensaje = "Se ha registrado la devolucion";
    } else {
        mensaje = "Se ha cancelado la devolucion";
    }
    document.getElementById("ejemplo").innerHTML = mensaje;
}