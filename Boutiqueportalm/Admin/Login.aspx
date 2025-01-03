<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Boutiqueportalm.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Admin</title>
    <link href="css/arpit.css" rel="stylesheet" />
    <link href="css/lgstyle.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/mdb.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
        <div class="row tpmargin">
            <div class="col-6 mx-auto">
                <div class="card">
                    <div class="card-header blue-gradient color-block">
                        <div>
                            <h3 class="mt-2 text-center text-white">Login</h3>
                        </div>
                    </div>
                    <div class="card-body">
    
                            <div class="md-form">
                                
                                <i class="fa fa-user prefix grey-text"></i>
                                 <asp:TextBox ID="TextBox1" placeholder="UserName/Email" CssClass="form-control" runat="server"></asp:TextBox> <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid" ControlToValidate="TextBox1" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>                               
                            </div>

                            <div class="md-form">
                                <i class="fa fa-key prefix grey-text"></i>
                                 <asp:TextBox ID="TextBox2"  placeholder="Password" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>

                            <div class="text-center">
                                <asp:Button ID="Button1" CssClass="btn blue-gradient" runat="server"  Text="Login" OnClick="Button1_Click"  />                                
                            </div>
                        <div class=" text-center">
                         <asp:Label  ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>                   
       
    </form>
</body>
</html>
