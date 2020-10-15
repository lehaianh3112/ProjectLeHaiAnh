<?php
$errors=array();
$host = 'localhost';
$user='root';
$pass='';
$db='ktqt';
$port='3306';
$conn=mysqli_connect($host,$user,$pass,$db,$port);
if(!$conn){
    die('Khong the ket noi csdl ..');
}
if(isset($_POST['sbmsave'])){
     $name=$_POST['txtName'];
     $desc=$_POST['ttrDec'];
     $salary=$_POST['txtSalary'];
     $gender=$_POST['rdgender'];
     $birthday=$_POST['birthD'];

if($name =="")
{
    echo"You forgot to enter your name.";
}
else
{
    $sql="INSERT INTO employees (name,description,salary,gender,birthday) 
    VALUES('$name','$desc','$salary','$gender','$birthday');";
     
    $result = mysqli_query($conn,$sql);
    if($result)
    {
    header("location:employees.php");
}
else   {
    echo "co loi j do";}
}
}
?>