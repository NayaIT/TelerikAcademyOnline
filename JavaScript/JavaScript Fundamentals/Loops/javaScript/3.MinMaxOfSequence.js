/**
 Problem 3. Min/Max of sequence
 Write a script that finds the max and min number from a sequence of numbers.
 */

var arr = [];

function solveProblem(numbersSet) {
    numbersSet.sort();
    console.log('min = ' + numbersSet[0]);
    console.log('max = ' + numbersSet[numbersSet.length - 1]);
    console.log(new Array(11).join('*'));
}

solveProblem([3, 5, 7, 9, 11]);
solveProblem([17, 18, 22, 24, 29, 30]);
solveProblem([3836, 8823, 8290, 2829]);
