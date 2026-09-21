if ("serviceWorker" in navigator) {
    window.addEventListener("load", function () {
        navigator.serviceWorker
            .register("/service-worker.js")
            .catch(function (error) {
                console.error(
                    "Error al registrar el service worker:",
                    error
                );
            });
    });
}