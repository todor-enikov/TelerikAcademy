function solve(Args){
        var x =+Args[0];
        var y =+Args[1];
        var circle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        var rectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
        if (circle === true && rectangle === true)
        {
            console.log("inside circle inside rectangle");
        }
        else if (circle === true && rectangle === false)
        {
            console.log("inside circle outside rectangle");
        }
        else if (circle === false && rectangle === true)
        {
            console.log("outside circle inside rectangle");
        }
        else
        {
            console.log("outside circle outside rectangle");
        }
}

