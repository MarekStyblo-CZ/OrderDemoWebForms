<%@ Page Title="Objednávky" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderCreate.aspx.cs" Inherits="OrderDemoWebForms.Pages.Order.OrderCreate" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2><%: Title %></h2>

        <hr />
        <h3>Detail objednávky</h3>
        <table class="nav-justified">
            <tr>
                <td>Jméno zákazníka</td>
                <td>
                    <asp:TextBox ID="txtCreateCustomerName" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCreateCustomerName" ErrorMessage="Je třeba zadat jméno" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Adresa zákazníka</td>
                <td>
                    <asp:TextBox ID="txtCreateCustomerAddress" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCreateCustomerAddress" ErrorMessage="Je třeba zadat adresu" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>
            </tr>

        </table>
        <br />
        <br />

        <hr />
        <table class="nav-justified">
            <tr>
                <th>Produkt</th>
                <th>Množství</th>
            </tr>

            <tr>
                <td>
                    <asp:DropDownList ID="ProductsDropDownList1" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="Quantity1" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Quantity1" ErrorMessage="Je třeba vyplnit" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:DropDownList ID="ProductsDropDownList2" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="Quantity2" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Quantity2" ErrorMessage="Je třeba vyplnit" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:DropDownList ID="ProductsDropDownList3" runat="server"></asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="Quantity3" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Quantity3" ErrorMessage="Je třeba vyplnit" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </td>
            </tr>


        </table>
        <br />
    </div>



    <asp:Button ID="Back" runat="server" OnClick="Back_Click" Text="Zpět" />
    <asp:Button ID="AddOrder" runat="server" OnClick="AddOrder_Click" Text="Vytvořit" />
</asp:Content>

