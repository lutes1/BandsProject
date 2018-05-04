$(function()
{
    $("#interests-edit-container").css("display","block");
    addCloseHandler();
        $('.user-data-form').on('keyup keypress', function (e) {
            var keyCode = e.keyCode || e.which;
            if (keyCode === 13) {
                e.preventDefault();
                return false;
            }
        });
    $("#interests-edit").keypress(function (e){
        addInterests(e);
    });
    function addInterests(e)
    {
         var keyCode = e.keyCode || e.which;
        if ((keyCode === 13) && $("#interests-edit").val().trim().length !== 0) {
        manageIntrests();
        }
    }

    function manageIntrests() {
        $("#interests-edit-container").css("display", "block");
        $("#interests-edit-container").prepend("<div class='user-interest'><label class='interest-name'>" +
            $("#interests-edit").val().trim() +
            "</label><div class='cross-icon'>&#10005</div></div>");
        addCloseHandler();
        $("#interests-edit").val("");
    }
    function addCloseHandler()
    {
        $(".cross-icon").click(function () {
        $(this).parent().remove();
        if ($("#interests-edit-container").children().length === 0)
            $("#interests-edit-container").css("display", "none");
    });
    }
    $("#submit").click(function () {
        var userInterests = [];

        var interests = $(".interest-name");

        for (var i = 0; i < interests.length; i++) {
            var currentInterest = interests[i];
            userInterests.push(currentInterest.textContent);
        }
        $("#interestsEditHidden").val(userInterests);
        console.log(userInterests);
    });

    $(".enable-editor").click(function(e)
    {
        $(this).parent().parent().children(".form-control").removeAttr("disabled");
    });

    $("#equipments-block-toogle").click(function()
    {   
        $("#equipments-block").toggle('blind');
   });
});