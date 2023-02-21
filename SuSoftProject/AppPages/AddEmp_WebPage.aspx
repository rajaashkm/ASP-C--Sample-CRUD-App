<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainPage.Master" AutoEventWireup="true" CodeBehind="AddEmp_WebPage.aspx.cs" Inherits="SuSoftProject.AppPages.AddEmp_WebPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center-block form-horizontal">
        <div class="h1">Employee Information</div>
        <div class="form-group">
            <label class="col-sm-4 control-label">Employee ID</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEmpID" class="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <label class="col-sm-4 control-label">Employee Name</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEmpName" class="form-control" runat="server"></asp:TextBox>
            </div>
            
        </div>
        <div class="form-group">
            <label class="col-sm-4 control-label">Date of Birth</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEmpDob" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
            </div>
           
        </div>
        <div class="form-group">
            <label class="col-sm-4 control-label">Designation</label>
            <div class="col-sm-4">
                <asp:DropDownList ID="ddlEmpDesg" class="form-control dropdown-toggle" data-toggle="dropdown" runat="server">
                    <asp:ListItem>---Select---</asp:ListItem>
                    <asp:ListItem>Manager</asp:ListItem>
                    <asp:ListItem>HR</asp:ListItem>
                    <asp:ListItem>Director</asp:ListItem>
                    <asp:ListItem>Developer</asp:ListItem>
                </asp:DropDownList>
            </div>
           
        </div>
        <div class="form-group">
            <label class="col-sm-4 control-label">Mobile No</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEmpMobile" class="form-control" runat="server"></asp:TextBox>
            </div>
           
        </div>
        <div class="form-group">
            <label class="col-sm-4 control-label">Email ID</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEmailID" class="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Button" OnClick="btnSubmit_Click"/> &nbsp;
            <asp:Button ID="btnCancel" class="btn btn-danger" runat="server" Text="Cancel" OnClick="btnCancel_Click"/> &nbsp;
            <asp:Button ID="btnList" class="btn btn-default" runat="server" Text="Back" OnClick="btnList_Click"/>
        </div>
    </div>
</asp:Content>
