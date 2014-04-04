<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="PostAQuestion.aspx.cs" Inherits="DiscussionBoard.UI.PostAQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
        <div class="form-group">
        <asp:Label ID="lblMessage" runat="server" CssClass="label label-success"></asp:Label>
    </div>
    
    <form class="form-horizontal">
    <div class="form-group">
	        <asp:Label ID="lblTitle" runat="server" Text="Title" AssociatedControlID="txtTitle" class="col-sm-2 control-label"></asp:Label>        
        <div class="col-sm-10">
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTitle" runat="server" 
                    ControlToValidate="txtTitle" Text="Title, please!" CssClass="label-warning">
                </asp:RequiredFieldValidator>
	    </div>
    </div>

    <div class="form-group">
        <asp:Label ID="lblTag" runat="server" Text="Tag" AssociatedControlID="txtTag" class="col-sm-2 control-label"></asp:Label>        
        <div class="col-sm-10">
          <asp:TextBox ID="txtTag" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTag" runat="server"
                    ControlToValidate="txtTag" Text="Tag, please!" CssClass="label-warning">
                </asp:RequiredFieldValidator>
	    </div>
    </div>

    <div class="form-group">
        <asp:Label ID="lblTQuestion" runat="server" Text="Question" AssociatedControlID="txtQuestion" class="col-sm-2 control-label"></asp:Label>        
        <div class="col-sm-10">
            <asp:TextBox ID="txtQuestion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ControlToValidate="txtQuestion"
                ErrorMessage="Your question, please?" CssClass="label-warning">
            </asp:RequiredFieldValidator>
	    </div>
    </div>
    
    <div class="form-group">
        <asp:Label ID="lblStatus" runat="server" Text="Status" AssociatedControlID="ddlStatus" class="col-sm-2 control-label"></asp:Label>        
        <div class="col-sm-8">
		      <asp:DropDownList ID="ddlStatus" runat="server">
			    <asp:ListItem Value="Draft">Draft</asp:ListItem>
			    <asp:ListItem Value="Publish" Selected="True">Publish</asp:ListItem>
		    </asp:DropDownList>
	    </div>
        <div class="col-md-2">
                <asp:Button ID="Button1" Text="Post" runat="server"
                    Width="90px" CssClass="btn btn-default" BackColor="#428bca" OnClick="btnPost_Click" />
        </div>
    </div>

    <%--<div class="form-group">
        <div class="col-md-10">
		    <asp:Label ID="lblStatus" runat="server" Text="Status"> </asp:Label>
		    <asp:DropDownList ID="ddlStatus" runat="server">
			    <asp:ListItem Value="Draft">Draft</asp:ListItem>
			    <asp:ListItem Value="Publish" Selected="True">Publish</asp:ListItem>
		    </asp:DropDownList>
	    </div>
	    <div class="col-md-2">
                <asp:Button ID="btnPost" Text="Post" runat="server"
                    Width="90px" CssClass="btn btn-default" BackColor="#428bca" OnClick="btnPost_Click" />
        </div>
    </div>--%>
  
    </form>

</asp:Content>


    <%--<div class="form-group">
        <asp:Label ID="lblMessage" runat="server" CssClass="label label-success"></asp:Label>
    </div>

    <div class="form-group">
            <asp:Label ID="lblTitle" runat="server" Text="Title" AssociatedControlID="txtTitle"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle" 
                ErrorMessage="Please, fill the title!" CssClass="label-warning">
            </asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="lblTag" runat="server" Text="Tag" AssociatedControlID="txtTag"></asp:Label>
        <asp:TextBox ID="txtTag" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTag" runat="server" ControlToValidate="txtTag"
            ErrorMessage="Please, fill the tag!" CssClass="label-warning">
        </asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="lblQuestion" runat="server" Text="Question" AssociatedControlID="txtQuestion"></asp:Label>
        <asp:TextBox ID="txtQuestion" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ControlToValidate="txtQuestion"
            ErrorMessage="Your question, please?" CssClass="label-warning">
        </asp:RequiredFieldValidator>
    </div>
    <div class="row">
        <div class="col-md-10">
            <asp:Label ID="lblStatus" runat="server" Text="Status"> </asp:Label>
            <asp:DropDownList ID="ddlStatus" runat="server">
                <asp:ListItem Value="Draft">Draft</asp:ListItem>
                <asp:ListItem Value="Publish" Selected="True">Publish</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-md-2">
            <asp:Button ID="btnPost" Text="Post" runat="server"
                Width="90px" CssClass="btn btn-default" OnClick="btnPost_Click" />
        </div>
    </div>
</asp:Content>--%>



