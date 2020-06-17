<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Laboratorio2.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label id="uName" runat="server" />
            <br />
            <asp:TextBox id="Num" runat="server" />
            <br />
            <br />
            <asp:Button Text="Calcular" runat="server" ID="Calc" OnClick="Calc_Click" />
            <br />
            <br />
            <asp:TextBox id="Resultado" ReadOnly="true" runat="server"></asp:TextBox>
            
        </div>
    </form>
</body>
</html>
