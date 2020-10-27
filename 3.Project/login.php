<?php include('config/data/connect.php');
 if (isset($_POST['email'])) {
    $email=$_POST['email'];
    $password=$_POST['password'];
    $sql="SELECT *FROM user WHERE email='$email'";
    $query=mysqli_query($conn,$sql);
    $data=mysqli_fetch_assoc($query);
    $checkEmail=mysqli_num_rows($query);
    if ($checkEmail==1) {
        $checkPass=password_verify($password,$data['password']);
        if ($checkPass) {
            //lưu vào session
            $_SESSION['user']=$data;
            header("location:index.php");
        }else {
            echo"Sai mật khẩu";
        }
    }else {
        echo"Email không tồn tại";
    }
}
?>
<!doctype html>
<html lang="en">

<head>
    <title>Login</title>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.7.2/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:300,400,500,600,700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://kit.fontawesome.com/81c2c05f29.js">
    <link rel="stylesheet" href="assets/css/style.css">
    <style>
        * {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

body {
    width: auto;
    height: auto;
    background: rgb(200, 229, 238);
}

.row {
    background: white;
    border-radius: 30px;
    box-shadow: 12px 12px 22px rgb(52, 63, 63);
}

img {
    border-top-left-radius: 30px;
    border-bottom-left-radius: 30px;
}
    </style>
</head>
<body>

    <section class="Form my-4 mx-5">
        <div class="container">
            <div class="row no-gutters  ">
                <div class="col-lg-5">
                    <img src="./assets/images/1.jpg" class="img-fluid" alt="">
                </div>
                <div class="col-lg-7 px-5 pt-5">
                    <a href="index.php" class="py-3"><img src="./assets/images/logo.jpg" style="height: 3rem;" alt=""></a>
                    <form action="" method="POST">
                    <h4>Sign in</h4>
                    <div class="form-row col-lg-7">    
                    <input type="email" name="email"  placeholder="Email Address" class="form-control  my-3 p-3">
                            <div class="error " style="color: red;">
                                <span ><?php echo(isset($err['username']))?$err['username']:'' ?></span>
                            </div>
                    </div>
                    <div class="form-row col-lg-7">
                            <input type="password" name="password" placeholder="Password" class="form-control  my-3 p-3">
                            <div class="error " style="color: red;">
                                <span ><?php echo(isset($err['password']))?$err['password']:'' ?></span>
                            </div>
                    </div>
                    <div class="form-row col-lg-7">
                            <input type="submit" name="login-btn" class="btn btn-primary mt-3 mb-5 " value="Login">
                    </div>
                    <a href="">Forgot password?</a>
                    <p> If you don't have an account? <a href="register.php">Register here</a> <br><a href="index.php">Back home page</a></p>
                    </form>
                </div>
            </div>
        </div>
    </section>





    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="js/scripts.js"></script>
</body>

</html>