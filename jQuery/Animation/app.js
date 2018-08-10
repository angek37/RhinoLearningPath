// $(function () {
//    $("div")
//        .animate({"height" : 300})
//        .fadeOut()
//        .show(500)
//        .animate({"width" : 100})
//        .css("background", "red");
// });

$(function () {
   $("h5").on("click", function () {
       $("div").stop(true, true).fadeToggle(500);
   });
});