<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website_Project_Address.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        Please type in the first and last name of the customer to find their address.<br />
        Once both are typed in press Enter or click outside on an empty white space.<br />
        To search for another customer&#39;s address simply replace the first and last names with the new names.<br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" SelectCommand="SELECT [CustAddress], [CustFName], [CustLName] FROM [Customers] WHERE (([CustFName] = @CustFName) AND ([CustLName] = @CustLName))">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtFName" Name="CustFName" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtLName" Name="CustLName" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:Label ID="lblName" runat="server" Text="First Name:"></asp:Label>
        <asp:TextBox ID="txtFName" runat="server" AutoPostBack="True" TabIndex="1"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
        <asp:TextBox ID="txtLName" runat="server" AutoPostBack="True" TabIndex="2"></asp:TextBox>
        <br />
        <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" OnPageIndexChanging="FormView1_PageIndexChanging">
            <EditItemTemplate>
                CustAddress:
                <asp:TextBox ID="CustAddressTextBox" runat="server" Text='<%# Bind("CustAddress") %>' />
                <br />
                CustFName:
                <asp:TextBox ID="CustFNameTextBox" runat="server" Text='<%# Bind("CustFName") %>' />
                <br />
                CustLName:
                <asp:TextBox ID="CustLNameTextBox" runat="server" Text='<%# Bind("CustLName") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                CustAddress:
                <asp:TextBox ID="CustAddressTextBox" runat="server" Text='<%# Bind("CustAddress") %>' />
                <br />
                CustFName:
                <asp:TextBox ID="CustFNameTextBox" runat="server" Text='<%# Bind("CustFName") %>' />
                <br />
                CustLName:
                <asp:TextBox ID="CustLNameTextBox" runat="server" Text='<%# Bind("CustLName") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                <asp:Label ID="CustFNameLabel" runat="server" Text='<%# Bind("CustFName") %>' />
&nbsp;<asp:Label ID="CustLNameLabel" runat="server" Text='<%# Bind("CustLName") %>' />
                &nbsp;lives in
                <asp:Label ID="CustAddressLabel" runat="server" Text='<%# Bind("CustAddress") %>' />
                <br />
            </ItemTemplate>
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        </asp:FormView>
        <br />
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" Visible="False" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Visible="False" />
    </form>
</body>
</html>
