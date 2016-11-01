function solve(){
    function task(element, content){
            if (typeof element === 'string') {
                element = document.getElementById(element);
                    if (element === null) {
                throw Error();
                }
            }
            else if (el instanceof HTMLElement) {
            // nothing
            }
            else{
                throw Error();
            } 
            if (!Array.isArray(content)) {
            throw new Error();
            }

            var docFrag = document.createDocumentFragment();

            for (var i = 0; i < content.length; i+=1) {
                    if (typeof content[i] !== 'string' && typeof content[i] !== 'number') {
                    throw new Error();
                    }
                var divEl = document.createElement('div');
                divEl.innerHTML = content[i];
                docFrag.appendChild(divEl);
            }
            element.appendChild(docFrag);
    }
    return task;
}
//100/100
// function solve(){
//     function task(element, content){
//             if (typeof element === 'string') {
//                 element = document.getElementById(element);
//                     if (element === null) {
//                 throw Error();
//                 }
//             }
//             else if (el instanceof HTMLElement) {
//             // nothing
//             }
//             else{
//                 throw Error();
//             } 
//             if (!Array.isArray(content)) {
//             throw new Error();
//             }
//             var addDiv='';
//             for (var i = 0; i < content.length; i+=1) {
//                     if (typeof content[i] !== 'string' && typeof content[i] !== 'number') {
//                     throw new Error();
//                     }
//             addDiv += '<div>' + content[i] + '</div>';
//             }
//             element.innerHTML = addDiv;
//     }
//     return task;
// }