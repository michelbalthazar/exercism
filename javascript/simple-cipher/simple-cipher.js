'use strict'
var ALPHABET = 'abcdefghijklmnopqrstuvwxyz';

function randomKey() {
    var result;
    for (var i = 0; i < 100; i++) {
        result += ALPHABET[randomUpTo(26)];
    }
    return result;
}

function randomUpTo(n) {
    return Math.floor(Math.random() * n);
}

module.exports = function() {
    var key = randomKey();
    console.log('passei aqi', randomKey());

    return key;
}