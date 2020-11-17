<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstate.aspx.cs" Inherits="الوظيفة_المحاضرة_الرابعة_الطلب_الثاني.viewstate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            user_name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            password
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button_sub" runat="server" OnClick="Button_sub_Click" Text="submite" />
            <asp:Button ID="Button_restor" runat="server" OnClick="Button_restor_Click" Text="restore" />
        </p>
    </form>
</body>
</html>
