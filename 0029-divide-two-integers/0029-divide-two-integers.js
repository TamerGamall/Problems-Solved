/**
 * @param {number} dividend
 * @param {number} divisor
 * @return {number}
 */
var divide = function (dividend, divisor) {
    let sum = parseInt(dividend / divisor)
    if (sum >= 2147483648) {
        sum = 2147483647
    }
    return sum
};