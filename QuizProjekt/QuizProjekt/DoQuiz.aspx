<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoQuiz.aspx.cs" Inherits="QuizProjekt.DoQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataTextField="Text" DataValueField="Id">
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="btnNextQuestion" runat="server" OnClick="btnNextQuestion_Click" Text="Nästa fråga" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPreviousQuestion" runat="server" OnClick="btnPreviousQuestion_Click" Text="Förgående fråga" />
        <br />
    </p>
</asp:Content>
