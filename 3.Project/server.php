<?php
include('config/connect.php');
$title="";
$question="";
$id=0;
$msg="";


if (isset($_POST['btn_post'])) {
    $title=$_POST['title'];
    $question=$_POST['question'];
    $query="INSERT INTO cauhoi(title,question)VALUES('$title','$question')";
    mysqli_query($conn,$query);
    header('location:forum.php');
}
// if (isset($_GET['xem'])) {
//     $id=$_GET['xem'];
//     $rec=mysqli_query($conn,"SELECT*FROM cauhoi WHERE id=$id");
//     $records=mysqli_fetch_assoc($rec);
//     $question=$records['question'];
//     $id=$records['id'];
// }

if (isset($_POST['btn_comment'])) {
    $name=$_POST['name'];
    $comment=$_POST['comment'];
    $date=date("Y-m-d");
    $sql="INSERT INTO binhluan(name,comment,date)VALUES('$name','$comment','$date')";
    if ($conn->query($sql)) {
        $msg="Bình luận thành công";
    }else {
        $msg="Bình luận thất bại";
    }
}
if (isset($_GET['de'])) {
    $id=$_GET['de'];
     $sql=mysqli_query($conn,"DELETE FROM binhluan WHERE id='$id' ");
     header('location:xem.php');
}

if (isset($_POST['liked'])) {
    $cauhoi_id=$_POST['cauhoi_id'];
    $result=mysqli_query($conn,"SELECT*FROM cauhoi WHERE cauhoi_id=$cauhoi_id");
    $row=mysqli_fetch_array($result);
    $a=$row['likes'];
    mysqli_query($conn,"UPDATE cauhoi SET likes=$a+1 WHERE id=$cauhoi_id");
    mysqli_query($conn,"INSERT INTO likes(user_id,cauhoi_id) VALUES(1,$cauhoi_id)");
    exit();
}
if (isset($_POST['unliked'])) {
    $cauhoi_id=$_POST['cauhoi_id'];
    $result=mysqli_query($conn,"SELECT*FROM cauhoi WHERE cauhoi_id=$cauhoi_id");
    $row=mysqli_fetch_array($result);
    $a=$row['likes'];
    mysqli_query($conn,"DELETE FROM likes WHERE id=$cauhoi_id AND user_id=1");
    mysqli_query($conn,"UPDATE cauhoi SET likes=$a-1 WHERE id=$cauhoi_id");
    exit();
}

if (isset($_GET['del'])) {
    $id=$_GET['del'];
     mysqli_query($conn,"DELETE FROM cauhoi WHERE id=$id");
     header('location:forum.php');
}
$results=mysqli_query($conn,"SELECT*FROM cauhoi");

function getOneQ($id){
    global $conn;
    $sql = "SELECT * FROM cauhoi WHERE id='$id' ";
    $result = mysqli_query($conn, $sql);
    $ques = mysqli_fetch_assoc($result);
    return $ques;
}
?>