var modal = document.getElementById("myModal");
var btn = document.getElementById("pay");
var btnFinal = document.getElementById("buttonPayFinal");
var span = document.getElementsByClassName("close")[0];
var orderPrice= document.getElementById("finalPrice");
var tip = document.getElementById("tipBox");
var orderPriceWithoutTip = parseInt(orderPrice.innerText);
var orderPriceWithTip = parseInt(orderPrice.innerText);
orderPriceWithTip = orderPriceWithTip + (5 / 100) * orderPriceWithTip;

btn.onclick = function () {
    modal.style.display = "block";
}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target === modal) {
        modal.style.display = "none";
    }
}

tip.onchange = function () {
    if (tip.checked === true){
        finalPrice.innerText = orderPriceWithTip;
    }
    else {
        finalPrice.innerText = orderPriceWithoutTip;
    }
};

btnFinal.onclick = function () {
    btnFinal.innerText = "Zamówienie zapłacone";
    btnFinal.style.background = "linear-gradient(to bottom, #3F51B5, #00BCD4)";
    btnFinal.style.border = "2px solid #673AB7";
}