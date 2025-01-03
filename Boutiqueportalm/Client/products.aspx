<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Category.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="Boutiqueportalm.Client.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" >
        
         <ItemTemplate>
             <asp:ImageButton ID="ImageButton1" runat="server" Height="380px" ImageUrl='<%# Eval("path") %>' Width="380px" CssClass="image_2 beds_section "  />
             <br />
             <br />
             <asp:Label ID="Label1" runat="server" Height="20px" Text='<%# Eval("name2") %>' Width="60px" CssClass="seemore_bt"></asp:Label>
         </ItemTemplate>
     </asp:DataList>
     <br />
    </div>
</asp:Content>
