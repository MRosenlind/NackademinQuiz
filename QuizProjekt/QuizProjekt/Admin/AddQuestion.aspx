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
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test %>" SelectCommand="SELECT [Id], [Name] FROM [Tests]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />

    </p>
    
    
</asp:Content>
