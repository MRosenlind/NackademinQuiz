<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditQuiz.aspx.cs" Inherits="QuizProjekt.Admin.EditQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
      <div id="h1">
        MM Quizes
      </div> 
        </div>
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Namn"></asp:Label>
        <br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*" ForeColor="Red" ValidationGroup="txtVal"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Beskrivning"></asp:Label>
        <br />
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescription" ErrorMessage="*" ForeColor="Red" ValidationGroup="txtVal"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:CheckBox ID="checkBoxPublic" runat="server" Text="Publik" />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Lägg till en fråga"></asp:Label>
    <br />
    
        <asp:TextBox ID="txtQuestion" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtQuestion" ErrorMessage="*" ForeColor="Red" ValidationGroup="txtVal"></asp:RequiredFieldValidator>
    </p>
    <p>
    
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EditQuestion.aspx?id={0}" DataTextField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" ShowHeader="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Test %>" DeleteCommand="DELETE FROM [Questions] WHERE [Id] = @original_Id AND (([Text] = @original_Text) OR ([Text] IS NULL AND @original_Text IS NULL))" InsertCommand="INSERT INTO [Questions] ([Text]) VALUES (@Text)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Id], [Text] FROM [Questions] WHERE ([Test_Id] = @Test_Id)" UpdateCommand="UPDATE [Questions] SET [Text] = @Text WHERE [Id] = @original_Id AND (([Text] = @original_Text) OR ([Text] IS NULL AND @original_Text IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Text" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Text" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="0" Name="Test_Id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="Text" Type="String" />
                <asp:Parameter Name="original_Id" Type="Int32" />
                <asp:Parameter Name="original_Text" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="btnSaveBack" runat="server" OnClick="btnSaveBack_Click" Text="Lägg till fråga" ValidationGroup="txtVal" />
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Startsidan" runat="server" OnClick="Startsidan_Click" Text="Startsidan" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Ta bort" />
        <br />
    </p>
</asp:Content>
