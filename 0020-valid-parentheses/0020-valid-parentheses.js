/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) {
    let stack = [];
    let pairs = {
        ')' : '(',
        '}' : '{',
        ']' : '['
    };

    for (let ch of s) {
        if (ch in pairs) {
            // لو القوس مقفول
            if (stack.length > 0 && stack[stack.length - 1] === pairs[ch]) {
                stack.pop();
            } else {
                return false;
            }
        } else {
            // لو القوس مفتوح
            stack.push(ch);
        }
    }

    return stack.length === 0;
};
