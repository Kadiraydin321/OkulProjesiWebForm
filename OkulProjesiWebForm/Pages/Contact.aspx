﻿<%@ Page Title="İletişim" Language="C#" MasterPageFile="~/NoUser.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height:40px;"></div>
    <div class="container">
        <div class="card card-warning card-outline">
        <!-- Card Header -->
        <div class="card-header">
            <h3 class="card-title">İletişim Sayfası</h3>
        </div>
        <!-- Card Body -->
        <div class="card-body">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" CssClass="text-black" Text="Bu web sitesi, Ankara Yıldırım Beyazıt Üniversitesi - Bilgisayar Programcılığı bölümü öğrencisi Kadir Aydın'ın yapmış olduğu İnternet Programlama dersi final projesidir."></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" CssClass="text-black" Text="Telefon:"></asp:Label>
                <asp:Label ID="Label5" runat="server" CssClass="text-secondary" Text="0 312 906 20 00"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" CssClass="text-black" Text="Posta Kodu:"></asp:Label>
                <asp:Label ID="Label7" runat="server" CssClass="text-secondary" Text="06010"></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" CssClass="text-black" Text="Adres:"></asp:Label>
                <asp:Label ID="Label3" runat="server" CssClass="text-secondary" Text="15 Temmuz Şehitleri Binası C Blok 1. Kat Takdir Cad. 150. Sok. No 5 06010 Etlik Keçiören/ANKARA"></asp:Label>
            </div>
            <div class="form-group text-center">
                <a href="https://aybu.edu.tr"><i class="fas fa-graduation-cap" style="color:orange; font-size:45px; margin-right:50px;"></i></a>
                <a href="https://www.instagram.com/ybuankara"><i class="fab fa-instagram" style="color:orange; font-size:45px; margin-right:50px;"></i></a> 
                <a href="https://twitter.com/ybuankara"><i class="fab fa-twitter" style="color:orange; font-size:45px; margin-right:50px;"></i></a> 
                <a href="https://www.facebook.com/ybuankara"><i class="fab fa-facebook-f" style="color:orange; font-size:45px; margin-right:50px;"></i></a> 
                <a href="https://tr.linkedin.com/organization-guest/school/ybuankara"><i class="fab fa-linkedin-in" style="color:orange; font-size:45px;"></i></a>
            </div>
        </div>
    </div>
    </div>
    
    
</asp:Content>
