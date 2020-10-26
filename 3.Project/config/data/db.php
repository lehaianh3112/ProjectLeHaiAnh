<?php
require('connect.php');

function getAllUsers(){
    global $conn;
    $sql = "SELECT * FROM users";
    $result = mysqli_query($conn,$sql);
    $users = mysqli_fetch_all($result);
    return $users;
}

function getOneUser($id){
    global $conn;
    $sql = "SELECT * FROM users WHERE userid = '$id'";
    $result = mysqli_query($conn,$sql);
    $user = mysqli_fetch_assoc($result);
    return $user;
}
function update()
{
    
}
function create()
{

}

function deleteUser($id){
    global $conn;
    $sql = "DELETE FROM users WHERE userid = '$id'";
    if(mysqli_query($conn,$sql))
        return TRUE;
    else
        return FALSE;
}
?>