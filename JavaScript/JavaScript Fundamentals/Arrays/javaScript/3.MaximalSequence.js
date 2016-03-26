/**
 Problem 3. Maximal sequence
 Write a script that finds the maximal sequence of equal elements in an array.
 */

function getMaxEqualElements(arr) {
 var indexOfLongest,
     currentSequence = 1,
     longestSequence = 1;

 for (var i = 0; i < arr.length - 1; i++) {
  if (arr[i] == arr[i + 1]) {
   currentSequence += 1;
  } else {
   if (longestSequence < currentSequence) {
    longestSequence = currentSequence;
    indexOfLongest = i - currentSequence + 1;
   }
   currentSequence = 1;
  }
 }

 var result = arr.slice(indexOfLongest, indexOfLongest + longestSequence);
 console.log('The maximal sequence has ' + longestSequence + ' elements.');
 console.log('It starts at position ' + indexOfLongest + ' and contains the elements [' + result + '].');
}

getMaxEqualElements([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);

// or You can check getMaxEqualElements with random numbers.