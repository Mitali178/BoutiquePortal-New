<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Category.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Boutiqueportalm.Client.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!--category section start -->
      <div class="container">
         <!--<div class="category_section">
            <div class="row">
               <div class="col-lg-10 col-sm-12 main">
                  
               </div>
            </div>
         </div>-->
         <div class="category_section_2">
            <div class="row">
               <div class="col-lg-4 col-sm-12">
                  <div class="beds_section ">
                     <h1 class="bed_text">Up to 50% off | Beds</h1>
                     <div><img src="images/img-2.png" class="image_2"></div>
                     <div class="seemore_bt"><a href="#">see More</a></div>
                  </div>
               </div>
               <div class="col-lg-4 col-sm-12">
                  <div class="beds_section">
                     <h1 class="bed_text">organized in style</h1>
                     <div><img src="images/img-3.png" class="image_2"></div>
                     <div class="seemore_bt"><a href="#">see More</a></div>
                  </div>
               </div>
               <div class="col-lg-4 col-sm-12">
                  <div class="beds_section">
                     <h1 class="bed_text">Refurbished mixer</h1>
                     <div><img src="images/img-4.png" class="image_2"></div>
                     <div class="seemore_bt"><a href="#">see More</a></div>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- category section end -->

    <div class="container">
     <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" >
        
         <ItemTemplate>
             <asp:ImageButton ID="ImageButton1" runat="server" Height="380px" ImageUrl='<%# Eval("path") %>' Width="380px" CssClass="image_2 beds_section "  />
             <br />
             <br />
             <asp:Label ID="Label1" runat="server" Height="20px" Text='<%# Eval("name") %>' Width="60px" CssClass="seemore_bt"></asp:Label>
         </ItemTemplate>
     </asp:DataList>
     <br />
    </div>
&nbsp;

</asp:Content>
