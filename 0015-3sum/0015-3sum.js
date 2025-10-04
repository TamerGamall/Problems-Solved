/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var threeSum = function (nums) {
    let arr = [];
    nums.sort((a, b) => a - b);
    for (let i = 0; i < nums.length; i++) {
        let left = i + 1;
        let right = nums.length - 1
        if (i == left && i == right && left == right) continue;
        if (i > 0 && nums[i] === nums[i - 1]) continue;
        while (left < right) {
            let sum = nums[i] + nums[left] + nums[right];
            if (sum == 0) {
                arr.push([nums[i], nums[left], nums[right]]);
                while (nums[left] === nums[left + 1]) left++;
                while (nums[right] === nums[right - 1]) right--;
                left++;
                right--;
            } else if (sum > 0) {
                right -= 1
            } else {
                left += 1
            }
        }
    }
    return arr;

};