function solve(Args){
    
     var len = +Args[0],
     array = Args[1].split(' ').map(Number);
     
    largerNeighbours(len,array);
    
    function largerNeighbours(length, array) {
       var counter = 0,
       i;
       for (i = 1; i < length; i++) {
           
           if (array[i-1] < array[i] && array[i] > array[i+1]) {
               counter+=1;
           }
       }
       console.log(counter);      
       }
    
}

 solve(['6','-26 -25 -28 31 2 27']);