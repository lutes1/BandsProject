$(document).ready(
    function () {
        if ($(window).width() <= 991) {
            arrangeContentForSmallScreen();
        }
        else {
            arrangeContentForBigScreen();
        }

        $(window).resize(function () {
            if ($(window).width() <= 991) {
                arrangeContentForSmallScreen();

            } else {
                arrangeContentForBigScreen();
            }
        });

        function arrangeContentForBigScreen() {
            $("nav").addClass("navbar-custom");
            $(".top-menu-item").addClass("line-right");
            $(".dropdown-container").addClass("dropdown-container-right");
            $(".dropdown-container").removeClass("dropdown-container-left");
        }

        function arrangeContentForSmallScreen() {
            $("nav").removeClass("navbar-custom");
            $(".top-menu-item").removeClass("line-right");
            $(".dropdown-container").removeClass("dropdown-container-right");
            $(".dropdown-container").addClass("dropdown-container-left");
        }

        $("#user-dropdown").click(
            function() {
                $(".dropdown-container").toggle("blind");
            }
        );

        $('.sign-up-form').on('keyup keypress', function (e) {
            var keyCode = e.keyCode || e.which;
            if (keyCode === 13) {
                e.preventDefault();
                return false;
            }
        });
    });