<?php
$msg = $_GET['w'];
$logfile= 'data.txt';
$fp = fopen($logfile, "w");
fwrite($fp, $msg);
fclose($fp);
?>
