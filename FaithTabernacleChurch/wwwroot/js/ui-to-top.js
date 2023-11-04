// JavaScript to handle the back-to-top button
var backToTopButton = document.getElementById("ui-to-top");

// Add a click event handler to scroll to the top when the button is clicked
backToTopButton.addEventListener("click", function () {
    window.scrollTo(0, 0);
});

// Show or hide the button based on scroll position
window.addEventListener("scroll", function () {
    if (window.scrollY > 200) {
        backToTopButton.style.display = "block";
    } else {
        backToTopButton.style.display = "none";
    }
});
