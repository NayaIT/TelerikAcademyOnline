/**
 Problem 2. Correct brackets
 Write a JavaScript function
 to check if in a given expression the brackets are put correctly.
 */

function checkBrackets(expressions) {
 var bracketOpen = '(',
     bracketClose = ')',
     countOpen = 0,
     countClose = 0,
     isCorrect,
     i;
 for (i = 0; i < expressions.length; i += 1) {
  if (expressions[i] === bracketClose) {
   countClose++;
  }
  else if (expressions[i] === bracketOpen) {
   countOpen++;
  }
 }
 isCorrect = countOpen === countClose;
 return console.log('Is the expression corect? ' + isCorrect);
}
checkBrackets('`)(a+b)(`(');