// My Own implementation
// var paragraphs;
//
// $(function () {
//    var headings = $("h2");
//    paragraphs = $("p");
//    paragraphs.not(":first").hide();
//    headings.each(function (index) {
//        $(this).on("click", function () {
//            closeAll();
//            $(paragraphs[index]).show();
//        });
//    });
// });
//
// function closeAll() {
//     $(paragraphs).each(function () {
//         if($(this).css("display") == "block"){
//             $(this).hide();
//         }
//     });
// }

// // Book Implementation
// $(function () {
//     var headings = $("h2");
//     var paragraphs = $("p");
//     paragraphs.not(":first").hide();
//     headings.on("click", function () {
//         var t = $(this);
//         if(t.next().is(":visible")){
//             return;
//         }
//         paragraphs.slideUp("normal");
//         t.next().slideDown("normal");
//     });
// });

// Refactoring
// event delegation
// Custom event
// $(function () {
//     var accordion = $("#accordion");
//     var paragraphs = $("p");
//     paragraphs.not(":first").hide();
//     accordion.on("click", "h2", function () {
//         var t = $(this);
//         var tPara = t.next();
//         if(!tPara.is(":visible")){
//             tPara.trigger("showParagraph");
//         }
//     });
//     accordion.on("showParagraph", "p", function () {
//        paragraphs.slideUp("normal");
//        $(this).slideDown("normal");
//     });
// });

//Refactoring
// remove lag problem
$(function () {
    var accordion = $("#accordion");
    var headings = $("h2");
    var paragraphs = $("p");
    paragraphs.not(":first").hide();
    accordion.on("click", "h2", function () {
        var t = $(this);
        var tPara = t.next();
        if(!tPara.is(":visible")){
            tPara.trigger("showParagraph");
        }
    });

    accordion.on("showParagraph", "p", function () {
       paragraphs.stop(true, true).slideUp("normal", "easeInCirc");
       $(this).stop(true, true).slideDown("normal", "easeInCirc");
    });
});