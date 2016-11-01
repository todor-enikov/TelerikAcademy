function solve(Args){

     var len = +Args[0],
     array = Args[1].split(' ').map(Number);
     
    firstLargerNeighbours(len,array);
    
    function firstLargerNeighbours(length, array) {
       var firstNumber = 0,
       i;
       for (i = 1; i < length; i++) {
           
           if (array[i-1] < array[i] && array[i] > array[i+1]) {
               firstNumber = i;
               break;
           }
       }
       console.log(firstNumber);      
       }  
}

 solve(['6','-26 -25 -28 31 2 27']);