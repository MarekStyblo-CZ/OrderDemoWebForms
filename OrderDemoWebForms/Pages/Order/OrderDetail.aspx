<%@ Page Title="Objednávky" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="OrderDemoWebForms.Pages.Order.OrderDetail" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2><%: Title %></h2>

        <hr />
        <h3>Detail objednávky</h3>
        <table class="nav-justified">
            <tr>
                <td>Id objednávky</td>
                <td>
                    <asp:TextBox ID="txtId" runat="server" ReadOnly="true" disabled="disabled" />
                </td>
            </tr>
            <tr>
                <td>Jméno zákazníka</td>
                <td>
                    <asp:TextBox ID="txtCustomerName" runat="server" ReadOnly="true" disabled="disabled" />
                </td>
            </tr>
            <tr>
                <td>Adresa zákazníka</td>
                <td>
                    <asp:TextBox ID="txtCustomerAddress" runat="server" ReadOnly="true" disabled="disabled" />
                </td>
            </tr>
            <tr>
                <td>Cena</td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server" ReadOnly="true" disabled="disabled" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Zpět" />
        <%--<asp:Button ID="UpdateProducId" runat="server" OnClick="UpdateProduct_Click" Text="Aktualizovat" />--%>
        <br />
    </div>
</asp:Content>

