<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Account.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
         <div style="height:40px;"></div>
         <div class="card card-primary card-outline">
             <!-- Header -->
                <div class="card-header">
                        Profil Sayfası
                </div>
             <!-- Body -->
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
                        <asp:TextBox ID="UserNameTextBox" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Ad"></asp:Label>
                        <asp:TextBox ID="NameTextBox" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Soyad"></asp:Label>
                        <asp:TextBox ID="SurnameTextBox" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="EmailTextBox" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Şifre"></asp:Label>
                        <asp:TextBox ID="PasswordTextBox" TextMode="Password" placeholder="Profili güncellemek için şifreyi giriniz." CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>
                </div>
             <!-- Footer -->
                <div class="card-footer">
                    <asp:Button ID="ProfileUpdateButton" runat="server" CssClass="btn btn-outline-primary disabled" OnClick="ProfileUpdateButton_Click" Text="Güncelle" />
                </div>
       </div>
    </div>
</asp:Content>
