/**
 Problem 1. Odd or Even
 Write an expression that checks if given integer is odd or even.
 */

function checkInt (number) {
    if (number % 2 == 0) {
        return 'even.';
    }
    else {
        return 'odd.'
    }
}

console.log('The number 5 is ' + checkInt(5));
console.log('The number 9 is ' + checkInt(9));
console.log('The number 18 is ' + checkInt(18));
console.log('The number 29 is ' + checkInt(29));
console.log('The number 30 is ' + checkInt(30));
