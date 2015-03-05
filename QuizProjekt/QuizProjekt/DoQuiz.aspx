<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoQuiz.aspx.cs" Inherits="QuizProjekt.DoQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
      <div id="h1">
        MM Quizes
      </div> 
        </div>
        <div id="doQuiz">
        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
        <asp:Label ID="lblFinish" runat="server" Text="Du har nu svarat på alla frågor. &lt;br/&gt;Klicka på avsluta för att se ditt resultat!"></asp:Label>
        <br />
            <asp:Image ID="Image1" runat="server" Height="215px" Width="320px" />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataTextField="Text" DataValueField="Id">
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="btnNextQuestion" runat="server" OnClick="btnNextQuestion_Click" Text="Nästa fråga" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPreviousQuestion" runat="server" OnClick="btnPreviousQuestion_Click" Text="Förgående fråga" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFinish" runat="server" OnClick="btnFinish_Click" Text="Avsluta quiz" />
        <br />
            </div>
    
</asp:Content>
