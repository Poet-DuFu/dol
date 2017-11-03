(function () {
    var url = '../html/main.html';
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.open("GET", url, false);
    xmlhttp.send(null);
    var result = xmlhttp.status;
    if (result == 200) {
        document.write(xmlhttp.responseText);
    }
})();