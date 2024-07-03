<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="Task2.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input {
            margin-bottom: 10px;
        }
        .divClass{
            display:flex;
            flex-direction:row;
            justify-content:flex-start;
            align-items:center;
            gap:10px;
        }
        #ResultBox{
            text-align:center;
            align-content:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Num1" runat="server" Text="Number 1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Num2" runat="server" Text="Number 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <div class="divClass" id="BtnsDiv">
                <asp:Button ID="Multiply" runat="server" Text="*" BackColor="#6699FF" Height="40px" OnClick="Multiply_Click" Width="100px" />
                <asp:Button ID="Subtract" runat="server" Text="-" BackColor="#FF66FF" Height="40px" OnClick="Subtract_Click" Width="100px" />
                <asp:Button ID="Add" runat="server" Text="+" BackColor="#00CC99" Height="40px" OnClick="Add_Click" Width="100px" />
                <asp:Button ID="Divide" runat="server" Text="/" BackColor="#FFCC99" Height="40px" OnClick="Divide_Click" Width="100px" />
            </div>

            <div class="divClass">
                <asp:Label ID="Result" runat="server" Text="Result"></asp:Label>
                <asp:Label ID="ResultBox" runat="server" BorderColor="#000000" BorderStyle="Solid" Font-Bold="True" Width="150px" Height="40px"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
