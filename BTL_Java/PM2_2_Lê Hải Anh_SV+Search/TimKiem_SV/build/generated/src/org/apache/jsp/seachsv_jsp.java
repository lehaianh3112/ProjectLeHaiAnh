package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import Search.SinhVien;
import Search.db_process;

public final class seachsv_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html;charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("    <head>\n");
      out.write("        <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\n");
      out.write("        <title>Tìm Kiếm</title>\n");
      out.write("        <style>\n");
      out.write("         \n");
      out.write("            #header\n");
      out.write("            {\n");
      out.write("            width: 1500px;\n");
      out.write("            height:80px;\n");
      out.write("            background: #00ff00;\n");
      out.write("           margin : auto;\n");
      out.write("            }\n");
      out.write("            #menutrai\n");
      out.write("               {\n");
      out.write("            width: 1500px;\n");
      out.write("            height:80px;\n");
      out.write("            background:#ccff33;\n");
      out.write("              margin : auto;\n");
      out.write("          \n");
      out.write("            }\n");
      out.write("      \n");
      out.write("  \n");
      out.write("             #left \n");
      out.write("            {\n");
      out.write("             width: 200px;\n");
      out.write("            height:500px;\n");
      out.write("            background: coral;\n");
      out.write("           float: left;\n");
      out.write("            }\n");
      out.write("            \n");
      out.write("             #right \n");
      out.write("            {\n");
      out.write("             width: 200px;\n");
      out.write("            height:500px;\n");
      out.write("            background: #ffcccc;\n");
      out.write("           float: right;\n");
      out.write("            }\n");
      out.write("            \n");
      out.write("            #content\n");
      out.write("            {\n");
      out.write("            width: 1300px;\n");
      out.write("            height:500px;\n");
      out.write("            background: #ff3366;\n");
      out.write("            \n");
      out.write("            }\n");
      out.write("            #footer{\n");
      out.write("            width: 16000px;\n");
      out.write("            height:250px;\n");
      out.write("            background: #00cccc;\n");
      out.write("           \n");
      out.write("            }\n");
      out.write("            \n");
      out.write("        </style>\n");
      out.write("    </head>\n");
      out.write("    <body>\n");
      out.write("                    \n");
      out.write("        \n");
      out.write("        <div id=\"header\"> <center style=\"color:royalblue\"> <strong><h1>Tìm Kiếm Sinh Viên</h1> </strong> </center> </div>\n");
      out.write("    \n");
      out.write("    <div id=\"left\"></div>\n");
      out.write("    <div id=\"right\"></div>\n");
      out.write("        <div id=\"content\">\n");
      out.write("            <center>\n");
      out.write("        <form name=\"fromfind\" method=\"POST\">\n");
      out.write("            <table border=\"0\">\n");
      out.write("                <thead>\n");
      out.write("                    <tr style=\"color:#ccffcc\">\n");
      out.write("                        <th>Chọn Lớp</th> \n");
      out.write("                                <th><select name=\"ddl_MaLop\">\n");
      out.write("                                        <option style=\"color:#666600\">PM1</option>\n");
      out.write("                                        <option style=\"color:#ff9900\">PM2</option>\n");
      out.write("                                </select></th>\n");
      out.write("                                <th><input style=\"color: blue\" type=\"submit\" value=\"Tìm Kiếm\" name=\"bt_tk\"/> </th>\n");
      out.write("                               <th></th>\n");
      out.write("                    </tr>\n");
      out.write("                </thead>\n");
      out.write("                <tbody>\n");
      out.write("                    <tr>\n");
      out.write("                        <td style=\"color: darkblue\">*****************</td>\n");
      out.write("                        <td style=\"color: #ccffcc\">*******************</td>\n");
      out.write("                        <td style=\"color: #ff9900\">*******************</td>\n");
      out.write("                        \n");
      out.write("                    </tr>                    \n");
      out.write("                </tbody>\n");
      out.write("            </table>\n");
      out.write("            <table border=\"1\">\n");
      out.write("                <thead>\n");
      out.write("                    <tr>\n");
      out.write("                        <th style=\"color:greenyellow \">Mã SV</th>\n");
      out.write("                        <th style=\"color: darkcyan\">Họ Tên</th>\n");
      out.write("                        <th style=\"color: #ffff33\">Giới Tính</th>\n");
      out.write("                        <th style=\"color: indigo\">Năm Sinh</th>\n");
      out.write("                        <th style=\"color: #ff99ff\">Quê Quán</th>\n");
      out.write("                        <th style=\"color: #00ff99\">Mã Lớp</th>\n");
      out.write("                    </tr>\n");
      out.write("                </thead>\n");
      out.write("                ");
   db_process p=new db_process();
                String MaLop=request.getParameter("ddl_MaLop");
                for(SinhVien s:p.dbFindSV(MaLop))
                {
                
      out.write("\n");
      out.write("                <tbody>\n");
      out.write("                    <tr>\n");
      out.write("                        <td style=\"color: #99ff99\">");
      out.print(s.getMasv());
      out.write("</td>\n");
      out.write("                        <td style=\"color: black\">");
      out.print(s.getHT());
      out.write("</td>\n");
      out.write("                        <td style=\"color: #ff99ff\">");
      out.print(s.getGT());
      out.write("</td>\n");
      out.write("                        <td style=\"color: #0099ff\">");
      out.print(s.getNS());
      out.write("</td>\n");
      out.write("                        <td style=\"color: #660033\">");
      out.print(s.getQQ());
      out.write("</td>\n");
      out.write("                        <td style=\"color: white\">");
      out.print(s.getMaLop());
      out.write("</td>\n");
      out.write("                    </tr>\n");
      out.write("                </tbody>\n");
      out.write("                ");
}
      out.write("\n");
      out.write("            </table>\n");
      out.write("        </form>\n");
      out.write("            </center>\n");
      out.write("            \n");
      out.write("        </div>\n");
      out.write("            <div id=\"footer\"></div>\n");
      out.write("    \n");
      out.write("</body>\n");
      out.write("</html>\n");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
