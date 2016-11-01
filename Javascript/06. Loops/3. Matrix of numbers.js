function solve(Args){
    var number = +Args[0];
    
    var output = "";
    for (var i = 1; i <= number; i+=1) {
        var counter = i;
        for (var j = 0; j < number; j+=1) {
                if (j===number) {
                    output += counter;
                }
                else{
                    output += counter + " ";
                }
                counter++;
          }
                console.log(output);
                output="";
    }
}

 solve(['4']);