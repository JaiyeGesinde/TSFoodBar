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


/*function addSumit(formSelector) {
    document.querySelector(formSelector).addEventListener("submit", onSubmit);
}

addSumit("#foodForm");
*/


function onSubmit(e) {
    console.log("handle submit");
    e.preventDefault();
    getFormData("#foodForm");
}


/*CART*/
//Update Total

let price = document.getElementById('price').innerText;

let quantityDom = document.getElementById('quantity');

let total = 0;


quantityDom.addEventListener('change', () => {
    document.getElementById('total').innerText = Number(price) * Number(document.getElementById('quantity').value)
})


