Imports Microsoft.VisualBasic

Public Enum TptBillStatus
	Cancelled = 1
	Free = 2
	UnderReceiveByAccounts = 3
	UnderReceiveByLogistics = 4
	UnderReSubmitbyLogistics = 5
	UnderPaymentProcessing = 6
	PaymentProcessed = 7
	Closed = 8
	PTRCreated = 9
End Enum

