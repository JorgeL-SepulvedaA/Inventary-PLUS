import { showAlert } from './functions.js';

let form = document.querySelector('#form');
let alertField = document.querySelector('.alert-field');

document.addEventListener('DOMContentLoaded', () => {
    form.addEventListener('submit', dataValidation);
});

function dataValidation(e) {
    e.preventDefault();

    let userName = document.querySelector('#userName').value;
    let userEmail = document.querySelector('#email').value;
    let userPassword = document.querySelector('#password').value;

    if (userName == '' || userEmail == '' || userPassword == '') {
        showAlert('All fields are required', 'error');

        return;
    }


    swal("Bien hecho", "Usuario creado!", "success");
}