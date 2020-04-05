const carousel = {
    prev: document.getElementsByClassName("prev")[0],
    next: document.getElementsByClassName("next")[0]
}

//carousel starting line
carousel.next.style = `color: rgb(174, 174, 174)`;
carousel.prev.style = `color: rgb(174, 174, 174)`;

let slideIndex = 1;

showSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}

setInterval(function () {
    let slides = document.getElementsByClassName("mySlides");
    if (slideIndex >= slides.length)
    {
        slideIndex = 1;
        showSlides(slideIndex);
        
    }
    else if (slideIndex < slides.length)
    {
        slideIndex++;
        showSlides(slideIndex);
        
    }
    
    
}, 5000);
//carousel ending line