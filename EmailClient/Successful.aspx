<%@ Page Title="Successful" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Successful.aspx.cs" Inherits="EmailClient.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <asp:Label ID="SuccessFulMessage" runat="server"></asp:Label>
</asp:Content>
