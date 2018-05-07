$(function () {
    $("#interests-edit-container").css("display", "block");

    $(".submit-interests-container").css("display", "none");

    addCloseHandler();

    $("#interests-update-form").on('keyup keypress', function (e) {
        preventFormSubmittOnEnter(e);
    });

    $('.user-data-form').on('keyup keypress', function (e) {
        preventFormSubmittOnEnter(e);
    });

    function preventFormSubmittOnEnter(e) {
        var keyCode = e.keyCode || e.which;
        if (keyCode === 13) {
            e.preventDefault();
            return false;
        }
    }

    $("#interests-edit").keypress(function (e) {
        addInterests(e);
    });

    function addInterests(e) {
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
        $(".submit-interests-container").show();
        addCloseHandler();
        $("#interests-edit").val("");
    }
    function addCloseHandler() {
        $(".cross-icon").click(function () {
            $(this).parent().remove();
            if ($("#interests-edit-container").children().length === 0)
                $("#interests-edit-container").css("display", "none");
            $(".submit-interests-container").show();
        });
    }

    //submitt interests
    $("#submit-interests").click(function () {
        var userInterests = [];

        var interests = $(".interest-name");

        for (var i = 0; i < interests.length; i++) {
            var currentInterest = interests[i];
            userInterests.push(currentInterest.textContent.trim());
        }

        var request = $.post({
            url: 'InterestsUpdate',
            data: { interestsModel: userInterests }
        });
        request.done(function (msg) {
            $(".submit-interests-container").hide();
            $("#interests-callback-message").show();
            $("#interests-callback-message").addClass("alert alert-success");
            $("#interests-callback-message").text(msg);

            $(".alert").click(function () {
                $(this).hide();
            });
        });

        request.fail(function (textStatus) {
            $("#interests-callback-message").addClass("alert alert-danger");
            $("#interests-callback-message").text("Error");

            $(".alert").click(function () {
                $(this).hide();
            });
        });
    });

    $(".enable-editor").click(function (e) {
        $(this).parent().parent().children(".form-control").removeAttr("disabled");
        $(".submit-container").show();
    });

    $("#equipments-block-toogle").click(function () {
        $("#equipments-block").toggle('blind');
    });

    if ($("#interests-edit-container").children().length === 0) {
        $("#interests-edit-container").css("display", "none");
    }
    //-----------------------------------------------------------------------------------

    $("#equipment-submit-0").click(function () {

        var model = $("#equipments-update-form-0 :input").serialize();

        var request = $.post({
            url: 'AddEquipment',
            data: model
        });

        request.done(function (msg) {
            $("#equipments-callback-message-0").show();
            $("#equipments-callback-message-0").addClass("alert alert-success equipments-update-feedback");
            $("#equipments-callback-message-0").text(msg);

            $(".equipments-update-feedback").click(function () {
                $(this).hide();
            });
        });

        request.fail(function (textStatus) {
            $("#equipments-callback-message-0").addClass("alert alert-danger equipments-update-feedback");
            $("#equipments-callback-message-0").text("Error");

            $(".equipments-update-feedback").click(function () {
                $(this).hide();
            });
        });

    });

    //-----------------------------------------------------------------------------------------

    $(".cross-icon-equipments").click(function () {
        var id = $(this).parent().attr("id").split("-")[2];

        var formId = "#equipments-update-form-" + id;
        $(formId).remove();

        var request = $.post({
            url: 'RemoveEquipment',
            data: { equipmentId: id }
        });

        request.done(function (msg) {
            $("#equipments-callback-message-" + id).show();
            $("#equipments-callback-message-" + id).addClass("alert alert-success equipments-update-feedback");
            $("#equipments-callback-message-" + id).text(msg);

            $(".equipments-update-feedback").click(function () {
                $(this).hide();
            });
        });

        request.fail(function (textStatus) {
            $("#equipments-callback-message-" + id).show();
            $("#equipments-callback-message-" + id).addClass("alert alert-danger equipments-update-feedback");
            $("#equipments-callback-message-" + id).text("Error");

            $(".equipments-update-feedback").click(function () {
                $(this).hide();
            });
        });
    });

    //add new equipment
    $("#add-new-equipment-button").click(function () {
        $("#add-new-equipment-container").toggle(500);
    });
});