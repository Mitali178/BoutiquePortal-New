<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/DashboardAdmin.Master" AutoEventWireup="true" CodeBehind="Subcat.aspx.cs" Inherits="Boutiqueportalm.Admin.Subcat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Sub-Category</title>
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
                                Sub-Category                               
                            </div>

                            <!--Card content-->
                            <div class="card-body table-responsive">
                                
                                <div class="form-group">
                                    Category:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red" InitialValue="--select--"></asp:RequiredFieldValidator>
                                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                                    <br /><br />

                                    <label>Sub-Category Name<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </label>&nbsp;<asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" ></asp:TextBox>  
                                    
                                    <label>Sub-Category Image<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUpload1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                    <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
                                    </label>
                                    <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" /> 
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Save" OnClick="Button1_Click"   />
                                    <asp:Button ID="Button2" CssClass="btn btn-primary" CausesValidation="false" runat="server" Text="Cancel" OnClick="Button2_Click"    />                                    
                                </div>
                                
                                 <asp:GridView ID="GridView1" CssClass="table table-striped"  runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand"   >
                                    <Columns>
                                        <asp:TemplateField HeaderText="<b>Category Name</b>">
                                            <ItemTemplate>
                                                <asp:Label ID="Label3" runat="server"  Text='<%# Eval("name") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="<b>Sub-Category Name</b>">
                                            <ItemTemplate>
                                                <asp:Label ID="Label4" runat="server"  Text='<%# Eval("name1") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="<b>Sub-Category Image</b>">
                                            <ItemTemplate>
                                                <asp:Image ID="Image1" runat="server" Height="70px" ImageUrl='<%# Eval("path") %>' Width="70px" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="<b>Edit</b>">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" CausesValidation="false" PostBackUrl='<%#"editsubcat.aspx?id="+Eval("id") %>' runat="server">Edit</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="<b>Delete</b>">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="LinkButton2" CausesValidation="false" CommandName="del" CommandArgument='<%#Eval("id") %>' OnClientClick="return confirm('r u sure')" runat="server">Delete</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>                                                                                           
                           </div>                     
                      </div>          
                </div>
            </div>
    </div>
            <!--Main layout End-->
</asp:Content>
