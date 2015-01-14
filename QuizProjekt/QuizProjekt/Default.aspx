<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuizProjekt.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="QuizList" runat="server">
        <ItemTemplate>
            <div>
                <br />
                <div><a href="DoQuiz.aspx?id=<%#Eval("Id") %>"><%#Eval("Name") %> 
                     </a>
                </div>
                    <br />
                    <div><%#Eval("Description") %></div>
                <br />
            </div>
        </ItemTemplate>
    </asp:Repeater>
       
</asp:Content>
