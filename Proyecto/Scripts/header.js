let navbarToggler2 = document.querySelector(".header-2 .navbar-toggler");
var navbarCollapse2 = document.querySelector(".header-2 .navbar-collapse");
document.querySelectorAll(".header-2 .page-scroll").forEach(e =>
    e.addEventListener("click", () => {
        navbarToggler2.classList.remove("active");
        navbarCollapse2.classList.remove('show')
    })
);
navbarToggler2.addEventListener('click', function () {
    navbarToggler2.classList.toggle("active");
})