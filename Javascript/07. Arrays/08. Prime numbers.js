function solve(Args){
    var input = +Args[0];
    var primе;
    for (var i = input; i > 2; i-=1)
        {
            prime = isPrime(i);
            if (prime)
            {
                console.log(i);
                return;
            }
        }
    
function isPrime(value){
        if (value === 0 || value === 1)
        {
            return false;
        }
        else
        {
            for (var a = 2; a <= value / 2; a+=1)
            {
                if (value % a === 0)
                {
                    return false;
                }
            }
            return true;
        }
}
    
}

 solve(['26']);


        