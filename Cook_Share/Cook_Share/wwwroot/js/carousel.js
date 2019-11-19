$(document).ready(function () {
    $(".owl-carousel").owlCarousel({
        margin: 0,
        nav: true,
        navClass: ["slider__nav--left", "slider__nav--right"],
        responsive: {
            0: {
                items: 1
            }
        }
    });
});
