<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPassword.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Account.NewPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="container">
         <div style="height:40px;"></div>
         <div class="card card-primary card-outline">
             <!-- Header -->
                <div class="card-header">
                        Yeni Şifre Oluşturma
                </div>
             <!-- Body -->
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Eski Şifre"></asp:Label>
                        <asp:TextBox ID="OldPasswordTextBox" TextMode="Password" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="OldPasswordTextBox" CssClass="text-danger" ErrorMessage="Eski şifrenizi giriniz."></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Yeni Şifre"></asp:Label>
                        <asp:TextBox ID="NewPasswordTextBox" TextMode="Password" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="NewPasswordTextBox" CssClass="text-danger" ErrorMessage="Yeni şifrenizi giriniz."></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Tekrar Yeni Şifre"></asp:Label>
                        <asp:TextBox ID="ReNewPasswordTextBox" TextMode="Password" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ReNewPasswordTextBox" CssClass="text-danger" ErrorMessage="Yeni şifrenizi tekrardan giriniz."></asp:RequiredFieldValidator>
                    </div>
                </div>
             <!-- Footer -->
                <div class="card-footer">
                    <asp:Button ID="NewPasswordButton" runat="server" CssClass="btn btn-outline-primary" OnClick="NewPasswordButton_Click" Text="Güncelle" />
                </div>
       </div>
    </div>

</asp:Content>
