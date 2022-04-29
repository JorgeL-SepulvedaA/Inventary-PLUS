let form = document.querySelector('#form');
let alertField = document.querySelector('.alert-field');

document.addEventListener('DOMContentLoaded', () => {
    form.addEventListener('submit', dataValidation);
});

function dataValidation(e) {
    e.preventDefault();

    let userEmail = document.querySelector('#email').value;
    let userPassword = document.querySelector('#password').value;

    if (userEmail == '' || userPassword == '') {
        swal("Error!", "Todos los campos son obligatorios", "error");

        return;
    }

    swal("Bien hecho!", "Datos correctos", "success");
}