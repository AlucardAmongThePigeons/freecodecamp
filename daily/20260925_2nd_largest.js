/*
2nd Largest

Given an array, return the second largest distinct number.
Tests:

    Passed: 1. secondLargest([1, 2, 3, 4]) should return 3.
    Passed: 2. secondLargest([20, 139, 94, 67, 31]) should return 94.
    Passed: 3. secondLargest([2, 3, 4, 6, 6]) should return 4.
    Passed: 4. secondLargest([10, -17, 55.5, 44, 91, 0]) should return 55.5.
    Passed: 5. secondLargest([1, 0, -1, 0, 1, 0, -1, 1, 0]) should return 0.
 */

function secondLargest(arr) {
  let first = -Infinity;
  let second = -Infinity;

  arr.forEach((n) => {
    if(n > first) {
      second = first;
      first = n;
    } else if(n > second && n < first) {
      second = n;
    }
  })

  return second == -Infinity ? null : second
}

function secondLargestDuo(arr) {
  const distinct = Array.from(new Set(arr)).toSorted((a, b) => b - a);
  return distinct.length > 1 ? distinct[1] : distinct[0];
}
