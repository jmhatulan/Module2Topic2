<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwitterClone.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

    <title></title>

</head>

<body>

    <form id="form1" runat="server">
        <div>
            <%--<asp:Repeater ID="PostRepeater" runat="server">
                <ItemTemplate>
                    <p> <%# Eval("Content") %> </p>
                </ItemTemplate>
            </asp:Repeater>--%>

            <%--<% if (currentPost.PostedBy == "joblipat") %>
            <% { %>
                <p><%= currentPost.Content %></p>
                <p><%= currentPost.PostedBy %></p>
            <% } %>--%>

            <%foreach (var currentPost in posts)%>
            <% { %>
            <% if (currentPost.PostedBy == "joblipat" || currentPost.PostedBy == "joelim") %>
                <% { %>
                    <p><%= currentPost.Content %></p>
                    <p><%= currentPost.PostedBy %></p>
                <% } %>
            <% } %>


        </div>
    </form>

</body>

</html>

<%-- 
    Repeaters "or" <% for %>
--%>
