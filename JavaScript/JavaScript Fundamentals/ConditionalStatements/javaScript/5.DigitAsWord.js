/**
 Problem 5. Digit as word
 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 */

var digit;

function getDigitAsWord(digit){
    switch(digit){
        case 0: return 'zero';
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default: return 'not a digit';
    }
}

console.log('5 - ' + getDigitAsWord(5));
console.log('9 - ' + getDigitAsWord(9));
console.log('-7 - '+ getDigitAsWord(-7));
console.log('\'Whats up\' is ' + getDigitAsWord('Whats up'));

// or we can do it with for loop and it is for all possible cases

// for(digit = 0; digit <= 9; digit += 1){
//     console.log(digit + ' ' + getDigitAsWord(digit));
// }
// console.log('hi\t' + getDigitAsWord('hi'));

