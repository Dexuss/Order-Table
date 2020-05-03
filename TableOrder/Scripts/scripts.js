window.setPrice(document.getElementById("Name").value);

document.getElementById("Name").addEventListener('change', (event) => {
    window.setPrice(event.target.value);
});

function setPrice(value) {
    var price = document.getElementById("Price");
    price.readOnly = true;
    console.log(value);
    if (value === "Rosół") {
        price.value = "9";
        console.log(price.value);
    }
    else if (value === "Pierogi") {
        price.value = "12";
        console.log(price.value);
    }
    else if (value === "Kotlet schabowy") {
        price.value = "23";
        console.log(price.value);
    }
    else if (value === "Frytki") {
        price.value = "8";
        console.log(price.value);
    }
    else if (value === "Burger") {
        price.value = "19";
        console.log(price.value);
    }
    else if (value === "Burger XXL") {
        price.value = "27";
        console.log(price.value);
    }
}

