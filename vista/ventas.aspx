<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ventas.aspx.cs" Inherits="venta.vista.ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="345px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Formulario de venta
        <asp:Panel ID="Panel2" runat="server" Height="329px">
            &nbsp;&nbsp;&nbsp; codigo venta&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="cod" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp; codigo producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [codigo], [nombre], [categoria], [stock], [marca], [cantidad], [precio] FROM [producto]"></asp:SqlDataSource>
            <br />
            &nbsp;&nbsp; Cantidad de producto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="cantidad" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            Datos del cliente<asp:Panel ID="Panel3" runat="server">
                <br />
                &nbsp;&nbsp;&nbsp; Nombre:&nbsp;
                <asp:TextBox ID="nom" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Correo:&nbsp;&nbsp;
                <asp:TextBox ID="correo" runat="server"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp; Apellido:&nbsp;
                <asp:TextBox ID="ape" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Guardar pedido" />
                <asp:Button ID="Button2" runat="server"  Text="modificar pedido" OnClick="Button2_Click" />
                <br />
                &nbsp;&nbsp;&nbsp; Direccion:
                <asp:TextBox ID="direc" runat="server"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp; Telefono:&nbsp;
                <asp:TextBox ID="tele" runat="server"></asp:TextBox>

                                        <li><a id="A1" runat="server" href="eliminar_venta.aspx">Eliminar pedido de venta</a></li>

            </asp:Panel>
            <br />
            <br />
            <br />
        </asp:Panel>

    </asp:Panel>
</asp:Content>
