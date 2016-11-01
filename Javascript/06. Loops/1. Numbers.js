function solve(Args){
    var number =+Args[0];
    var outputNumbers="";
    for (var index = 1; index <=number; index++) {
        outputNumbers += index;
        if (index===number) {
            outputNumbers += "";           
        }
        else    {
            outputNumbers += " ";
        }
    }
    console.log(outputNumbers);
}

 solve(["1"]);