; (function ($) {
    "use strict"
    var nav_offset_top = $('.header_area').height() + 50;
    /*-------------------------------------------------------------------------------
      Navbar 
    -------------------------------------------------------------------------------*/

    //* Navbar Fixed  
    function navbarFixed() {
        if ($('.header_area').length) {
            $(window).scroll(function () {
                var scroll = $(window).scrollTop();
                if (scroll >= nav_offset_top) {
                    $(".header_area").addClass("navbar_fixed");
                } else {
                    $(".header_area").removeClass("navbar_fixed");
                }
            });
        };
    };
    navbarFixed();

    function testimonialSlider() {
        if ($('.testimonial_slider').length) {
            $('.testimonial_slider').owlCarousel({
                loop: true,
                margin: 30,
                items: 2,
                nav: false,
                autoplay: true,
                dots: true,
                smartSpeed: 1500,
                responsiveClass: true,
                responsive: {
                    0: {
                        items: 1,
                    },
                    768: {
                        items: 2,
                    },
                }
            })
        }
    }
    testimonialSlider();

    //------- Mailchimp js --------//  

    function mailChimp() {
        $('#mc_embed_signup').find('form').ajaxChimp();
    }
    mailChimp();

    /* ===== Parallax Effect===== */

    function parallaxEffect() {
        $('.bg-parallax').parallax();
    }
    parallaxEffect();


    $('select').niceSelect();
    $('#datetimepicker11,#datetimepicker1').datepicker({
        format: 'mm/dd/yyyy',
        startDate: new Date(),
        endDate: new Date(new Date().setYear(new Date().getFullYear() + 1))
    });

    /*---------gallery isotope js-----------*/
    function galleryMasonry() {
        if ($('#gallery').length) {
            $('#gallery').imagesLoaded(function () {
                // images have loaded
                // Activate isotope in container
                $("#gallery").isotope({
                    itemSelector: ".gallery_item",
                    layoutMode: 'masonry',
                    animationOptions: {
                        duration: 750,
                        easing: 'linear'
                    }
                });
            })
        }
    }
    galleryMasonry();

    /*----------------------------------------------------*/
    /*  Simple LightBox js
    /*----------------------------------------------------*/
    $('.imageGallery1 .light').simpleLightbox();

    /*----------------------------------------------------*/
    /*  Google map js
    /*----------------------------------------------------*/

    if ($('#mapBox').length) {
        var $lat = $('#mapBox').data('lat');
        var $lon = $('#mapBox').data('lon');
        var $zoom = $('#mapBox').data('zoom');
        var $marker = $('#mapBox').data('marker');
        var $info = $('#mapBox').data('info');
        var $markerLat = $('#mapBox').data('mlat');
        var $markerLon = $('#mapBox').data('mlon');
        var map = new GMaps({
            el: '#mapBox',
            lat: $lat,
            lng: $lon,
            scrollwheel: false,
            scaleControl: true,
            streetViewControl: false,
            panControl: true,
            disableDoubleClickZoom: true,
            mapTypeControl: false,
            zoom: $zoom,
            styles: [
                {
                    "featureType": "water",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#dcdfe6"
                        }
                    ]
                },
                {
                    "featureType": "transit",
                    "stylers": [
                        {
                            "color": "#808080"
                        },
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "visibility": "on"
                        },
                        {
                            "color": "#dcdfe6"
                        }
                    ]
                },
                {
                    "featureType": "road.highway",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "road.local",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "visibility": "on"
                        },
                        {
                            "color": "#ffffff"
                        },
                        {
                            "weight": 1.8
                        }
                    ]
                },
                {
                    "featureType": "road.local",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#d7d7d7"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "visibility": "on"
                        },
                        {
                            "color": "#ebebeb"
                        }
                    ]
                },
                {
                    "featureType": "administrative",
                    "elementType": "geometry",
                    "stylers": [
                        {
                            "color": "#a7a7a7"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#ffffff"
                        }
                    ]
                },
                {
                    "featureType": "landscape",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "visibility": "on"
                        },
                        {
                            "color": "#efefef"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "color": "#696969"
                        }
                    ]
                },
                {
                    "featureType": "administrative",
                    "elementType": "labels.text.fill",
                    "stylers": [
                        {
                            "visibility": "on"
                        },
                        {
                            "color": "#737373"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "labels.icon",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "poi",
                    "elementType": "labels",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {
                    "featureType": "road.arterial",
                    "elementType": "geometry.stroke",
                    "stylers": [
                        {
                            "color": "#d6d6d6"
                        }
                    ]
                },
                {
                    "featureType": "road",
                    "elementType": "labels.icon",
                    "stylers": [
                        {
                            "visibility": "off"
                        }
                    ]
                },
                {},
                {
                    "featureType": "poi",
                    "elementType": "geometry.fill",
                    "stylers": [
                        {
                            "color": "#dadada"
                        }
                    ]
                }
            ]
        });
    }
})(jQuery);

const formatter = new Intl.NumberFormat('vi-VN', {
    style: 'currency',
    currency: 'VND',
});

function chooseService(index) {
    if (document.getElementById("checkbox-service-" + index).checked) {
        document.getElementById("amount-service-" + index).disabled = false;
        document.getElementById("amount-service-" + index).value = 1;
        var servicePrice = document.getElementById("service-price-" + index).value;
        var currentPrice = parseFloat(document.getElementById("service-total").innerHTML).toFixed(2);
        if (currentPrice < 100) currentPrice = currentPrice * 1000;
        document.getElementById("service-total").innerHTML = formatter.format(currentPrice*1000 + parseInt(servicePrice));
    } else {
        var servicePrice = document.getElementById("service-price-" + index).value;
        var serviceAmount = document.getElementById("amount-service-" + index).value;
        var currentPrice = parseFloat(document.getElementById("service-total").innerHTML).toFixed(2);
        if (currentPrice < 100) currentPrice = currentPrice * 1000;
        document.getElementById("service-total").innerHTML = formatter.format(currentPrice * 1000 - parseInt(servicePrice) * serviceAmount);
        document.getElementById("amount-service-" + index).value = 0;
        document.getElementById("amount-service-" + index).disabled=true;
    }
}

function bookService(numOfServiceList, roomPrice) {
    var serviceBookingTotal = 0;
    for (var i = 0; i < numOfServiceList; i++) {
        var amount = document.getElementById("amount-service-" + i).value;
        var price = document.getElementById("service-price-" + i).value;
        serviceBookingTotal = serviceBookingTotal + amount * price;
    }
    document.getElementById("service-total").innerHTML = formatter.format(serviceBookingTotal + roomPrice);
}