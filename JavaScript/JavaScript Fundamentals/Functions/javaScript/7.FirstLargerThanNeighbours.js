/**
 Problem 7. First larger than neighbours
 Write a function that returns the index of the first element in
 array that is larger than its neighbours or -1, if there’s no such element.
 Use the function from the previous exercise.
 */


function checkNeighbours(arr, index) {
 var i,
     len = arr.length;
 for (i = 1; i < len - 1; i += 1)
 {
  if (index > 0 && index < len - 1 && arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
  {
   return true;
  }
 }
 return false;
}

function firstLargerThanNeighbours(arr) {
 var i,
     len = arr.length;
 for (i = 0; i < len; i += 1)
 {
  if (checkNeighbours(arr, i))
  {
   return i;
  }
 }
 return -1;
}

firstLargerThanNeighbours([1,3,5,7,9,1]);
firstLargerThanNeighbours([1,3,9,7,9,1]);
firstLargerThanNeighbours([1,3,5,11,9,1]);

//You can check with random array
