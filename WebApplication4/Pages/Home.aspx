﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication4.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyPlaceHolder" runat="server">
    <p>My Page</p>
    <br />
    <br />
    <asp:Button ID="Nav" runat="server" Text="To next page" OnClick="Nav_Click" />

</asp:Content>
