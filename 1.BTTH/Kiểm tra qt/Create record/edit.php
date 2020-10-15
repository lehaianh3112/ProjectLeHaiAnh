<?php
include("includes/connect.php");
include("includes/header.php");
include("includes/function.php");
$id=$_GET['id'];
$em=getOneEmployees($id);
$error="";
if(isset($_POST['sbmsave'])){
    $name=$_POST['txtName'];
    $desc=$_POST['ttrDec'];
    $salary=$_POST['txtSalary'];
    $gender=$_POST['rdgender'];
    $birthday=$_POST['birthD'];
}
if(empty($name)){
    $error="don't leave blank";
}
else
{
    updateEmployees($id,$name,$desc,$salary,$gender,$birthday);
    header("location:employees.php");
}
?>
<div class="container">
<h1>Update Record</h1>
<div class="form-group">
              <label for="name">Name</label>
              <input type="text" name="txtName" id="" class="form-control" placeholder="<?php echo $employ['name'] ?>">
            </div>
            <div class="form-group">
                      <label for="ttrDec">Description</label>
                       <textarea class="form-control" name="ttrDec" id="ttrDec" rows="3"  placeholder="<?php echo $employ['description'] ?>"></textarea>
                </div>
                <div class="form-group">
               <label for="txtSalary">Salary</label>
                    <input type="text" class="form-control" placeholder="Enter salary" name="txtSalary" id="txtSalary"  placeholder="<?php echo $employ['salary'] ?>" >
                </div> 
                 <label for="rdgender"> Gender </label> <br>
                <div class="form-group"> 
                        <label class="radio-line"><input type="radio"  name="rdgender" id="rdgender" value="0" checked> Male</label> 
                  <label class="radio-line"><input type="radio" name="rdgender" id="rdgender"value="1" checked> Female</label>
                </div>
                <div class="form-group">
                <label for="birthD"> Birthday </label>
                <input type="date" class="form-control" placeholder="mm/dd/yyyy" name="birthD" id="txtSalary"  placeholder="<?php echo $employ['birthday'] ?>">
                </div>
                <div class="form-group">
                <input class="btn btn-primary" type="submit" name="sbmsave" id="sbmsave" value="Save">
                <input class="btn btn-primary" type="submit" name="sbmcancel" id="sbmcancel"  value="Cancel">
                </div>


</div>