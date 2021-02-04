<%@ Page Title="To-Do List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="OkulProjesiWebForm.Pages.ToDo.Index" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="~/Template_Folder/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top: 40px;"></div>
    <div class="card card-dark card-outline">
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
            <div class="input-group">
                <asp:TextBox ID="SearchTextBox" AutoCompleteType="Disabled" TextMode="Search" CssClass="form-control" placeholder="Arama yapın..." runat="server"></asp:TextBox>
                <div class="input-group-append">
                    <asp:LinkButton ID="SearchButton" CausesValidation="false" OnClick="SearchButton_Click" CssClass="btn btn-default" runat="server">
                        <i class="fa fa-search"></i>
                    </asp:LinkButton>
                </div>
            </div>
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
                            <asp:LinkButton runat="server" CssClass="btn btn-outline-danger" style="padding-left:15px; padding-right:15px;" CommandName="DeleteCommand" CommandArgument='<%#Eval("ID") %>'>
                                <i class="fas fa-times"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div class="text-center" style="margin:20px;">
                <h4><asp:Label ID="nullRow" Visible="false" runat="server" Text="Aradığınız kriterlere uygun sonuç bulunamadı."></asp:Label></h4>
            </div>
            <asp:Panel ID="NullTable" Visible="false"  runat="server">
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
        </div>
        <!-- /.card-body -->
    </div>
    
</asp:Content>
