function solve(Args){
    var number =+Args[0];
    var arrayOfNumbers =[];
    for (var index = 0; index < number; index+=1) {
        arrayOfNumbers[index]=index*5; 
    }
    for (var i = 0; i < arrayOfNumbers.length; i+=1) {
        console.log(arrayOfNumbers[i]);      
    }
}

 solve(["5"]);