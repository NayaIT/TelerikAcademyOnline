/**
 Problem 4. Maximal increasing sequence
 Write a script that finds the maximal increasing sequence in an array.
 */

function getMaxIncreasingSequence(arr) {
 var current = 1, max = 0, lastIndex = 0;
 for (var i = 1; i < arr.length; i += 1) {
  if (arr[i - 1] < arr[i]) {
   current++;
  } else {
   if (max < current) {
    max = current;
    current = 1;
    lastIndex = i;
   }
  }
 }

 if (max < current) {
  max = current;
  lastIndex = arr.length;
 }

 var resultsStr = "The maximal increasing sequence is: ";
 for (var j = 0; j < max; j += 1) {
  resultsStr += arr[lastIndex - max + j];
  resultsStr += ' ';
 }

 console.log(resultsStr);
}

getMaxIncreasingSequence([3, 2, 3, 4, 2, 2, 4]);

// or You can check compareLexicographically with random numbers. Example:
// getMaxIncreasingSequence([3, 2, 3, 4, 2, 2, 4]);
// getMaxIncreasingSequence([2, 8, 9, 7, 8, 9, 10]);
// getMaxIncreasingSequence([1, 2, 3, 4, 2, 2, 4]);
// etc.