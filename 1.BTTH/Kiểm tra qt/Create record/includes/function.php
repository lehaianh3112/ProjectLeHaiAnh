<?php
 function getAllEmployees()
 {
     global $conn;
     $sql ="SELECT*FROM employees";
     $result =mysqli_query($conn,$sql);
     $em=mysqli_fetch_all($result);
     return $em;
 }
 function getOneEmployees($id){
    global $conn;
    $sql ="SELECT*FROM employees WHERE id='$id'";
    $result =mysqli_query($conn,$sql);
    $em=mysqli_fetch_assoc($result);
    return $em;
 }
 function deleteEmployees($id){
     global $conn;
     $sql ="DELETE FROM employees WHERE id='$id'";
     if(mysqli_query($conn,$sql))
            return TRUE;
        else
            return FALSE;
 }
 function updateEmployees($id,$name,$desc,$salary,$gender,$birthday){
     global $conn;
     $sql ="UPDATE employees SET name='$name',description='$desc',salary='$salary',gender='$gender',birthday='$birthday' WHERE id ='$id'";
     mysqli_query($conn,$sql);
 }
?>