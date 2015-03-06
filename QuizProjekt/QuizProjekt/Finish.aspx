<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="QuizProjekt.Finish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
            <div id="h1">
            <asp:Label runat="server" Text="MM Quizes"></asp:Label>
                </div>
        
            </div>
    <asp:Repeater ID="Answers" runat ="server">
            <ItemTemplate>
                <div>
                    <%#Eval("Key") %> -  <%#Eval("Value") %> 
                </div>
            </ItemTemplate>
        </asp:Repeater>
    <asp:Label ID="lblScore" runat="server"></asp:Label>
    <br />
    <br />
        <asp:Button ID="btnStartpage" runat="server" OnClick="btnStartpage_Click" Text="Startsida" />
        <br />
    
</asp:Content>
