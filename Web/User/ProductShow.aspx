<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductShow.aspx.cs" Inherits="Web_User_ProductShow" Theme="Farm_Theme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 491px;
        }
        .style2
        {
            width: 250px;
        }
        .style3
        {
            height: 44px;
            text-align: left;
        }
        .style8
        {
            height: 42px;
            text-align: left;
        }
        .style9
        {
            height: 314px;
            text-align: left;
        }
        .style11
        {
            height: 47px;
            text-align: left;
        }
        .style12
        {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <center>
    <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" 
        style="text-align: center" Width="794px">
        <EditItemTemplate>
            ID:
            <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
            <br />
            CatID:
            <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
            <br />
            BsCategory:
            <asp:TextBox ID="BsCategoryTextBox" runat="server" 
                Text='<%# Bind("BsCategory") %>' />
            <br />
            Name:
            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
            <br />
            Image:
            <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
            <br />
            Price:
            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
            <br />
            Summary:
            <asp:TextBox ID="SummaryTextBox" runat="server" Text='<%# Bind("Summary") %>' />
            <br />
            Producer:
            <asp:TextBox ID="ProducerTextBox" runat="server" Text='<%# Bind("Producer") %>' />
            <br />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" 
                CommandName="Update" Text="Update" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </EditItemTemplate>
        <InsertItemTemplate>
            ID:
            <asp:TextBox ID="IDTextBox" runat="server" Text='<%# Bind("ID") %>' />
            <br />
            CatID:
            <asp:TextBox ID="CatIDTextBox" runat="server" Text='<%# Bind("CatID") %>' />
            <br />
            BsCategory:
            <asp:TextBox ID="BsCategoryTextBox" runat="server" 
                Text='<%# Bind("BsCategory") %>' />
            <br />
            Name:
            <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
            <br />
            Image:
            <asp:TextBox ID="ImageTextBox" runat="server" Text='<%# Bind("Image") %>' />
            <br />
            Price:
            <asp:TextBox ID="PriceTextBox" runat="server" Text='<%# Bind("Price") %>' />
            <br />
            Summary:
            <asp:TextBox ID="SummaryTextBox" runat="server" Text='<%# Bind("Summary") %>' />
            <br />
            Producer:
            <asp:TextBox ID="ProducerTextBox" runat="server" Text='<%# Bind("Producer") %>' />
            <br />
            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                CommandName="Insert" Text="Insert" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" 
                CausesValidation="False" CommandName="Cancel" Text="Cancel" />
        </InsertItemTemplate>
        <ItemTemplate>
            <table class="style1">
                <tr>
                    <td class="style2" rowspan="5">
                        <asp:Image ID="Image1" runat="server" Height="383px" 
                            ImageUrl='<%# Eval("Image","~/Web/Common/ProductImages/{0}") %>' 
                            Width="237px" />
                    </td>
                    <td class="style11">
                        ProductName:<asp:Literal ID="Literal1" runat="server" Text='<%# Eval("Name") %>'></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        Summary:</td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("Summary") %>'></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        Price:<asp:Literal ID="Literal3" runat="server" Text='<%# Eval("Price") %>'></asp:Literal>
                    </td>
                </tr>
                <tr>
                    <td class="style12">
                        Producer:<asp:Literal ID="Literal4" runat="server" Text='<%# Eval("Producer") %>'></asp:Literal>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
    </center>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DataObjectTypeName="BsProduct" DeleteMethod="DeleteBsProduct" 
        InsertMethod="AddBsProduct" SelectMethod="FindBsProduct" TypeName="BsProductBLL" 
        UpdateMethod="EditBsProduct">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    </form>
</body>
</html>
