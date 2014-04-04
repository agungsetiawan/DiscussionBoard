<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="DiscussionBoard.UI.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 default-container">
        <div class="well well-sm">
            <asp:Literal ID="literalHello" runat="server" />
        </div>

        <div class="panel panel-success panel-top-question">
            <div class="panel-heading top-question-heading">
                <h3 class="panel-title top-question-label">List Questions</h3>
            </div>
            <div class="panel-body">
                <%--<asp:Repeater ID="repeaterQuestion" runat="server" ItemType="DiscussionBoard.Model.Question"
                    SelectMethod="repeaterQuestion_GetData">
                    <ItemTemplate>--%>
                        <div class="col-md-12 a-question">
                            <div class="col-md-9 question-title">
                                <a href="#">
                                    <p class="title-label">
                                        Title
                                    </p>
                                </a>
                            </div>
                             <div class="col-md-3 question-info">
                                <asp:Button ID="btnEdit" Text="Edit" runat="server"  CssClass="btn btn-default btn-dasboard" />
                                <asp:Button ID="btnDelete" Text="Delete" runat="server"  CssClass="btn btn-default btn-dasboard" />
                            </div>
                        </div>
<%--                    </ItemTemplate>
                </asp:Repeater>--%>
            </div>
        </div>
    </div>
</asp:Content>
