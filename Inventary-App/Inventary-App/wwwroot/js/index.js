let form = document.querySelector('#form');

document.addEventListener('DOMContentLoaded', () => {
    form.addEventListener('submit', dataValidation);
});

function dataValidation(e) {
    e.preventDefault();

    let userName = document.querySelector('#userName').value;
    let userEmail = document.querySelector('#email').value;
    let userPassword = document.querySelector('#password').value;

    if (userName == '' || userEmail == '' || userPassword == '') {
        swal("Error!", "Todos los campos son obligatorios", "error");

        return;
    }


    swal("Bien hecho", "Usuario creado!", "success");
}