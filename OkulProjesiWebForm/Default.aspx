<%@ Page Title="Ana Sayfa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OkulProjesiWebForm._Default" %>
<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <link runat="server"  rel="stylesheet" href="~/Template_Folder/default/Style.css">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Giriş</h1>

    <div class="mainBox">
        <div Class="col-6 row">
        <div Class="col-2">
          <asp:Label Text="Kullanıcı adı:" runat="server" />
             </div>
        <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>

    </div>
    <div style="height:15px;"></div>
    <div Class="col-6 row">
        <div Class="col-2">
            <asp:Label Text="Şifre:" runat="server" />
             </div>
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    </div>
    </div>
    
  
</asp:Content>


