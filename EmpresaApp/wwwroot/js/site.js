// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const formularioContainer = document.getElementById('formulario-container')
const inputsForm = document.querySelectorAll('#formulario-container input')
const selectForm = document.querySelectorAll('#formulario-container select')


document.getElementById('btnNuevo').addEventListener('click', () => {
    inputsForm.forEach(el => el.removeAttribute('disabled'))
    selectForm.forEach(el => el.removeAttribute('disabled'))
    document.getElementById('NoProducto').setAttribute('disabled', true)
})

document.getElementById('btnCancelar').addEventListener('click', () => {
    inputsForm.forEach(el => el.setAttribute('disabled', true))
    selectForm.forEach(el => el.setAttribute('disabled', true))
    document.getElementById('NoProducto').setAttribute('disabled', true)
})