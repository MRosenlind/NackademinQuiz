<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditQuiz.aspx.cs" Inherits="QuizProjekt.Admin.EditQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
      <div id="h1">
        MM Quizes
      </div> 
        </div>
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Namn"></asp:Label>
        <br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Beskrivning"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <asp:CheckBox ID="checkBoxPublic" runat="server" Text="Publik" />
    <br />
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test %>" SelectCommand="SELECT [Id], [Text] FROM [Questions]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="btnSaveBack" runat="server" OnClick="btnSaveBack_Click" Text="Spara -&gt; Tillbaka" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveToQuestions" runat="server" OnClick="btnSaveToQuestions_Click" Text="Spara -&gt; Frågor" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Ta bort" />
        <br />
    </p>
</asp:Content>
