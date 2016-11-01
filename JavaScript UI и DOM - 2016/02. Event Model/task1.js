function solve() {
    function task(element) {
        if (typeof element === 'string') {
            element = document.getElementById(element);
            if (!element) {
                throw new Error();
            }
        }
    }
    return task;
}