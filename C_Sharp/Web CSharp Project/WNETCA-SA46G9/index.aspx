<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WNETCA_SA46G9.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-3">

                <h1 class="my-4">T9 Book</h1>
                <div class="list-group">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddl_cat" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_cat_SelectedIndexChanged" AppendDataBoundItems="True" Font-Bold="True" ForeColor="Black" Height="40px">
                                <asp:ListItem>Choose by category</asp:ListItem>

                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

            </div>

            <!-- /.col-lg-3 -->

            <div class="col-lg-9">
                <div>
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>

                            <asp:TextBox ID="txt_search" runat="server"></asp:TextBox><asp:Button ID="btn_search" runat="server" Text="Search for book" OnClick="btn_search_Click"  />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
                <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                        <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                    </ol>
                    <div class="carousel-inner" role="listbox">
                        <div class="carousel-item active">
                            <img class="d-block img-fluid" src="Images/mh-1.png" alt="First slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="Images/mh-2.png" alt="Second slide">
                        </div>
                        <div class="carousel-item">
                            <img class="d-block img-fluid" src="Images/mh-3.png" alt="Third slide">
                        </div>
                    </div>
                    <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>

                <div class="row" style="margin: auto;">

                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="true" style="margin: auto; width: 100%;">
                        <ContentTemplate>
                            <asp:ListView ID="lvbook" runat="server" GroupItemCount="3" OnPreRender="lvbook_PreRender" OnDataBound="lvbook_DataBound">
                                <EmptyDataTemplate>
                                    <table>
                                        <tr>
                                            <td>No record found.</td>
                                        </tr>
                                    </table>
                                </EmptyDataTemplate>

                                <GroupTemplate>
                                    <tr id="itemPlaceholderContainer" runat="server" style="margin: auto; vertical-align: top; min-height: 375px;">
                                        <td id="itemPlaceholder" runat="server"></td>
                                    </tr>
                                </GroupTemplate>
                                <ItemTemplate>
                                    <td runat="server">

                                        <div class="col-lg-3 col-xs-3">
                                            <div class="card h-100">
                                                <div class="book-img">
                                                    <image class="" src="images/<%# Eval("ISBN") %>.jpg" width="120" height="150"></image>
                                                </div>
                                                <div class="card-body">
                                                    <h5>
                                                        <%#Eval("Title")%>
                                                    </h5>

                                                    <h4><%#Eval("Author")%></h4>
                                                    <p class="card-text"><%# String.Format("{0:c}",Eval("Price"))%></p>
                                                    <asp:Button Text="Buy" runat="server" CssClass="btn btn-info" CommandName="BuyBook" CommandArgument=<%#Eval("book_id")%> OnCommand="BuyCheck"/>
                                                    <a style="float:right; padding-top:7px;" href="BookDetail?book_id=<%#Eval("book_id")%>">More info</a>


                                                </div>
                                            </div>
                                        </div>

                                    </td>
                                </ItemTemplate>
                                <LayoutTemplate>
                                    <table style="width: 100%;">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                                        <tr id="groupPlaceholder"></tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                            </tr>
                                            <tr></tr>
                                        </tbody>
                                    </table>
                                    <div class="pagination">
                                        <asp:DataPager ID="ProductDataPager" runat="server" PagedControlID="lvbook" class="btn-group btn-group-sm" PageSize="12">
                                            <Fields>
                                                <asp:NextPreviousPagerField PreviousPageText="<" ShowPreviousPageButton="true"
                                                    ShowFirstPageButton="true" ShowNextPageButton="false" FirstPageText="|<" ShowLastPageButton="false"
                                                    ButtonCssClass="btn btn-outline-info" RenderNonBreakingSpacesBetweenControls="false" RenderDisabledButtonsAsLabels="false" />
                                                <asp:NumericPagerField ButtonType="Link" CurrentPageLabelCssClass="btn btn-success disabled" RenderNonBreakingSpacesBetweenControls="false"
                                                    NumericButtonCssClass="btn btn-outline-info" ButtonCount="10" NextPageText="..." NextPreviousButtonCssClass="btn btn-default" />
                                                <asp:NextPreviousPagerField NextPageText=">" LastPageText=">|" ShowNextPageButton="true"
                                                    ShowLastPageButton="true" ShowPreviousPageButton="false" ShowFirstPageButton="false"
                                                    ButtonCssClass="btn btn-outline-info" RenderNonBreakingSpacesBetweenControls="false" RenderDisabledButtonsAsLabels="false" />
                                            </Fields>
                                        </asp:DataPager>
                                    </div>
                                </LayoutTemplate>

                            </asp:ListView>
                        </ContentTemplate>
                    </asp:UpdatePanel>



                </div>
                <!-- /.row -->

            </div>
            <!-- /.col-lg-9 -->

        </div>
        <!-- /.row -->

    </div>
<%--    <div class="modal fade product_view" id="product_view">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <a href="#" data-dismiss="modal" class="class pull-right"><span class="glyphicon glyphicon-remove"></span></a>
                    <h3 class="modal-title">Book Info</h3>
                </div>
                <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:FormView ID="bookDetail" runat="server" SelectMethod="GetProduct" RenderOuterTable="false">
                                    <ItemTemplate>

                                        <div class="card flex-md-row mb-4 box-shadow h-md-250">
                                            <div class="card-body d-flex flex-column align-items-start">
                                                <img class="card-img-right flex-auto d-none d-md-block" data-src="holder.js/200x250?theme=thumb" alt="Thumbnail [200x250]" style="width: 200px; height: 250px;" src="images/<%# Eval("ISBN") %>.jpg" data-holder-rendered="true">
                                                <h3 class="mb-0">
                                                    <a class="text-dark" href="#"><%#Eval("Title")%></a>
                                                </h3>
                                                <div class="mb-1 text-muted">Author: <%#Eval("Author")%></div>
                                                <div class="mb-1 text-muted">ISBN: Number <%#Eval("ISBN")%></div>

                                                <div class="mb-1 text-muted">Price: <%# String.Format("{0:c}",Eval("Price"))%></div>
                                                <p class="card-text mb-auto">This is a wider card with supporting text below as a natural lead-in to additional content.</p>
                                                <a href="#">Continue reading</a>

                                            </div>

                                        </div>



                                    </ItemTemplate>
                                </asp:FormView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
    <!-- /.container -->
</asp:Content>
