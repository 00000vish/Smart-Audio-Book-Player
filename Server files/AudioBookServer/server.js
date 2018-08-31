process.env.NODE_ENV = 'production'

var http = require('http');
var connect = require('connect');
var app = connect();
var net = require("net");
var fs = require('fs');
var path = require('path')
var toSend = "null";
var bookmark = 00;
var filePath = path.join(__dirname, '/data.txt');

//server config info
var ip = '127.0.0.1';
var httpPort = 1337;
var tcpPort = 7331;

//TODO
function readBookmark() {
    fs.readFile(filePath, 'utf8', function (err, data) {
        if (err) {
            console.log(err);
        }
        bookmark = data;
        console.log("bookmark read " + data);
    });
}

function writeBookmark() {
    fs.writeFile(filePath, bookmark.toString(), function (err) {
        if (err) {
            return console.log(err);
        }
        console.log("bookmark updated " + bookmark.toString());
    });
}

//talk with clients
var tcp = net.createServer(function (soc) {
    soc.on('data', function (data) {
        if (clientRequest(data.toString('utf8'))) {
            soc.write(new Buffer(bookmark.toString(), "utf8"));
        } else {
            soc.write(new Buffer(toSend, "utf8"));
            toSend = "null";
        }
    })
    soc.on('close', function () {
        console.log("closed");
    })
    soc.on('error', function (ex) {
        console.log("error happened");
    });
}).listen(tcpPort, ip);

//actual website
app.use('/home', home);
app.use('/', other);
readBookmark();
http.createServer(app).listen(httpPort);

function other(req, res) {
    switch (req.url) {
        case "/":
            res.writeHead(302, { 'Location': '/home' });
            res.end();
            break;
        case "/buttons.css":
            res.writeHead(200, { "Content-Type": "text/css" });
            fs.createReadStream("./buttons.css").pipe(res)
            break;
        case "/myscripts.js":
            res.writeHead(200, { "Content-Type": "text/javascript" });
            fs.createReadStream("./myscripts.js").pipe(res)
            break;
        default:
            webCommands(req.url);
    }
}

//decide waht to do 
function clientRequest(data) {
    switch (data.split('-')[0]) {
        case "null":
            return false;
        case "save":
            bookmark = data.split('-')[1];
            writeBookmark();
            return false;
        case "get":
            return true;
    }
}

//just to make sure its a valid command
function webCommands(url) {
    if (url.split('-').length == 1) {
        switch (url) {
            case "/play":
                toSend = "play";
                break;
            case "/pause":
                toSend = "pause";
                break;
            case "/save":
                toSend = "save";
                break;
        }
    } else if (url.split('-').length == 2) {
        if (url.split('-')[0] == '/shut') {
            toSend = "shut-" + url.split('-')[1];
        } else if (url.split('-')[0] == '/close') {
            toSend = "close-" + url.split('-')[1];
        }
    }
}

function home(req, res) {
    res.writeHead(200, { "Content-Type": "text/html" });
    fs.createReadStream("./index.html").pipe(res)
}