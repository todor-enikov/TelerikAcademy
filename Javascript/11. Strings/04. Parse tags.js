function solve(params) {

  String.prototype.ToMixCase = function () {
    var input = this;
    var result = '';

    return result;
  };

  var mixCaseTracker = 0;
  var openUp = 'upcase';
  var closeUp = '/upcase';
  var openLow = 'lowcase';
  var closeLow = '/lowcase';
  var openMix = 'orgcase';
  var closeMix = '/orgcase';

  // states
  var isTag = false;
  var curTag = '';
  var isUp = false;
  var isLow = false;
  var isMix = false;
  var toTransform = false;
  var curTransform = '';
  var transform = '';
  var tagStack = [];
  var result = '';

  function ParseTags(text) {
    var parse = String(text);

    var len = parse.length;
    for (var index = 0; index < len; index += 1) {
      var chr = parse[index];

      if (chr === '<') {
        isTag = true;
      }
      else if (chr === '>') {
        isTag = false;
        // check tag
        CheckTag(curTag);
        curTag = '';

        if (!toTransform) {
          Print(transform);
        }
      }
      else if (isTag) {
        curTag += chr;
      }
      else if (toTransform) {
        transform += chr;
      }
      else {
        // Print
        result += chr;
      }
    }

    console.log(result);
  }

  function Print(arg) {
    var text = String(arg);

    if (curTransform === openUp) {
      text = text.toUpperCase();
    }

    else if (curTransform === openLow) {
      text = text.toLowerCase();
    }

    else if (curTransform === openMix) {
      // text = text.ToMixCase();
    }

    result += text;
    transform = '';
    curTransform = '';
  }

  function CheckTag(tag) {
    var curTag = String(tag);

    if (curTag === openUp ||
      curTag === openLow ||
      curTag === openMix) {

      toTransform = true;
      AddToStack(curTag);
    }
    else if (curTag === closeUp ||
      curTag === closeLow ||
      curTag === closeMix) {

      toTransform = false;
      RemovaFromStack();
    }
  }

  function AddToStack(arg) {
    var curTag = String(arg);
    tagStack.push(curTag);
  }

  function RemovaFromStack(arg) {
    var curTag = String(arg);
    curTransform = tagStack.pop();
  }

  ParseTags(params[0] + '');

}


solve([ 'We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.' ]);

// function solve(args) {
//     const upOpen = 'upcase',
//         upClose = '/upcase',
//         lowOpen = 'lowcase',
//         lowClose = '/lowcase',
//         orgOpen = 'orgcase',
//         orgClose = '/orgcase',
//         upScope = 'up',
//         lowScope = 'low',
//         orgScope = 'initial';

//     let isTag = false,
//         scopeStack = [],
//         currentScope = orgScope,
//         strLength = args[0].length,
//         currentTag = '',
//         output = '';

//     for (let i = 0; i < strLength; i += 1) {
//         let c = args[0][i] + '';

//         if (c === '<') {
//             isTag = true;
//         } else if (c === '>') {
//             isTag = false;
//             // Evaluate Tag
//             if (currentTag === upOpen) {
//                 scopeStack.push(currentScope);
//                 currentScope = upScope;
//             } else if (currentTag === lowOpen) {
//                 scopeStack.push(currentScope);
//                 currentScope = lowScope;
//             } else if (currentTag === orgOpen) {
//                 scopeStack.push(currentScope);
//                 currentScope = orgScope;
//             } else if (currentTag === upClose) {
//                 currentScope = scopeStack.pop();
//             } else if (currentTag === lowClose) {
//                 currentScope = scopeStack.pop();
//             } else if (currentTag === orgClose) {
//                 currentScope = scopeStack.pop();
//             } else {
//                 output += currentTag;
//             }
//             currentTag = '';
//         } else if (isTag) {
//             currentTag += c;
//         } else if (!isTag) {
//             if (currentScope === upScope) {
//                 output += c.toUpperCase();
//             } else if (currentScope === lowScope) {
//                 output += c.toLowerCase();
//             } else {
//                 output += c;
//             }
//         }
//     }
//     console.log(output);
// }