<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="OtherPageManual.aspx.cs" Inherits="WebApplication4.Pages.OtherPageManual" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyPlaceHolder" runat="server">
    <asp:Label ID="MyLabel" runat="server" Text="Nothing!!"></asp:Label>
    <br />
    <br />
    <asp:Button ID="LoadButton" runat="server" Text="Load data" OnClick="LoadButton_Click" />
</asp:Content>
