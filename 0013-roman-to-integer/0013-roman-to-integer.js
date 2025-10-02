/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function (s) {
    s = s.split('')
    let sum = 0;
    for (let i = 0; i <= s.length; i++) {
        if (s[i] + s[i + 1] == "IV") {
            sum += 4
            s.shift()
            s.shift()
            i -= 2
        }
        if (s[i] + s[i + 1] == "IX") {
            sum += 9
            s.shift()
            s.shift()
            i -= 2
        }
        if (s[i] + s[i + 1] == "XL") {
            sum += 40
            s.shift()
            s.shift()
            i -= 2
        }
        if (s[i] + s[i + 1] == "XC") {
            sum += 90
            s.shift()
            s.shift()
            i -= 2
        }
        if (s[i] + s[i + 1] == "CD") {
            sum += 400
            s.shift()
            s.shift()
            i -= 2
        }
        if (s[i] + s[i + 1] == "CM") {
            sum += 900
            s.shift()
            s.shift()
            i -= 2
        }
        if (s[i] == "I") {
            sum += 1
            s.shift()
            i -= 1
        }

        if (s[i] == "V") {
            sum += 5
            s.shift()
            i -= 1
        }
        if (s[i] == "X") {
            sum += 10
            s.shift()
            i -= 1
        }
        if (s[i] == "L") {
            sum += 50
            s.shift()
            i -= 1
        }
        if (s[i] == "C") {
            sum += 100
            s.shift()
            i -= 1
        }
        if (s[i] == "D") {
            sum += 500
            s.shift()
            i -= 1
        }
        if (s[i] == "M") {
            s.shift()
            sum += 1000
            i -= 1
        }
    }
    return sum;
};