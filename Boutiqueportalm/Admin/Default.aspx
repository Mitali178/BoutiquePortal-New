<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/DashboardAdmin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Boutiqueportalm.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Dashboard</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
 <div class="container-fluid mt-5 content-inner">
                
                <div class="row wow fadeIn title_header">
                    <!--Grid column1-->
                    <div class="col-md-12 mb-4">
                        <div class="card mb-4">
                            <h1 align="center">Hello Welcome
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
                        </div>
                    </div>
                </div>
    </div>
    </asp:Content>