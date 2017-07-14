<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="venta.vista.contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <section class="contact">
    <header>
        <h3>Teléfono:</h3>
    </header>
    <p>
        <span class="label">Principal:</span> +569972437263</p>
    <p>
        <span class="label">Fuera del horario laboral:</span> +56978236584</p>
</section>
<section class="contact">
    <header>
        <h3>Correo electrónico:</h3>
    </header>
    <p>
        <span class="label">Soporte técnico:</span> <span><a href="mailto:Support@example.com">sisofis@gmail.com</a></span>
    </p>
    <p>
        <span class="label">Marketing:</span> sisofis123<span><a href="mailto:Marketing@example.com">@gmail.com</a></span>
    </p>
    <p>
        <span class="label">General:</span> o<span>fis<a href="mailto:General@example.com">@gmail.com</a></span>
    </p>
</section>
<section class="contact">
    <header>
        <h3>Dirección:</h3>
    </header>
    <p>
        Calle: Gamero #680</p>
    <p>
        Ciudad: Chillan</p>
</section>
</asp:Content>
