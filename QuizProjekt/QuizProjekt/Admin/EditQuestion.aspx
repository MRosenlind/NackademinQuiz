<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditQuestion.aspx.cs" Inherits="QuizProjekt.Admin.EditQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Lägg till alternativ"></asp:Label>
        <br />
        <asp:TextBox ID="txtAlternative" runat="server"></asp:TextBox>
    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAlternative" ErrorMessage="*" ForeColor="Red" ValidationGroup="valTxt"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:CheckBox ID="chechBoxRight" runat="server" Text="Rätt svar" />
    </p>
    <p>
    <br />
        <br />
    
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:CheckBoxField DataField="Correct" HeaderText="Correct" SortExpression="Correct" />
<asp:BoundField DataField="Question_Id" SortExpression="Question_Id"></asp:BoundField>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Test %>" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Id], [Text], [Correct], [Question_Id] FROM [Alternatives] WHERE ([Question_Id] = @Question_Id)" DeleteCommand="DELETE FROM [Alternatives] WHERE [Id] = @original_Id" InsertCommand="INSERT INTO [Alternatives] ([Text], [Correct], [Question_Id]) VALUES (@Text, @Correct, @Question_Id)" UpdateCommand="UPDATE [Alternatives] SET [Text] = @Text, [Correct] = @Correct, [Question_Id] = @Question_Id WHERE [Id] = @original_Id">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Text" Type="String" />
                <asp:Parameter Name="Correct" Type="Boolean" />
                <asp:Parameter Name="Question_Id" Type="Int32" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="Question_Id" QueryStringField="Id" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Text" Type="String" />
                <asp:Parameter Name="Correct" Type="Boolean" />
                <asp:Parameter Name="Question_Id" Type="Int32" />
                <asp:Parameter Name="original_Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
        
        <br />
        <br />
        <asp:Button ID="btnSaveToStart" runat="server" OnClick="btnSaveToStart_Click" Text="Spara -&gt; Startsida" ValidationGroup="valTxt" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSaveToAlternative" runat="server" OnClick="btnSaveToAlternative_Click" Text="Spara -&gt; Svarsalternativ" />
        <br />
    </p>
</asp:Content>
