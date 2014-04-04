<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DiscussionBoard.UI.Default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 default-container">
    <div class="well well-sm">
        <asp:Literal ID="literalHello" runat="server" />
    </div>

    <div class="panel panel-success panel-top-question">
        <div class="panel-heading top-question-heading">
            <h3 class="panel-title top-question-label">Top Question</h3>
        </div>
        <div class="panel-body">
            <asp:Repeater ID="repeaterQuestion" runat="server" ItemType="DiscussionBoard.Model.Question"
                SelectMethod="repeaterQuestion_GetData">
                <ItemTemplate>
                    <div class="col-md-12 a-question">
                        <div class="col-md-2 question-info">
                            <p class="answer-count"><%# Item.Answers.Count  %> </p>
                            <p class="answer-label">Answer </p>
                        </div>
                        <div class="col-md-10 question-title">
                            <a href="Detail.aspx?ID=<%# Item.QuestionId %>">
                                <p class="title-label">
                                    <%# Item.Title  %>
                                </p>
                            </a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
   
    <div class="panel panel-success panel-lastest-question">
        <div class="panel-heading lastest-question-heading">
            <h3 class="panel-title top-question-label">Lastest Question</h3>
        </div>
        <div class="panel-body">
            <asp:Repeater ID="repeaterLatestQuestion" runat="server" ItemType="DiscussionBoard.Model.Question"
                SelectMethod="repeaterLatestQuestion_GetData">
                <ItemTemplate>
                    <div class="col-md-12 a-question-lastest">
                        <div class="col-md-2 question-info">
                            <p class="answer-count"><%# Item.Answers.Count  %> </p>
                            <p class="answer-label">Answer </p>
                        </div>
                        <div class="col-md-10 question-title">
                            <a href="Detail.aspx?ID=<%# Item.QuestionId %>">
                                <p class="title-label">
                                    <%# Item.Title  %>
                                </p>
                            </a>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
  </div>
   

</asp:Content>
