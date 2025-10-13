/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums = [], target) {
    let index = nums.indexOf(target);
    if (index == -1) {
        if (target > nums[nums.length - 1]) {
            index = nums.length
        } else {
            for (let i = 0; i <= nums.length; i++) {
                if (target > nums[i]) {
                    index = i + 1;
                    continue;
                } else if (target == 0 && nums[i] < 0) {
                    index = i + 1;
                    break;
                } else if (nums.length == 1 && target < nums[i]) {
                    index = i
                    break;
                } else if (nums.length >= 1 && target < nums[i]) {
                    index = i
                    break;
                } else if (target == 0 && nums[i] < 0) {
                    index = i + 1;
                    break;
                } else if (target == 0) {
                    index = 0;
                    break;
                }
            }
        }
    }
    return (index);
};