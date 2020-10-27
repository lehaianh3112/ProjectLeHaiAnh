<?php 
include('config/data/connect.php');
$user=(isset($_SESSION['user']))? $_SESSION['user']: [];
?>
<nav class="navbar bg-light navbar-light navbar-expand-lg sticky-top">
        <div class="container-fluid">
            <a href="index.php" class="navbar-brand"><img src="assets/images/logo.jpg" alt="logoCSE" title="logoCSE"></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive">
          <span class="navbar-toggler-icon"></span>
    </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link active" href="index.php">Trang trủ <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Giới thiệu</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Diễn đàn</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">
                            Giảng viên</a>
                    </li>
                    <?php if(isset($user['email'])){?>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="dropdownId" data-toggle="dropdown"><?php echo $user['email'] ?> <b class="caret"></b></a>
                        <div class="dropdown-menu" aria-labelledby="dropdownId">
                            <!-- <a class="dropdown-item" href="login.php">Login</a>
                            <a class="dropdown-item" href="register.php">Register</a> -->
                            <a class="dropdown-item" href="logout.php">Logout</a>
                        </div>
                    </li>
<?php }else{ ?>
    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="dropdownId" data-toggle="dropdown">Tài khoản<b class="caret"></b></a>
                        <div class="dropdown-menu" aria-labelledby="dropdownId">
                            <a class="dropdown-item" href="login.php">Login</a>
                            <a class="dropdown-item" href="register.php">Register</a>
                        </div>
                    </li>
<?php } ?>
                </ul>
                <form class="form-inline my-2 my-lg-0">
                    <input class="form-control mr-sm-2" type="text" placeholder="Search">
                    <button class="btn btn-outline-primary my-2 my-sm-0" type="submit">Search</button>
                </form>
            </div>
        </div>
    </nav>