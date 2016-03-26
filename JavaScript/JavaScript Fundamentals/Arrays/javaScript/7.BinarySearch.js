/**
 Problem 7. Binary search
 Write a script that finds the index of given element in a
 sorted array of integers by using the binary search algorithm.
 */

function getIndexOfElement(arr, element) {
 var min = 0,
     max = arr.length - 1,
     result = -1;

 while (min <= max) {
  var mid = min + (max - min) / 2;
  mid = Math.floor(mid);

  if (arr[mid] > element) {
   max = mid - 1;
  } else if (arr[mid] < element) {
   min = mid + 1;
  } else {
   result = mid;
   break;
  }
 }

 console.log('The index of element ' + element + ' is: ' + result);
}

getIndexOfElement([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 5);

// or You can check getIndexOfElement with random numbers.