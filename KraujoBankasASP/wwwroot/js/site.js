//finding url location
const pathName = window.location.pathname;
const dashboard = window.location.href;
//checking if current page is index
if (pathName == "/") {
    let marginTop = document.querySelectorAll(".my-mt-10");
    marginTop.forEach(element => element.className = "container mt-5");
}

//padding bottom if dashboard is not active
if (dashboard.indexOf("/Dashboard") > 0) {
    let paddingBot = document.querySelectorAll('main');
    paddingBot.forEach(element => element.className = "my-pb-40");
}