function solve(Args){
    var input = Args[0].split('\n');
    var lenOfArray = input[0];
    var array=[];
    var counter=0;
    var currentCounter=1;
    var index;
    for (index = 0; index < lenOfArray; index+=1) {
        array[index]=input[index+1];
        
    }
    console.log(array.join(" "));
    for (index = 0; index < array.length; index+=1) {
        if (array[index-1]===array[index]) {
            currentCounter+=1;
            counter = Math.max(counter,currentCounter);
        }
        else{
            currentCounter=1;
        }     
    }

    console.log(counter);
}

 solve(['10\n2\n1\n1\n2\n3\n3\n2\n2\n2\n1']);