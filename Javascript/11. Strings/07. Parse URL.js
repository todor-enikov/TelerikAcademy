function solve(args) {
    var input = args[0];

    var indexStart = input.indexOf(':');

    var result = input.substring(0, indexStart);

    console.log("protocol: " + result);

    var indexStop = input.indexOf('/', indexStart + 3);

    var length = indexStop;

    result = input.substring(indexStart + 3, length);

    console.log("server: " + result);

    result = input.substring(indexStop);

    console.log("resource: " + result);

}

solve([ 'http://telerikacademy.com/Courses/Courses/Details/239' ]);
