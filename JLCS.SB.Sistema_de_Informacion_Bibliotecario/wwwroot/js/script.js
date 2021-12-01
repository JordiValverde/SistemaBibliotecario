function inicioMapa() {
    var coordenada = { lat: -9.3132294, lng: -75.9961645 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 100,
        center: coordenada
    });
    var marker = new google.maps.Marker({
        position: coordenada,
        map: map
    });
}