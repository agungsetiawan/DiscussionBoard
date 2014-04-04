<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DiscussionBoard.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="col-md-12 default-container">
    <div class="col-md-5">
        <div class="form-group">
            <asp:Label ID="lblLogin" runat="server" />
            <asp:Label for="txtEmail" ID="lblEmail" runat="server" Text="Email" />
            <asp:TextBox ID="txtEmail" type="email" class="form-control" runat="server" placeholder="Enter email" />
        </div>
        <div class="form-group">
             <asp:Label for="txtPassword" ID="lblPassword" runat="server" Text="Password" />
             <asp:TextBox type="password" ID="txtPassword" runat="server"  class="form-control" placeholder="Enter Password"/>
        </div>

       <div class="form-group">
            <asp:Button class="btn" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </div>
        </div>
</asp:Content>