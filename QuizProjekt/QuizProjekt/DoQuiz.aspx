<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoQuiz.aspx.cs" Inherits="QuizProjekt.DoQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnPreviousQuestion" runat="server" Text="Förgående" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNextQuestion" runat="server" Text="Nästa" OnClick="btnNextQuestion_Click" />
        <br />
    </p>
</asp:Content>
