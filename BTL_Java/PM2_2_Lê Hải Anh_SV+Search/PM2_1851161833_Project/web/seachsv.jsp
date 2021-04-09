<%-- 
    Document   : seachsv
    Created on : Jul 22, 2020, 10:18:56 PM
    Author     : DELL
--%>

<%@page import="Search.SinhVien"%>
<%@page import="Search.db_process"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Tìm Kiếm</title>
        <style>
         
            #header
            {
            width: 1500px;
            height:80px;
            background: #00ff00;
           margin : auto;
            }
            #menutrai
               {
            width: 1500px;
            height:80px;
            background:#ccff33;
              margin : auto;
          
            }
      
  
             #left 
            {
             width: 200px;
            height:500px;
            background: coral;
           float: left;
            }
            
             #right 
            {
             width: 200px;
            height:500px;
            background: #ffcccc;
           float: right;
            }
            
            #content
            {
            width: 1300px;
            height:500px;
            background: #ff3366;
            
            }
            #footer{
            width: 16000px;
            height:250px;
            background: #00cccc;
           
            }
            
        </style>
    </head>
    <body>
                    
        
        <div id="header"> <center style="color:royalblue"> <strong><h1>Tìm Kiếm Sinh Viên</h1> </strong> </center> </div>
    
    <div id="left"></div>
    <div id="right"></div>
        <div id="content">
            <center>
        <form name="fromfind" method="POST">
            <table border="0">
                <thead>
                    <tr style="color:#ccffcc">
                        <th>Chọn Lớp</th> 
                                <th><select name="ddl_MaLop">
                                        <option style="color:#666600">PM1</option>
                                        <option style="color:#ff9900">PM2</option>
                                </select></th>
                                <th><input style="color: blue" type="submit" value="Tìm Kiếm" name="bt_tk"/> </th>
                               <th></th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td style="color: darkblue">*****************</td>
                        <td style="color: #ccffcc">*******************</td>
                        <td style="color: #ff9900">*******************</td>
                        
                    </tr>                    
                </tbody>
            </table>
            <table border="1">
                <thead>
                    <tr>
                        <th style="color:greenyellow ">Mã SV</th>
                        <th style="color: darkcyan">Họ Tên</th>
                        <th style="color: #ffff33">Giới Tính</th>
                        <th style="color: indigo">Năm Sinh</th>
                        <th style="color: #ff99ff">Quê Quán</th>
                        <th style="color: #00ff99">Mã Lớp</th>
                    </tr>
                </thead>
                <%   db_process p=new db_process();
                String MaLop=request.getParameter("ddl_MaLop");
                for(SinhVien s:p.dbFindSV(MaLop))
                {
                %>
                <tbody>
                    <tr>
                        <td style="color: #99ff99"><%=s.getMasv()%></td>
                        <td style="color: black"><%=s.getHT()%></td>
                        <td style="color: #ff99ff"><%=s.getGT()%></td>
                        <td style="color: #0099ff"><%=s.getNS()%></td>
                        <td style="color: #660033"><%=s.getQQ()%></td>
                        <td style="color: white"><%=s.getMaLop()%></td>
                    </tr>
                </tbody>
                <%}%>
            </table>
        </form>
            </center>
            
        </div>
            <div id="footer"></div>
    
</body>
</html>
