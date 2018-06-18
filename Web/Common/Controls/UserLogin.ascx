<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLogin.ascx.cs" Inherits="Web_Common_Controls_UserLogin" %>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="View1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="#E6E2D8" Height="90px" Width="190px"
            HorizontalAlign="Center">
            Name&nbsp;&nbsp;<asp:TextBox ID="TxtUserName" runat="server" Width="110"></asp:TextBox><br />
            Password&nbsp;&nbsp;<asp:TextBox ID="TxtUserPwd" runat="server" TextMode="Password" Width="110"></asp:TextBox><br />
            &nbsp;
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
            <br />
        </asp:Panel>
    </asp:View>
    <asp:View ID="View2" runat="server">
        <asp:Panel ID="Panel2" runat="server" BackColor="#E6E2D8" Height="90px" Width="190px"
            HorizontalAlign="Center">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:LinkButton ID="LogoutButton" runat="server" OnClick="LogoutButton_Click">Logout</asp:LinkButton>&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Web/User/UserEdit.aspx">UpDate</asp:HyperLink>
            <br />
            <br />
        </asp:Panel>
    </asp:View>
</asp:MultiView>
