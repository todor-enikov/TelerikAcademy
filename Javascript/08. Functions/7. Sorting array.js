function solve(args) {
    input = args[0].split('\n'),
       arrayLength = input[0],
       array = input[1].split(' ').map(Number);

    var sortedArray = array.sort(function (a, b) {
        return a - b
    });

    return sortedArray.join(' ');
}
//working in bgcoder
// function solve(args) {
//     console.log(
//         numbers = args[1]
//             .split(' ')
//             .map(Number)
//             .sort(function (a, b) {
//                 return a - b;
//             })
//             .join(' '));
// }

 solve(['6\n-26 -25 -28 31 2 27']);