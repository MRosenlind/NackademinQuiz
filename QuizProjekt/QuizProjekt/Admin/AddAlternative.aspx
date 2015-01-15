<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAlternative.aspx.cs" Inherits="QuizProjekt.Admin.AddAlternative" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Lägg till svarsalternativ:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CheckBox ID="CheckBoxRattSvar" runat="server" Text="Rätt svar" />
        <br />
        <br />
        <asp:Button ID="btnLaggTill" runat="server" OnClick="btnLaggTill_Click" Text="Lägg till alternativ" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAvsluta" runat="server" OnClick="btnAvsluta_Click" Text="Avsluta" />
        <br />

    </p>
</asp:Content>
