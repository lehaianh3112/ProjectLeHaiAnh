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
$user=(isset($_SESSION['user']))? $_SESSION['user']: [];

?>
<nav class="navbar bg-light navbar-light navbar-expand-lg sticky-top">
        <div class="container-fluid">
            <a href="index.php" class="navbar-brand"><img src="images/logo.jpg" alt="logoCSE" title="logoCSE"></a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive">
          <span class="navbar-toggler-icon"></span>
          </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link active" href="index.php">Trang trủ <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="gioithieu.php">Giới thiệu</a>
                    </li>
                    <?php if(isset($user['email'])){?>
                    <li class="nav-item">
                        <a class="nav-link" href="forum.php">Diễn đàn</a>
                    </li>
                    <?php }else{ ?>
                       
                        <?php } ?>

                    <li class="nav-item">
                        <a class="nav-link" href="giangvien.php">
                            Giảng viên</a>
                    </li>
                    <?php if(isset($user['email'])){?>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="dropdownId" data-toggle="dropdown"><i class="fas fa-user"><?php echo $user['username'] ?></i> <b class="caret"></b></a>
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
      
            </div>
        </div>
    </nav>