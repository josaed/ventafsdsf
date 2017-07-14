<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reporteventa.aspx.cs" Inherits="venta.vista.reporteventa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="t_lista" runat="server" BorderColor="#000066" BorderStyle="Ridge" CellPadding="2">
    </asp:GridView>
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="t_total" runat="server" BorderColor="#000066" BorderStyle="Ridge" CellPadding="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </asp:Panel>
    <br />
    <asp:Button ID="b_listar" runat="server" OnClick="b_listar_Click" Text="Listar" Width="100px" />
    <asp:Button ID="b_total" runat="server"  Text="Total" Width="100px" OnClick="b_total_Click" />
</asp:Content>
