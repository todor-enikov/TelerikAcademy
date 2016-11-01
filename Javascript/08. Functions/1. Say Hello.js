function solve(Args){
    var name = Args[0];
    hello(name);

    function hello(name) {
        console.log('Hello, ' + name + '!');
    }
}

 solve(["Stanislav"]);