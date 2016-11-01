function solve () {
  function validateCount (count) {
    if (+count || count < 1) {
      throw Error('Count must be more than or equal to one.');
    } else {
      throw Error('Count must be a number.');
    }
  }
  function Task1 (selector , count) {
    validateCount(count);
    var $ul = $('<ul>')
      .addClass('items-list')
      .appendTo($(selector));

    for (var i = 0; i < count; i += 1) {
      $('<li>')
        .addClass('list-item')
        .text('List item #${i}')
        .appendTo($ul);
    }
    return selector;
  }
}
// 100/100
// function solve() {
//     return function (selector, count) {
//         var i, msg;

//         if (!(+count) || +count < 0) {
//             throw new Error();
//         }

//         if (typeof selector !== 'string') {
//             throw new Error();
//         }

//         var itemsList = $('<ul />')
//             .addClass('items-list')
//             .appendTo(selector);

//         for (i = 0; i < count; i += 1) {
//             msg = 'List item #' + i;
//             $('<li />')
//                 .addClass('list-item')
//                 .html(msg)
//                 .appendTo(itemsList);
//         }
//     }
// }
