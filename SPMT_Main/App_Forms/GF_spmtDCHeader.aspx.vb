Partial Class GF_spmtDCHeader
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/SPMT_Main/App_Display/DF_spmtDCHeader.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ChallanID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVspmtDCHeader_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVspmtDCHeader.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")  
        Dim RedirectUrl As String = TBLspmtDCHeader.EditUrl & "?ChallanID=" & ChallanID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToLower = "completewf".ToLower Then
      Try
        Dim ChallanID As String = GVspmtDCHeader.DataKeys(e.CommandArgument).Values("ChallanID")  
        SIS.SPMT.spmtDCHeader.CompleteWF(ChallanID)
        GVspmtDCHeader.DataBind()
      Catch ex As Exception
      End Try
    End If
  End Sub
  Protected Sub GVspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVspmtDCHeader.Init
    DataClassName = "GspmtDCHeader"
    SetGridView = GVspmtDCHeader
  End Sub
  Protected Sub TBLspmtDCHeader_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLspmtDCHeader.Init
    SetToolBar = TBLspmtDCHeader
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
