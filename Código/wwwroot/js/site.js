// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



document.addEventListener('DOMContentLoaded', function () {
    const selectElement = document.getElementById('supplierSelect');
    const descriptionElement = document.getElementById('supplierDescription');

    selectElement.addEventListener('change', function () {
        const selectedOption = selectElement.options[selectElement.selectedIndex];
        const description = selectedOption.getAttribute('data-description');
        descriptionElement.textContent = "Qr Code:\t" + description || 'Qr Code not avaible!';
    });
});


$(document).ready(function () {
    $('#myTable').DataTable();
});

