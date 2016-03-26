/**
 Problem 7. Is prime
 Write an expression that checks if given positive integer number
 n (n ? 100) is prime.
 */
var msgStr = 'The given number is prime? - ';
function isPrime(number){
    if(number < 2) return false;

    for(var divisor = 2; divisor <= Math.sqrt(number); divisor++){
        if(!(number % divisor)) return false;
    }

    return true;
}

console.log(msgStr + isPrime(35));
console.log(msgStr + isPrime(36));
console.log(msgStr + isPrime(37));