function play() {
    document.getElementById('frame').src = "/play";
}

function pause() {
    document.getElementById('frame').src = "/pause";
}

function save() {
    document.getElementById('frame').src = "/save";
}

function shutdown(delay) {
    document.getElementById('frame').src = "/shut-" + delay;
}

function closeapp(delay) {
      document.getElementById('frame').src = "/close-" + delay;
}
