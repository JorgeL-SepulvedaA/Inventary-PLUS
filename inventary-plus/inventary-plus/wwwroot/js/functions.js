export function showAlert(message, type) {
    let existingAlert = document.querySelector('.alerta');
    let alertField = document.querySelector('.alert-field');

    if (!existingAlert) {
        let alert = document.createElement('p');
        alert.classList.add('text-center', 'alert', 'font-weight-bold', 'd-block', 'm-auto', 'mb-2', 'alerta');

        if (type == 'error') {
            alert.classList.add('alert-danger');
        } else {
            alert.classList.add('alert-success');
        }

        alert.textContent = message;

        alertField.appendChild(alert);

        setTimeout(() => {
            alert.remove();
        }, 3000);
    }
}