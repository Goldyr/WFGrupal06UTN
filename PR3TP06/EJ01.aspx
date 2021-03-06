<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJ01.aspx.cs" Inherits="TP6_GRUPO7.EJ01" %>

<!DOCTYPE html>
<script runat="server">
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 480px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>
           Productos
        </h2>
        <div>
            <asp:GridView ID="grd_Productos" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnSelectedIndexChanging="grd_Productos_SelectedIndexChanging" AllowPaging="True" OnPageIndexChanging="grd_Productos_PageIndexChanging" OnRowEditing="grd_Productos_RowEditing" OnRowCancelingEdit="grd_Productos_RowCancelingEdit" OnRowDeleting="grd_Productos_RowDeleting" OnRowUpdating="grd_Productos_RowUpdating">
                <Columns>
                    <asp:TemplateField HeaderText="Id Producto">
                        <EditItemTemplate>
                            <asp:Label ID="lbl_eit_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_prod" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre Producto">
                        <EditItemTemplate>
                            <asp:TextBox ID="tb_eit_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>' ValidationGroup="grupo1"></asp:TextBox>
                            <asp:RequiredFieldValidator 
                 ControlToValidate="tb_eit_NombreProducto" 
                 runat="server" 
                 ErrorMessage="Escribe el nombre de un producto valido" 
                 Text="*"
                 ForeColor="Red"
                 />
                
                                
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_i_NombProd" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cantidad Por Unidad">
                        <EditItemTemplate>
                            <asp:TextBox ID="tb_eit_CantidadxUnidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>' ValidationGroup="grupo2" CausesValidation="True"></asp:TextBox>
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="tb_eit_CantidadxUnidad" Text="*" ForeColor="Red" ErrorMessage="Escribe una cantidad valida"  ID="rfv_1"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_cant" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio Unitario">
                        <EditItemTemplate>
                            <asp:TextBox ID="tb_eit_PrecioUnitario" runat="server" Text='<%# Bind("PrecioUnidad") %>' TextMode="Number"></asp:TextBox>
                            
                            <asp:RangeValidator Type="Double" ID="RangeValidator1" runat="server" Text="*" ControlToValidate="tb_eit_PrecioUnitario" ErrorMessage="Ingrese un numero valido" ForeColor="#CC0000" MaximumValue="10000" MinimumValue="1"></asp:RangeValidator>
                            <asp:RequiredFieldValidator  runat="server" ControlToValidate="tb_eit_PrecioUnitario" Text="*" ForeColor="Red" ErrorMessage="Ingrese Un Numero Valido"  ID="rfv_5"></asp:RequiredFieldValidator> 
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lbl_it_PreUni" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>
        <p class="auto-style1">
            <asp:HyperLink ID="hlkInicio" runat="server" NavigateUrl="~/Inicio.aspx">Volver a Inicio</asp:HyperLink>
            </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#CC0000" />
    </form>
</body>
</html>
