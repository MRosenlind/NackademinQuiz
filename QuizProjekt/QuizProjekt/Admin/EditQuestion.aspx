<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditQuestion.aspx.cs" Inherits="QuizProjekt.Admin.EditQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:TextBox ID="txtAlternative" runat="server"></asp:TextBox>
    <br />
        <br />
    
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:CheckBoxField DataField="Correct" HeaderText="Correct" SortExpression="Correct" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Test %>" DeleteCommand="DELETE FROM [Alternatives] WHERE [Id] = @original_Id AND (([Text] = @original_Text) OR ([Text] IS NULL AND @original_Text IS NULL)) AND [Correct] = @original_Correct" InsertCommand="INSERT INTO [Alternatives] ([Text], [Correct]) VALUES (@Text, @Correct)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Text], [Correct], [Id] FROM [Alternatives]" UpdateCommand="UPDATE [Alternatives] SET [Text] = @Text, [Correct] = @Correct WHERE [Id] = @original_Id AND (([Text] = @original_Text) OR ([Text] IS NULL AND @original_Text IS NULL)) AND [Correct] = @original_Correct">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Text" Type="String" />
                <asp:Parameter Name="original_Correct" Type="Boolean" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Text" Type="String" />
                <asp:Parameter Name="Correct" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Text" Type="String" />
                <asp:Parameter Name="Correct" Type="Boolean" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Text" Type="String" />
                <asp:Parameter Name="original_Correct" Type="Boolean" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
        
        <br />
        <br />
        <asp:Button ID="btnSaveToStart" runat="server" OnClick="btnSaveToStart_Click" Text="Spara -&gt; Startsida" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveToAlternative" runat="server" OnClick="btnSaveToAlternative_Click" Text="Spara -&gt; Svarsalternativ" />
        <br />
    </p>
</asp:Content>
