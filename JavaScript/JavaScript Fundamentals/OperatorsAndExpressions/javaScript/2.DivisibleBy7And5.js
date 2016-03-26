/**
 Problem 2. Divisible by 7 and 5
 Write a boolean expression that checks for given integer if it can be divided
 (without remainder) by 7 and 5 in the same time.
 */

function checkDivideNum (number) {
    if (number % 5 === 0 && number % 7 === 0) {
        return 'true';
    }
    else {
        return 'false'
    }
}

console.log('The number 15 is divisible by 7 and 5: ' + checkDivideNum(15));
console.log('The number 30 is divisible by 7 and 5: ' + checkDivideNum(30));
console.log('The number 35 is divisible by 7 and 5: ' + checkDivideNum(35));
console.log('The number 70 is divisible by 7 and 5: ' + checkDivideNum(70));
console.log('The number 89 is divisible by 7 and 5: ' + checkDivideNum(89));