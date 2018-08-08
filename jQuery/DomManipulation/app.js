// $(function () {
//    $("#box").slideUp(2000);
// });
$(function () {
   var i = 0;
   while (i < 10){
       $("#box").slideToggle(2000);
       i++;
   };
   var p = $("p").remove();
   console.log(p);
});