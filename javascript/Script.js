var previous;

$(document).ready(function () {
    previous = $("#title ul li")[0];

    $("#title ul li").hover(function () {
        if (previous !== $(this).attr("data")) {
            $(previous).removeClass("selected");

            $(this).addClass("selected")

            $("#" + $(previous).attr("data")).css("display", "none");

            $("#" + $(this).attr("data")).css("display", "block");

            previous = $(this);
        }
    });
});