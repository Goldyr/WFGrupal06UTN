<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO7.SeleccionarProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grd_SelProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnPageIndexChanging="grd_SelProductos_PageIndexChanging" OnSelectedIndexChanging="grd_SelProductos_SelectedIndexChanging" PageSize="14">
                <Columns>
                    <asp:TemplateField HeaderText="IdProducto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NombreProducto">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IdProveedor">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_IdProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PrecioUnidad">
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_Precio" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <br />
            <asp:Label ID="lblProducto" runat="server"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="hlkInicio" runat="server" NavigateUrl="~/Inicio.aspx">Volver a Inicio</asp:HyperLink>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
