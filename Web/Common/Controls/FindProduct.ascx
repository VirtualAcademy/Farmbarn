<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FindProduct.ascx.cs" Inherits="Web_Common_Controls_FindProduct" %>
<style type="text/css">
    .style1
    {
        width: 200px;
        height: 75px;
    }
    .style2
    {
        text-align: left;
        height:17px;
    }
    .auto-style1 {
        text-align: left;
        height: 17px;
    }
    .auto-style2 {
        text-align: left;
        height: 17px;
    }
</style>
<table class="style1" cellpadding="0" cellspacing="0">
    <tr>
        <td class="auto-style1" colspan="2">
<asp:RadioButtonList ID="RadFindFlag" runat="server" RepeatDirection="Horizontal" Width="300px">
    <asp:ListItem Value="0">By Product</asp:ListItem>
    <asp:ListItem Value="1">By Producer</asp:ListItem>
</asp:RadioButtonList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2" style="text-align:center">
<asp:TextBox ID="TxtFindText" runat="server" Width="400px" Height="18px" 
                style="text-align: center"></asp:TextBox>
        </td>
        <td class="auto-style2" style="text-align:center">
<asp:Button ID="Button1" runat="server" Text="Search" 
    PostBackUrl="~/web/Product/ProductBrowse.aspx" onclick="Button1_Click" />
            </td>
    </tr>
</table>
<br />
<br />
