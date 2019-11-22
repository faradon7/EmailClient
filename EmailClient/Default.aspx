<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmailClient._Default" %>

<%@ Register Src="~/Controls/SendingForm.ascx" TagPrefix="send" TagName="SendingForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" SelectMethod="frm_GetItem" UpdateMethod="frm_UpdateItem" DataKeyNames="Id" runat="server">
    <h1>
        <asp:Label runat="server" ID="NewMessage" />
    </h1>
    <asp:TextBox ID="ToID" runat="server" MaxLength="320" Rows="1" Width="60%"></asp:TextBox>
    <br />
    <asp:TextBox ID="MessageID" runat="server" onKeyUp="SaveToSession()" Rows="10" Style="margin-top: 0px" Width="100%" TextMode="MultiLine"></asp:TextBox>
    <br />
    <div style="margin-top: 1%">
        <send:SendingForm runat="server" ID="SendingForm1" OnSend="OnSend" />
    </div>
</asp:Content>
