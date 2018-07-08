<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WNETWorkshop.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 122px;
        }
        .auto-style4 {
            width: 742px;
        }
        .auto-style5 {
            width: 742px;
            height: 81px;
        }
        .auto-style6 {
            height: 81px;
        }
    </style>
</head>
<body style="height: 107px">
    <form id="form1" runat="server">
        <div style="font-size: x-large; font-weight: bold">
            Welcome to ISS Food Ordering System<br />
            <br />
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="63px">
            <asp:Label ID="Label1" runat="server" Text="Please choose your identity:"></asp:Label>
            <asp:DropDownList ID="DropDownListName" runat="server" DataSourceID="EntityDataSource1" DataTextField="CustomerName" DataValueField="CustomerName" Height="24px" OnSelectedIndexChanged="DropDownListName_SelectedIndexChanged" OnLoad="DropDownListName_Load">
            </asp:DropDownList>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=WNETWSEntities" DefaultContainerName="WNETWSEntities" EnableFlattening="False" EntitySetName="Customers" Select="it.[CustomerName]">
            </asp:EntityDataSource>
        </asp:Panel>        
        <asp:Panel ID="Panel2" runat="server" Height="337px" style="margin-top: 0px" Width="1138px" BorderStyle="Ridge" Wrap="False">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">
                        <asp:RadioButtonList ID="RadioButtonListFood" runat="server" DataSourceID="EntityDataSource2" DataTextField="FoodName" DataValueField="FoodName" OnSelectedIndexChanged="RadioButtonListFood_SelectedIndexChanged">
                        </asp:RadioButtonList>
                        <asp:EntityDataSource ID="EntityDataSource2" runat="server" ConnectionString="name=WNETWSEntities" DefaultContainerName="WNETWSEntities" EnableFlattening="False" EntitySetName="FoodMenus" Select="it.[FoodName]">
                        </asp:EntityDataSource>
                    </td>
                    <td class="auto-style6">
                        <asp:RadioButtonList ID="RadioButtonListSalt" runat="server" OnSelectedIndexChanged="RadioButtonListSalt_SelectedIndexChanged">
                            <asp:ListItem>No Salt</asp:ListItem>
                            <asp:ListItem>Less Salt</asp:ListItem>
                            <asp:ListItem>More Salt</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style6">
                        <asp:RadioButtonList ID="RadioButtonListChili" runat="server" OnSelectedIndexChanged="RadioButtonListChili_SelectedIndexChanged">
                            <asp:ListItem>No Chili</asp:ListItem>
                            <asp:ListItem>Less Chili</asp:ListItem>
                            <asp:ListItem>More Chili</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:RadioButtonList ID="RadioButtonListSize" runat="server" OnSelectedIndexChanged="RadioButtonListSize_SelectedIndexChanged">
                            <asp:ListItem>Small</asp:ListItem>
                            <asp:ListItem>Medium</asp:ListItem>
                            <asp:ListItem>Large</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxListPepper" runat="server" OnSelectedIndexChanged="CheckBoxListPepper_SelectedIndexChanged">
                            <asp:ListItem>Add Pepper</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:GridView ID="GridViewTransactions" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="TransactionID" DataSourceID="EntityDataSource3" AllowPaging="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="TransactionID" HeaderText="TransactionID" ReadOnly="True" SortExpression="TransactionID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="FoodID" HeaderText="FoodID" SortExpression="FoodID" />
                <asp:BoundField DataField="OrderOptions" HeaderText="OrderOptions" SortExpression="OrderOptions" />
                <asp:BoundField DataField="OrderSize" HeaderText="OrderSize" SortExpression="OrderSize" />
                <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:Button ID="ButtonSubmit" runat="server" OnClick="ButtonSubmit_Click" Text="Submit" />
        <asp:EntityDataSource ID="EntityDataSource3" runat="server" ConnectionString="name=WNETWSEntities" DefaultContainerName="WNETWSEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Transactions">
        </asp:EntityDataSource>
    </form>
</body>
</html>
