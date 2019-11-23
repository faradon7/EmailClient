<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmailClient._Default" %>

<%@ Register Src="~/Controls/SendingControl.ascx" TagPrefix="send" TagName="SendingControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" SelectMethod="frm_GetItem" UpdateMethod="frm_UpdateItem" DataKeyNames="Id" runat="server">
   <send:SendingControl runat="server" ID="SendingControl1" OnSend="OnSend" />
</asp:Content>
