"use strict";
// var model = {
//     user : "Adam",
//     items: [{action: "Buy Flowers", done: false},
//         {action: "Get Shoes", done: false},
//         {action: "Collect Tickets", done: true},
//         {action: "Call Joe", done: false}]
// };
var Model = (function () {
    function Model() {
        this.user = "Miguel";
        this.items = [new TodoItem("Buy Flowers", false),
            new TodoItem("Get Shoes", false),
            new TodoItem("Collect Tickers", false),
            new TodoItem("Call Joe", false)];
    }
    return Model;
}());
exports.Model = Model;
var TodoItem = (function () {
    function TodoItem(action, done) {
        this.action = action;
        this.done = done;
    }
    return TodoItem;
}());
exports.TodoItem = TodoItem;
