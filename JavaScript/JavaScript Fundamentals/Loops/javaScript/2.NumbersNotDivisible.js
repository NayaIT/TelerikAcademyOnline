/**
 Problem 2. Numbers not divisible
 Write a script that prints all the numbers from 1 to N,
 that are not divisible by 3 and 7 at the same time
 */

var number,
    n = 100;

for (number = 1; number <= n; number += 1){
    if ((number % 3 === 0)&&(number % 7 === 0)){
        console.log(number + ' ');
        number += 1;
    }
}

// You can check with random numbers for n. Example: n = 21; n = 70; n = 200;
