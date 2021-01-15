<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Account.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
         <div style="height:40px;"></div>
         <div class="card card-success">
             <!-- Header -->
                <div class="card-header">

                        Profil
                </div>
             <!-- Body -->
                <div class="card-body bg-gradient-green">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı"></asp:Label>
                        <asp:TextBox ID="UserNameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Ad"></asp:Label>
                        <asp:TextBox ID="NameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Soyad"></asp:Label>
                        <asp:TextBox ID="SurnameTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="EmailTextBox" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
             <!-- Footer -->
                <div class="card-footer">
                    <asp:Button ID="ProfileUpdateButton" runat="server" CssClass="btn btn-outline-success" Text="Güncelle" />
                </div>
       </div>
    </div>
</asp:Content>
