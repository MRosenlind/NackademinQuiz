<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuizProjekt.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
      <div id="h1">
        MM Quizes
      </div>  
        
    </div>
    <div id="meny">
        <asp:Button ID="btnLogin" runat="server"  OnClick="btnLogin_Click" Text="Logga In" />
    </div>
    
    <div id="quiz-list">
        <ul>
            <li>En quiz <a href="#1">Starta</a></li>
            <li>En annan <a href="#2">Starta</a></li>
            <li>Fula frågor <a href="#3">Starta</a></li>
        </ul>
    </div>
    
    

    
    <asp:Repeater ID="QuizList" runat="server">
        <ItemTemplate>
            
            <div id="QuizDiv">
                <br />
                <div id="ListQuiz"><a href="DoQuiz.aspx?id=<%#Eval("Id") %>"><%#Eval("Name") %> </a>
                    <br />
                    <%#Eval("Description") %>
                    </div>
                
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    <br />
    
       
</asp:Content>
