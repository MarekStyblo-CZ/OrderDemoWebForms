<%@ Page Title="Objednávky" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="OrderDemoWebForms.Pages.Order.Orders" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div>
        <asp:Button ID="CreateOrderBtn" runat="server" OnClick="CreateOrderBtn_Click" Text="Vytvořit objednávku" />
        <hr />
        <h3>Přehled Objednávek</h3>

        <asp:GridView ID="OrdersGrid" runat="server" AutoGenerateColumns="False" Width="458px"
            AutoGenerateSelectButton="True"
            OnSelectedIndexChanging="OrdersGridView_SelectedIndexChanging"
            AutoGenerateDeleteButton="True"
            OnRowDeleting="OrdersGridView_RowDeleting">
            <%--AutoGenerateEditButton="True"
            OnRowUpdating="OrdersGridView_RowUpdating"
            OnRowEditing="OrdersGridView_RowEditing">--%>

            <Columns>

                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label ID="Id" runat="server" Text='<%# Bind("Id") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Jméno zákazníka">
                    <ItemTemplate>
                        <asp:Label ID="CustomerName" runat="server" Text='<%# Bind("CustomerName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Adresa zákazníka">
                    <ItemTemplate>
                        <asp:Label ID="CustomerAddress" runat="server" Text='<%# Bind("CustomerAddress") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Celková cena">
                    <ItemTemplate>
                        <asp:Label ID="TotalPrice" runat="server" Text='<%# Bind("TotalPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Datum vytvoření">
                    <ItemTemplate>
                        <asp:Label ID="Created" runat="server" Text='<%# Bind("Created") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>

        <hr />
    </div>
</asp:Content>
