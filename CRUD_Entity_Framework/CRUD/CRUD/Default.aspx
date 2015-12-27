<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
            <asp:GridView ID="GridDados" runat="server" OnSelectedIndexChanged="GridDados_SelectedIndexChanged" Width="452px">
            </asp:GridView>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Cadastro de Clientes </h3>
    <asp:FormView runat="server" ID="FormCadastro" DefaultMode="Insert" ItemType="Model.Cliente.ClienteModel" InsertMethod="FormCadastro_InsertItem"
        CellPadding="4" ForeColor="#333333" DataKeyNames="Id">

        <InsertItemTemplate>
            Nome: <br />
            <asp:TextBox ID="NomeTextBox" runat="server" Text='<% BindItem.Nome %>' /> 
 
        </InsertItemTemplate>



    </asp:FormView>

</asp:Content>
