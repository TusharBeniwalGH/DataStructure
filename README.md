# Data Structure
A repository for different algorithms and concepts used in data structures.
# Arrays #
### Sliding Window Technique ###
 This is a method used to efficiently calculate maximum sum of k consective elements from an array or string.
Here sliding window refers to the first calculate sum of window of size k from the beginning and then move the window by one that is
k +1 and substracting first element from the previous window.At each step of the sliding window we are checking if the current sum is greater than the max_sum
then we update the max_sum and the current sum.
Time Complexity= O(n) where n is the number of elements in the array.
