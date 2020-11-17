<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookies.aspx.cs" Inherits="الوظيفة_المحاضرة_الرابعة_الطلب_الثاني.cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Button ID="Btn_cookies" runat="server" Height="25px" OnClick="Button1_Click" Text="creat cookies" Width="81px" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Btn_return" runat="server" Text="return" OnClick="Btn_return_Click" />
        </p>

     
    </form>
</body>
</html>
