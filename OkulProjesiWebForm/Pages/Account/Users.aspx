<%@ Page Title="Kullanıcılar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="OkulProjesiWebForm.Pages.Account.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <div style="margin-top: 40px;"></div>
    <div class="card">
        <div class="card-header">
        <h3 class="card-title">Kullanıcılar</h3>
        <div class="card-tools">
        </div>
        </div>
        <!-- /.card-header -->
        <div class="card-body p-0">
         <asp:GridView ID="UserTable" runat="server" AutoGenerateColumns="false" CssClass="table table-dark table-hover" OnRowCommand="UserTable_RowCommand">
                <Columns>
                    <asp:BoundField DataField="UID" HeaderText="Kullanıcı ID" />
                    <asp:BoundField DataField="UserName" HeaderText="Kullanıcı Adı" />
                    <asp:BoundField DataField="Name" HeaderText="Ad" />
                    <asp:BoundField DataField="Surname" HeaderText="Soyad" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:TemplateField HeaderText="" ItemStyle-CssClass="text-center">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CssClass="btn btn-outline-danger" CommandName="DeleteCommand" CommandArgument='<%#Eval("UID") %>' OnClientClick="return confirm('Silmek istediğine emin misin?');">
                                <i class="fas fa-times"></i>
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <!-- /.card-body -->
    </div>
</asp:Content>
