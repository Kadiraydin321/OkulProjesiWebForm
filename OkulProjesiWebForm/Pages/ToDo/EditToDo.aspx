<%@ Page Title="To-Do Güncelle" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditToDo.aspx.cs" Inherits="OkulProjesiWebForm.Pages.ToDo.EditToDO" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
         <div style="height:40px;"></div>
         <div class="card card-success">
             <!-- Header -->
                <div class="card-header">
                        To-Do Güncelleme Sayfası
                </div>
             <!-- Body -->
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Konu Başlığı"></asp:Label>
                        <asp:TextBox ID="SubjectTitleTextBox" AutoCompleteType="Disabled" MaxLength="250" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Konu Metni"></asp:Label>
                        <asp:TextBox ID="SubjectTextBox" TextMode="MultiLine" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Son Tarih"></asp:Label>
                        <asp:TextBox ID="DateTextBox" TextMode="Date" CssClass="form-control text-gray" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Son Durum"></asp:Label>
                        <asp:DropDownList ID="Status" CssClass="custom-select" runat="server">
                            <asp:ListItem Value="YAPILMADI">Yapılmadı</asp:ListItem>
                            <asp:ListItem Value="YAPILDI">Yapıldı</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
             <!-- Footer -->
                <div class="card-footer">
                    <asp:Button ID="UpdateButton" runat="server" CssClass="btn btn-outline-success" OnClick="UpdateButton_Click" Text="Güncelle" />
                </div>
       </div>
    </div>
</asp:Content>
