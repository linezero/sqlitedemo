<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="SqliteDemo.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="BtnAdd" runat="server" Text="新增" OnClick="BtnAdd_Click"/>
    </div>
    </form>
    <%=System.Environment.OSVersion.ToString() %>
</body>
</html>
