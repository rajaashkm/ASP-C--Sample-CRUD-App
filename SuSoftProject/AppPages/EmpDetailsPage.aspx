<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/MainPage.Master" AutoEventWireup="true" CodeBehind="EmpDetailsPage.aspx.cs" Inherits="SuSoftProject.AppPages.EmpDetailsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-md-2"></div>
    <div class="col-md-8" style="margin-top:150px">
        <asp:GridView ID="EmpGridData" runat="server" CssClass="table table-bordered table-hover table-responsive" AutoGenerateColumns="False" AutoGenerateSelectButton="true" OnRowDataBound="EmpGridData_RowDataBound" OnSelectedIndexChanged="EmpGridData_SelectedIndexChanged">
        <Columns>
            <asp:BoundField HeaderText="Employee ID" DataField="Emp_ID" HeaderStyle-CssClass="text-center"/>
            <asp:BoundField HeaderText="Employee Name" DataField="Emp_Name" HeaderStyle-CssClass="text-center"/>
            <asp:BoundField HeaderText="DOB" DataField="Emp_DoB" DataFormatString="{0:D}" HeaderStyle-CssClass="text-center"/>
            <asp:BoundField HeaderText="Designation" DataField="Emp_Desg" HeaderStyle-CssClass="text-center"/>
            <asp:BoundField HeaderText="Mobile" DataField="Emp_Mobile" HeaderStyle-CssClass="text-center"/>
            <asp:BoundField HeaderText="Email ID" DataField="Email_ID" HeaderStyle-CssClass="text-center"/>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" HorizontalAlign="Center"/>
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" HorizontalAlign="Center"/>
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    </div>
    <div class="col-md-2"></div>
    

</asp:Content>
