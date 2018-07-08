<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BookDetail.aspx.cs" Inherits="WNETCA_SA46G9.BookDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <div class="row">
        <div class="col-md-12">
            <asp:FormView ID="bookDetail" runat="server" SelectMethod="GetProduct" RenderOuterTable="false" OnPageIndexChanging="bookDetail_PageIndexChanging">
                <ItemTemplate>

                    <div class="card flex-md-row mb-4 box-shadow h-md-250 card-dt">
                        <div class="card-body d-flex flex-column align-items-start">
                             
                            <h3 class="mb-0">
                                <a class="text-dark" href="#"><%#Eval("Title")%></a>
                            </h3>
                            <div class="mb-1 text-muted">Author: <%#Eval("Author")%></div>
                            <div class="mb-1 text-muted">ISBN: Number <%#Eval("ISBN")%></div>
                           
                            <div class="mb-1 text-muted">Price: <%# String.Format("{0:c}",Eval("Price"))%></div>
                           
                          <asp:Button Text="Back" runat="server" CssClass="btn btn-info back" OnClick="Unnamed1_Click" />
                           
                        </div>
                        <img class="card-img-right flex-auto d-none d-md-block" data-src="holder.js/200x250?theme=thumb" alt="Thumbnail [200x250]" style="width: 200px; height: 250px;" src="images/<%# Eval("ISBN") %>.jpg" data-holder-rendered="true">
                    </div>



                </ItemTemplate>
            </asp:FormView>
        </div>
    </div>
        </div>
</asp:Content>
