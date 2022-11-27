// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function OpenPopup(id) {
    let popup = document.getElementById(id);
    popup.classList.add("open-popup");
}

function ClosePopup(id) {
    let popup = document.getElementById(id);
    popup.classList.remove("open-popup");
}

function getFormData(selector) {
    var data = Object.fromEntries(new FormData(document.querySelector(selector)));
    console.log(data);
}

function addSumit(formSelector) {
    document.querySelector(formSelector).addEventListener("submit", onSubmit);
}

addSumit("#foodForm");

function onSubmit(e) {
    console.log("handle submit");
    e.preventDefault();
    getFormData("#foodForm");
}

/*MENU*/
var data = 1;

//printing default value of data that is 0 in h2 tag
document.getElementById(id).innerText = data;

//increment function
function increment(id) {
    data = data + 1;
    document.getElementById(id).innerText = data;
}
//decrement function
function decrement(id) {
    data = data - 1;
    document.getElementById(id).innerText = data;
}

