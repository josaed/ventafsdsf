<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="producto.aspx.cs" Inherits="venta.vista.producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="396px">
        &nbsp;&nbsp;&nbsp; Producto<br /> <br /> &nbsp;&nbsp;&nbsp;&nbsp; Codigo P:&nbsp;
        <asp:TextBox ID="tb_codigop" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Nombre:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_nombre" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Categoria:&nbsp;
        <asp:TextBox ID="tb_categoria" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Stock:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_stock" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Marca:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_marca" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Cantidad:&nbsp;&nbsp;
        <asp:TextBox ID="tb_cantidad" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp; Precio:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="tb_Precio" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="ingresar producto" OnClick="Button2_Click1" />
        <asp:Button ID="Button3" runat="server" Text="modificar producto" OnClick="Button3_Click" />

                                                <li style="height: 59px"><a id="A1" runat="server" href="eliminarproducto.aspx">Eliminar producto</a></li>

    </asp:Panel>
</asp:Content>
