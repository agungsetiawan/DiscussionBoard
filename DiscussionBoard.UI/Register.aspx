<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DiscussionBoard.UI.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12 default-container">
        <div class="alert alert-success">
            <asp:Literal ID="literalSuccess" runat="server" />
        </div>
        <div class="col-md-5">
            
            <div class="form-group">
                <asp:Label ID="lblName" runat="server" Text="Name" />
                <asp:TextBox class="form-control" ID="txtName" runat="server" placeholder="Enter Your Name"/>
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" 
            ErrorMessage="Please, fill the Name!" CssClass="label-warning"/>
            </div>

            <div class="form-group">
                <asp:Label ID="lblEmailExist" runat="server" />
                <asp:Label for="txtEmail" ID="lblEmail" runat="server" Text="Email" />
                <asp:TextBox class="form-control" ID="txtEmail" runat="server" placeholder="Enter Your Email"/>
                <asp:RequiredFieldValidator Display="Dynamic" ID="rfvEmail" runat="server" ControlToValidate="txtEmail" 
            ErrorMessage="Please, fill the Email!" CssClass="label-warning"/>
                <asp:RegularExpressionValidator ID="regexEmail" runat="server" CssClass="label-warning" ErrorMessage="Email format is wrong"
                   Display="Dynamic" ControlToValidate="txtEmail" ValidationExpression="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" />
            </div>

            <div class="form-group">
                <asp:Label for="txtPassword" ID="lblPassword" runat="server" Text="Password" />
                <asp:TextBox  class="form-control" ID="txtPassword" runat="server" TextMode="Password" placeholder="Choose Your Password"/>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" 
            ErrorMessage="Please, fill the Password!" CssClass="label-warning"/>
            </div>

            <div class="form-group">
                <asp:Label for="txtPassword" ID="lblPasswordAgain" runat="server" Text="Password Again" />
                <asp:TextBox  class="form-control" ID="txtPasswordAgain" runat="server" TextMode="Password" placeholder="Choose Your Password Again"/>
                <asp:RequiredFieldValidator ID="rfvPasswordAgain" runat="server" ControlToValidate="txtPasswordAgain" 
            ErrorMessage="Please, fill the Password Again!" Display="Dynamic" CssClass="label-warning"/>
                <asp:CompareValidator ID="comparePassword" runat="server" ControlToValidate="txtPassword" ControlToCompare="txtPasswordAgain"
                    ErrorMessage="Password Doesn't Macth!" Display="Dynamic" CssClass="label-warning" />
            </div>

            <div class="form-group">
                <asp:Button class="btn btn-default" ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
        </div>
</asp:Content>
