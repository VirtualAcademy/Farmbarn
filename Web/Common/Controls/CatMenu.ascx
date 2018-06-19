<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CatMenu.ascx.cs" Inherits="Web_Common_Controls_CatMenu" %>
<asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" 
     
    RepeatDirection="Horizontal" Width="100%">
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton1" runat="server" 
            CommandArgument='<%# Eval("ID") %>' 
            oncommand="LinkButton1_Command" Text='<%# Eval("Name") %>'></asp:LinkButton>
        <br />
    </ItemTemplate>
</asp:DataList>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
    DataObjectTypeName="FbCategory" DeleteMethod="DeleteFbCategory" 
    InsertMethod="AddFbCategory" SelectMethod="FindFbCategories" 
    TypeName="FbCategoryBLL" UpdateMethod="EditFbCategory">
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int32" />
    </DeleteParameters>
</asp:ObjectDataSource>

