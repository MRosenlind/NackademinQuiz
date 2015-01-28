<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateQuiz.aspx.cs" Inherits="QuizProjekt.Admin.CreateQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
      <div id="h1">
        MM Quizes
      </div> 
        </div>
    <asp:Label ID="Label1" Font-Size="Larger" runat="server" Text="Skapa nytt quiz"></asp:Label>
   
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*" ForeColor="Red" ValidationGroup="txtVal"></asp:RequiredFieldValidator>
    <br />
   
    
&nbsp;
    <br />
    <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
    <br />
    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescription" ErrorMessage="*" ForeColor="Red" ValidationGroup="txtVal"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="lblPublic" runat="server" Text="Publik"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="CheckBoxPublic" runat="server" />
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server"  OnClick="btnSubmit_Click" Text="Skapa" ValidationGroup="txtVal" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Size="Larger" Text="Redigera quiz"></asp:Label>
    <br />
    <br />
    <asp:DropDownList ID="DdlQuizList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click"  Text="Redigera" />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test %>" SelectCommand="SELECT [Id], [Name] FROM [Tests]"></asp:SqlDataSource>
</asp:Content>
