<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Play Rock Paper Scissors</title>
    <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="Content">
        <header><p>Rock Paper Scissors</p></header>
    <form id="form1" runat="server">
        <p id="heading">
            To start playing, choose an option below:
        </p>
        <p>
            <asp:ImageButton class="img" ID="ImageButton1" runat="server" ImageUrl="~/Images/Rock.jpg" OnClick="ImageButton1_Click" />
            <asp:ImageButton class="img" ID="ImageButton2" runat="server" ImageUrl="~/Images/Paper.jpg" OnClick="ImageButton2_Click" />
            <asp:ImageButton class="img" ID="ImageButton3" runat="server" ImageUrl="~/Images/Scissors.jpg" OnClick="ImageButton3_Click" />
        </p>
        <p>
             <asp:Label ID="Label3" runat="server"></asp:Label><br />
            <asp:Label ID="Label1" runat="server"></asp:Label><br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <table><tr>
            <td class="tableText">
            Total games played: </td>
            <td><asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
            </td>
            </tr><tr>
            <td class="tableText">
            You Won: </td>
            <td><asp:Label ID="Label5" runat="server" Text="0"></asp:Label>
            </td>
           </tr><tr>
            <td class="tableText">
            You Lost: </td>
            <td><asp:Label ID="Label6" runat="server" Text="0"></asp:Label>
            </td>
            </tr>
         </table><br />
        <asp:Button ID="Button1" runat="server" Text="Restart Game" OnClick="Button1_Click" />
    </form>
    </div>
</body>
</html>
