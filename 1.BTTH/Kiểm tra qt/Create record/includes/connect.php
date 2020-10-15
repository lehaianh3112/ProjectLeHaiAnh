<?php
$host = 'localhost';
$user='root';
$pass='';
$db='ktqt';
$port='3306';
$conn=mysqli_connect($host,$user,$pass,$db,$port);
if(!$conn){
    die('Khong the ket noi csdl ..');
}
?>