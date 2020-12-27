<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Account.Register" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height:40px;"></div>
    <div class="row">
        <div class="col"></div>
        <div class="col-4">

            <div class="card card-success">
                <!-- Card Header -->
                <div class="card-header">
                    <h3 class="card-title">Kayıt sayfası</h3>
                </div>
                <!-- Card Body -->
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="UyariMesaji" runat="server" Text=""></asp:Label>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="UserNameTextBox" runat="server" CssClass="form-control" placeholder="Kullanıcı adı"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Kullanıcı adı alanı boş bırakılamaz." CssClass="text-warning" ControlToValidate="UserNameTextBox"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="NameTextBox" runat="server" CssClass="form-control" placeholder="Ad"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ad alanı boş bırakılamaz." CssClass="text-warning" ControlToValidate="NameTextBox"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="SurnameTextBox" runat="server" CssClass="form-control" placeholder="Soyad"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Soyad alanı boş bırakılamaz." CssClass="text-warning" ControlToValidate="SurnameTextBox"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:TextBox ID="EmailTextBox" TextMode="Email" runat="server" CssClass="form-control" placeholder="E-Mail"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="E-Mail alanı boş bırakılamaz." CssClass="text-warning" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:TextBox TextMode="Password" ID="PasswordTextBox" runat="server" CssClass="form-control" placeholder="Şifre"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Şifre alanı boş bırakılamaz." CssClass="text-warning" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
                    </div>
               </div>
                <!-- Card Footer -->
                 <div class="card-footer">
                     <div class="form-group">
                        <asp:Button ID="RegisterButton" CssClass="btn btn-success" runat="server" Text="Kayıt ol" OnClick="RegisterButton_Click" />
                    </div>
                 </div>
           </div>
        </div>
        <div class="col"></div>
    </div>
</asp:Content>
