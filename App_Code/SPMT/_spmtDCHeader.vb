Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.SPMT
  <DataObject()> _
  Partial Public Class spmtDCHeader
    Private Shared _RecordCount As Integer
    Private _ChallanID As String = ""
    Private _ChallanDate As String = ""
    Private _IssuerID As String = ""
    Private _IssuerCompanyName As String = ""
    Private _IssuerAddress1Line As String = ""
    Private _IssuerAddress2Line As String = ""
    Private _IssuerPAN As String = ""
    Private _IssuerCIN As String = ""
    Private _ProjectID As String = ""
    Private _UnitID As String = ""
    Private _PONo As String = ""
    Private _PlaceOfSupply As String = ""
    Private _PlaceOfDelivery As String = ""
    Private _ConsignerIsgecID As String = ""
    Private _ConsigneeIsgecID As String = ""
    Private _ConsignerBPID As String = ""
    Private _ConsigneeBPID As String = ""
    Private _ConsignerGSTIN As String = ""
    Private _ConsigneeGSTIN As String = ""
    Private _ConsignerName As String = ""
    Private _ConsigneeName As String = ""
    Private _ConsignerGSTINNo As String = ""
    Private _ConsigneeGSTINNo As String = ""
    Private _ConsignerAddress1Line As String = ""
    Private _ConsigneeAddress1Line As String = ""
    Private _ConsignerAddress2Line As String = ""
    Private _ConsigneeAddress2Line As String = ""
    Private _ConsignerAddress3Line As String = ""
    Private _ConsigneeAddress3Line As String = ""
    Private _ConsignerStateID As String = ""
    Private _ConsigneeStateID As String = ""
    Private _Purpose As String = ""
    Private _ExpectedReturnDate As String = ""
    Private _ModeOfTransportID As String = ""
    Private _VehicleNo As String = ""
    Private _GRNo As String = ""
    Private _GRDate As String = ""
    Private _TransporterID As String = ""
    Private _TransporterName As String = ""
    Private _FromPlace As String = ""
    Private _ToPlace As String = ""
    Private _TotalAmount As String = "0.00"
    Private _TotalAmountInWords As String = ""
    Private _CreatedOn As String = ""
    Private _StatusID As String = ""
    Private _CreatedBy As String = ""
    Private _Declaration2Line As String = ""
    Private _Declaration1Line As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _HRM_Companies2_Description As String = ""
    Private _IDM_Projects3_Description As String = ""
    Private _SPMT_DCStates4_Description As String = ""
    Private _SPMT_ERPStates5_Description As String = ""
    Private _SPMT_ERPStates6_Description As String = ""
    Private _SPMT_ERPStates7_Description As String = ""
    Private _SPMT_ERPStates8_Description As String = ""
    Private _SPMT_IsgecGSTIN9_Description As String = ""
    Private _SPMT_IsgecGSTIN10_Description As String = ""
    Private _SPMT_IsgecGSTIN11_Description As String = ""
    Private _SPMT_ModeOfTransport12_Description As String = ""
    Private _VR_BPGSTIN13_Description As String = ""
    Private _VR_BPGSTIN14_Description As String = ""
    Private _VR_BusinessPartner15_BPName As String = ""
    Private _VR_BusinessPartner16_BPName As String = ""
    Private _VR_BusinessPartner17_BPName As String = ""
    Private _FK_SPMT_DCHeader_CreatedBy As SIS.COM.comUsers = Nothing
    Private _FK_SPMT_DCHeader_UnitID As SIS.COM.comCompanies = Nothing
    Private _FK_SPMT_DCHeader_ProjectID As SIS.COM.comProjects = Nothing
    Private _FK_SPMT_DCHeader_StatusID As SIS.SPMT.spmtDCStates = Nothing
    Private _FK_SPMT_DCHeader_PlaceOfSupply As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_DCHeader_PlaceOfDelivery As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_DCHeader_consignerStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_DCHeader_ConsigneeStateID As SIS.SPMT.spmtERPStates = Nothing
    Private _FK_SPMT_DCHeader_ConsignerIsgecID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_DCHeader_CongigneeIsgecID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_DCHeader_IssuerID As SIS.SPMT.spmtIsgecGSTIN = Nothing
    Private _FK_SPMT_DCHeader_ModeOfTransportID As SIS.SPMT.spmtModeOfTransport = Nothing
    Private _FK_SPMT_DCHeader_ConsignerGSTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_DCHeader_ConsigneeGISTIN As SIS.SPMT.spmtBPGSTIN = Nothing
    Private _FK_SPMT_DCHeader_ConsignerBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_DCHeader_TransporterID As SIS.SPMT.spmtBusinessPartner = Nothing
    Private _FK_SPMT_DCHeader_ConsigneeBPID As SIS.SPMT.spmtBusinessPartner = Nothing
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
          mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property ChallanID() As String
      Get
        Return _ChallanID
      End Get
      Set(ByVal value As String)
        _ChallanID = value
      End Set
    End Property
    Public Property ChallanDate() As String
      Get
        If Not _ChallanDate = String.Empty Then
          Return Convert.ToDateTime(_ChallanDate).ToString("dd/MM/yyyy")
        End If
        Return _ChallanDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ChallanDate = ""
         Else
           _ChallanDate = value
         End If
      End Set
    End Property
    Public Property IssuerID() As String
      Get
        Return _IssuerID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IssuerID = ""
         Else
           _IssuerID = value
         End If
      End Set
    End Property
    Public Property IssuerCompanyName() As String
      Get
        Return _IssuerCompanyName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IssuerCompanyName = ""
         Else
           _IssuerCompanyName = value
         End If
      End Set
    End Property
    Public Property IssuerAddress1Line() As String
      Get
        Return _IssuerAddress1Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IssuerAddress1Line = ""
         Else
           _IssuerAddress1Line = value
         End If
      End Set
    End Property
    Public Property IssuerAddress2Line() As String
      Get
        Return _IssuerAddress2Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IssuerAddress2Line = ""
         Else
           _IssuerAddress2Line = value
         End If
      End Set
    End Property
    Public Property IssuerPAN() As String
      Get
        Return _IssuerPAN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IssuerPAN = ""
         Else
           _IssuerPAN = value
         End If
      End Set
    End Property
    Public Property IssuerCIN() As String
      Get
        Return _IssuerCIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _IssuerCIN = ""
         Else
           _IssuerCIN = value
         End If
      End Set
    End Property
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ProjectID = ""
         Else
           _ProjectID = value
         End If
      End Set
    End Property
    Public Property UnitID() As String
      Get
        Return _UnitID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _UnitID = ""
         Else
           _UnitID = value
         End If
      End Set
    End Property
    Public Property PONo() As String
      Get
        Return _PONo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PONo = ""
         Else
           _PONo = value
         End If
      End Set
    End Property
    Public Property PlaceOfSupply() As String
      Get
        Return _PlaceOfSupply
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PlaceOfSupply = ""
         Else
           _PlaceOfSupply = value
         End If
      End Set
    End Property
    Public Property PlaceOfDelivery() As String
      Get
        Return _PlaceOfDelivery
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _PlaceOfDelivery = ""
         Else
           _PlaceOfDelivery = value
         End If
      End Set
    End Property
    Public Property ConsignerIsgecID() As String
      Get
        Return _ConsignerIsgecID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerIsgecID = ""
         Else
           _ConsignerIsgecID = value
         End If
      End Set
    End Property
    Public Property ConsigneeIsgecID() As String
      Get
        Return _ConsigneeIsgecID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeIsgecID = ""
         Else
           _ConsigneeIsgecID = value
         End If
      End Set
    End Property
    Public Property ConsignerBPID() As String
      Get
        Return _ConsignerBPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerBPID = ""
         Else
           _ConsignerBPID = value
         End If
      End Set
    End Property
    Public Property ConsigneeBPID() As String
      Get
        Return _ConsigneeBPID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeBPID = ""
         Else
           _ConsigneeBPID = value
         End If
      End Set
    End Property
    Public Property ConsignerGSTIN() As String
      Get
        Return _ConsignerGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerGSTIN = ""
         Else
           _ConsignerGSTIN = value
         End If
      End Set
    End Property
    Public Property ConsigneeGSTIN() As String
      Get
        Return _ConsigneeGSTIN
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeGSTIN = ""
         Else
           _ConsigneeGSTIN = value
         End If
      End Set
    End Property
    Public Property ConsignerName() As String
      Get
        Return _ConsignerName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerName = ""
         Else
           _ConsignerName = value
         End If
      End Set
    End Property
    Public Property ConsigneeName() As String
      Get
        Return _ConsigneeName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeName = ""
         Else
           _ConsigneeName = value
         End If
      End Set
    End Property
    Public Property ConsignerGSTINNo() As String
      Get
        Return _ConsignerGSTINNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerGSTINNo = ""
         Else
           _ConsignerGSTINNo = value
         End If
      End Set
    End Property
    Public Property ConsigneeGSTINNo() As String
      Get
        Return _ConsigneeGSTINNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeGSTINNo = ""
         Else
           _ConsigneeGSTINNo = value
         End If
      End Set
    End Property
    Public Property ConsignerAddress1Line() As String
      Get
        Return _ConsignerAddress1Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerAddress1Line = ""
         Else
           _ConsignerAddress1Line = value
         End If
      End Set
    End Property
    Public Property ConsigneeAddress1Line() As String
      Get
        Return _ConsigneeAddress1Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeAddress1Line = ""
         Else
           _ConsigneeAddress1Line = value
         End If
      End Set
    End Property
    Public Property ConsignerAddress2Line() As String
      Get
        Return _ConsignerAddress2Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerAddress2Line = ""
         Else
           _ConsignerAddress2Line = value
         End If
      End Set
    End Property
    Public Property ConsigneeAddress2Line() As String
      Get
        Return _ConsigneeAddress2Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeAddress2Line = ""
         Else
           _ConsigneeAddress2Line = value
         End If
      End Set
    End Property
    Public Property ConsignerAddress3Line() As String
      Get
        Return _ConsignerAddress3Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerAddress3Line = ""
         Else
           _ConsignerAddress3Line = value
         End If
      End Set
    End Property
    Public Property ConsigneeAddress3Line() As String
      Get
        Return _ConsigneeAddress3Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeAddress3Line = ""
         Else
           _ConsigneeAddress3Line = value
         End If
      End Set
    End Property
    Public Property ConsignerStateID() As String
      Get
        Return _ConsignerStateID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsignerStateID = ""
         Else
           _ConsignerStateID = value
         End If
      End Set
    End Property
    Public Property ConsigneeStateID() As String
      Get
        Return _ConsigneeStateID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ConsigneeStateID = ""
         Else
           _ConsigneeStateID = value
         End If
      End Set
    End Property
    Public Property Purpose() As String
      Get
        Return _Purpose
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Purpose = ""
         Else
           _Purpose = value
         End If
      End Set
    End Property
    Public Property ExpectedReturnDate() As String
      Get
        If Not _ExpectedReturnDate = String.Empty Then
          Return Convert.ToDateTime(_ExpectedReturnDate).ToString("dd/MM/yyyy")
        End If
        Return _ExpectedReturnDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ExpectedReturnDate = ""
         Else
           _ExpectedReturnDate = value
         End If
      End Set
    End Property
    Public Property ModeOfTransportID() As String
      Get
        Return _ModeOfTransportID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ModeOfTransportID = ""
         Else
           _ModeOfTransportID = value
         End If
      End Set
    End Property
    Public Property VehicleNo() As String
      Get
        Return _VehicleNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VehicleNo = ""
         Else
           _VehicleNo = value
         End If
      End Set
    End Property
    Public Property GRNo() As String
      Get
        Return _GRNo
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _GRNo = ""
         Else
           _GRNo = value
         End If
      End Set
    End Property
    Public Property GRDate() As String
      Get
        If Not _GRDate = String.Empty Then
          Return Convert.ToDateTime(_GRDate).ToString("dd/MM/yyyy")
        End If
        Return _GRDate
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _GRDate = ""
         Else
           _GRDate = value
         End If
      End Set
    End Property
    Public Property TransporterID() As String
      Get
        Return _TransporterID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TransporterID = ""
         Else
           _TransporterID = value
         End If
      End Set
    End Property
    Public Property TransporterName() As String
      Get
        Return _TransporterName
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TransporterName = ""
         Else
           _TransporterName = value
         End If
      End Set
    End Property
    Public Property FromPlace() As String
      Get
        Return _FromPlace
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _FromPlace = ""
         Else
           _FromPlace = value
         End If
      End Set
    End Property
    Public Property ToPlace() As String
      Get
        Return _ToPlace
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _ToPlace = ""
         Else
           _ToPlace = value
         End If
      End Set
    End Property
    Public Property TotalAmount() As String
      Get
        Return _TotalAmount
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TotalAmount = "0.00"
         Else
           _TotalAmount = value
         End If
      End Set
    End Property
    Public Property TotalAmountInWords() As String
      Get
        Return _TotalAmountInWords
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _TotalAmountInWords = ""
         Else
           _TotalAmountInWords = value
         End If
      End Set
    End Property
    Public Property CreatedOn() As String
      Get
        If Not _CreatedOn = String.Empty Then
          Return Convert.ToDateTime(_CreatedOn).ToString("dd/MM/yyyy")
        End If
        Return _CreatedOn
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CreatedOn = ""
         Else
           _CreatedOn = value
         End If
      End Set
    End Property
    Public Property StatusID() As String
      Get
        Return _StatusID
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _StatusID = ""
         Else
           _StatusID = value
         End If
      End Set
    End Property
    Public Property CreatedBy() As String
      Get
        Return _CreatedBy
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _CreatedBy = ""
         Else
           _CreatedBy = value
         End If
      End Set
    End Property
    Public Property Declaration2Line() As String
      Get
        Return _Declaration2Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Declaration2Line = ""
         Else
           _Declaration2Line = value
         End If
      End Set
    End Property
    Public Property Declaration1Line() As String
      Get
        Return _Declaration1Line
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _Declaration1Line = ""
         Else
           _Declaration1Line = value
         End If
      End Set
    End Property
    Public Property aspnet_Users1_UserFullName() As String
      Get
        Return _aspnet_Users1_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users1_UserFullName = value
      End Set
    End Property
    Public Property HRM_Companies2_Description() As String
      Get
        Return _HRM_Companies2_Description
      End Get
      Set(ByVal value As String)
        _HRM_Companies2_Description = value
      End Set
    End Property
    Public Property IDM_Projects3_Description() As String
      Get
        Return _IDM_Projects3_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects3_Description = value
      End Set
    End Property
    Public Property SPMT_DCStates4_Description() As String
      Get
        Return _SPMT_DCStates4_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_DCStates4_Description = ""
         Else
           _SPMT_DCStates4_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates5_Description() As String
      Get
        Return _SPMT_ERPStates5_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates5_Description = ""
         Else
           _SPMT_ERPStates5_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates6_Description() As String
      Get
        Return _SPMT_ERPStates6_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates6_Description = ""
         Else
           _SPMT_ERPStates6_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates7_Description() As String
      Get
        Return _SPMT_ERPStates7_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates7_Description = ""
         Else
           _SPMT_ERPStates7_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ERPStates8_Description() As String
      Get
        Return _SPMT_ERPStates8_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ERPStates8_Description = ""
         Else
           _SPMT_ERPStates8_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN9_Description() As String
      Get
        Return _SPMT_IsgecGSTIN9_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN9_Description = ""
         Else
           _SPMT_IsgecGSTIN9_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN10_Description() As String
      Get
        Return _SPMT_IsgecGSTIN10_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN10_Description = ""
         Else
           _SPMT_IsgecGSTIN10_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_IsgecGSTIN11_Description() As String
      Get
        Return _SPMT_IsgecGSTIN11_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_IsgecGSTIN11_Description = ""
         Else
           _SPMT_IsgecGSTIN11_Description = value
         End If
      End Set
    End Property
    Public Property SPMT_ModeOfTransport12_Description() As String
      Get
        Return _SPMT_ModeOfTransport12_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _SPMT_ModeOfTransport12_Description = ""
         Else
           _SPMT_ModeOfTransport12_Description = value
         End If
      End Set
    End Property
    Public Property VR_BPGSTIN13_Description() As String
      Get
        Return _VR_BPGSTIN13_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN13_Description = ""
         Else
           _VR_BPGSTIN13_Description = value
         End If
      End Set
    End Property
    Public Property VR_BPGSTIN14_Description() As String
      Get
        Return _VR_BPGSTIN14_Description
      End Get
      Set(ByVal value As String)
         If Convert.IsDBNull(Value) Then
           _VR_BPGSTIN14_Description = ""
         Else
           _VR_BPGSTIN14_Description = value
         End If
      End Set
    End Property
    Public Property VR_BusinessPartner15_BPName() As String
      Get
        Return _VR_BusinessPartner15_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner15_BPName = value
      End Set
    End Property
    Public Property VR_BusinessPartner16_BPName() As String
      Get
        Return _VR_BusinessPartner16_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner16_BPName = value
      End Set
    End Property
    Public Property VR_BusinessPartner17_BPName() As String
      Get
        Return _VR_BusinessPartner17_BPName
      End Get
      Set(ByVal value As String)
        _VR_BusinessPartner17_BPName = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _Purpose.ToString.PadRight(250, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _ChallanID
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKspmtDCHeader
      Private _ChallanID As String = ""
      Public Property ChallanID() As String
        Get
          Return _ChallanID
        End Get
        Set(ByVal value As String)
          _ChallanID = value
        End Set
      End Property
    End Class
    Public ReadOnly Property FK_SPMT_DCHeader_CreatedBy() As SIS.COM.comUsers
      Get
        If _FK_SPMT_DCHeader_CreatedBy Is Nothing Then
          _FK_SPMT_DCHeader_CreatedBy = SIS.COM.comUsers.comUsersGetByID(_CreatedBy)
        End If
        Return _FK_SPMT_DCHeader_CreatedBy
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_UnitID() As SIS.COM.comCompanies
      Get
        If _FK_SPMT_DCHeader_UnitID Is Nothing Then
          _FK_SPMT_DCHeader_UnitID = SIS.COM.comCompanies.comCompaniesGetByID(_UnitID)
        End If
        Return _FK_SPMT_DCHeader_UnitID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ProjectID() As SIS.COM.comProjects
      Get
        If _FK_SPMT_DCHeader_ProjectID Is Nothing Then
          _FK_SPMT_DCHeader_ProjectID = SIS.COM.comProjects.comProjectsGetByID(_ProjectID)
        End If
        Return _FK_SPMT_DCHeader_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_StatusID() As SIS.SPMT.spmtDCStates
      Get
        If _FK_SPMT_DCHeader_StatusID Is Nothing Then
          _FK_SPMT_DCHeader_StatusID = SIS.SPMT.spmtDCStates.spmtDCStatesGetByID(_StatusID)
        End If
        Return _FK_SPMT_DCHeader_StatusID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_PlaceOfSupply() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_DCHeader_PlaceOfSupply Is Nothing Then
          _FK_SPMT_DCHeader_PlaceOfSupply = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_PlaceOfSupply)
        End If
        Return _FK_SPMT_DCHeader_PlaceOfSupply
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_PlaceOfDelivery() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_DCHeader_PlaceOfDelivery Is Nothing Then
          _FK_SPMT_DCHeader_PlaceOfDelivery = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_PlaceOfDelivery)
        End If
        Return _FK_SPMT_DCHeader_PlaceOfDelivery
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_consignerStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_DCHeader_consignerStateID Is Nothing Then
          _FK_SPMT_DCHeader_consignerStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ConsignerStateID)
        End If
        Return _FK_SPMT_DCHeader_consignerStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ConsigneeStateID() As SIS.SPMT.spmtERPStates
      Get
        If _FK_SPMT_DCHeader_ConsigneeStateID Is Nothing Then
          _FK_SPMT_DCHeader_ConsigneeStateID = SIS.SPMT.spmtERPStates.spmtERPStatesGetByID(_ConsigneeStateID)
        End If
        Return _FK_SPMT_DCHeader_ConsigneeStateID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ConsignerIsgecID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_DCHeader_ConsignerIsgecID Is Nothing Then
          _FK_SPMT_DCHeader_ConsignerIsgecID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_ConsignerIsgecID)
        End If
        Return _FK_SPMT_DCHeader_ConsignerIsgecID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_CongigneeIsgecID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_DCHeader_CongigneeIsgecID Is Nothing Then
          _FK_SPMT_DCHeader_CongigneeIsgecID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_ConsigneeIsgecID)
        End If
        Return _FK_SPMT_DCHeader_CongigneeIsgecID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_IssuerID() As SIS.SPMT.spmtIsgecGSTIN
      Get
        If _FK_SPMT_DCHeader_IssuerID Is Nothing Then
          _FK_SPMT_DCHeader_IssuerID = SIS.SPMT.spmtIsgecGSTIN.spmtIsgecGSTINGetByID(_IssuerID)
        End If
        Return _FK_SPMT_DCHeader_IssuerID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ModeOfTransportID() As SIS.SPMT.spmtModeOfTransport
      Get
        If _FK_SPMT_DCHeader_ModeOfTransportID Is Nothing Then
          _FK_SPMT_DCHeader_ModeOfTransportID = SIS.SPMT.spmtModeOfTransport.spmtModeOfTransportGetByID(_ModeOfTransportID)
        End If
        Return _FK_SPMT_DCHeader_ModeOfTransportID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ConsignerGSTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_DCHeader_ConsignerGSTIN Is Nothing Then
          _FK_SPMT_DCHeader_ConsignerGSTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_ConsignerBPID, _ConsignerGSTIN)
        End If
        Return _FK_SPMT_DCHeader_ConsignerGSTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ConsigneeGISTIN() As SIS.SPMT.spmtBPGSTIN
      Get
        If _FK_SPMT_DCHeader_ConsigneeGISTIN Is Nothing Then
          _FK_SPMT_DCHeader_ConsigneeGISTIN = SIS.SPMT.spmtBPGSTIN.spmtBPGSTINGetByID(_ConsigneeBPID, _ConsigneeGSTIN)
        End If
        Return _FK_SPMT_DCHeader_ConsigneeGISTIN
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ConsignerBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_DCHeader_ConsignerBPID Is Nothing Then
          _FK_SPMT_DCHeader_ConsignerBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_ConsignerBPID)
        End If
        Return _FK_SPMT_DCHeader_ConsignerBPID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_TransporterID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_DCHeader_TransporterID Is Nothing Then
          _FK_SPMT_DCHeader_TransporterID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_TransporterID)
        End If
        Return _FK_SPMT_DCHeader_TransporterID
      End Get
    End Property
    Public ReadOnly Property FK_SPMT_DCHeader_ConsigneeBPID() As SIS.SPMT.spmtBusinessPartner
      Get
        If _FK_SPMT_DCHeader_ConsigneeBPID Is Nothing Then
          _FK_SPMT_DCHeader_ConsigneeBPID = SIS.SPMT.spmtBusinessPartner.spmtBusinessPartnerGetByID(_ConsigneeBPID)
        End If
        Return _FK_SPMT_DCHeader_ConsigneeBPID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtDCHeaderSelectList(ByVal OrderBy As String) As List(Of SIS.SPMT.spmtDCHeader)
      Dim Results As List(Of SIS.SPMT.spmtDCHeader) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "ChallanID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtDCHeaderSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtDCHeader)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtDCHeader(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtDCHeaderGetNewRecord() As SIS.SPMT.spmtDCHeader
      Return New SIS.SPMT.spmtDCHeader()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtDCHeaderGetByID(ByVal ChallanID As String) As SIS.SPMT.spmtDCHeader
      Dim Results As SIS.SPMT.spmtDCHeader = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtDCHeaderSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID",SqlDbType.NVarChar,ChallanID.ToString.Length, ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.SPMT.spmtDCHeader(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function spmtDCHeaderSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.SPMT.spmtDCHeader)
      Dim Results As List(Of SIS.SPMT.spmtDCHeader) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "ChallanID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spspmtDCHeaderSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spspmtDCHeaderSelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.SPMT.spmtDCHeader)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.SPMT.spmtDCHeader(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function spmtDCHeaderSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function spmtDCHeaderInsert(ByVal Record As SIS.SPMT.spmtDCHeader) As SIS.SPMT.spmtDCHeader
      Dim _Rec As SIS.SPMT.spmtDCHeader = SIS.SPMT.spmtDCHeader.spmtDCHeaderGetNewRecord()
      With _Rec
        .ChallanID = Record.ChallanID
        .ChallanDate = Record.ChallanDate
        .IssuerID = Record.IssuerID
        .IssuerCompanyName = Record.IssuerCompanyName
        .IssuerAddress1Line = Record.IssuerAddress1Line
        .IssuerAddress2Line = Record.IssuerAddress2Line
        .IssuerPAN = Record.IssuerPAN
        .IssuerCIN = Record.IssuerCIN
        .ProjectID = Record.ProjectID
        .UnitID = Record.UnitID
        .PONo = Record.PONo
        .PlaceOfSupply = Record.PlaceOfSupply
        .PlaceOfDelivery = Record.PlaceOfDelivery
        .ConsignerIsgecID = Record.ConsignerIsgecID
        .ConsigneeIsgecID = Record.ConsigneeIsgecID
        .ConsignerBPID = Record.ConsignerBPID
        .ConsigneeBPID = Record.ConsigneeBPID
        .ConsignerGSTIN = Record.ConsignerGSTIN
        .ConsigneeGSTIN = Record.ConsigneeGSTIN
        .ConsignerName = Record.ConsignerName
        .ConsigneeName = Record.ConsigneeName
        .ConsignerGSTINNo = Record.ConsignerGSTINNo
        .ConsigneeGSTINNo = Record.ConsigneeGSTINNo
        .ConsignerAddress1Line = Record.ConsignerAddress1Line
        .ConsigneeAddress1Line = Record.ConsigneeAddress1Line
        .ConsignerAddress2Line = Record.ConsignerAddress2Line
        .ConsigneeAddress2Line = Record.ConsigneeAddress2Line
        .ConsignerAddress3Line = Record.ConsignerAddress3Line
        .ConsigneeAddress3Line = Record.ConsigneeAddress3Line
        .ConsignerStateID = Record.ConsignerStateID
        .ConsigneeStateID = Record.ConsigneeStateID
        .Purpose = Record.Purpose
        .ExpectedReturnDate = Record.ExpectedReturnDate
        .ModeOfTransportID = Record.ModeOfTransportID
        .VehicleNo = Record.VehicleNo
        .GRNo = Record.GRNo
        .GRDate = Record.GRDate
        .TransporterID = Record.TransporterID
        .TransporterName = Record.TransporterName
        .FromPlace = Record.FromPlace
        .ToPlace = Record.ToPlace
        .CreatedOn = Now
        .StatusID = 1
        .CreatedBy =  Global.System.Web.HttpContext.Current.Session("LoginID")
        .Declaration2Line = Record.Declaration2Line
        .Declaration1Line = Record.Declaration1Line
      End With
      Return SIS.SPMT.spmtDCHeader.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.SPMT.spmtDCHeader) As SIS.SPMT.spmtDCHeader
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtDCHeaderInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID",SqlDbType.NVarChar,21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanDate",SqlDbType.DateTime,21, Iif(Record.ChallanDate= "" ,Convert.DBNull, Record.ChallanDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerID",SqlDbType.Int,11, Iif(Record.IssuerID= "" ,Convert.DBNull, Record.IssuerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCompanyName",SqlDbType.NVarChar,51, Iif(Record.IssuerCompanyName= "" ,Convert.DBNull, Record.IssuerCompanyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress1Line",SqlDbType.NVarChar,201, Iif(Record.IssuerAddress1Line= "" ,Convert.DBNull, Record.IssuerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress2Line",SqlDbType.NVarChar,201, Iif(Record.IssuerAddress2Line= "" ,Convert.DBNull, Record.IssuerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerPAN",SqlDbType.NVarChar,51, Iif(Record.IssuerPAN= "" ,Convert.DBNull, Record.IssuerPAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCIN",SqlDbType.NVarChar,51, Iif(Record.IssuerCIN= "" ,Convert.DBNull, Record.IssuerCIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UnitID",SqlDbType.NVarChar,7, Iif(Record.UnitID= "" ,Convert.DBNull, Record.UnitID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONo",SqlDbType.NVarChar,10, Iif(Record.PONo= "" ,Convert.DBNull, Record.PONo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfSupply",SqlDbType.NVarChar,3, Iif(Record.PlaceOfSupply= "" ,Convert.DBNull, Record.PlaceOfSupply))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfDelivery",SqlDbType.NVarChar,3, Iif(Record.PlaceOfDelivery= "" ,Convert.DBNull, Record.PlaceOfDelivery))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerIsgecID",SqlDbType.Int,11, Iif(Record.ConsignerIsgecID= "" ,Convert.DBNull, Record.ConsignerIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeIsgecID",SqlDbType.Int,11, Iif(Record.ConsigneeIsgecID= "" ,Convert.DBNull, Record.ConsigneeIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerBPID",SqlDbType.NVarChar,10, Iif(Record.ConsignerBPID= "" ,Convert.DBNull, Record.ConsignerBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeBPID",SqlDbType.NVarChar,10, Iif(Record.ConsigneeBPID= "" ,Convert.DBNull, Record.ConsigneeBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTIN",SqlDbType.Int,11, Iif(Record.ConsignerGSTIN= "" ,Convert.DBNull, Record.ConsignerGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTIN",SqlDbType.Int,11, Iif(Record.ConsigneeGSTIN= "" ,Convert.DBNull, Record.ConsigneeGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerName",SqlDbType.NVarChar,51, Iif(Record.ConsignerName= "" ,Convert.DBNull, Record.ConsignerName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeName",SqlDbType.NVarChar,51, Iif(Record.ConsigneeName= "" ,Convert.DBNull, Record.ConsigneeName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTINNo",SqlDbType.NVarChar,51, Iif(Record.ConsignerGSTINNo= "" ,Convert.DBNull, Record.ConsignerGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTINNo",SqlDbType.NVarChar,51, Iif(Record.ConsigneeGSTINNo= "" ,Convert.DBNull, Record.ConsigneeGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress1Line",SqlDbType.NVarChar,101, Iif(Record.ConsignerAddress1Line= "" ,Convert.DBNull, Record.ConsignerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress1Line",SqlDbType.NVarChar,101, Iif(Record.ConsigneeAddress1Line= "" ,Convert.DBNull, Record.ConsigneeAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress2Line",SqlDbType.NVarChar,101, Iif(Record.ConsignerAddress2Line= "" ,Convert.DBNull, Record.ConsignerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress2Line",SqlDbType.NVarChar,101, Iif(Record.ConsigneeAddress2Line= "" ,Convert.DBNull, Record.ConsigneeAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress3Line",SqlDbType.NVarChar,101, Iif(Record.ConsignerAddress3Line= "" ,Convert.DBNull, Record.ConsignerAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress3Line",SqlDbType.NVarChar,101, Iif(Record.ConsigneeAddress3Line= "" ,Convert.DBNull, Record.ConsigneeAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerStateID",SqlDbType.NVarChar,3, Iif(Record.ConsignerStateID= "" ,Convert.DBNull, Record.ConsignerStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeStateID",SqlDbType.NVarChar,3, Iif(Record.ConsigneeStateID= "" ,Convert.DBNull, Record.ConsigneeStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Purpose",SqlDbType.NVarChar,251, Iif(Record.Purpose= "" ,Convert.DBNull, Record.Purpose))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ExpectedReturnDate",SqlDbType.DateTime,21, Iif(Record.ExpectedReturnDate= "" ,Convert.DBNull, Record.ExpectedReturnDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModeOfTransportID",SqlDbType.Int,11, Iif(Record.ModeOfTransportID= "" ,Convert.DBNull, Record.ModeOfTransportID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleNo",SqlDbType.NVarChar,51, Iif(Record.VehicleNo= "" ,Convert.DBNull, Record.VehicleNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRNo",SqlDbType.NVarChar,51, Iif(Record.GRNo= "" ,Convert.DBNull, Record.GRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRDate",SqlDbType.DateTime,21, Iif(Record.GRDate= "" ,Convert.DBNull, Record.GRDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterID",SqlDbType.NVarChar,10, Iif(Record.TransporterID= "" ,Convert.DBNull, Record.TransporterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterName",SqlDbType.NVarChar,51, Iif(Record.TransporterName= "" ,Convert.DBNull, Record.TransporterName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FromPlace",SqlDbType.NVarChar,51, Iif(Record.FromPlace= "" ,Convert.DBNull, Record.FromPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToPlace",SqlDbType.NVarChar,51, Iif(Record.ToPlace= "" ,Convert.DBNull, Record.ToPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,21, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountInWords",SqlDbType.NVarChar,501, Iif(Record.TotalAmountInWords= "" ,Convert.DBNull, Record.TotalAmountInWords))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration2Line",SqlDbType.NVarChar,251, Iif(Record.Declaration2Line= "" ,Convert.DBNull, Record.Declaration2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration1Line",SqlDbType.NVarChar,251, Iif(Record.Declaration1Line= "" ,Convert.DBNull, Record.Declaration1Line))
          Cmd.Parameters.Add("@Return_ChallanID", SqlDbType.NVarChar, 21)
          Cmd.Parameters("@Return_ChallanID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.ChallanID = Cmd.Parameters("@Return_ChallanID").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function spmtDCHeaderUpdate(ByVal Record As SIS.SPMT.spmtDCHeader) As SIS.SPMT.spmtDCHeader
      Dim _Rec As SIS.SPMT.spmtDCHeader = SIS.SPMT.spmtDCHeader.spmtDCHeaderGetByID(Record.ChallanID)
      With _Rec
        .ChallanDate = Record.ChallanDate
        .IssuerID = Record.IssuerID
        .IssuerCompanyName = Record.IssuerCompanyName
        .IssuerAddress1Line = Record.IssuerAddress1Line
        .IssuerAddress2Line = Record.IssuerAddress2Line
        .IssuerPAN = Record.IssuerPAN
        .IssuerCIN = Record.IssuerCIN
        .ProjectID = Record.ProjectID
        .UnitID = Record.UnitID
        .PONo = Record.PONo
        .PlaceOfSupply = Record.PlaceOfSupply
        .PlaceOfDelivery = Record.PlaceOfDelivery
        .ConsignerIsgecID = Record.ConsignerIsgecID
        .ConsigneeIsgecID = Record.ConsigneeIsgecID
        .ConsignerBPID = Record.ConsignerBPID
        .ConsigneeBPID = Record.ConsigneeBPID
        .ConsignerGSTIN = Record.ConsignerGSTIN
        .ConsigneeGSTIN = Record.ConsigneeGSTIN
        .ConsignerName = Record.ConsignerName
        .ConsigneeName = Record.ConsigneeName
        .ConsignerGSTINNo = Record.ConsignerGSTINNo
        .ConsigneeGSTINNo = Record.ConsigneeGSTINNo
        .ConsignerAddress1Line = Record.ConsignerAddress1Line
        .ConsigneeAddress1Line = Record.ConsigneeAddress1Line
        .ConsignerAddress2Line = Record.ConsignerAddress2Line
        .ConsigneeAddress2Line = Record.ConsigneeAddress2Line
        .ConsignerAddress3Line = Record.ConsignerAddress3Line
        .ConsigneeAddress3Line = Record.ConsigneeAddress3Line
        .ConsignerStateID = Record.ConsignerStateID
        .ConsigneeStateID = Record.ConsigneeStateID
        .Purpose = Record.Purpose
        .ExpectedReturnDate = Record.ExpectedReturnDate
        .ModeOfTransportID = Record.ModeOfTransportID
        .VehicleNo = Record.VehicleNo
        .GRNo = Record.GRNo
        .GRDate = Record.GRDate
        .TransporterID = Record.TransporterID
        .TransporterName = Record.TransporterName
        .FromPlace = Record.FromPlace
        .ToPlace = Record.ToPlace
        .Declaration2Line = Record.Declaration2Line
        .Declaration1Line = Record.Declaration1Line
      End With
      Return SIS.SPMT.spmtDCHeader.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.SPMT.spmtDCHeader) As SIS.SPMT.spmtDCHeader
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtDCHeaderUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ChallanID",SqlDbType.NVarChar,21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanID",SqlDbType.NVarChar,21, Record.ChallanID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ChallanDate",SqlDbType.DateTime,21, Iif(Record.ChallanDate= "" ,Convert.DBNull, Record.ChallanDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerID",SqlDbType.Int,11, Iif(Record.IssuerID= "" ,Convert.DBNull, Record.IssuerID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCompanyName",SqlDbType.NVarChar,51, Iif(Record.IssuerCompanyName= "" ,Convert.DBNull, Record.IssuerCompanyName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress1Line",SqlDbType.NVarChar,201, Iif(Record.IssuerAddress1Line= "" ,Convert.DBNull, Record.IssuerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerAddress2Line",SqlDbType.NVarChar,201, Iif(Record.IssuerAddress2Line= "" ,Convert.DBNull, Record.IssuerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerPAN",SqlDbType.NVarChar,51, Iif(Record.IssuerPAN= "" ,Convert.DBNull, Record.IssuerPAN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@IssuerCIN",SqlDbType.NVarChar,51, Iif(Record.IssuerCIN= "" ,Convert.DBNull, Record.IssuerCIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Iif(Record.ProjectID= "" ,Convert.DBNull, Record.ProjectID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UnitID",SqlDbType.NVarChar,7, Iif(Record.UnitID= "" ,Convert.DBNull, Record.UnitID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PONo",SqlDbType.NVarChar,10, Iif(Record.PONo= "" ,Convert.DBNull, Record.PONo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfSupply",SqlDbType.NVarChar,3, Iif(Record.PlaceOfSupply= "" ,Convert.DBNull, Record.PlaceOfSupply))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@PlaceOfDelivery",SqlDbType.NVarChar,3, Iif(Record.PlaceOfDelivery= "" ,Convert.DBNull, Record.PlaceOfDelivery))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerIsgecID",SqlDbType.Int,11, Iif(Record.ConsignerIsgecID= "" ,Convert.DBNull, Record.ConsignerIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeIsgecID",SqlDbType.Int,11, Iif(Record.ConsigneeIsgecID= "" ,Convert.DBNull, Record.ConsigneeIsgecID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerBPID",SqlDbType.NVarChar,10, Iif(Record.ConsignerBPID= "" ,Convert.DBNull, Record.ConsignerBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeBPID",SqlDbType.NVarChar,10, Iif(Record.ConsigneeBPID= "" ,Convert.DBNull, Record.ConsigneeBPID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTIN",SqlDbType.Int,11, Iif(Record.ConsignerGSTIN= "" ,Convert.DBNull, Record.ConsignerGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTIN",SqlDbType.Int,11, Iif(Record.ConsigneeGSTIN= "" ,Convert.DBNull, Record.ConsigneeGSTIN))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerName",SqlDbType.NVarChar,51, Iif(Record.ConsignerName= "" ,Convert.DBNull, Record.ConsignerName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeName",SqlDbType.NVarChar,51, Iif(Record.ConsigneeName= "" ,Convert.DBNull, Record.ConsigneeName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerGSTINNo",SqlDbType.NVarChar,51, Iif(Record.ConsignerGSTINNo= "" ,Convert.DBNull, Record.ConsignerGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeGSTINNo",SqlDbType.NVarChar,51, Iif(Record.ConsigneeGSTINNo= "" ,Convert.DBNull, Record.ConsigneeGSTINNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress1Line",SqlDbType.NVarChar,101, Iif(Record.ConsignerAddress1Line= "" ,Convert.DBNull, Record.ConsignerAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress1Line",SqlDbType.NVarChar,101, Iif(Record.ConsigneeAddress1Line= "" ,Convert.DBNull, Record.ConsigneeAddress1Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress2Line",SqlDbType.NVarChar,101, Iif(Record.ConsignerAddress2Line= "" ,Convert.DBNull, Record.ConsignerAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress2Line",SqlDbType.NVarChar,101, Iif(Record.ConsigneeAddress2Line= "" ,Convert.DBNull, Record.ConsigneeAddress2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerAddress3Line",SqlDbType.NVarChar,101, Iif(Record.ConsignerAddress3Line= "" ,Convert.DBNull, Record.ConsignerAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeAddress3Line",SqlDbType.NVarChar,101, Iif(Record.ConsigneeAddress3Line= "" ,Convert.DBNull, Record.ConsigneeAddress3Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsignerStateID",SqlDbType.NVarChar,3, Iif(Record.ConsignerStateID= "" ,Convert.DBNull, Record.ConsignerStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ConsigneeStateID",SqlDbType.NVarChar,3, Iif(Record.ConsigneeStateID= "" ,Convert.DBNull, Record.ConsigneeStateID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Purpose",SqlDbType.NVarChar,251, Iif(Record.Purpose= "" ,Convert.DBNull, Record.Purpose))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ExpectedReturnDate",SqlDbType.DateTime,21, Iif(Record.ExpectedReturnDate= "" ,Convert.DBNull, Record.ExpectedReturnDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ModeOfTransportID",SqlDbType.Int,11, Iif(Record.ModeOfTransportID= "" ,Convert.DBNull, Record.ModeOfTransportID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@VehicleNo",SqlDbType.NVarChar,51, Iif(Record.VehicleNo= "" ,Convert.DBNull, Record.VehicleNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRNo",SqlDbType.NVarChar,51, Iif(Record.GRNo= "" ,Convert.DBNull, Record.GRNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GRDate",SqlDbType.DateTime,21, Iif(Record.GRDate= "" ,Convert.DBNull, Record.GRDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterID",SqlDbType.NVarChar,10, Iif(Record.TransporterID= "" ,Convert.DBNull, Record.TransporterID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TransporterName",SqlDbType.NVarChar,51, Iif(Record.TransporterName= "" ,Convert.DBNull, Record.TransporterName))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FromPlace",SqlDbType.NVarChar,51, Iif(Record.FromPlace= "" ,Convert.DBNull, Record.FromPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ToPlace",SqlDbType.NVarChar,51, Iif(Record.ToPlace= "" ,Convert.DBNull, Record.ToPlace))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmount",SqlDbType.Decimal,21, Iif(Record.TotalAmount= "" ,Convert.DBNull, Record.TotalAmount))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TotalAmountInWords",SqlDbType.NVarChar,501, Iif(Record.TotalAmountInWords= "" ,Convert.DBNull, Record.TotalAmountInWords))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedOn",SqlDbType.DateTime,21, Iif(Record.CreatedOn= "" ,Convert.DBNull, Record.CreatedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StatusID",SqlDbType.Int,11, Iif(Record.StatusID= "" ,Convert.DBNull, Record.StatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CreatedBy",SqlDbType.NVarChar,9, Iif(Record.CreatedBy= "" ,Convert.DBNull, Record.CreatedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration2Line",SqlDbType.NVarChar,251, Iif(Record.Declaration2Line= "" ,Convert.DBNull, Record.Declaration2Line))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Declaration1Line",SqlDbType.NVarChar,251, Iif(Record.Declaration1Line= "" ,Convert.DBNull, Record.Declaration1Line))
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)> _
    Public Shared Function spmtDCHeaderDelete(ByVal Record As SIS.SPMT.spmtDCHeader) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtDCHeaderDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_ChallanID",SqlDbType.NVarChar,Record.ChallanID.ToString.Length, Record.ChallanID)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
    End Function
'    Autocomplete Method
    Public Shared Function SelectspmtDCHeaderAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spspmtDCHeaderAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(250, " "),""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.SPMT.spmtDCHeader = New SIS.SPMT.spmtDCHeader(Reader)
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results.ToArray
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              If Convert.IsDBNull(Reader(pi.Name)) Then
                CallByName(Me, pi.Name, CallType.Let, String.Empty)
              Else
                CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
