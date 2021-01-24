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
            <h4>
                <asp:LinkButton ID="NewToDo1" runat="server" CausesValidation="false" CssClass="text-success" PostBackUrl="~/Pages/ToDo/AddToDo.aspx">
                    <i class="fas fa-plus-circle"></i>
                </asp:LinkButton>
            </h4>
            
        </div>
        </div>
        <!-- /.card-header -->
        <div class="card-body p-0">
            <asp:PlaceHolder ID="placeholder" runat="server" />
        </div>
        <!-- /.card-body -->
    </div>
    <asp:Panel ID="NullTable"  runat="server">
        <div class="text-center">
            <h4 class="text-black text-center">
                Hadi yeni bir to-do ekleyelim. 
            </h4>
            <h1>
                <asp:LinkButton ID="NewToDo" runat="server" CausesValidation="false" CssClass="text-success" PostBackUrl="~/Pages/ToDo/AddToDo.aspx">
                    <i class="fas fa-plus-circle"></i>
                </asp:LinkButton>
            </h1>
        </div>
    </asp:Panel>
</asp:Content>
