<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditQuestion.aspx.cs" Inherits="QuizProjekt.Admin.EditQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
    <br />
        <br />
    
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetQuestions" TypeName="QuizProjekt.Services.QuestionService">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="quizId" QueryStringField="Id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    
        
        <br />
        <br />
        <asp:Button ID="btnSaveToStart" runat="server" OnClick="btnSaveToStart_Click" Text="Spara -&gt; Startsida" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveToAlternative" runat="server" OnClick="btnSaveToAlternative_Click" Text="Spara -&gt; Svarsalternativ" />
        <br />
    </p>
</asp:Content>
