<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/DashboardAdmin.Master" AutoEventWireup="true" CodeBehind="editproduct.aspx.cs" Inherits="Boutiqueportalm.Admin.editproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <!--Main layout-->
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="container-fluid mt-5 content-inner">
                <div class="card mb-4 wow fadeIn"></div>
                <div class="row wow fadeIn title_header">
                    <!--Grid column1-->
                    <div class="col-md-12 mb-4">
                        <div class="card mb-4">
                            <!-- Card header -->
                            <div class="card-header text-left blue-gradient text-white mdtitle">
                                Products                                
                            </div>

                            <!--Card content-->
                            <div class="card-body table-responsive">
                                
                                <div class="form-group">
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                            Category:<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="--select--"></asp:RequiredFieldValidator>
                                            <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"  ></asp:DropDownList>
                                            <br />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            Sub-Category:<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList2" ErrorMessage="*" ForeColor="Red" InitialValue="--select--"></asp:RequiredFieldValidator>
                                            <asp:DropDownList ID="DropDownList2" CssClass="form-control" runat="server"></asp:DropDownList>
                                            <br /><br />
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    

                                    <label>Product Name</label>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox> 

                                     <label>Product Price</label>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    &nbsp;<asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>

                                     <label>Product Description</label>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    &nbsp;<asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                                    
                                    <label>Product Image<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FileUpload1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                                    </label>
                                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" /> 
                                    <asp:Image ID="Image1" runat="server" Height="80px" Width="80px"/>

                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Edit" OnClick="Button1_Click" />
                                    <asp:Button ID="Button2" CssClass="btn btn-primary" CausesValidation="false" runat="server" Text="Cancel" OnClick="Button2_Click"   />
                                     </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    
    <!--Main layout End-->
</asp:Content>
