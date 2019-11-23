<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SendingControl.ascx.cs" Inherits="EmailClient.Controls.SendingControl" %>

<h1>
    <asp:Label runat="server" ID="NewMessageLabel" />
</h1>
<asp:TextBox ID="Recipient" runat="server" MaxLength="320" Rows="1" Width="60%"></asp:TextBox>
<br />
<asp:TextBox ID="Content" runat="server" onKeyUp="SaveToSession()" Rows="10" Style="margin-top: 0px" Width="100%" TextMode="MultiLine"></asp:TextBox>
<br />
<asp:Label runat="server" CssClass="text-danger" ID="ValidationMessage" />
<div style="margin-top: 1%">
    <asp:Button runat="server" Text="Send" ID="SendMail" CssClass="btn btn-secondary" Width="100%" OnClick="SendMail_Click" />
</div>

