<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="query_string.aspx.cs" Inherits="الوظيفة_المحاضرة_الرابعة_الطلب_الثاني.query_string" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        last name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button_sub" runat="server" OnClick="Button_sub_Click" Text="submit" />
    
    </div>
    </form>
</body>
</html>
