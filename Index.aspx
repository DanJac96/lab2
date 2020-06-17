<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Laboratorio2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Usuario <asp:textbox ID="Usuario" runat="server"/> </p>
            <p>Contraseña <asp:textbox TextMode="Password" ID="Contra" runat="server"/> </p>
            <asp:Button Text="Iniciar Sesion" runat="server" onclick="LogOn" />
        </div>
          
   </form>
</body>
</html>
