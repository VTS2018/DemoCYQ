<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Pager.ascx.cs" Inherits="DemoCYQ.Pager" %>


<table id="pager" border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td>
            <asp:LinkButton ID="lbtnFirstLink" runat="server" CausesValidation="false" OnClick="ClickEvent">首页</asp:LinkButton>
            <asp:LinkButton ID="lbtnPrevPage" runat="server" CausesValidation="false"  OnClick="ClickEvent">上一页</asp:LinkButton>
    
            <asp:Repeater ID="rptNum" runat="server" OnItemCommand="rptNum_ItemCommand">
                <ItemTemplate>
                    <asp:LinkButton ID="lbtnNum" runat="server" CausesValidation="false" CommandArgument='<%# Container.DataItem %>'
                        CssClass='<%# Convert.ToInt32(Container.DataItem)==PageIndex? "num_yellow":"num_blue"%>'>
                        <%# Container.DataItem %>
                     </asp:LinkButton>
                </ItemTemplate>
            </asp:Repeater>
      
            <asp:LinkButton ID="lbtnNextPage" runat="server" CausesValidation="false"  OnClick="ClickEvent">下一页</asp:LinkButton>
            <asp:LinkButton ID="lbtnLastPage" runat="server" CausesValidation="false"  OnClick="ClickEvent">尾页</asp:LinkButton>
            <asp:HiddenField ID="hfBindName" runat="server" />
        </td>
    </tr>
</table>