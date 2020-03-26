let loginWindow = document.getElementById("login");
let registerWindow = document.getElementsByClassName("form-control");

//overwriting BS4 conflicting style between login and registration window
loginWindow.addEventListener("click", () => {

    for (var i = 0; i < registerWindow.length; i++) {
        registerWindow[i].style.width = "100%";
    }
});
