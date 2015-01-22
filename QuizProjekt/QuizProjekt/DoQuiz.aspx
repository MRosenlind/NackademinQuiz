<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoQuiz.aspx.cs" Inherits="QuizProjekt.DoQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Text" DataValueField="Id">
        </asp:RadioButtonList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAlternatives" TypeName="QuizProjekt.Services.AlternativeService">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="questionId" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Button ID="btnNextQuestion" runat="server" OnClick="btnNextQuestion_Click" Text="Nästa fråga" />
        <br />
    </p>
</asp:Content>
