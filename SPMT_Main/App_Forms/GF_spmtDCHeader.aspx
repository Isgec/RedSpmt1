<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtDCHeader.aspx.vb" Inherits="GF_spmtDCHeader" title="Maintain List: Delivery Challan" %>
<asp:Content ID="CPHspmtDCHeader" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtDCHeader" runat="server" Text="&nbsp;List: Delivery Challan"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtDCHeader" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtDCHeader"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtDCHeader.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtDCHeader.aspx?skip=1"
      ValidationGroup = "spmtDCHeader"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtDCHeader" runat="server" AssociatedUpdatePanelID="UPNLspmtDCHeader" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <script type="text/javascript">
      var pcnt = 0;
      function print_report(o) {
        pcnt = pcnt + 1;
        var nam = 'wTask' + pcnt;
        var url = self.location.href.replace('App_Forms/GF_','App_Print/RP_');
        url = url + '?pk=' + o.alt;
        window.open(url, nam, 'left=20,top=20,width=1000,height=600,toolbar=1,resizable=1,scrollbars=1');
        return false;
      }
    </script>
    <asp:GridView ID="GVspmtDCHeader" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtDCHeader" DataKeyNames="ChallanID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PRINT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdPrintPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Print the record." SkinID="Print" OnClientClick="return print_report(this);" />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Challan ID" SortExpression="ChallanID">
          <ItemTemplate>
            <asp:Label ID="LabelChallanID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ChallanID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Challan Date" SortExpression="ChallanDate">
          <ItemTemplate>
            <asp:Label ID="LabelChallanDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ChallanDate") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="90px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Issuer" SortExpression="SPMT_IsgecGSTIN11_Description">
          <ItemTemplate>
             <asp:Label ID="L_IssuerID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("IssuerID") %>' Text='<%# Eval("SPMT_IsgecGSTIN11_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Unit" SortExpression="HRM_Companies2_Description">
          <ItemTemplate>
             <asp:Label ID="L_UnitID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("UnitID") %>' Text='<%# Eval("HRM_Companies2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Place Of Supply" SortExpression="SPMT_ERPStates5_Description">
          <ItemTemplate>
             <asp:Label ID="L_PlaceOfSupply" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("PlaceOfSupply") %>' Text='<%# Eval("SPMT_ERPStates5_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Place Of Delivery" SortExpression="SPMT_ERPStates6_Description">
          <ItemTemplate>
             <asp:Label ID="L_PlaceOfDelivery" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("PlaceOfDelivery") %>' Text='<%# Eval("SPMT_ERPStates6_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Amount" SortExpression="TotalAmount">
          <ItemTemplate>
            <asp:Label ID="LabelTotalAmount" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalAmount") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Prepared By" SortExpression="aspnet_users1_UserFullName">
          <ItemTemplate>
             <asp:Label ID="L_CreatedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CreatedBy") %>' Text='<%# Eval("aspnet_users1_UserFullName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Status" SortExpression="SPMT_DCStates4_Description">
          <ItemTemplate>
             <asp:Label ID="L_StatusID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("StatusID") %>' Text='<%# Eval("SPMT_DCStates4_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Complete">
          <ItemTemplate>
            <asp:ImageButton ID="cmdCompleteWF" ValidationGroup='<%# "Complete" & Container.DataItemIndex %>' CausesValidation="true" runat="server" Visible='<%# EVal("CompleteWFVisible") %>' Enabled='<%# EVal("CompleteWFEnable") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Complete" SkinID="complete" OnClientClick='<%# "return Page_ClientValidate(""Complete" & Container.DataItemIndex & """) && confirm(""Complete record ?"");" %>' CommandName="CompleteWF" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtDCHeader"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtDCHeader"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_spmtDCHeaderSelectList"
      TypeName = "SIS.SPMT.spmtDCHeader"
      SelectCountMethod = "spmtDCHeaderSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVspmtDCHeader" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
