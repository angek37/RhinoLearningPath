// $(function () {
//    $("body").css("background", "red");
// });

$(function () {
    var box = $("#box");
    // box.fadeOut(3000, function () {
    //     box.fadeIn("slow");
    // });
    var para = $("p");
    var i = 0;

    para.text(i);

    function toggleBox(i) {
        box.fadeToggle(500, function () {
            i = i + 1;
            if(i < 10){
                para.text(i);
                toggleBox(i);
            };
        });
    };

    toggleBox(i);
});