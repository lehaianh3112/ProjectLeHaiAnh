<?php  include('includes/header.php');
include("server.php");

?>
<!doctype html>
<html lang="en">
<head>
    <title>Diễn đàn</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>  
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.7.2/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:300,400,500,600,700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="https://kit.fontawesome.com/81c2c05f29.js">
   
</head>
<body>
<div id="fb-root"></div>
    <script async defer crossorigin="anonymous" src="https://connect.facebook.net/vi_VN/sdk.js#xfbml=1&version=v8.0" nonce="EEfaaYbW"></script>
    <div class="container my-3">
     <div class="row">
         <div class="col-md-8 mx-auto">
       <h2 class="h4 category mb-0 p-4 rounded-top text-light">Hãy đặt câu hỏi
             <button name="add" id="add"  class="btn btn-success " data-toggle="modal" data-target="#add_question" style="float: right;"><i class="fas fa-plus"></i> Add question</button></h2>
                 <table class="table">
                <thead class="bg-primary text-white">
                    <tr>
                    <th scope="col">Title</th>
                    <th scope="col">Question</th>
                    <th scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <?php while ($row=mysqli_fetch_array($results)) { ?>
                         <tr>
                    <td><?php echo $row['title']?></td>
                    <td>
                    <?php echo $row['question']?>&nbsp;<br>
                    <?php 
                    $result=mysqli_query($conn,"SELECT * FROM likes WHERE user_id=1 AND cauhoi_id=".$row['id']."");
                    if (mysqli_num_rows($result)==1) { ?>
                        <span ><a href="" class="unlike" id=" <?php echo $row['id'];?> "><i class="far fa-thumbs-down"></i></a></span>
                 <?php   }else{ ?> 
                    <span ><a href=""class="like"  id=" <?php echo $row['id'];?> "><i class="far fa-thumbs-up"></i></a></span>
                 <?php } ?>                     
                    
                     <div class="voting">
                        <button id="likebtn"><i class="fa fa-thumbs-up"></i></button> 
                        <input  type="number" id="input1" value="0" name="">
                        <button id="dislikebtn"><i class="fa fa-thumbs-down"></i></button> 
                        <input type="number" id="input2" value="0" name="">
                    </div>
                </td>
                    <td>
                    <a   href="edit.php?edit=<?php echo $row['id'];?>" class="text-success"><i class="fas fa-edit"></i></a>&nbsp;
                    <a href="xem.php?xem=<?php echo$row['id'];?>" class="text-dark"><i class="far fa-eye"></i></a>&nbsp;
                    <a  href="forum.php?del=<?php echo$row['id'];?>" class="text-danger mr-2" onclick="return confirm('Bạn có muốn xóa câu hỏi này?');" title="Delete"><i class="fas fa-trash"></i></a>
                       </td>
                    </tr>
                  <?php  } ?>
                   
                </tbody>
                </table>
         </div>
         <br><br><br><br>
       
         <div class="col-12 col-xl-3">
             <aside>
                 <div class="row">
                     <div class="col-12 col-sm-6 col-xl-12">
                     <div class="fb-page" data-href="https://www.facebook.com/cse.tlu.edu.vn" data-tabs="timeline" data-width="250" data-height="134" data-small-header="false" data-adapt-container-width="true" data-hide-cover="false" data-show-facepile="true">
                    <blockquote cite="https://www.facebook.com/cse.tlu.edu.vn" class="fb-xfbml-parse-ignore"><a href="https://www.facebook.com/cse.tlu.edu.vn">Khoa Công nghệ thông tin- Đại học Thủy lợi</a></blockquote>
                </div>
                         <div class="card mb-3 md-sm-0 mb-xl-3">
                             <div class="card-body">
                                 <h2 class="h4 card-title text-danger">Chuyên mục</h2>
                                 <ul class="list-group list-group-flush mb-0">
                            <li class="list-group-item"><a href="forum.php">CSE Forum</a>
                                     <li class="list-group-item"><a href="index.php">Tin tức-Thông báo</a></li>
                                     <li class="list-group-item"><a href="tuvan.php">Tư vấn tuyển sinh</a></li>
                                     <li class="list-group-item"><a href="daotao.php">Đào tạo-Hướng nghiệp</a></li>
                            </ul>
                             </div>           
                             </div>
                             <p><h3 class="bg-dark text-white" style="border-radius: 0.2rem;font-size:large;">Chào mừng đến với CSE.TLU, nơi bạn có thể đặt câu hỏi hoặc trả lời câu hỏi về những thắc mắc của bạn tất cả về khoa CNTT cũng như về trường Đại học Thủy Lợi</h3></p>
                         </div>
                     </div>
                 </div>
             </aside>
         </div>
     </div>
    </div>

    <div id="add_question" class="modal fade">  
      <div class="modal-dialog">  
           <div class="modal-content">  
                <div class="modal-header">  
                <h4 class="modal-title">Hãy điền câu hỏi của bạn</h4>  
                     <button type="button" class="close" data-dismiss="modal">&times;</button>  
                </div>  
                <div class="modal-body"> 
 <form action="server.php" method="post">
                 <div class="form-group">
                     <label for="">Tiêu đề</label>
                     <input type="text " name="title" id="title" name="title" class="form-control" >
                 </div>
                 <div class="form-group">
                     <label for="">Câu hỏi</label>
                     <textarea name="question" id="question" class="form-control"  rows="3" ></textarea>
                 </div>
                 <div class="form-group">
                        <button type="submit" id="btn_post" name="btn_post" class="btn btn-outline-primary">Post</button>
                    </div>
                 </form> 
                 </div>
                 <div class="modal-footer">  
                     <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>  
                </div>  
           </div>  
      </div>  
 </div>  


     <br><br><br><br><?php include('includes/footer.php')?>
    <div class="container my-5"></div>

    <script src="https://code.jquery.com/jquery-3.5.1.min.js"integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0="crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <script src="like.js"></script>
</body>
</html> 