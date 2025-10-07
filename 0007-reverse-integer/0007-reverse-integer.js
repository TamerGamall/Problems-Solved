/**
 * @param {number} x
 * @return {number}
 */
var reverse = function (x) {
    let a = x.toString()
    let arr = [];
    let char = [];
    for (let i = 0; i < a.length; i++) {
        arr.push(a[i])
    }
    // console.log(arr.lastIndexOf());

    if (arr[0] == "-") {
        char = arr.splice(0, 1)
    }

    arr.reverse()

    if (arr.length - 1 == 0 && arr.length > 1) {
        arr.shift()
    }
    arr.unshift(...char)
    let final = parseInt(arr.join(""))
    if (final > 2147483647 || final < -2147483648) {
        final = 0
    }
    return (final);
};