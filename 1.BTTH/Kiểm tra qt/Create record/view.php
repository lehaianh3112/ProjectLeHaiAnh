<?php 
include("includes/header.php");
    include ("includes/connect.php");
    include ("includes/function.php");

    $id = $_GET['id'];
    $em = getOneEmployees($id);
?>
<div class="container">
        <h1 >View Record</h1>
        <div class="form-group ">
            <label for="" class="">ID</label>
            <input type="text" name="" id="" class="form-control" placeholder="<?php echo $em['id'] ?>" disabled>
        </div>
        <div class="form-group ">
            <label for="" class="col-form">Name</label>
            <input type="text" name="txtName" id="" class="form-control " placeholder="<?php echo $em['name'] ?>"  disabled>
        </div>
        <div class="form-group">
            <label for="" class="col-form">Description</label>
            <input type="text" name="ttrDec" id="" class="form-control " placeholder="<?php echo $em['description'] ?>"  disabled>
        </div>
        <div class="form-group">
          <label for="" class="col-form">Salary</label>
          <input type="text" name="txtSalary" id="" class="form-control" placeholder="<?php echo $em['salary'] ?>"  disabled>
        </div>

        <div class="form-group ">
          <label for="" class="col-form-lab">Gender</label>
          <input type="text" name="" id="" class="form-control " placeholder="Male"  disabled>
        </div>
    
        <div class="form-group ">
          <label for="" class="col-form-label ">Gender</label>
          <input type="text" name="" id="" class="form-control " placeholder="Female"  disabled>
        </div>
        
        <div class="form-group">
          <label for="" class="col-form-label">Birthday</label>
          <input type="text" name="" id="" class="form-control" placeholder="<?php echo $em['birthday'] ?>"  disabled>
        </div>
        <div class="form-group row">
          <label for="" class="col-form-label">Created at</label>
          <input type="text" name="" id="" class="form-control" placeholder="<?php echo $em['created_at'] ?>"  disabled>
        </div>
        <a name="" id="" class="btn btn-primary" href="employees.php" role="button">Back</a>
    </div>