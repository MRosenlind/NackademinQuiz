<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoQuiz.aspx.cs" Inherits="QuizProjekt.DoQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblQuestion" runat="server"></asp:Label>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Text" DataValueField="Id">
        </asp:RadioButtonList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test %>" SelectCommand="SELECT [Id], [Text], [Correct], [Question_Id] FROM [Alternatives] WHERE ([Question_Id] = @Question_Id)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="Question_Id" QueryStringField="Id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="btnNextQuestion" runat="server" OnClick="btnNextQuestion_Click" Text="Nästa fråga" />
        <br />
    </p>
</asp:Content>
