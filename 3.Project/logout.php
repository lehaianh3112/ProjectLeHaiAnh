<?php
$host ='localhost';
$user='root';
$pass='';
$db_name='project';
$port='3306';

$conn=new mysqli($host,$user,$pass,$db_name,$port);
if(!$conn)
{
    die('CSDL khong ket noi : ');
}
 session_start();
unset($_SESSION['user']);
// session_destroy();
header('location:index.php');
?>