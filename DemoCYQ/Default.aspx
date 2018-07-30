<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoCYQ._Default" EnableViewState="true" %>

<%@ Register Src="~/Pager.ascx" TagPrefix="uc1" TagName="Pager" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 980px; margin: 80px auto">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

            <uc1:Pager runat="server" ID="Pager" PageSize="10" />

            <hr />

            <asp:Label ID="labTemplate" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="txtTemplate" runat="server"></asp:TextBox>
            <br />
            <asp:Literal ID="litTemplate" runat="server"></asp:Literal>
            <br />

            <asp:Literal ID="litName" runat="server"></asp:Literal>
            <hr />
            <asp:DropDownList ID="ddlTableName" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
