<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="QuizProjekt.Finish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
            <div id="h1">
            <asp:Label runat="server" Text="MM Quizes"></asp:Label>
                </div>
            </div>
    <br />
        <asp:Button ID="btnStartpage" runat="server" OnClick="btnStartpage_Click" Text="Startsida" />
        <br />
    
</asp:Content>
