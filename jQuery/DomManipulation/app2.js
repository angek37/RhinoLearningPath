// $(function () {
//     var i = 0;
//     var newUl = $("<ul />").appendTo("body");
//     while ( i < 10){
//         $("<li />",{
//             "text" : i + 1
//         }).appendTo(newUl);
//         i++;
//     }
// });

// Inserting only once
$(function () {
    var i = 0;
    var newUl = $("<ul />");
    while(i < 10){
        $("<li />", {
            "text" : i + 1
        }).appendTo(newUl);
        i++;
    }
    newUl.appendTo("body");
});