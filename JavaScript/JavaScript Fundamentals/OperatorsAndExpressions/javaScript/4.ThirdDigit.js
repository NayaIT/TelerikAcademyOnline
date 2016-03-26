/**
 Problem 4. Third digit
 Write an expression that checks for given integer if its third digit
 (right-to-left) is 7.
 */
var msgStr = 'The third digit is 7: ';
var isSeven = 718, notSeven = 1229;

console.log(msgStr + checkThirdDigit(isSeven));
console.log(msgStr + checkThirdDigit(notSeven));

function checkThirdDigit(number){
    return (Math.floor(number / 100) % 10) === 7;
}

//or we can check the result with random numbers

console.log(msgStr + checkThirdDigit(12789));
console.log(msgStr + checkThirdDigit(117));
console.log(msgStr + checkThirdDigit(1718));
console.log(msgStr + checkThirdDigit(3029));
console.log(msgStr + checkThirdDigit(5));