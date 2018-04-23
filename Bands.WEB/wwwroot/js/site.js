$(document).ready(
function() {
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

    //-------Interests delete
    

    //------Interests additions
    $("#Interests").keypress(
        function (e) 
        {
        if (e.which == 13 && $("#Interests").val() != "") {
                $("#interests-container").css("display","block");
                $("#interests-container").prepend("<div class='user-interest'><label class='interest-name'>" +
                $("#Interests").val() +
                "</label><div class='cross-icon'>&#10005</div></div>");
                
                $(".cross-icon").click(function()
                    {
                        $(this).parent().remove();
                        if($("#interests-container").children().length == 0)
                            $("#interests-container").css("display","none");
                    });
                $("#Interests").val("");
            }
        });

        $('#sign-up-form').on('keyup keypress', function(e) {
            var keyCode = e.keyCode || e.which;
            if (keyCode === 13) { 
              e.preventDefault();
              return false;
            }
          });
});