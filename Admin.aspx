<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Project_2_IT114L.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SEMINAR CODE
            <asp:TextBox ID="TextBox1" runat="server" Width="168px"></asp:TextBox>
            <br />
            <br />
            SEMINAR TITLE
            <asp:TextBox ID="TextBox2" runat="server" Width="168px"></asp:TextBox>
            <br />
            <br />
            SEMINAR DATE
            <asp:TextBox ID="TextBox3" runat="server" Width="168px"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SAVE" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Saved"></asp:Label>
        </div>
    </form>
</body>
</html>
