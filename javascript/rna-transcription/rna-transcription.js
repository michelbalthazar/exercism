var DnaTranscriber = function() {};

var nucleotidesMapping = {
    C: 'G',
    G: 'C',
    A: 'U',
    T: 'A'
}

DnaTranscriber.prototype.toRna = function(nucleotides) {
    nucleotides = nucleotides.split('');

    var ret = '';
    for (var i = 0; i < nucleotides.length; i++) {
        if (nucleotidesMapping[nucleotides[i]])
            ret += nucleotidesMapping[nucleotides[i]];
        else {
            throw new Error("Invalid input");
        }
    }

    return ret;
}

module.exports = DnaTranscriber;