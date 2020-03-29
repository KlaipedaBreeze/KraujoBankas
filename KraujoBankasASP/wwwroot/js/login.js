let loginWindow = document.getElementById("login");
let registerWindow = document.getElementsByClassName("form-control");

//overwriting BS4 conflicting style between login and registration window
loginWindow.addEventListener("click", () => {

    for (var i = 0; i < registerWindow.length; i++) {
        registerWindow[i].style.width = "100%";
    }
});

// When the DOM is ready, run this function
$(document).ready(function () {
    //Set the carousel options
    $('#quote-carousel').carousel({
        pause: true,
        interval: 4000,
    });
});