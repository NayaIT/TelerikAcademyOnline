/**
 Problem 5. Appearance count
 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */

function countNumber(arr, number) {
 var answer = 0,
     len = arr.length;
 for (var i = 0; i < len; i += 1) {
  if (arr[i] === number) {
   answer += 1;
  }
 }
 return answer;
}

countNumber([5, 2, 3, 9, 1, 2, 4, 5, 3, 1, 5, 2, 3, 9], 5);

//You can check with random array