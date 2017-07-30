function play() {
    var rnd = Math.floor(Math.random() * 100);
    var win = window.open("http://example.com/remote.php?w=1 " + rnd, '_blank');
}

function pause() {
    var rnd = Math.floor(Math.random() * 100);
    var win = window.open("http://example.com/remote.php?w=2 " + rnd, '_blank');
}

function bookmark() {
    var rnd = Math.floor(Math.random() * 100);
    var win = window.open("http://example.com/remote.php?w=3 " + rnd, '_blank');
}

function delay() {
    var rnd = Math.floor(Math.random() * 100);
    var win = window.open("http://example.com/remote.php?w=4 " + rnd, '_blank');
}