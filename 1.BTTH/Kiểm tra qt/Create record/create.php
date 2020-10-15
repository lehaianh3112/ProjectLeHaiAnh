<?php
include("includes/header.php");
require("includes/connect.php");
require("insert.php")
?>
<main class="container">
    <div class="row">
        <div class="col-md-12">
            <form action="" method="POST">
                <div class="form-group">
                   <br> <label class="control-label" for="txtName">Name <span style="color: red;">*</span></label>
                    <input type="text" class="form-control" placeholder="Enter name" name="txtName" id="txtName">
                   
                </div>
                <div class="form-group">
                      <label for="ttrDec">Description</label>
                       <textarea class="form-control" name="ttrDec" id="ttrDec" rows="3"></textarea>
                </div>
                <div class="form-group">
               <label for="txtSalary">Salary</label>
                    <input type="text" class="form-control" placeholder="Enter salary" name="txtSalary" id="txtSalary">
                </div> 
                 <label for="rdgender"> Gender </label> <br>
                <div class="form-group"> 
                        <label class="radio-line"><input type="radio"  name="rdgender" id="rdgender" value="0" checked> Male</label> 
                  <label class="radio-line"><input type="radio" name="rdgender" id="rdgender"value="1" checked> Female</label>
                </div>
                <div class="form-group">
                <label for="birthD"> Birthday </label>
                <input type="date" class="form-control" placeholder="mm/dd/yyyy" name="birthD" id="txtSalary">
                </div>
                <div class="form-group">
                <input class="btn btn-primary" type="submit" name="sbmsave" id="sbmsave" value="Save">
                <input class="btn btn-light" type="submit" name="sbmcancel" id="sbmcancel"  value="Cancel">
                </div>
            </form>
        </div>

    </div>
</main>