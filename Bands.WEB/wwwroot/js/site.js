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

        //------Autocompletes population
        $("#Interests").autocomplete({
            classes: {
                "ui-autocomplete": "dropdown-element"
            },
            source: interests
        });

        $("#Country").autocomplete({
            classes: {
                "ui-autocomplete": "dropdown-element"
            },
            source: countries
        });

        $("#MusicianType").autocomplete({
            classes: {
                "ui-autocomplete": "dropdown-element"
            },
            source: musicianTypes
        });

        $("#City").autocomplete({
            classes: {
                "ui-autocomplete": "dropdown-element"
            },
            source: cities
        });

        //--------------------------
        $("#submit-button").click(function () {
            var userInterests = [];

            var interests = $(".interest-name");

            for (var i = 0; i < interests.length; i++) {
                var currentInterest = interests[i];
                userInterests.push(currentInterest.textContent);
            }
            $("#interestsHidden").val(userInterests);
            console.log(userInterests);
        });

        //------Interests additions 
        $("#Interests").keypress(function (e) {
            var keyCode = e.keyCode || e.which;
            if ((keyCode === 13 || keyCode === 32) && $("#Interests").val().trim().length !== 0) {
                manageIntrests();
            }
            else
                if ($("#Interests").val().trim().length === 0 && keyCode === 32) {
                    $("#Interests").val("".trim());
                }
        });

        function manageIntrests() {

            $("#interests-container").css("display", "block");
            $("#interests-container").prepend("<div class='user-interest'><label class='interest-name'>" +
                $("#Interests").val() +
                "</label><div class='cross-icon'>&#10005</div></div>");

            //------------------interest remove
            $(".cross-icon").click(function () {
                $(this).parent().remove();
                if ($("#interests-container").children().length === 0)
                    $("#interests-container").css("display", "none");
            });
            $("#Interests").val("");
        }

        $('.sign-up-form').on('keyup keypress', function (e) {
            var keyCode = e.keyCode || e.which;
            if (keyCode === 13) {
                e.preventDefault();
                return false;
            }
        });
    });