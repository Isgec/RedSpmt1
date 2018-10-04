SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPASelectList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPASelectList]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPASelectList]
  @LoginID NVarChar(8),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  SELECT
    [SPMT_newPA].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [aspnet_Users2].[UserFullName] AS aspnet_Users2_UserFullName,
    [aspnet_Users3].[UserFullName] AS aspnet_Users3_UserFullName,
    [aspnet_Users4].[UserFullName] AS aspnet_Users4_UserFullName,
    [HRM_Employees5].[EmployeeName] AS HRM_Employees5_EmployeeName,
    [SPMT_PAStatus6].[Description] AS SPMT_PAStatus6_Description,
    [SPMT_TranTypes7].[Description] AS SPMT_TranTypes7_Description,
    [VR_BusinessPartner8].[BPName] AS VR_BusinessPartner8_BPName 
  FROM [SPMT_newPA] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_newPA].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users2]
    ON [SPMT_newPA].[ReceivedInACBy] = [aspnet_users2].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users3]
    ON [SPMT_newPA].[PostedInACBy] = [aspnet_users3].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users4]
    ON [SPMT_newPA].[LockedInACBy] = [aspnet_users4].[LoginID]
  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]
    ON [SPMT_newPA].[ConcernedHOD] = [HRM_Employees5].[CardNo]
  LEFT OUTER JOIN [SPMT_PAStatus] AS [SPMT_PAStatus6]
    ON [SPMT_newPA].[StatusID] = [SPMT_PAStatus6].[AdviceStatusID]
  LEFT OUTER JOIN [SPMT_TranTypes] AS [SPMT_TranTypes7]
    ON [SPMT_newPA].[TranTypeID] = [SPMT_TranTypes7].[TranTypeID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner8]
    ON [SPMT_newPA].[BPID] = [VR_BusinessPartner8].[BPID]
  WHERE 1 = 1  
  ORDER BY
     CASE @OrderBy WHEN 'AdviceNo' THEN [SPMT_newPA].[AdviceNo] END,
     CASE @OrderBy WHEN 'AdviceNo DESC' THEN [SPMT_newPA].[AdviceNo] END DESC,
     CASE @OrderBy WHEN 'TranTypeID' THEN [SPMT_newPA].[TranTypeID] END,
     CASE @OrderBy WHEN 'TranTypeID DESC' THEN [SPMT_newPA].[TranTypeID] END DESC,
     CASE @OrderBy WHEN 'BPID' THEN [SPMT_newPA].[BPID] END,
     CASE @OrderBy WHEN 'BPID DESC' THEN [SPMT_newPA].[BPID] END DESC,
     CASE @OrderBy WHEN 'SupplierName' THEN [SPMT_newPA].[SupplierName] END,
     CASE @OrderBy WHEN 'SupplierName DESC' THEN [SPMT_newPA].[SupplierName] END DESC,
     CASE @OrderBy WHEN 'ConcernedHOD' THEN [SPMT_newPA].[ConcernedHOD] END,
     CASE @OrderBy WHEN 'ConcernedHOD DESC' THEN [SPMT_newPA].[ConcernedHOD] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [SPMT_newPA].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [SPMT_newPA].[Remarks] END DESC,
     CASE @OrderBy WHEN 'AdvanceRate' THEN [SPMT_newPA].[AdvanceRate] END,
     CASE @OrderBy WHEN 'AdvanceRate DESC' THEN [SPMT_newPA].[AdvanceRate] END DESC,
     CASE @OrderBy WHEN 'AdvanceAmount' THEN [SPMT_newPA].[AdvanceAmount] END,
     CASE @OrderBy WHEN 'AdvanceAmount DESC' THEN [SPMT_newPA].[AdvanceAmount] END DESC,
     CASE @OrderBy WHEN 'RetensionRate' THEN [SPMT_newPA].[RetensionRate] END,
     CASE @OrderBy WHEN 'RetensionRate DESC' THEN [SPMT_newPA].[RetensionRate] END DESC,
     CASE @OrderBy WHEN 'RetensionAmount' THEN [SPMT_newPA].[RetensionAmount] END,
     CASE @OrderBy WHEN 'RetensionAmount DESC' THEN [SPMT_newPA].[RetensionAmount] END DESC,
     CASE @OrderBy WHEN 'AccountsRemarks' THEN [SPMT_newPA].[AccountsRemarks] END,
     CASE @OrderBy WHEN 'AccountsRemarks DESC' THEN [SPMT_newPA].[AccountsRemarks] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [SPMT_newPA].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [SPMT_newPA].[StatusID] END DESC,
     CASE @OrderBy WHEN 'ReceivedInACBy' THEN [SPMT_newPA].[ReceivedInACBy] END,
     CASE @OrderBy WHEN 'ReceivedInACBy DESC' THEN [SPMT_newPA].[ReceivedInACBy] END DESC,
     CASE @OrderBy WHEN 'TotalAdviceAmount' THEN [SPMT_newPA].[TotalAdviceAmount] END,
     CASE @OrderBy WHEN 'TotalAdviceAmount DESC' THEN [SPMT_newPA].[TotalAdviceAmount] END DESC,
     CASE @OrderBy WHEN 'ReceivedInACOn' THEN [SPMT_newPA].[ReceivedInACOn] END,
     CASE @OrderBy WHEN 'ReceivedInACOn DESC' THEN [SPMT_newPA].[ReceivedInACOn] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [SPMT_newPA].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [SPMT_newPA].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'PostedInACBy' THEN [SPMT_newPA].[PostedInACBy] END,
     CASE @OrderBy WHEN 'PostedInACBy DESC' THEN [SPMT_newPA].[PostedInACBy] END DESC,
     CASE @OrderBy WHEN 'ERPCompany' THEN [SPMT_newPA].[ERPCompany] END,
     CASE @OrderBy WHEN 'ERPCompany DESC' THEN [SPMT_newPA].[ERPCompany] END DESC,
     CASE @OrderBy WHEN 'LockedInACBy' THEN [SPMT_newPA].[LockedInACBy] END,
     CASE @OrderBy WHEN 'LockedInACBy DESC' THEN [SPMT_newPA].[LockedInACBy] END DESC,
     CASE @OrderBy WHEN 'UploadBatchNo' THEN [SPMT_newPA].[UploadBatchNo] END,
     CASE @OrderBy WHEN 'UploadBatchNo DESC' THEN [SPMT_newPA].[UploadBatchNo] END DESC,
     CASE @OrderBy WHEN 'PostedInACOn' THEN [SPMT_newPA].[PostedInACOn] END,
     CASE @OrderBy WHEN 'PostedInACOn DESC' THEN [SPMT_newPA].[PostedInACOn] END DESC,
     CASE @OrderBy WHEN 'VoucherNo' THEN [SPMT_newPA].[VoucherNo] END,
     CASE @OrderBy WHEN 'VoucherNo DESC' THEN [SPMT_newPA].[VoucherNo] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [SPMT_newPA].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [SPMT_newPA].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'VoucherType' THEN [SPMT_newPA].[VoucherType] END,
     CASE @OrderBy WHEN 'VoucherType DESC' THEN [SPMT_newPA].[VoucherType] END DESC,
     CASE @OrderBy WHEN 'LockedInACOn' THEN [SPMT_newPA].[LockedInACOn] END,
     CASE @OrderBy WHEN 'LockedInACOn DESC' THEN [SPMT_newPA].[LockedInACOn] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users2_UserFullName' THEN [aspnet_Users2].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users2_UserFullName DESC' THEN [aspnet_Users2].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users3_UserFullName' THEN [aspnet_Users3].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users3_UserFullName DESC' THEN [aspnet_Users3].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users4_UserFullName' THEN [aspnet_Users4].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users4_UserFullName DESC' THEN [aspnet_Users4].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'HRM_Employees5_EmployeeName' THEN [HRM_Employees5].[EmployeeName] END,
     CASE @OrderBy WHEN 'HRM_Employees5_EmployeeName DESC' THEN [HRM_Employees5].[EmployeeName] END DESC,
     CASE @OrderBy WHEN 'SPMT_PAStatus6_Description' THEN [SPMT_PAStatus6].[Description] END,
     CASE @OrderBy WHEN 'SPMT_PAStatus6_Description DESC' THEN [SPMT_PAStatus6].[Description] END DESC,
     CASE @OrderBy WHEN 'SPMT_TranTypes7_Description' THEN [SPMT_TranTypes7].[Description] END,
     CASE @OrderBy WHEN 'SPMT_TranTypes7_Description DESC' THEN [SPMT_TranTypes7].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BusinessPartner8_BPName' THEN [VR_BusinessPartner8].[BPName] END,
     CASE @OrderBy WHEN 'VR_BusinessPartner8_BPName DESC' THEN [VR_BusinessPartner8].[BPName] END DESC 
  SET @RecordCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPAAutoCompleteList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPAAutoCompleteList]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPAAutoCompleteList]
  @LoginID NVarChar(8),
  @Prefix NVarChar(250),
  @Records Int,
  @ByCode Int 
  AS 
  BEGIN 
  DECLARE @Prefix1 VarChar(260)
  SET @Prefix1 = LOWER(@Prefix) + '%'
  DECLARE @LGSQL VarChar(8000)
  SET @LGSQL = 'SELECT TOP (' + STR(@Records) + ') ' 
  SET @LGSQL = @LGSQL + ' [SPMT_newPA].[BPID]' 
  SET @LGSQL = @LGSQL + ',[SPMT_newPA].[AdviceNo]' 
  SET @LGSQL = @LGSQL + ' FROM [SPMT_newPA] ' 
  SET @LGSQL = @LGSQL + ' WHERE 1 = 1 ' 
  SET @LGSQL = @LGSQL + ' AND (LTRIM(STR(ISNULL([SPMT_newPA].[AdviceNo],0))) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ' OR LOWER(ISNULL([SPMT_newPA].[BPID],'''')) LIKE ''' + @Prefix1 + ''''
  SET @LGSQL = @LGSQL + ')' 
  
  EXEC (@LGSQL)
  END 
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPASelectByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPASelectByID]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPASelectByID]
  @LoginID NVarChar(8),
  @AdviceNo Int 
  AS
  SELECT
    [SPMT_newPA].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [aspnet_Users2].[UserFullName] AS aspnet_Users2_UserFullName,
    [aspnet_Users3].[UserFullName] AS aspnet_Users3_UserFullName,
    [aspnet_Users4].[UserFullName] AS aspnet_Users4_UserFullName,
    [HRM_Employees5].[EmployeeName] AS HRM_Employees5_EmployeeName,
    [SPMT_PAStatus6].[Description] AS SPMT_PAStatus6_Description,
    [SPMT_TranTypes7].[Description] AS SPMT_TranTypes7_Description,
    [VR_BusinessPartner8].[BPName] AS VR_BusinessPartner8_BPName 
  FROM [SPMT_newPA] 
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_newPA].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users2]
    ON [SPMT_newPA].[ReceivedInACBy] = [aspnet_users2].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users3]
    ON [SPMT_newPA].[PostedInACBy] = [aspnet_users3].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users4]
    ON [SPMT_newPA].[LockedInACBy] = [aspnet_users4].[LoginID]
  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]
    ON [SPMT_newPA].[ConcernedHOD] = [HRM_Employees5].[CardNo]
  LEFT OUTER JOIN [SPMT_PAStatus] AS [SPMT_PAStatus6]
    ON [SPMT_newPA].[StatusID] = [SPMT_PAStatus6].[AdviceStatusID]
  LEFT OUTER JOIN [SPMT_TranTypes] AS [SPMT_TranTypes7]
    ON [SPMT_newPA].[TranTypeID] = [SPMT_TranTypes7].[TranTypeID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner8]
    ON [SPMT_newPA].[BPID] = [VR_BusinessPartner8].[BPID]
  WHERE
  [SPMT_newPA].[AdviceNo] = @AdviceNo
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPASelectListSearch]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPASelectListSearch]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPASelectListSearch]
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @KeyWord VarChar(250),
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
    DECLARE @KeyWord1 VarChar(260)
    SET @KeyWord1 = '%' + LOWER(@KeyWord) + '%'
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,AdviceNo Int NOT NULL
  )
  INSERT INTO #PageIndex (AdviceNo)
  SELECT [SPMT_newPA].[AdviceNo] FROM [SPMT_newPA]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_newPA].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users2]
    ON [SPMT_newPA].[ReceivedInACBy] = [aspnet_users2].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users3]
    ON [SPMT_newPA].[PostedInACBy] = [aspnet_users3].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users4]
    ON [SPMT_newPA].[LockedInACBy] = [aspnet_users4].[LoginID]
  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]
    ON [SPMT_newPA].[ConcernedHOD] = [HRM_Employees5].[CardNo]
  LEFT OUTER JOIN [SPMT_PAStatus] AS [SPMT_PAStatus6]
    ON [SPMT_newPA].[StatusID] = [SPMT_PAStatus6].[AdviceStatusID]
  LEFT OUTER JOIN [SPMT_TranTypes] AS [SPMT_TranTypes7]
    ON [SPMT_newPA].[TranTypeID] = [SPMT_TranTypes7].[TranTypeID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner8]
    ON [SPMT_newPA].[BPID] = [VR_BusinessPartner8].[BPID]
 WHERE  
   ( 
         STR(ISNULL([SPMT_newPA].[AdviceNo], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[TranTypeID],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[BPID],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[SupplierName],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[ConcernedHOD],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[Remarks],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_newPA].[AdvanceRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_newPA].[AdvanceAmount], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_newPA].[RetensionRate], 0)) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_newPA].[RetensionAmount], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[AccountsRemarks],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_newPA].[StatusID], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[ReceivedInACBy],'')) LIKE @KeyWord1
     OR STR(ISNULL([SPMT_newPA].[TotalAdviceAmount], 0)) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[PostedInACBy],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[ERPCompany],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[LockedInACBy],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[UploadBatchNo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[VoucherNo],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[CreatedBy],'')) LIKE @KeyWord1
     OR LOWER(ISNULL([SPMT_newPA].[VoucherType],'')) LIKE @KeyWord1
   ) 
  ORDER BY
     CASE @OrderBy WHEN 'AdviceNo' THEN [SPMT_newPA].[AdviceNo] END,
     CASE @OrderBy WHEN 'AdviceNo DESC' THEN [SPMT_newPA].[AdviceNo] END DESC,
     CASE @OrderBy WHEN 'TranTypeID' THEN [SPMT_newPA].[TranTypeID] END,
     CASE @OrderBy WHEN 'TranTypeID DESC' THEN [SPMT_newPA].[TranTypeID] END DESC,
     CASE @OrderBy WHEN 'BPID' THEN [SPMT_newPA].[BPID] END,
     CASE @OrderBy WHEN 'BPID DESC' THEN [SPMT_newPA].[BPID] END DESC,
     CASE @OrderBy WHEN 'SupplierName' THEN [SPMT_newPA].[SupplierName] END,
     CASE @OrderBy WHEN 'SupplierName DESC' THEN [SPMT_newPA].[SupplierName] END DESC,
     CASE @OrderBy WHEN 'ConcernedHOD' THEN [SPMT_newPA].[ConcernedHOD] END,
     CASE @OrderBy WHEN 'ConcernedHOD DESC' THEN [SPMT_newPA].[ConcernedHOD] END DESC,
     CASE @OrderBy WHEN 'Remarks' THEN [SPMT_newPA].[Remarks] END,
     CASE @OrderBy WHEN 'Remarks DESC' THEN [SPMT_newPA].[Remarks] END DESC,
     CASE @OrderBy WHEN 'AdvanceRate' THEN [SPMT_newPA].[AdvanceRate] END,
     CASE @OrderBy WHEN 'AdvanceRate DESC' THEN [SPMT_newPA].[AdvanceRate] END DESC,
     CASE @OrderBy WHEN 'AdvanceAmount' THEN [SPMT_newPA].[AdvanceAmount] END,
     CASE @OrderBy WHEN 'AdvanceAmount DESC' THEN [SPMT_newPA].[AdvanceAmount] END DESC,
     CASE @OrderBy WHEN 'RetensionRate' THEN [SPMT_newPA].[RetensionRate] END,
     CASE @OrderBy WHEN 'RetensionRate DESC' THEN [SPMT_newPA].[RetensionRate] END DESC,
     CASE @OrderBy WHEN 'RetensionAmount' THEN [SPMT_newPA].[RetensionAmount] END,
     CASE @OrderBy WHEN 'RetensionAmount DESC' THEN [SPMT_newPA].[RetensionAmount] END DESC,
     CASE @OrderBy WHEN 'AccountsRemarks' THEN [SPMT_newPA].[AccountsRemarks] END,
     CASE @OrderBy WHEN 'AccountsRemarks DESC' THEN [SPMT_newPA].[AccountsRemarks] END DESC,
     CASE @OrderBy WHEN 'StatusID' THEN [SPMT_newPA].[StatusID] END,
     CASE @OrderBy WHEN 'StatusID DESC' THEN [SPMT_newPA].[StatusID] END DESC,
     CASE @OrderBy WHEN 'ReceivedInACBy' THEN [SPMT_newPA].[ReceivedInACBy] END,
     CASE @OrderBy WHEN 'ReceivedInACBy DESC' THEN [SPMT_newPA].[ReceivedInACBy] END DESC,
     CASE @OrderBy WHEN 'TotalAdviceAmount' THEN [SPMT_newPA].[TotalAdviceAmount] END,
     CASE @OrderBy WHEN 'TotalAdviceAmount DESC' THEN [SPMT_newPA].[TotalAdviceAmount] END DESC,
     CASE @OrderBy WHEN 'ReceivedInACOn' THEN [SPMT_newPA].[ReceivedInACOn] END,
     CASE @OrderBy WHEN 'ReceivedInACOn DESC' THEN [SPMT_newPA].[ReceivedInACOn] END DESC,
     CASE @OrderBy WHEN 'CreatedOn' THEN [SPMT_newPA].[CreatedOn] END,
     CASE @OrderBy WHEN 'CreatedOn DESC' THEN [SPMT_newPA].[CreatedOn] END DESC,
     CASE @OrderBy WHEN 'PostedInACBy' THEN [SPMT_newPA].[PostedInACBy] END,
     CASE @OrderBy WHEN 'PostedInACBy DESC' THEN [SPMT_newPA].[PostedInACBy] END DESC,
     CASE @OrderBy WHEN 'ERPCompany' THEN [SPMT_newPA].[ERPCompany] END,
     CASE @OrderBy WHEN 'ERPCompany DESC' THEN [SPMT_newPA].[ERPCompany] END DESC,
     CASE @OrderBy WHEN 'LockedInACBy' THEN [SPMT_newPA].[LockedInACBy] END,
     CASE @OrderBy WHEN 'LockedInACBy DESC' THEN [SPMT_newPA].[LockedInACBy] END DESC,
     CASE @OrderBy WHEN 'UploadBatchNo' THEN [SPMT_newPA].[UploadBatchNo] END,
     CASE @OrderBy WHEN 'UploadBatchNo DESC' THEN [SPMT_newPA].[UploadBatchNo] END DESC,
     CASE @OrderBy WHEN 'PostedInACOn' THEN [SPMT_newPA].[PostedInACOn] END,
     CASE @OrderBy WHEN 'PostedInACOn DESC' THEN [SPMT_newPA].[PostedInACOn] END DESC,
     CASE @OrderBy WHEN 'VoucherNo' THEN [SPMT_newPA].[VoucherNo] END,
     CASE @OrderBy WHEN 'VoucherNo DESC' THEN [SPMT_newPA].[VoucherNo] END DESC,
     CASE @OrderBy WHEN 'CreatedBy' THEN [SPMT_newPA].[CreatedBy] END,
     CASE @OrderBy WHEN 'CreatedBy DESC' THEN [SPMT_newPA].[CreatedBy] END DESC,
     CASE @OrderBy WHEN 'VoucherType' THEN [SPMT_newPA].[VoucherType] END,
     CASE @OrderBy WHEN 'VoucherType DESC' THEN [SPMT_newPA].[VoucherType] END DESC,
     CASE @OrderBy WHEN 'LockedInACOn' THEN [SPMT_newPA].[LockedInACOn] END,
     CASE @OrderBy WHEN 'LockedInACOn DESC' THEN [SPMT_newPA].[LockedInACOn] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName' THEN [aspnet_Users1].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users1_UserFullName DESC' THEN [aspnet_Users1].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users2_UserFullName' THEN [aspnet_Users2].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users2_UserFullName DESC' THEN [aspnet_Users2].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users3_UserFullName' THEN [aspnet_Users3].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users3_UserFullName DESC' THEN [aspnet_Users3].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'aspnet_Users4_UserFullName' THEN [aspnet_Users4].[UserFullName] END,
     CASE @OrderBy WHEN 'aspnet_Users4_UserFullName DESC' THEN [aspnet_Users4].[UserFullName] END DESC,
     CASE @OrderBy WHEN 'HRM_Employees5_EmployeeName' THEN [HRM_Employees5].[EmployeeName] END,
     CASE @OrderBy WHEN 'HRM_Employees5_EmployeeName DESC' THEN [HRM_Employees5].[EmployeeName] END DESC,
     CASE @OrderBy WHEN 'SPMT_PAStatus6_Description' THEN [SPMT_PAStatus6].[Description] END,
     CASE @OrderBy WHEN 'SPMT_PAStatus6_Description DESC' THEN [SPMT_PAStatus6].[Description] END DESC,
     CASE @OrderBy WHEN 'SPMT_TranTypes7_Description' THEN [SPMT_TranTypes7].[Description] END,
     CASE @OrderBy WHEN 'SPMT_TranTypes7_Description DESC' THEN [SPMT_TranTypes7].[Description] END DESC,
     CASE @OrderBy WHEN 'VR_BusinessPartner8_BPName' THEN [VR_BusinessPartner8].[BPName] END,
     CASE @OrderBy WHEN 'VR_BusinessPartner8_BPName DESC' THEN [VR_BusinessPartner8].[BPName] END DESC 

    SET @RecordCount = @@RowCount

  SELECT
    [SPMT_newPA].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [aspnet_Users2].[UserFullName] AS aspnet_Users2_UserFullName,
    [aspnet_Users3].[UserFullName] AS aspnet_Users3_UserFullName,
    [aspnet_Users4].[UserFullName] AS aspnet_Users4_UserFullName,
    [HRM_Employees5].[EmployeeName] AS HRM_Employees5_EmployeeName,
    [SPMT_PAStatus6].[Description] AS SPMT_PAStatus6_Description,
    [SPMT_TranTypes7].[Description] AS SPMT_TranTypes7_Description,
    [VR_BusinessPartner8].[BPName] AS VR_BusinessPartner8_BPName 
  FROM [SPMT_newPA] 
      INNER JOIN #PageIndex
          ON [SPMT_newPA].[AdviceNo] = #PageIndex.AdviceNo
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_newPA].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users2]
    ON [SPMT_newPA].[ReceivedInACBy] = [aspnet_users2].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users3]
    ON [SPMT_newPA].[PostedInACBy] = [aspnet_users3].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users4]
    ON [SPMT_newPA].[LockedInACBy] = [aspnet_users4].[LoginID]
  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]
    ON [SPMT_newPA].[ConcernedHOD] = [HRM_Employees5].[CardNo]
  LEFT OUTER JOIN [SPMT_PAStatus] AS [SPMT_PAStatus6]
    ON [SPMT_newPA].[StatusID] = [SPMT_PAStatus6].[AdviceStatusID]
  LEFT OUTER JOIN [SPMT_TranTypes] AS [SPMT_TranTypes7]
    ON [SPMT_newPA].[TranTypeID] = [SPMT_TranTypes7].[TranTypeID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner8]
    ON [SPMT_newPA].[BPID] = [VR_BusinessPartner8].[BPID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPASelectListFilteres]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPASelectListFilteres]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPASelectListFilteres]
  @Filter_TranTypeID NVarChar(3),
  @Filter_BPID NVarChar(9),
  @Filter_CreatedBy NVarChar(8),
  @LoginID NVarChar(8),
  @StartRowIndex int,
  @MaximumRows int,
  @OrderBy NVarChar(50),
  @RecordCount Int = 0 OUTPUT
  AS
  BEGIN
  DECLARE @LGSQL VarChar(8000)
  CREATE TABLE #PageIndex (
  IndexID INT IDENTITY (1, 1) NOT NULL
 ,AdviceNo Int NOT NULL
  )
  SET @LGSQL = 'INSERT INTO #PageIndex (' 
  SET @LGSQL = @LGSQL + 'AdviceNo'
  SET @LGSQL = @LGSQL + ')'
  SET @LGSQL = @LGSQL + ' SELECT '
  SET @LGSQL = @LGSQL + '[SPMT_newPA].[AdviceNo]'
  SET @LGSQL = @LGSQL + ' FROM [SPMT_newPA] '
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[CreatedBy] = [aspnet_users1].[LoginID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users2]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[ReceivedInACBy] = [aspnet_users2].[LoginID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users3]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[PostedInACBy] = [aspnet_users3].[LoginID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users4]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[LockedInACBy] = [aspnet_users4].[LoginID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[ConcernedHOD] = [HRM_Employees5].[CardNo]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_PAStatus] AS [SPMT_PAStatus6]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[StatusID] = [SPMT_PAStatus6].[AdviceStatusID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [SPMT_TranTypes] AS [SPMT_TranTypes7]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[TranTypeID] = [SPMT_TranTypes7].[TranTypeID]'
  SET @LGSQL = @LGSQL + '  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner8]'
  SET @LGSQL = @LGSQL + '    ON [SPMT_newPA].[BPID] = [VR_BusinessPartner8].[BPID]'
  SET @LGSQL = @LGSQL + '  WHERE 1 = 1 '
  IF (@Filter_TranTypeID > '') 
    SET @LGSQL = @LGSQL + ' AND [SPMT_newPA].[TranTypeID] = ''' + @Filter_TranTypeID + ''''
  IF (@Filter_BPID > '') 
    SET @LGSQL = @LGSQL + ' AND [SPMT_newPA].[BPID] = ''' + @Filter_BPID + ''''
  IF (@Filter_CreatedBy > '') 
    SET @LGSQL = @LGSQL + ' AND [SPMT_newPA].[CreatedBy] = ''' + @Filter_CreatedBy + ''''
  SET @LGSQL = @LGSQL + '  ORDER BY '
  SET @LGSQL = @LGSQL + CASE @OrderBy
                        WHEN 'AdviceNo' THEN '[SPMT_newPA].[AdviceNo]'
                        WHEN 'AdviceNo DESC' THEN '[SPMT_newPA].[AdviceNo] DESC'
                        WHEN 'TranTypeID' THEN '[SPMT_newPA].[TranTypeID]'
                        WHEN 'TranTypeID DESC' THEN '[SPMT_newPA].[TranTypeID] DESC'
                        WHEN 'BPID' THEN '[SPMT_newPA].[BPID]'
                        WHEN 'BPID DESC' THEN '[SPMT_newPA].[BPID] DESC'
                        WHEN 'SupplierName' THEN '[SPMT_newPA].[SupplierName]'
                        WHEN 'SupplierName DESC' THEN '[SPMT_newPA].[SupplierName] DESC'
                        WHEN 'ConcernedHOD' THEN '[SPMT_newPA].[ConcernedHOD]'
                        WHEN 'ConcernedHOD DESC' THEN '[SPMT_newPA].[ConcernedHOD] DESC'
                        WHEN 'Remarks' THEN '[SPMT_newPA].[Remarks]'
                        WHEN 'Remarks DESC' THEN '[SPMT_newPA].[Remarks] DESC'
                        WHEN 'AdvanceRate' THEN '[SPMT_newPA].[AdvanceRate]'
                        WHEN 'AdvanceRate DESC' THEN '[SPMT_newPA].[AdvanceRate] DESC'
                        WHEN 'AdvanceAmount' THEN '[SPMT_newPA].[AdvanceAmount]'
                        WHEN 'AdvanceAmount DESC' THEN '[SPMT_newPA].[AdvanceAmount] DESC'
                        WHEN 'RetensionRate' THEN '[SPMT_newPA].[RetensionRate]'
                        WHEN 'RetensionRate DESC' THEN '[SPMT_newPA].[RetensionRate] DESC'
                        WHEN 'RetensionAmount' THEN '[SPMT_newPA].[RetensionAmount]'
                        WHEN 'RetensionAmount DESC' THEN '[SPMT_newPA].[RetensionAmount] DESC'
                        WHEN 'AccountsRemarks' THEN '[SPMT_newPA].[AccountsRemarks]'
                        WHEN 'AccountsRemarks DESC' THEN '[SPMT_newPA].[AccountsRemarks] DESC'
                        WHEN 'StatusID' THEN '[SPMT_newPA].[StatusID]'
                        WHEN 'StatusID DESC' THEN '[SPMT_newPA].[StatusID] DESC'
                        WHEN 'ReceivedInACBy' THEN '[SPMT_newPA].[ReceivedInACBy]'
                        WHEN 'ReceivedInACBy DESC' THEN '[SPMT_newPA].[ReceivedInACBy] DESC'
                        WHEN 'TotalAdviceAmount' THEN '[SPMT_newPA].[TotalAdviceAmount]'
                        WHEN 'TotalAdviceAmount DESC' THEN '[SPMT_newPA].[TotalAdviceAmount] DESC'
                        WHEN 'ReceivedInACOn' THEN '[SPMT_newPA].[ReceivedInACOn]'
                        WHEN 'ReceivedInACOn DESC' THEN '[SPMT_newPA].[ReceivedInACOn] DESC'
                        WHEN 'CreatedOn' THEN '[SPMT_newPA].[CreatedOn]'
                        WHEN 'CreatedOn DESC' THEN '[SPMT_newPA].[CreatedOn] DESC'
                        WHEN 'PostedInACBy' THEN '[SPMT_newPA].[PostedInACBy]'
                        WHEN 'PostedInACBy DESC' THEN '[SPMT_newPA].[PostedInACBy] DESC'
                        WHEN 'ERPCompany' THEN '[SPMT_newPA].[ERPCompany]'
                        WHEN 'ERPCompany DESC' THEN '[SPMT_newPA].[ERPCompany] DESC'
                        WHEN 'LockedInACBy' THEN '[SPMT_newPA].[LockedInACBy]'
                        WHEN 'LockedInACBy DESC' THEN '[SPMT_newPA].[LockedInACBy] DESC'
                        WHEN 'UploadBatchNo' THEN '[SPMT_newPA].[UploadBatchNo]'
                        WHEN 'UploadBatchNo DESC' THEN '[SPMT_newPA].[UploadBatchNo] DESC'
                        WHEN 'PostedInACOn' THEN '[SPMT_newPA].[PostedInACOn]'
                        WHEN 'PostedInACOn DESC' THEN '[SPMT_newPA].[PostedInACOn] DESC'
                        WHEN 'VoucherNo' THEN '[SPMT_newPA].[VoucherNo]'
                        WHEN 'VoucherNo DESC' THEN '[SPMT_newPA].[VoucherNo] DESC'
                        WHEN 'CreatedBy' THEN '[SPMT_newPA].[CreatedBy]'
                        WHEN 'CreatedBy DESC' THEN '[SPMT_newPA].[CreatedBy] DESC'
                        WHEN 'VoucherType' THEN '[SPMT_newPA].[VoucherType]'
                        WHEN 'VoucherType DESC' THEN '[SPMT_newPA].[VoucherType] DESC'
                        WHEN 'LockedInACOn' THEN '[SPMT_newPA].[LockedInACOn]'
                        WHEN 'LockedInACOn DESC' THEN '[SPMT_newPA].[LockedInACOn] DESC'
                        WHEN 'aspnet_Users1_UserFullName' THEN '[aspnet_Users1].[UserFullName]'
                        WHEN 'aspnet_Users1_UserFullName DESC' THEN '[aspnet_Users1].[UserFullName] DESC'
                        WHEN 'aspnet_Users2_UserFullName' THEN '[aspnet_Users2].[UserFullName]'
                        WHEN 'aspnet_Users2_UserFullName DESC' THEN '[aspnet_Users2].[UserFullName] DESC'
                        WHEN 'aspnet_Users3_UserFullName' THEN '[aspnet_Users3].[UserFullName]'
                        WHEN 'aspnet_Users3_UserFullName DESC' THEN '[aspnet_Users3].[UserFullName] DESC'
                        WHEN 'aspnet_Users4_UserFullName' THEN '[aspnet_Users4].[UserFullName]'
                        WHEN 'aspnet_Users4_UserFullName DESC' THEN '[aspnet_Users4].[UserFullName] DESC'
                        WHEN 'HRM_Employees5_EmployeeName' THEN '[HRM_Employees5].[EmployeeName]'
                        WHEN 'HRM_Employees5_EmployeeName DESC' THEN '[HRM_Employees5].[EmployeeName] DESC'
                        WHEN 'SPMT_PAStatus6_Description' THEN '[SPMT_PAStatus6].[Description]'
                        WHEN 'SPMT_PAStatus6_Description DESC' THEN '[SPMT_PAStatus6].[Description] DESC'
                        WHEN 'SPMT_TranTypes7_Description' THEN '[SPMT_TranTypes7].[Description]'
                        WHEN 'SPMT_TranTypes7_Description DESC' THEN '[SPMT_TranTypes7].[Description] DESC'
                        WHEN 'VR_BusinessPartner8_BPName' THEN '[VR_BusinessPartner8].[BPName]'
                        WHEN 'VR_BusinessPartner8_BPName DESC' THEN '[VR_BusinessPartner8].[BPName] DESC'
                        ELSE '[SPMT_newPA].[AdviceNo]'
                    END
  EXEC (@LGSQL)

  SET @RecordCount = @@RowCount

  SELECT
    [SPMT_newPA].* ,
    [aspnet_Users1].[UserFullName] AS aspnet_Users1_UserFullName,
    [aspnet_Users2].[UserFullName] AS aspnet_Users2_UserFullName,
    [aspnet_Users3].[UserFullName] AS aspnet_Users3_UserFullName,
    [aspnet_Users4].[UserFullName] AS aspnet_Users4_UserFullName,
    [HRM_Employees5].[EmployeeName] AS HRM_Employees5_EmployeeName,
    [SPMT_PAStatus6].[Description] AS SPMT_PAStatus6_Description,
    [SPMT_TranTypes7].[Description] AS SPMT_TranTypes7_Description,
    [VR_BusinessPartner8].[BPName] AS VR_BusinessPartner8_BPName 
  FROM [SPMT_newPA] 
      INNER JOIN #PageIndex
          ON [SPMT_newPA].[AdviceNo] = #PageIndex.AdviceNo
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users1]
    ON [SPMT_newPA].[CreatedBy] = [aspnet_users1].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users2]
    ON [SPMT_newPA].[ReceivedInACBy] = [aspnet_users2].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users3]
    ON [SPMT_newPA].[PostedInACBy] = [aspnet_users3].[LoginID]
  LEFT OUTER JOIN [aspnet_users] AS [aspnet_users4]
    ON [SPMT_newPA].[LockedInACBy] = [aspnet_users4].[LoginID]
  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]
    ON [SPMT_newPA].[ConcernedHOD] = [HRM_Employees5].[CardNo]
  LEFT OUTER JOIN [SPMT_PAStatus] AS [SPMT_PAStatus6]
    ON [SPMT_newPA].[StatusID] = [SPMT_PAStatus6].[AdviceStatusID]
  LEFT OUTER JOIN [SPMT_TranTypes] AS [SPMT_TranTypes7]
    ON [SPMT_newPA].[TranTypeID] = [SPMT_TranTypes7].[TranTypeID]
  LEFT OUTER JOIN [VR_BusinessPartner] AS [VR_BusinessPartner8]
    ON [SPMT_newPA].[BPID] = [VR_BusinessPartner8].[BPID]
  WHERE
        #PageIndex.IndexID > @StartRowIndex
        AND #PageIndex.IndexID < (@StartRowIndex + @MaximumRows + 1)
  ORDER BY
    #PageIndex.IndexID
  END
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPAInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPAInsert]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPAInsert]
  @TranTypeID NVarChar(3),
  @BPID NVarChar(9),
  @SupplierName NVarChar(100),
  @ConcernedHOD NVarChar(8),
  @Remarks NVarChar(500),
  @AdvanceRate Decimal(18,2),
  @AdvanceAmount Decimal(18,2),
  @RetensionRate Decimal(18,2),
  @RetensionAmount Decimal(18,2),
  @AccountsRemarks NVarChar(100),
  @StatusID Int,
  @ReceivedInACBy NVarChar(8),
  @TotalAdviceAmount Decimal(18,2),
  @ReceivedInACOn DateTime,
  @CreatedOn DateTime,
  @PostedInACBy NVarChar(8),
  @ERPCompany NVarChar(3),
  @LockedInACBy NVarChar(8),
  @UploadBatchNo NVarChar(50),
  @PostedInACOn DateTime,
  @VoucherNo NVarChar(10),
  @CreatedBy NVarChar(8),
  @VoucherType NVarChar(3),
  @LockedInACOn DateTime,
  @Return_AdviceNo Int = null OUTPUT 
  AS
  INSERT [SPMT_newPA]
  (
   [TranTypeID]
  ,[BPID]
  ,[SupplierName]
  ,[ConcernedHOD]
  ,[Remarks]
  ,[AdvanceRate]
  ,[AdvanceAmount]
  ,[RetensionRate]
  ,[RetensionAmount]
  ,[AccountsRemarks]
  ,[StatusID]
  ,[ReceivedInACBy]
  ,[TotalAdviceAmount]
  ,[ReceivedInACOn]
  ,[CreatedOn]
  ,[PostedInACBy]
  ,[ERPCompany]
  ,[LockedInACBy]
  ,[UploadBatchNo]
  ,[PostedInACOn]
  ,[VoucherNo]
  ,[CreatedBy]
  ,[VoucherType]
  ,[LockedInACOn]
  )
  VALUES
  (
   @TranTypeID
  ,@BPID
  ,@SupplierName
  ,@ConcernedHOD
  ,@Remarks
  ,@AdvanceRate
  ,@AdvanceAmount
  ,@RetensionRate
  ,@RetensionAmount
  ,@AccountsRemarks
  ,@StatusID
  ,@ReceivedInACBy
  ,@TotalAdviceAmount
  ,@ReceivedInACOn
  ,@CreatedOn
  ,@PostedInACBy
  ,@ERPCompany
  ,@LockedInACBy
  ,@UploadBatchNo
  ,@PostedInACOn
  ,@VoucherNo
  ,@CreatedBy
  ,@VoucherType
  ,@LockedInACOn
  )
  SET @Return_AdviceNo = Scope_Identity()
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPAUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPAUpdate]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPAUpdate]
  @Original_AdviceNo Int, 
  @TranTypeID NVarChar(3),
  @BPID NVarChar(9),
  @SupplierName NVarChar(100),
  @ConcernedHOD NVarChar(8),
  @Remarks NVarChar(500),
  @AdvanceRate Decimal(18,2),
  @AdvanceAmount Decimal(18,2),
  @RetensionRate Decimal(18,2),
  @RetensionAmount Decimal(18,2),
  @AccountsRemarks NVarChar(100),
  @StatusID Int,
  @ReceivedInACBy NVarChar(8),
  @TotalAdviceAmount Decimal(18,2),
  @ReceivedInACOn DateTime,
  @CreatedOn DateTime,
  @PostedInACBy NVarChar(8),
  @ERPCompany NVarChar(3),
  @LockedInACBy NVarChar(8),
  @UploadBatchNo NVarChar(50),
  @PostedInACOn DateTime,
  @VoucherNo NVarChar(10),
  @CreatedBy NVarChar(8),
  @VoucherType NVarChar(3),
  @LockedInACOn DateTime,
  @RowCount int = null OUTPUT
  AS
  UPDATE [SPMT_newPA] SET 
   [TranTypeID] = @TranTypeID
  ,[BPID] = @BPID
  ,[SupplierName] = @SupplierName
  ,[ConcernedHOD] = @ConcernedHOD
  ,[Remarks] = @Remarks
  ,[AdvanceRate] = @AdvanceRate
  ,[AdvanceAmount] = @AdvanceAmount
  ,[RetensionRate] = @RetensionRate
  ,[RetensionAmount] = @RetensionAmount
  ,[AccountsRemarks] = @AccountsRemarks
  ,[StatusID] = @StatusID
  ,[ReceivedInACBy] = @ReceivedInACBy
  ,[TotalAdviceAmount] = @TotalAdviceAmount
  ,[ReceivedInACOn] = @ReceivedInACOn
  ,[CreatedOn] = @CreatedOn
  ,[PostedInACBy] = @PostedInACBy
  ,[ERPCompany] = @ERPCompany
  ,[LockedInACBy] = @LockedInACBy
  ,[UploadBatchNo] = @UploadBatchNo
  ,[PostedInACOn] = @PostedInACOn
  ,[VoucherNo] = @VoucherNo
  ,[CreatedBy] = @CreatedBy
  ,[VoucherType] = @VoucherType
  ,[LockedInACOn] = @LockedInACOn
  WHERE
  [AdviceNo] = @Original_AdviceNo
  SET @RowCount = @@RowCount
  GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spspmtNewPADelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spspmtNewPADelete]
GO
 
CREATE PROCEDURE [dbo].[spspmtNewPADelete]
  @Original_AdviceNo Int,
  @RowCount int = null OUTPUT
  AS
  DELETE [SPMT_newPA]
  WHERE
  [SPMT_newPA].[AdviceNo] = @Original_AdviceNo
  SET @RowCount = @@RowCount
  GO

SET QUOTED_IDENTIFIER OFF
GO
SET ANSI_NULLS ON
GO
