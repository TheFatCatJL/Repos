<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.Master" CodeBehind="ViewMyCart.aspx.cs" Inherits="WNETCA_SA46G9.ViewMyCart" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label3" runat="server" Text="DearCustomer"></asp:Label></div>    
    <div>
            <div>  
                <asp:UpdatePanel ID="updatepanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ShopCartID" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand" OnRowDeleted="GridView1_RowDeleted">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText ="Book Cover">
                    <ItemTemplate>
                        <image src="images/<%# Eval("ISBN") %>.jpg" width="90" height="120"></image>
                    </ItemTemplate>
                            <ControlStyle BorderStyle="Solid" />
                </asp:TemplateField>
                        <asp:BoundField DataField="BookTitle" HeaderText="BookTitle" SortExpression="BookTitle" >                        
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" >                        
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" >
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Discount" HeaderText="Total Discount (%)" SortExpression="Discount" >
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Subtotal" HeaderText="Sub-total" SortExpression="Subtotal" >                        
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:ButtonField ButtonType="Image" HeaderText="DeleteBook" ImageUrl="~/Images/DeleteFromCart.PNG" CommandName="DeleteCart" ControlStyle-Height="20" ControlStyle-Width="20">
                        <ControlStyle Height="20px" Width="20px" />
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:ButtonField>
                        
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
        </ContentTemplate>
</asp:UpdatePanel>
            </div> <div><asp:Label ID="Label2" runat="server" Text="TotalDiscount"></asp:Label></div>
            <asp:Label ID="Label1" runat="server" Text="Subtotal"></asp:Label>
        </div>
    </asp:Content>
