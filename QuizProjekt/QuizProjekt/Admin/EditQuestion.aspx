<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditQuestion.aspx.cs" Inherits="QuizProjekt.Admin.EditQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Lägg till alternativ"></asp:Label>
        <br />
        <asp:TextBox ID="txtAlternative" runat="server"></asp:TextBox>
    <br />
        <br />
    
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CheckBoxField DataField="Correct" HeaderText="Correct" SortExpression="Correct" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Correct], [Text], [Id] FROM [Alternatives] WHERE ([Question_Id] = @Question_Id)">
            <SelectParameters>
                <asp:QueryStringParameter Name="Question_Id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
        
        <br />
        <br />
        <asp:Button ID="btnSaveToStart" runat="server" OnClick="btnSaveToStart_Click" Text="Spara -&gt; Startsida" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveToAlternative" runat="server" OnClick="btnSaveToAlternative_Click" Text="Spara -&gt; Svarsalternativ" />
        <br />
    </p>
</asp:Content>
