/**
 Problem 6. Most frequent number
 Write a script that finds the most frequent number in an array.
 */

function getMostFrequentNum(arr) {
 var maxFrequent = 0,
     element = arr[0];

 for (var i = 0; i < arr.length; i += 1) {
  var currentEl = 0;
  for (var j = 0; j < arr.length; j += 1) {
   if (arr[i] === arr[j]) {
    currentEl += 1;
   }
  }

  if (currentEl > maxFrequent) {
   maxFrequent = currentEl;
   element = arr[i];
  }
 }

 console.log('Most frequent number is: ' + element);
}

getMostFrequentNum([9, 5, 1, 9, 2, 5, 9, 9, 1, 2, 9, 9, 3]);

// or You can check getMostFrequentNum with random numbers.