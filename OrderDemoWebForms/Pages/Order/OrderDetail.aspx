<%@ Page Title="Objednávky" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="OrderDemoWebForms.Pages.Order.OrderDetail" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2><%: Title %></h2>

        <hr />
        <h3>Zákaznické údaje</h3>
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
                <td>Celková cena</td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server" ReadOnly="true" disabled="disabled" />
                </td>
            </tr>
        </table>
        <br />

    </div>


    <div>
        <hr />
        <h3>Přehled položek</h3>
        <asp:GridView ID="OrderItemsGrid" runat="server" AutoGenerateColumns="False" Width="458px">
            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label ID="Id" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <%--#todo insert product name dont know how to bidn complex object--%>

                <asp:TemplateField HeaderText="Množství">
                    <ItemTemplate>
                        <asp:Label ID="Quantity" runat="server" Text='<%# Bind("Quantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Cena">
                    <ItemTemplate>
                        <asp:Label ID="Price" runat="server" Text='<%# Bind("Price") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>

        <hr />
    </div>

    <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Zpět" />
    <%--<asp:Button ID="UpdateProducId" runat="server" OnClick="UpdateProduct_Click" Text="Aktualizovat" />--%>
</asp:Content>

