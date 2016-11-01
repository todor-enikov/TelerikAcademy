var a =['1','2','5','3','3'];
a.print();

Array.prototype.print = function() {
    for (var index = 0; index < array.length; index++) {
        var element = array[index];
        console.log(element);
    }
};