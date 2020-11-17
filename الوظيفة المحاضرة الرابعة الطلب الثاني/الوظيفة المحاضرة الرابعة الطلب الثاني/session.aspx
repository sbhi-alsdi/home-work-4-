<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session.aspx.cs" Inherits="الوظيفة_المحاضرة_الرابعة_الطلب_الثاني.session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 197px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            provide following details</p>
        <p>
            &nbsp;email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_email" runat="server"></asp:TextBox>
            &nbsp;</p>
        <p>
            &nbsp;password &nbsp;<asp:TextBox ID="TextBox_password" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn_login" runat="server" OnClick="Btn_login_Click" Text="log in" />
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
