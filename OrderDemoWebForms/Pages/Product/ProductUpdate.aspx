<%@ Page Title="Produkty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductUpdate.aspx.cs" Inherits="OrderDemoWebForms.Pages.Product.ProductUpdate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2><%: Title %></h2>

        <hr />
        <h3>Upravit produkt</h3>
        <table class="nav-justified">
            <tr>
                <td>Id produktu</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server" ReadOnly="true" disabled="disabled" Text='<%# Product.Id %>' />
                </td>
            </tr>
            <tr>
                <td>Kód produktu</td>
                <td>
                    <asp:TextBox ID="txtCode" runat="server" Text='<%# Product.Code %>' />
                </td>
            </tr>
            <tr>
                <td>Název produktu</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Text='<%# Product.Name %>' />
                </td>
            </tr>
            <tr>
                <td>Cena</td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server" Text='<%# Product.Price %>' />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Zpět" />
        <asp:Button ID="UpdateProducId" runat="server" OnClick="UpdateProduct_Click" Text="Aktualizovat" />
        <br />
    </div>
</asp:Content>

