/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function (nums1 = [], nums2 = []) {
    let nums = [];
    let median = 0;
    nums = nums1.concat(nums2);
    nums.sort((a, b) => a - b);
    if (nums.length % 2 == 0) {
        let index = nums.length / 2
        median = (nums[index - 1] + nums[index]) / 2
        return median;
    } else {
        let index = Math.floor(nums.length / 2)
        median = nums[index]
        return (median);
    }
};