<?php
$msg = $_GET['w'];
$logfile= 'ping.txt';
$fp = fopen($logfile, "w");
fwrite($fp, $msg);
fclose($fp);
?>
