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

$(function () {
    var headings = $("h2");
    var paragraphs = $("p");
    paragraphs.not(":first").hide();
    headings.on("click", function () {
        var t = $(this);
        if(t.next().is(":visible")){
            return;
        }
        paragraphs.slideUp("normal");
        t.next().slideDown("normal");
    });
});