Option Strict Off
Option Explicit On
Friend Class frmPELATES
	Inherits System.Windows.Forms.Form
	
	Private Sub frmPELATES_Paint(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
		If Len(Lab1.Text) = 0 Then
		Else
			
			
			datPrimaryRS.RecordSource = Lab1.Text '=  select ONOMA,DIR,RIZA,C1,C2,C3,D1,D2,D3,HME,N1,N2,N3 from PELATES
			datPrimaryRS.Refresh()
			
		End If
		
	End Sub
	
	Private Sub frmPELATES_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub datPrimaryRS_Error(ByVal ErrorNumber As Integer, ByRef Description As String, ByVal Scode As Integer, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Integer, ByRef fCancelDisplay As Boolean) Handles datPrimaryRS.Error
		'This is where you would put error handling code
		'If you want to ignore errors, comment out the next line
		'If you want to trap them, add code here to handle them
		MsgBox("Data error event hit err:" & Description)
	End Sub
	
	'Private Sub datPrimaryRS_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
	'  'This will display the current record position for this recordset
	'  datPrimaryRS.Caption = "Record: " & CStr(datPrimaryRS.Recordset.AbsolutePosition)
	'End Sub
	
	'Private Sub datPrimaryRS_WillChangeRecord(ByVal adReason As ADODB.EventReasonEnum, ByVal cRecords As Long, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
	'  'This is where you put validation code
	'  'This event gets called when the following actions occur
	'  Dim bCancel As Boolean
	'
	'  Select Case adReason
	'  Case adRsnAddNew
	'  Case adRsnClose
	'  Case adRsnDelete
	'  Case adRsnFirstChange
	'  Case adRsnMove
	'  Case adRsnRequery
	'  Case adRsnResynch
	'  Case adRsnUndoAddNew
	'  Case adRsnUndoDelete
	'  Case adRsnUndoUpdate
	'  Case adRsnUpdate
	'  End Select
	'
	'  If bCancel Then adStatus = adStatusCancel
	' End Sub
	
	Private Sub cmdAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdd.Click
		On Error GoTo AddErr
		datPrimaryRS.Recordset.AddNew()
		
		Exit Sub
AddErr: 
		MsgBox(Err.Description)
	End Sub
	
	Private Sub cmdDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.Click
		On Error GoTo DeleteErr
		With datPrimaryRS.Recordset
			.Delete()
			.MoveNext()
			If .EOF Then .MoveLast()
		End With
		Exit Sub
DeleteErr: 
		MsgBox(Err.Description)
	End Sub
	
	Private Sub cmdRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.Click
		'This is only needed for multi user apps
		On Error GoTo RefreshErr
		datPrimaryRS.Refresh()
		Exit Sub
RefreshErr: 
		MsgBox(Err.Description)
	End Sub
	
	Private Sub cmdUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUpdate.Click
		On Error GoTo UpdateErr
		
		datPrimaryRS.Recordset.UpdateBatch(ADODB.AffectEnum.adAffectAll)
		Exit Sub
UpdateErr: 
		MsgBox(Err.Description)
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Me.Close()
	End Sub
End Class