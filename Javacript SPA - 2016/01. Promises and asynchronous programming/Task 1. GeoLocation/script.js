(function() {
    let promise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((pos) => {
            resolve(pos);
        });
    });

    function getLattitudeAndLongtitude(geolocationPosition) {
        return {
            latitude: geolocationPosition.coords.latitude,
            longitude: geolocationPosition.coords.longitude
        };
    }

    function map(coordinates) {
        let map = document.getElementById('map');
        let imgSrc = "http://maps.googleapis.com/maps/api/staticmap?center=" + coordinates.latitude + "," + coordinates.longitude + "&zoom=18&size=500x500&sensor=false";

        map.setAttribute('src', imgSrc);
    }

    promise
        .then(getLattitudeAndLongtitude)
        .then(map)
        .catch();
}());