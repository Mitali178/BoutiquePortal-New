<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/DashboardAdmin.Master" AutoEventWireup="true" CodeBehind="editcategory.aspx.cs" Inherits="Boutiqueportalm.Admin.editcategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <!--Main layout-->

            <div class="container-fluid mt-5 content-inner">
                <div class="card mb-4 wow fadeIn"></div>
                <div class="row wow fadeIn title_header">
                    <!--Grid column1-->
                    <div class="col-md-12 mb-4">
                        <div class="card mb-4">
                            <!-- Card header -->
                            <div class="card-header text-left blue-gradient text-white mdtitle">
                                Category                                
                            </div>

                            <!--Card content-->
                            <div class="card-body table-responsive">
                                
                                <div class="form-group">
                                    <label>Category Name<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </label>&nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" ></asp:TextBox>  
                                    
                                    <label>Category Image<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUpload1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                                    </label>
                                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" /> 
                                    <br />
                                    <asp:Image ID="Image1" runat="server" Height="80px" Width="80px" />
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Edit" OnClick="Button1_Click"   />
                                    <asp:Button ID="Button2" CssClass="btn btn-primary" CausesValidation="false" runat="server" Text="Cancel" OnClick="Button2_Click"   />                                    
                                </div>                                                                                       
                           </div>                     
                      </div>          
                </div>
            </div>
    </div>
            <!--Main layout End-->

</asp:Content>
