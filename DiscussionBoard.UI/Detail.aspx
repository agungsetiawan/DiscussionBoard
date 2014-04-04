<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="DiscussionBoard.UI.Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 id="invalidNotif" runat="server"></h3>
    </div>
    <div id="successNotif" runat="server" class="alert alert-success" visible="false">
        <button type="button" class="close" data-dismiss="alert" aria-hidden="true">&times;</button>
        Your answer has been sent
    </div>
    <div id="questionSection">
        <div class="well">
            <h4 id="titleQuestion" runat="server"></h4>
            <div id="contentQuestion" runat="server">
            </div>
            <div id="byQuestion" class="pull-right" runat="server" style="color: grey">
            </div>
            <br />
            <div id="dateQuestion" class="pull-right" runat="server" style="color: grey">
            </div>
            <hr />
            <asp:Repeater ID="repeater1" runat="server" ItemType="DiscussionBoard.Model.Tag"
                SelectMethod="repeaterTag_GetData">
                <ItemTemplate>
                    <span class="label label-success" runat="server"><%# Item.Label %></span>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
        <div id="commentSection">
            <asp:Repeater ID="repeaterAnswer" runat="server" ItemType="DiscussionBoard.Model.Answer"
                SelectMethod="repeaterAnswer_GetData" >
                <ItemTemplate >
                    <div class="row">
                        <div class="col-md-1">
                            <a href="#" class="btn btn-default btn-white btn-sm">
                                <span class="glyphicon glyphicon-chevron-up"></span>
                            </a>
                            <%--<br />--%>
                            <div style="text-align: center; font-weight: bold"><%# Item.Vote %></div>
                            <%--<br />--%>
                            <a href="#" class="btn btn-default btn-white btn-sm">
                                <span class="glyphicon glyphicon-chevron-down"></span>
                            </a>
                        </div>
                        <div class="col-md-11 a-answer" style="background-color: white; padding: 20px; border-radius: 3px; border-left: 1px solid whitesmoke">
                            <div>
                                <%# Item.Content %>
                                <hr />
                            </div>
                            <div class="pull-right">
                                By: <%# Item.User.Name %>
                            </div>
                            <br />
                            <div class="pull-right">
                                <%# Item.Date %>
                            </div>
                        </div>
                    </div>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <a id="answerButton" runat="server" class="btn btn-primary btn-md" data-toggle="modal" data-target="#myModal">Answer this question</a>
        <a id="loginAnswer" href="Login.aspx" class="btn btn-default btn-md pull-right" runat="server" visible="false">Login to answer</a>
    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title" id="myModalLabel">Answer</h4>
                </div>
                <div class="modal-body">
                    <asp:TextBox ID="ContentAnswer" runat="server" CssClass="form-control" TextMode="multiline" Rows="5"></asp:TextBox>
                    <input ID="QuestionId" type="hidden" runat="server"  />

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    <%--<button type="button" class="btn btn-primary">Post</button>--%>
                    <asp:Button ID="Button" runat="server" CssClass="btn btn-primary" Text="Post"  OnClick="buttonSubmit_Click"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
