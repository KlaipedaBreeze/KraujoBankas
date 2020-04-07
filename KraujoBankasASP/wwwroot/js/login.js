const loginLink = document.getElementById("loginLink");
const loginStyle = document.getElementsByClassName("form-control");
const showLoginModal = document.getElementById("show-login-modal")
//turn login window off when other forms gets open selector
var login = document.getElementById("loginLink").getAttribute("aria-expanded");

const registerLink = document.getElementById("registerLink");
const registerStyle = document.getElementsByClassName("form-control");

const reminderLink = document.getElementById("reminderLink");
const reminderStyle = document.getElementsByClassName("form-control");



//overwriting BS4 conflicting style between login and and other pop-up windows
loginLink.addEventListener("click", () => {
    for (var i = 0; i < loginStyle.length; i++) {
        loginStyle[i].style.width = `auto`;
        showLoginModal.style.display = "block";
    }
})

registerLink.addEventListener("click", () => {
    for (var i = 0; i < registerStyle.length; i++) {
        registerStyle[i].style.width = `100%`;       
    }
    showLoginModal.style.display = "none";
   
   
           
})

reminderLink.addEventListener("click", () => {
    for (var i = 0; i < reminderStyle.length; i++) {
        reminderStyle[i].style.width = `100%`;       
    }
    showLoginModal.style.display = "none";
   
})

window.addEventListener('click', function (e) {
    if (!document.getElementById('show-login-modal').contains(e.target)) {
        // Clicked outside of the box
        showLoginModal.style.display = "none";
    } 
});