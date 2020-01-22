// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function replaceSpecialChars(str) {
    return str.normalize('NFD').replace(/[\u0300-\u036f]/g, '') // Remove acentos
        .split("&").join("e")
        .replace(/([^\w]+|\s+)/g, '-') // Substitui espaço e outros caracteres por hífen
        .replace(/\-\-+/g, '-')	// Substitui multiplos hífens por um único hífen
        .replace(/(^-+|-+$)/, '') // Remove hífens extras do final ou do inicio da string
        .toLowerCase();  
}

function generateUrl(urlDefault, url, title) {

    var titulo = $("#Titulo");  

    titulo.keyup(function () {
        url.val(urlDefault + replaceSpecialChars(titulo.val()));
    });
}
