<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Theme="Farm_Theme" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 602%;
            height: 214px;
        }
        .style4
        {
            width: 62px;
        }
        .style5
        {
            width: 41px;
        }
        .style8
        {
            height: 54px;
            width: 58px;
        }
        .style9
        {
            width: 58px;
        }
        .style11
        {
            height: 54px;
            width: 77px;
        }
        .style12
        {
            width: 38px;
        }
        .style13
        {
            width: 77px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1" 
        GroupItemCount="2" onselectedindexchanged="ListView1_SelectedIndexChanged" 
        style="margin-right: 0px">
        
        
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>
                        No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
<td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr ID="itemPlaceholderContainer" runat="server">
                <td ID="itemPlaceholder" runat="server">
                </td>
            </tr>
        </GroupTemplate>
       
        <ItemTemplate>
            <td runat="server" class="style4">
                <table style="width:100%" class="style3">
                    <tr>
                        <td class="style5" rowspan="4">
                            <asp:Image ID="Image1" runat="server" Height="180px" Width="134px" 
                                ImageUrl='<%# Eval("Image", "~/Web/Common/ProductImages/{0}") %>' />
                        </td>
                        <td class="style13">
                            productname:</td>
                        <td class="style9">
                            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" 
                                NavigateUrl='<%# Eval("ID","~/Web/User/ProductShow.aspx?id={0}") %>' 
                                Text='<%# Eval("Name") %>'></asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td class="style11">
                            producer:</td>
                        <td class="style8">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("Producer") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td class="style13">
                            price:</td>
                        <td class="style9">
                            <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("Price") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td class="style13">
                            <asp:HyperLink ID="HyperLink2" runat="server">Add Cart</asp:HyperLink>
                        </td>
                        <td class="style9">
                            &nbsp;</td>
                    </tr>
                </table>
                <br />
            </td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server" style="width: 509px">
                <tr runat="server">
                    <td runat="server">
                        <table ID="groupPlaceholderContainer" runat="server" border="0" style="">
                            <tr ID="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="">
                        <asp:DataPager ID="DataPager1" runat="server" PageSize="4">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        
    </asp:ListView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="FbProduct" DeleteMethod="DeleteFbProduct" InsertMethod="AddFbProduct" SelectMethod="FindFbProduct" TypeName="FbProductBLL" UpdateMethod="EditFbProduct" >
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <SelectParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>