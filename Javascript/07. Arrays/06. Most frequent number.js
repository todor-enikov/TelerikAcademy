function solve(Args){
    var input = (Args[0]).split('\n');
    var lenOfArray = +input[0], array=[],counter = 0,currentCounter = 0, finalIndex = 0, i, j;
    
    for (i = 0; i < lenOfArray; i+=1) {
        array[i]=+input[i+1];      
    }

   for (i = 0; i < array.length; i+=1) {
            for (j = 0; j < array.length; j+=1){

                if (array[i] === array[j]) {
                    currentCounter+=1;
                }
            }
            if (currentCounter > counter) {
                finalIndex = i;
                counter = currentCounter;
            }
            currentCounter = 0;
        }

    console.log(array[finalIndex] + ' (' + counter + ' times)');
    
}

 solve(['13\n4\n1\n1\n4\n2\n3\n4\n4\n1\n2\n4\n9\n3']);