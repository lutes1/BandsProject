$(function () {


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
    addInterests(e);
});


function addInterests(e) {
    var keyCode = e.keyCode || e.which;
    if ((keyCode === 13) && $("#Interests").val().trim().length !== 0) {
        manageIntrests();
    }
}

function manageIntrests() {
    $("#interests-container").css("display", "block");
    $("#interests-container").prepend("<div class='user-interest'><label class='interest-name'>" +
        $("#Interests").val().trim() +
        "</label><div class='cross-icon'>&#10005</div></div>");

    //------------------interest remove
    $(".cross-icon").click(function () {
        $(this).parent().remove();
        if ($("#interests-container").children().length === 0)
            $("#interests-container").css("display", "none");
    });
    $("#Interests").val("");
}
        });