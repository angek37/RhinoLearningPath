$(function () {
   $.ajax({
      "url" : "sample.json",
      "type" : "get",
      "dataType" : "json",
   }).done(function (results) {
       console.log(results);
   });

   // requesting GOT episodes in free API
   var req = $.ajax({
      url : "http://api.tvmaze.com/shows/82/episodes"
   });
   req.done(function (data) {
       console.log(data);
       list(data);
   });


});

var list = function (data) {
    var ul = $("<div />");
    for(var c = 0; c < data.length; c++){
        $("<li />").text(data[c].name).appendTo(ul);
    }
    ul.appendTo($("body"));
    console.log("test");
};