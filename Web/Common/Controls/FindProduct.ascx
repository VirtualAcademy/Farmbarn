<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FindProduct.ascx.cs" Inherits="Web_Common_Controls_FindProduct" %>
<style type="text/css">
    .style1
    {
        width: 190px;
        height: 179px;
    }
    .style2
    {
        text-align: left;
    }
</style>
<table class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td style="margin:0; padding:0;" class="style2">
<b style="text-align:left">Search:</b></td>
    </tr>
    <tr>
        <td class="style2">
<asp:RadioButtonList ID="RadFindFlag" runat="server">
    <asp:ListItem Value="0">Search by Product Name</asp:ListItem>
    <asp:ListItem Value="1">Search by Producer</asp:ListItem>
</asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="style2" style="text-align:center">
<asp:TextBox ID="TxtFindText" runat="server" Width="131px" Height="18px" 
                style="text-align: center"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style2" style="text-align:center" >
        <br />
<asp:Button ID="Button1" runat="server" Text="Search" 
    PostBackUrl="~/web/Product/ProductBrowse.aspx" onclick="Button1_Click" />
    <br />
        </td>
    </tr>
</table>
<br />
<br />
