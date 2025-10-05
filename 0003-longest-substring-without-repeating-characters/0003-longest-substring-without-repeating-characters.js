/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    let maxLen = 0;

    for (let i = 0; i < s.length; i++) {
        let n = []; // نبدأ سلسلة جديدة من هنا
        for (let j = i; j < s.length; j++) {
            if (n.includes(s[j])) {
                // أول ما نلاقي تكرار نوقف
                break;
            }
            n.push(s[j]);
        }
        // نحسب أكبر طول وصلنا له
        maxLen = Math.max(maxLen, n.length);
    }

    console.log(maxLen);
    return maxLen;
};