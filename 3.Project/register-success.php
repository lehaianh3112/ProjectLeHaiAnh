<?php require_once('config/controller/sigController.php') ;
if (!isset($_SESSION['id'])) {
  header('location:login.php');
  exit();

}
?>
<!doctype html>
<html lang="en">
  <head>
    <title>Title</title>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
  </head>
  <style>
      .form-div{
          margin: 50px auto 50px;
          padding: 25px 15px 10px 15px;
      }
  </style>
  <body>
      <div class="container">
          <div class="row">
              <div class="col-md-4 offset-md-4 form-div login">
                  <?php if(isset($_SESSION['message'])):?>
                  <div class="alert <?php echo $_SESSION['alert-class'];?>">
                    <?php echo $_SESSION['message'];
                    unset($_SESSION['message']);
                    unset($_SESSION['alert-class']);
                    ?>
                  </div>
                  <?php endif ;?>
                  <h3>Welcome,<?php echo $_SESSION['username'];?></h3>

                  <?php if(!$_SESSION['verified']): ?>
                  <div class="alert alert-warning">
                      Bạn cần xác thực mã từ email.
                      Đăng nhập vào email của bạn và ấn vào nút xác nhận chúng tôi sẽ gửi email cho bạn 
                      <strong><?php echo $_SESSION['email'];?></strong>
                      <a href="register-success.php?logout=1"class="logout">logout</a>

                  </div>    
                         <?php endif; ?>
                         <?php  if ($_SESSION['verified']): ?>
                    <button class="btn -btn-block btn-lg btn-primary">Xác nhận</button>
                         <?php  endif; ?>
              </div>
          </div>
      </div>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  </body>
</html>