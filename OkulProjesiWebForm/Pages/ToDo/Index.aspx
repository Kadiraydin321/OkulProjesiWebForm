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
            <asp:GridView ID="ToDoTable" runat="server" AutoGenerateColumns="false" CssClass="table table-dark table-hover" OnRowCommand="ToDoTable_RowCommand">
                <Columns>
                    <asp:BoundField DataField="SubjectTitle" HeaderText="Konu Başlığı" ItemStyle-Width="20%"/>
                    <asp:BoundField DataField="SubjectText" HeaderText="Konu Metni" ItemStyle-Width="50%"/>
                    <asp:BoundField DataField="Date" HeaderText="Tarih" ItemStyle-Width="10%"/>
                    <asp:BoundField DataField="Status" HeaderText="Durum" ItemStyle-Width="10%"/>
                    <asp:TemplateField HeaderText="" ItemStyle-CssClass="text-center" ItemStyle-Width="10%">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CssClass="btn btn-outline-primary" CommandName="EditCommand" CommandArgument='<%#Eval("ID") %>'>
                                <i class="far fa-edit"></i>
                            </asp:LinkButton>
                            <asp:LinkButton runat="server" CssClass="btn btn-outline-danger" CommandName="DeleteCommand" CommandArgument='<%#Eval("ID") %>'>
                                <i class="fas fa-times"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
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
