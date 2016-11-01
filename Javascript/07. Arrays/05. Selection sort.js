function solve(Args){
    var input = (Args + '').split('\n');
    var lenOfArray = +input[0];
    var arrayForSorting=[];
    var index;

    var temp;
    var i,j;
    for (index = 0; index < lenOfArray; index+=1) {
        arrayForSorting[index]=input[index+1];      
    }

   for (i = 0; i < arrayForSorting.length-1; i+=1) {
            for (j = i + 1; j < arrayForSorting.length; j+=1){

                if (+arrayForSorting[j] < +arrayForSorting[i]) {
                    temp = arrayForSorting[i];
                    arrayForSorting[i] = arrayForSorting[j];
                    arrayForSorting[j] = temp;
                }
            }
        }

    console.log(arrayForSorting.join('\n'));
    
}

 solve(['6\n3\n4\n1\n5\n2\n6']);

//  function solve(args) {
//   var input = (args + '').split('\n').map(Number),
//     len, i, j, temp;

//   len = input.length;
//   for (i = 1; i < len; i += 1) {
//     for (j = i + 1; j < len; j += 1) {
//       if (input[j] < input[i]) {
//         temp = input[i];
//         input[i] = input[j];
//         input[j] = temp;
//       }
//     }
//   }

//   console.log();
//   input.splice(0, 1);
//   console.log(input.join('\n'));
// }