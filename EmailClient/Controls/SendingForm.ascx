<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SendingForm.ascx.cs" Inherits="EmailClient.Controls.SendingForm" %>

<%--<h1>
    <asp:Label runat="server" ID="NewMessage" />
</h1>
<asp:TextBox ID="EmailTo" runat="server" MaxLength="320" Rows="1" Width="60%"></asp:TextBox>
<br />
<asp:TextBox ID="InnerText" runat="server" Rows="10" Style="margin-top: 0px" Width="100%" TextMode="MultiLine"></asp:TextBox>
<br />--%>
    <asp:Button runat="server" Text="Send" ID="SendMail" CssClass="btn btn-secondary" Width="100%" OnClick="SendMail_Click" />
