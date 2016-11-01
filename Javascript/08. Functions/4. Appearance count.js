function solve(Args){
     var len = +Args[0],
     array =Args[1].split(' '),
     appearanceNumber = +Args[2];
    
    CountingAppearance(len, array,appearanceNumber);

    
    function CountingAppearance(length, array, number) {
       var counter = 0,
       i;
       for (i = 0; i < array.length; i++) {
           
           if (array[i]==number) {
               counter+=1;
           }
       }
       console.log(counter);
       
       }  
}

 solve(['8','28 6 21 6 -7856 73 73 -56','73']);