let form = document.querySelector('#form');

document.addEventListener('DOMContentLoaded', () => {
    form.addEventListener('submit', dataValidation);
})

function dataValidation(e) {
    e.preventDefault();

    let userEmail = document.querySelector('#email').value;

    if (userEmail == '') {
        swal("Error!", "El Email es obligatorio", "error");

        return;
    }

    swal("Bien hecho!", "Correo Enviado", "success");
}