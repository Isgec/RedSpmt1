<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtReturnReason.aspx.vb" Inherits="GF_spmtReturnReason" title="Maintain List: Return Reason" %>
<asp:Content ID="CPHspmtReturnReason" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtReturnReason" runat="server" Text="&nbsp;List: Return Reason"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtReturnReason" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtReturnReason"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtReturnReason.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtReturnReason.aspx"
      ValidationGroup = "spmtReturnReason"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtReturnReason" runat="server" AssociatedUpdatePanelID="UPNLspmtReturnReason" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtReturnReason" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtReturnReason" DataKeyNames="ReasonID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Reason ID" SortExpression="ReasonID">
          <ItemTemplate>
            <asp:Label ID="LabelReasonID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ReasonID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignright" />
          <HeaderStyle CssClass="alignright" Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSspmtReturnReason"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtReturnReason"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtReturnReasonSelectList"
      TypeName = "SIS.SPMT.spmtReturnReason"
      SelectCountMethod = "spmtReturnReasonSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtReturnReason" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
