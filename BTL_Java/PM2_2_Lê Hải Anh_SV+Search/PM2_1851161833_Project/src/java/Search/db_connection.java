/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Search;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import sun.awt.AWTAccessor;

/**
 *
 * @author DELL
 */
public class db_connection {
    
   Connection cn ;
        public static Connection getcon() throws ClassNotFoundException, SQLException
        {
            Connection cn = null;
            try {
                Class.forName("com.mysql.jdbc.Driver");
            cn =  DriverManager.getConnection("jdbc:mysql://localhost/tk_sv" , "root" , "");
            } catch (ClassNotFoundException | SQLException e) {
            }
            return cn;
        }
        public static void main(String[] args) throws ClassNotFoundException, SQLException {
            System.out.println(getcon());
    }
}
