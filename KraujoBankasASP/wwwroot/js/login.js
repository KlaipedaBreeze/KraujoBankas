let loginWindow = document.getElementsByClassName("login");
let registerWindow = document.getElementsByClassName("form-control");

//overwriting BS4 conflicting style between login and registration window
for (var i = 0; i < loginWindow.length; i++) {
    loginWindow[i].addEventListener("click", () => {

        for (var i = 0; i < registerWindow.length; i++) {
            registerWindow[i].style.width = "100%";
            console.log("veikia");
        }
    })
}

//registerWindow.addEventListener("click", () => {

//})