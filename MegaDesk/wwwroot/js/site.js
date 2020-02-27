// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function imgChange(e) {

    var value = e.value;
    document.getElementById("Materials").style.backgroundImage = "url('../images/mat/" + value + ".jpg')";
    document.getElementById("Materials").style.color = "white";
}