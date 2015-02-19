<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddQuestion.aspx.cs" Inherits="QuizProjekt.Admin.AddQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="header">
      <div id="h1">
        MM Quizes
      </div> 
        </div>
    <p>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Lägg till frågor till quiz"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Fyll i din fråga"></asp:Label>
        <br />
        <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtQuestion" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
      <br />
        <br />
        <br />
        <asp:Button ID="btnQuestSubmit" runat="server" OnClick="btnQuestSubmit_Click" Text="Nästa" />
        <br />

    </p>
    
    
</asp:Content>
