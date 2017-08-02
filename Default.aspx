<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AffectingDefaultValueWithIsPostBack.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #0033CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3 class="auto-style1"><strong>Tolulope Birthday&#39;s Wisher Application</strong></h3>
    
        Type your Name:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        Type your Birthday:
        <asp:TextBox ID="birthdayTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Retrieve" />
&nbsp;<br />
&nbsp;<asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
