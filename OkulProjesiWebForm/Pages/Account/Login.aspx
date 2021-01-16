<%@ Page Title="Giriş" Language="C#" MasterPageFile="~/NoUser.Master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Account.Login" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="~/Template_Folder/plugins/toastr/toastr.min.css">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div style="height:40px;"></div>
    <div class="row">
        <div class="col"></div>
        <div class="col-md-4">
            <div class="card card-success card-outline">
                <!-- Card Header -->
                <div class="card-header">
                    <h3 class="card-title">Giriş Sayfası</h3>
                </div>
                <!-- Card Body -->
                <div class="card-body">
                     <div class="form-group">
                        <asp:TextBox ID="UserNameTextBox" runat="server" CssClass="form-control" placeholder="Kullanıcı adı"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Kullanıcı adı boş bırakılamaz." CssClass="text-warning" ControlToValidate="UserNameTextBox"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:TextBox TextMode="Password" ID="PasswordTextBox" runat="server" CssClass="form-control" placeholder="Şifre"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Şifre boş bırakılamaz." CssClass="text-warning" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
                   </div>

                    <div class="form-group">
                        <asp:CheckBox ID="BeniHatirlaCheck" runat="server" /><asp:Label ID="Label1" runat="server" CssClass="control-label text-gray" Text=""> Beni hatırla?</asp:Label>
                    </div>
               </div>
                <!-- Card Footer -->
                 <div class="card-footer">
                      <asp:Button ID="LoginButton" CssClass="btn btn-success" runat="server" Text="Giriş Yap" OnClick="LoginButton_Click"/>
                      <a runat="server" href="~/Pages/Account/Register" class="btn btn-outline-secondary float-right">Kayıt Ol</a>
                 </div>
           </div>
        </div>
        <div class="col"></div>
    </div>
</asp:Content>



