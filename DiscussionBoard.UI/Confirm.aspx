<%@ Page Language="C#"  MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Confirm.aspx.cs" Inherits="DiscussionBoard.UI.Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 default-container">
        <div class="col-md-5">
            <asp:Label ID="lblEmail" runat="server" />
            <asp:Literal ID="literalLink" runat="server" />
        </div>
    </div>
</asp:Content>