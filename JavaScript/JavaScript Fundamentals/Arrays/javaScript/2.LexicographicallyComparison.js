/**
 Problem 2. Lexicographically comparison
 Write a script that compares two char arrays lexicographically (letter by letter).
 */


function compareLexicographically(n, m) {
    var firstArr = randomStr(n);
    var secondArr = randomStr(m);
    var length = Math.min(firstArr.length, secondArr.length);
    if (firstArr.length > secondArr.length) {
        console.log('The second array is earlier.');
    }
    else if (firstArr.length == secondArr.length) {
        for (var i = 0; i < length; i++) {
            if (firstArr[i] > secondArr[i]) {
                console.log('The second array is earlier.');
                break;
            } else if (firstArr[i] < secondArr[i]) {
                console.log('The first array is earlier.');
                break;
            } else {
                console.log('The both Arrays are equal.');
            }
        }
    } else {
        console.log('The first array is earlier.');
    }

    function randomStr(length) {
        var chars = "abcdefghiklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZ";
        var randomStr = '';
        for (var i = 0; i < length; i++) {
            var rndNum = Math.floor(Math.random() * chars.length);
            randomStr += chars.substring(rndNum, rndNum + 1);
        }
        return randomStr;
    }
}
compareLexicographically(18, 9);
compareLexicographically(29, 30);
compareLexicographically(85, 44);

// or You can check compareLexicographically with random numbers. Example:
// compareLexicographically(17, 29); compareLexicographically(5, 3); etc.

