<?php
include("includes/header.php");
?>
<main>
<main class="container">
            <div class="header">
            <div class="container">
            <div class="row"> 
            <h1>Employees list</h1> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="create.php" class="btn btn-primary"><i class="fas fa-plus"></i>Add New Employees</a>
            </div>
            </div>
            </div>
    
            </div>
                <table class="table table-striped">
                    <thead class="thead-dark">
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th>Description</th>
                            <th>Salary</th>
                            <th>Gender</th>
                            <th>Birthday</th>
                            <th>Created_at</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                    <?php
                        require('includes/connect.php');
                        include("includes/function.php");
                        // B2: Khai bao truy van
                      $employees =getAllEmployees();
                        foreach($employees as $em){
                    ?>
                            <tr>
                                <td><?php echo $em[0];?></td>
                                <td><?php echo $em[1];?></td>
                                <td><?php echo $em[2];?></td>
                                <td><?php echo $em[3];?></td>
                                <td><?php  echo $em[4];?></td>
                                <td><?php echo $em[5];?></td>
                                <td><?php echo $em[6];?></td>
                                <td>
                                <a href="delete.php?id=<?php echo $em[0];?>"><i class="fas fa-trash-alt"></i></a>
                                <a href="edit.php?id=<?php echo $em[0];?>"> <i class="fas fa-edit"></i></a>
                                 <a href="view.php?id=<?php echo $em[0];?>"> <i class="far fa-eye"></i></a>
                            </td>
                            </tr>
                    <?php
                        }
                    ?>
                    </tbody>
                </table>
        
</main>