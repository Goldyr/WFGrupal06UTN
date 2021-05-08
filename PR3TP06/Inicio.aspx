<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TP6_GRUPO7.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>
            GRUPO N7
        </h2>
        <div>
            <asp:HyperLink ID="linkEjercicio1" runat="server" NavigateUrl="EJ01.aspx">Ejercicio1</asp:HyperLink>
        </div>
        <div>
            <asp:HyperLink ID="linkEjercicio2" runat="server" NavigateUrl="~/EJ02_Inicio.aspx">Ejercicio2</asp:HyperLink>
        </div>
    </form>
</body>
</html>
