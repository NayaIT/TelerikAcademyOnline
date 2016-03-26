/**
 Problem 1. English digit
 Write a function that returns the last digit of given integer as an English word.
 */

function lastDigitAsWord (number){
    switch (number % 10){
        case 0: console.log('zero'); break;
        case 1: console.log('one'); break;
        case 2: console.log('two'); break;
        case 3: console.log('three'); break;
        case 4: console.log('four'); break;
        case 5: console.log('five'); break;
        case 6: console.log('six'); break;
        case 7: console.log('seven'); break;
        case 8: console.log('eight'); break;
        case 9: console.log('nine'); break;

        default: return 'Error! Invalid input!';
    }
}

lastDigitAsWord(0);
lastDigitAsWord(18);
lastDigitAsWord(1895);
lastDigitAsWord(17189);
lastDigitAsWord('What\'s up');

//You can check with random number

//or second way

function secondWayDigitAsWord(number){
    var digit = number % 10;
    switch (digit){
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

        default: return 'Error! Invalid input!';
    }
}

secondWayDigitAsWord(512);
secondWayDigitAsWord(1024);
secondWayDigitAsWord(12309);

//You can check with random number