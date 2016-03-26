/**
 Problem 5. Third bit
 Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
 The bits are counted from right to left, starting from bit #0.
 The result of the expression should be either 1 or 0.
 */

function checkThirdBit(number) {
    var strMsg = 'The third bit of the given number is: ';
    if (number & (1 << 3) != 0) {
        console.log(strMsg + 1);
    }
    else {
        console.log(strMsg + 0);
    }
}

console.log(checkThirdBit(1817));
console.log(checkThirdBit(995));
console.log(checkThirdBit(2229));
console.log(checkThirdBit(30));
console.log(checkThirdBit(9));