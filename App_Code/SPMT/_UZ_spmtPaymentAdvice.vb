Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  Partial Public Class spmtPaymentAdvice
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Black
      If Convert.ToBoolean(Forward) Then
        Select Case AdviceStatusID
          Case 3
            mRet = Drawing.Color.Blue
          Case 7
            mRet = Drawing.Color.Green
          Case 2
            mRet = Drawing.Color.Red
          Case 8
            mRet = Drawing.Color.DarkOrchid
          Case 9, 10, 11
            mRet = Drawing.Color.DarkOrange
          Case 12
            mRet = Drawing.Color.Navy
        End Select
      End If
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEnable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEditable() As Boolean
      Dim mRet As Boolean = True
      If Convert.ToBoolean(Forward) = True Then
        mRet = False
      End If
      Return mRet
    End Function
    Public ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property BillSelectable As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          Select Case AdviceStatusID
            Case spmtPAStates.Returned, spmtPAStates.Free
              mRet = True
          End Select
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property

    Public ReadOnly Property InitiateWFVisible() As Boolean
      Get
        Dim mRet As Boolean = False
        Try
          If Convert.ToBoolean(Forward) = True Then
            Select Case AdviceStatusID
              Case spmtPAStates.Returned, spmtPAStates.Free
                mRet = True
            End Select
          End If
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property InitiateWFEnable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function InitiateWF(ByVal AdviceNo As Int32) As SIS.SPMT.spmtPaymentAdvice
      Dim Results As SIS.SPMT.spmtPaymentAdvice = spmtPaymentAdviceGetByID(AdviceNo)
      With Results
        .AdviceStatusID = spmtPAStates.ForwardedToAC
      End With
      SIS.SPMT.spmtPaymentAdvice.UpdateData(Results)
      Return Results
    End Function
    Public Shared Function UZ_spmtPaymentAdviceSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal AdviceNo As Int32, ByVal TranTypeID As String, ByVal BPID As String) As List(Of SIS.SPMT.spmtPaymentAdvice)
      Dim Results As List(Of SIS.SPMT.spmtPaymentAdvice) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "AdviceNo DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmt_LG_PaymentAdviceSelectListSearch"
            Cmd.CommandText = "spspmtPaymentAdviceSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmt_LG_PaymentAdviceSelectListFilteres"
            Cmd.CommandText = "spspmtPaymentAdviceSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AdviceNo", SqlDbType.Int, 10, IIf(AdviceNo = Nothing, 0, AdviceNo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_TranTypeID", SqlDbType.NVarChar, 3, IIf(TranTypeID Is Nothing, String.Empty, TranTypeID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_BPID", SqlDbType.NVarChar, 9, IIf(BPID Is Nothing, String.Empty, BPID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtPaymentAdvice)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtPaymentAdvice(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function ValidateAdvice(ByVal AdviceNo As Integer) As Boolean
      Dim oAdv As SIS.SPMT.spmtPaymentAdvice = SIS.SPMT.spmtPaymentAdvice.spmtPaymentAdviceGetByID(AdviceNo)
      Dim oBills As List(Of SIS.SPMT.spmtPaymentAdviceSupplierBill) = SIS.SPMT.spmtPaymentAdviceSupplierBill.spmtPaymentAdviceSupplierBillSelectList(0, 9999, "", False, "", AdviceNo)
      If oBills.Count <= 0 Then
        oAdv.Forward = False
        oAdv.CostCenter = "0.00"
        SIS.SPMT.spmtPaymentAdvice.UpdateData(oAdv)
        Return False
      Else
        Dim tmpTot As Decimal = 0
        For Each tmp As SIS.SPMT.spmtPaymentAdviceSupplierBill In oBills
          tmpTot += tmp.TotalAmountINR
        Next
        oAdv.Forward = True
        oAdv.CostCenter = tmpTot
        SIS.SPMT.spmtPaymentAdvice.UpdateData(oAdv)
        Return True
      End If
    End Function
    Public Shared Function UZ_spmtPaymentAdviceInsert(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      With Record
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .AdviceStatusID = 3
        .AdviceStatusOn = Now
        .AdviceStatusUser = HttpContext.Current.Session("LoginID")
      End With
      Dim _Result As SIS.SPMT.spmtPaymentAdvice = spmtPaymentAdviceInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtPaymentAdviceUpdate(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As SIS.SPMT.spmtPaymentAdvice
      With Record
        .TranTypeID = Record.TranTypeID.Split("|".ToCharArray)(0)
        .AdviceStatusID = 3
        .AdviceStatusOn = Now
        .AdviceStatusUser = HttpContext.Current.Session("LoginID")
      End With
      Dim _Result As SIS.SPMT.spmtPaymentAdvice = spmtPaymentAdviceUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_spmtPaymentAdviceDelete(ByVal Record As SIS.SPMT.spmtPaymentAdvice) As Integer
      Dim _Result As Integer = spmtPaymentAdviceDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_AdviceNo"), TextBox).Text = ""
          CType(.FindControl("F_TranTypeID"), Object).SelectedValue = ""
          CType(.FindControl("F_BPID"), TextBox).Text = ""
          CType(.FindControl("F_BPID_Display"), Label).Text = ""
          CType(.FindControl("F_ConcernedHOD"), TextBox).Text = ""
          CType(.FindControl("F_ConcernedHOD_Display"), Label).Text = ""
          CType(.FindControl("F_Remarks"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID"), TextBox).Text = ""
          CType(.FindControl("F_ProjectID_Display"), Label).Text = ""
          CType(.FindControl("F_ElementID"), TextBox).Text = ""
          CType(.FindControl("F_ElementID_Display"), Label).Text = ""
          CType(.FindControl("F_CostCenterID"), Object).SelectedValue = ""
          CType(.FindControl("F_EmployeeID"), TextBox).Text = ""
          CType(.FindControl("F_EmployeeID_Display"), Label).Text = ""
          CType(.FindControl("F_DepartmentID"), Object).SelectedValue = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
