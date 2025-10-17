document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('formComentario');
    const mensaje = document.getElementById('mensajeEnviado');

    form.addEventListener('submit', function (e) {
        e.preventDefault(); // Evita recargar la página

        // Mostrar mensaje
        mensaje.style.display = 'block';

        // Limpiar campos
        form.reset();

        // Ocultar mensaje después de 2 segundos
        setTimeout(() => {
            mensaje.style.display = 'none';
        }, 2000);
    });
});

