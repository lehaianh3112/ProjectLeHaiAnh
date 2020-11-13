<?php 
include_once("includes/header.php");
include("server.php");
?>
<!doctype html>
<html lang="en">
<head>
    <title>Bình luận câu hỏi diễn đàn</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>  
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.7.2/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:300,400,500,600,700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="https://kit.fontawesome.com/81c2c05f29.js">
</head>
<body> <br><br><br>
    <div class="container">
     <div class="row">
     <div class="col-md-8 mx-auto">
     <h2 class="h4 category mb-0 p-4 rounded-top text-light">Bình luận bài viết
         
     <button name="add" id="add"  class="btn btn-success " data-toggle="modal" data-target="#add_comment" style="float: right;"><i class="fas fa-plus"></i> Add comment</button>
     </h2><br>
              
                 <div class="form-group">
                 <?php 
                 if (isset($_GET['xem'])) {
                    $id=$_GET['xem'];
                    $rec=mysqli_query($conn,"SELECT*FROM cauhoi WHERE id=$id");
                        $records=mysqli_fetch_assoc($rec);
                        $question=$records['question'];
                 ?>
                    <h3 name="question" id="question" ><p><?= $records['question'];?></p></h3>
                    <?php }?>
                 </div>


                 <div id="add_comment" class="modal fade">  
      <div class="modal-dialog">  
           <div class="modal-content">  
                <div class="modal-header">  
                <h4 class="modal-title">Bình luận bài viết</h4>  
                     <button type="button" class="close" data-dismiss="modal">&times;</button>  
                </div>  
                <div class="modal-body"> 
                <form action="xem.php?xem=<?php echo $id; ?>" method="post" id="form">
                 <div class="form-group">
                     <label for="">Tên của bạn</label>
                     <input type="text " name="name" id="name"  placeholder="Enter username" class="form-control" >
                 </div>
                 <div class="form-group">
                     <label for="">Bình luận</label>
                     <textarea name="comment" id="comment" placeholder="Enter comment" class="form-control"  rows="3"></textarea>
                 </div>
                 <div class="form-group">
                     <button type="submit" id="btn_comment" name="btn_comment" class="btn btn-outline-primary" >Comment</button>
                        
                    </div>
                    </form>
                 </div>
                 <div class="modal-footer">  
                     <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>  
                </div>  
           </div>  
      </div>  
 </div>  
            
           
            </div>
           
                </div>  
               
                 
         </div>
         
         <div class="row justify-content-center">
             <div class="col-lg-5 rounded bg-danger p-3">
             <h5 class=" text-white p-3 "><?= $msg;?></h5>
                 <?php 
                 $sql="SELECT * FROM binhluan ORDER BY id DESC";
                 $results=$conn->query($sql);
                 while($row=$results->fetch_assoc()){
                 ?>
                 <div class="card mb-2 border-secondary">
                     <div class="card-header bg-primary py-1 text-light">
                         <span class="font-italic">Được đăng bởi:<?= $row['name']?></span>
                         <span class="float-right font-italic">Thời gian:<?= $row['date']?> </span>
                     </div>
                     <div class="card-body py-2">
                         <p class="card-text"><?= $row['comment']?></p>
                     </div>
                     <div class="card-footer py-2">
                         <div class="float-right">
                             <a href="server.php?de=<?= $row['id']?>" class="text-danger mr-2" onclick="return confirm('Bạn có muốn xóa bình luận này?');" title="Delete"><i class="fas fa-trash"></i></a>

                         </div>
                     </div>
                 </div>
                 <?php }?>

             </div>
         </div>

     </div>
     
    


     <br><br><br><br><br><?php include('includes/footer.php')?>
    <div class="container my-5"></div>

    <script src="https://code.jquery.com/jquery-3.5.1.min.js"integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0="crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
     <!-- <script src="js/comment.js"></script> -->

   
</body>
</html> 
