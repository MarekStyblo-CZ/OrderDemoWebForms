﻿<%@ Page Title="Produkty" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="OrderDemoWebForms.Pages.Product.Products" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2><%: Title %></h2>



        <hr />
        <h3>Přidat produkt</h3>
        <table class="nav-justified">
            <tr>
                <td>Kód produktu</td>
                <td>
                    <asp:TextBox ID="txtCode" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Název produktu</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" />
                </td>
            </tr>
            <tr>
                <td>Cena</td>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="AddProducId" runat="server" OnClick="AddProduct_Click" Text="Přidat" />
        <br />
    </div>

    <div>
        <hr />
        <h3>Přehled produktů</h3>
        <asp:GridView ID="ProductsGrid" runat="server" AutoGenerateColumns="False" Width="458px" AutoGenerateDeleteButton="True"
            OnRowDeleting="ProductsGridView_RowDeleting"
            AutoGenerateEditButton="True"
            OnRowUpdating="ProductsGridView_RowUpdating"
            OnRowEditing="ProductsGridView_RowEditing">
            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label ID="Id" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Kód produktu">
                    <ItemTemplate>
                        <asp:Label ID="Code" runat="server" Text='<%# Bind("Code") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Název produktu">
                    <ItemTemplate>
                        <asp:Label ID="Name" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
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

</asp:Content>
