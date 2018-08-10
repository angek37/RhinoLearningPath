// $.fn.logId = function () {
//   return this.each(function () {
//      console.log(this.id);
//   });
// };

// jQuery.fn.logId = function () {
//     return this.each(function () {
//         console.log(this.id);
//     });
// };

// var definePlugin = function () {
//   var $ = jQuery;
//   $.fn.logId = function () {
//     return this.each(function () {
//         console.log(this.id);
//     });
//   };
// };
//
// definePlugin();

// Refactoring to be IIFE (Inmmediately-Invoked Function Expressions)
(function ($) {
   $.fn.logId = function () {
     return this.each(function () {
        console.log(this.id);
     });
   };
})(jQuery);