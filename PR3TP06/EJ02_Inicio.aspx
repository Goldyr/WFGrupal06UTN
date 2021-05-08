<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJ02_Inicio.aspx.cs" Inherits="TP6_GRUPO7.EJ02_Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Inicio<br />
&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlkSeleccionar" runat="server" NavigateUrl="~/SeleccionarProductos.aspx" style="font-size: medium">Seleccionar productos</asp:HyperLink>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lbtEliminar" runat="server" style="font-size: medium">Eliminar productos seleccionados</asp:LinkButton>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hlkMostrar" runat="server" style="font-size: medium" NavigateUrl="~/MostrarProductos.aspx">Mostrar productos</asp:HyperLink>
            <br />
            </strong>
        </div>
    </form>
</body>
</html>
