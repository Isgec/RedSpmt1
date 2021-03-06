<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_spmtBusinessPartner.aspx.vb" Inherits="GF_spmtBusinessPartner" title="Maintain List: Business Partner" %>
<asp:Content ID="CPHspmtBusinessPartner" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelspmtBusinessPartner" runat="server" Text="&nbsp;List: Business Partner"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLspmtBusinessPartner" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLspmtBusinessPartner"
      ToolType = "lgNMGrid"
      EditUrl = "~/SPMT_Main/App_Edit/EF_spmtBusinessPartner.aspx"
      AddUrl = "~/SPMT_Main/App_Create/AF_spmtBusinessPartner.aspx?skip=1"
      ValidationGroup = "spmtBusinessPartner"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSspmtBusinessPartner" runat="server" AssociatedUpdatePanelID="UPNLspmtBusinessPartner" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVspmtBusinessPartner" SkinID="gv_silver" runat="server" DataSourceID="ODSspmtBusinessPartner" DataKeyNames="BPID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle HorizontalAlign="Center" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BP ID" SortExpression="BPID">
          <ItemTemplate>
            <asp:Label ID="LabelBPID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BPID") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="BP Name" SortExpression="BPName">
          <ItemTemplate>
            <asp:Label ID="LabelBPName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("BPName") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address Line [1]" SortExpression="Address1Line">
          <ItemTemplate>
            <asp:Label ID="LabelAddress1Line" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Address1Line") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address Line [2]" SortExpression="Address2Line">
          <ItemTemplate>
            <asp:Label ID="LabelAddress2Line" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Address2Line") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="City" SortExpression="City">
          <ItemTemplate>
            <asp:Label ID="LabelCity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("City") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="" />
        <HeaderStyle CssClass="" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="E-Mail ID" SortExpression="EMailID">
          <ItemTemplate>
            <asp:Label ID="LabelEMailID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("EMailID") %>'></asp:Label>
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
      ID = "ODSspmtBusinessPartner"
      runat = "server"
      DataObjectTypeName = "SIS.SPMT.spmtBusinessPartner"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "spmtBusinessPartnerSelectList"
      TypeName = "SIS.SPMT.spmtBusinessPartner"
      SelectCountMethod = "spmtBusinessPartnerSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVspmtBusinessPartner" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
