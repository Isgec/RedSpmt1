﻿Imports Microsoft.VisualBasic

Public Enum spmtPAStates
  Cancelled = 1
  Returned = 2
  Free = 3
  IRLinked = 4
  UnderHODFeedback = 5
  UnderApprovalHR = 6
  ForwardedToAC = 7
  ReceivedInAC = 8
  Returning = 9
  UpdatingVoucher = 10
  VoucherUpdated = 11
  Locked = 12
End Enum
