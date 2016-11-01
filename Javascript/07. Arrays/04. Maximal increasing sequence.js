function solve(Args){
    var input = Args[0].split('\n');
    var lenOfArray = +input[0];
    var array=[];
    var firstCounter=1;
    var secondCounter=0;
    var index;

    for (index = 0; index < lenOfArray; index+=1) {
        array[index]=+input[index+1];
        
    }

    for (index = 1; index < array.length; index+=1) {
        if (array[index-1]<array[index]) {
            firstCounter+=1;
            secondCounter = Math.max(firstCounter,secondCounter);
        }
        else{
            firstCounter=1;
        }     
    }

    console.log(secondCounter);
}

 solve(['8\n7\n3\n2\n3\n4\n2\n2\n4']);