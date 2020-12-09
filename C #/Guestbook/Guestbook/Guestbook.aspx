<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Guestbook.aspx.cs" Inherits="Guestbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guestbook</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 387px;
        }
        .auto-style3 {
            width: 387px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .textBoxWidth {
            width: 300px;
        }
        .textBoxHeight {
            height: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Please leave a message in our guestbook:</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name:</td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server" CssClass="textBoxWidth"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="nameRequiredFieldValidator" runat="server" ControlToValidate="nameTextBox" Display="Dynamic" ErrorMessage="Please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">E-mail:</td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server" CssClass="textBoxWidth"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Please enter a email address" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Please enter a email address in a valid format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Tell the world:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="messageTextBox" runat="server" CssClass="textBoxWidth textBoxHeight"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="messageRequiredFieldValidator" runat="server" ControlToValidate="messageTextBox" Display="Dynamic" ErrorMessage="Please enter a message" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
&nbsp;<asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" Width="64px" />
                </td>
            </tr>
        </table>
    
    </div>
        <asp:GridView ID="messagesGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MessageID" DataSourceID="messagesEntityDataSource" ForeColor="#333333" GridLines="None" Width="784px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Message1" HeaderText="Message" SortExpression="Message1" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:EntityDataSource ID="messagesEntityDataSource" runat="server" ConnectionString="name=GuestbookEntities" DefaultContainerName="GuestbookEntities" EnableFlattening="False" EntitySetName="Messages">
        </asp:EntityDataSource>
    </form>
</body>
</html>
