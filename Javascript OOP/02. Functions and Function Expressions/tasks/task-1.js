/* Task Description */
/*
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number

*/

function sum(arr) {

    let len = arr.length;
    if (len === 0) {
        return null;
    }
    let sum = 0;
    for (let i = 0; i < len; i += 1) {
        if (typeof arr[i] === 'undefined') {
            throw new Error('The element is undefined');
        }
        let arAsNumber = parseInt(arr[i]);
        if (!isNaN(arAsNumber)) {
            sum += arr[i];
        } else {
            throw new Error('The element must be a number');
        }
    }
    console.log(sum);
}

//sum([1, 2, 3, 4]);
module.exports = sum;
//100/100
// function solve() {

// 	function sum(array) {
// 		var sum;

// 		if (!Array.isArray(array)) {
// 			throw new Error();
// 		}

// 		if (array.length === 0) {
// 			return null;
// 		}

// 		sum = 0;
// 		array.forEach(function (element) {
// 			if (+element) {
// 				sum += +element;
// 			} else {
// 				throw new Error();
// 			}
// 		});

// 		return sum;
// 	}

// 	module.exports = sum;
// }