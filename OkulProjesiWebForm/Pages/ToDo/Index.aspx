<%@ Page Title="To-Do List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="OkulProjesiWebForm.Pages.ToDo.Index" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="~/Template_Folder/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top: 40px;"></div>
    <div class="card">
        <div class="card-header">
        <h3 class="card-title">To-Do List</h3>
        <div class="card-tools">
            <ul class="pagination pagination-sm float-right">
            <li class="page-item"><a class="page-link" href="#">«</a></li>
            <li class="page-item"><a class="page-link" href="#">1</a></li>
            <li class="page-item"><a class="page-link" href="#">2</a></li>
            <li class="page-item"><a class="page-link" href="#">3</a></li>
            <li class="page-item"><a class="page-link" href="#">»</a></li>
            </ul>
        </div>
        </div>
        <!-- /.card-header -->
        <div class="card-body p-0">
        <asp:PlaceHolder ID="placeholder" runat="server" />
        </div>
        <!-- /.card-body -->
    </div>
</asp:Content>
