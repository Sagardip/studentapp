// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var deleteItem = document.getElementById('delete');
deleteItem.addEventListener('click', function() {

    var confirmValue = confirm("Are you sure want to Delete");
    if (confirmValue == true) {
        return true;
    } else {
        return false;
    }
})
var a = document.getElementById('file');
a.onchange = function(event) {
    var reader = new FileReader();
    reader.readAsDataURL(event.srcElement.files[0]);

    reader.onload = function() {
        var fileContent = reader.result;
        var b = document.getElementById('imagepath');
        b.src = fileContent;
        var cancel = document.getElementById('crossicon');
        b.style.opacity = "1";
        var i = 0;
        cancel.addEventListener('click', function() {
            a.value = "";
            b.style.opacity = "0";

        })
    };
}