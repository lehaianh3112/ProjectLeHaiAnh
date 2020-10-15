<?php
    $eid = $_GET['id'];
    include("includes/connect.php");
    include("includes/function.php");
    if(deleteEmployees($eid)){
        header("Location:employees.php");
        exit();
    }else{
        echo "Loi gi do ...";
    }
    // B3: Dong ket noi
    mysqli_close($conn);
?>
