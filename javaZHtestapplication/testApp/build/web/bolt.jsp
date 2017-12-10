<%-- 
    Document   : bolt
    Created on : Dec 10, 2017, 1:59:18 PM
    Author     : hory0
--%>


<%@page import="java.util.ArrayList"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>

    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Bolt</title>
        <%@ page import="myServlet.*"%>
        <%@ page import="mymodel.*"%>
    </head>
    
    <body>

        <h1> Bontó autó alkatrészek </h1>
        <table>
            <tr><th>lorem ipsum</th></tr>
            <tr>
                <td>
                 <p><%out.println((String)session.getAttribute("username"));%></p>
                </td>
                <td>
                    <a href="${pageContext.request.contextPath}/LogoutS">Kijelentkezés</a>
                </td>
            </tr>
            <% 
             Bolt temp = (Bolt)session.getAttribute("bolt");
             ArrayList<Vasarlo> alv = temp.getVevok();
             int size = alv.size();
             for(int i=0; i<size;i+=1) { 
            %>
            <tr>  
                <td><%=alv.get(i).getUname()%></td>
            </tr>
            <% } %>
        </table>
        
        <table>
            <tr><th>Kosár</th></tr>
            <%
            Vasarlo tempV = (Vasarlo)session.getAttribute("aktualis");
            for(int i=0; i < tempV.getKosar().size();i++){
            session.setAttribute("torles", tempV.getKosar().get(i));
            
            %>
            <tr>
                <td><a href="${pageContext.request.contextPath}/TorlesS?param=<%=i%>"><%=tempV.getKosar().get(i)%><%%></a></td>
            </tr>
            <% } %>
        </table>
         
        
        <table>
            <tr><th>Elado</th></tr>
            <%
            for(int i=0; i < temp.getLista().size();i++){
            session.setAttribute("add", temp.getLista().get(i));       
            %>
            <tr>
                <td><a <a href="${pageContext.request.contextPath}/HozzaadS?param=<%=i%>"><%=temp.getLista().get(i)%><%%></a></td>
            </tr>
            <% } %>
            <form action="FelveszS" method="post">
            Új alkatrész:<input type="text" name="item"><br>
            <input type="submit" value="hozzáad">
        </form>
        </table>
        

    </body>

