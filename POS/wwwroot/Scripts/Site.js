function getUrlVars() {
    var vars = [], hash;
    var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for (var i = 0; i < hashes.length; i++) {
        hash = hashes[i].split('=');
        vars.push(hash[0]);
        vars[hash[0]] = hash[1];
    }
    return vars;
}

function getStringDate(data) {
    var date = new Date(data);
    var newDate = (date.getMonth() + 1) + "/" + date.getDate() + "/" + date.getFullYear();
    return newDate;
}


function StringDateFormatter(data) {
    var date = new Date(data);
    var newDate = (((date.getMonth() > 8) ? (date.getMonth() + 1) : ('0' + (date.getMonth() + 1))) + '/' + ((date.getDate() > 9) ? date.getDate() : ('0' + date.getDate())) + '/' + date.getFullYear());
    return newDate;
}
function StringDateFormatter2(data) {
    var date = new Date(data);
    var newDate = (((date.getDate() > 9) ? date.getDate() : ('0' + date.getDate())) + '-' + ((date.getMonth() > 8) ? (date.getMonth() + 1) : ('0' + (date.getMonth() + 1))) + '-' + date.getFullYear());
    return newDate;
}
function DateTimeFormatChange(date) {
    var d = new Date(date.split("/").reverse().join("/"));
    var dd = d.getDate();
    var mm = d.getMonth() + 1;
    var yy = d.getFullYear();
    var newDate = dd + "-" + mm + "-" +yy;
    return newDate;
}
function checkValidation(source, destination, message) {
    if ($("#" + source + "").val().length < 1) {
        $("#" + destination + "").text(message);
        return false;
    } else {
        $("#" + destination + "").text("");
        return true;
    }
}
function validateBetweenTwoDate(dateFrom, dateTo) {
    var d1 = dateFrom.split("-");
    var d2 = dateTo.split("-");
    var from = new Date(d1[2], parseInt(d1[1]) - 1, d1[0]);  // -1 because months are from 0 to 11
    var to = new Date(d2[2], parseInt(d2[1]) - 1, d2[0]);
    if (from > to) {
        return false;
    }
    return true;
}
var numbers = {
    '০': 0,
    '১': 1,
    '২': 2,
    '৩': 3,
    '৪': 4,
    '৫': 5,
    '৬': 6,
    '৭': 7,
    '৮': 8,
    '৯': 9
};
var numbers2= {
    0: '০',
    1:'১',
    2:'২',
    3:'৩' ,
    4:'৪',
    5:'৫',
    6:'৬',
    7:'৭',
    8:'৮',
    9:'৯'
};
function replaceToBanglaNumbers(input) {
    var output = [];
    for (var i = 0; i < input.length; ++i) {
        if (numbers2.hasOwnProperty(input[i])) {
            output.push(numbers2[input[i]]);
        } else {
            output.push(input[i]);
        }
    }
    return output.join('');
}
function replaceToEnglishNumbers(input) {
    var output = [];
    for (var i = 0; i < input.length; ++i) {
        if (numbers.hasOwnProperty(input[i])) {
            output.push(numbers[input[i]]);
        } else {
            output.push(input[i]);
        }
    }
    return output.join('');
}

function ToJsonDate(jsonDate) {
    var shortDate = null;
    if (jsonDate) {
        var regex = /-?\d+/;
        var matches = regex.exec(jsonDate);
        var dt = new Date(parseInt(matches[0]));
        var month = dt.getMonth() + 1;
        var monthString = month > 9 ? month : '0' + month;
        var day = dt.getDate();
        var dayString = day > 9 ? day : '0' + day;
        var year = dt.getFullYear();
        //shortDate = year + '-' + monthString + '-' + dayString;
        shortDate = dayString + '-' + monthString + '-' + year;
    }
    return shortDate;
};

function pad(str, max) {
    str = str.toString();
    return str.length < max ? pad("0" + str, max) : str;
}