Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Dim FIRST_TIME As Short
	
	
	Private Sub Check_directory()
		' δημιουργεί το directory \backup αν δεν υπάρχει
		Dim mdir As Object
		On Error GoTo create
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mdir = Dir(Text1.Text & "\*.zip")
		'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If mdir = "" Then
			MkDir(Text1.Text)
		End If
		Exit Sub
		
create: 
		MkDir(Text1.Text)
		
	End Sub
	
	Function ACCESS_TO_ACCESS(ByRef file As Object, ByRef MDB1 As Object, ByRef MDB2 As Object) As Object
		'ΜΕΤΑΦΟΡΑ ΑΡΧΕΙΟΥ FILE ΑΠΟ MDB1 ΣΕ MDB2 DATABASE
		Dim Errors, mydb As Object
		'On Error GoTo ERR
		'UPGRADE_WARNING: Couldn't resolve default property of object Errors. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Errors = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object MDB2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mydb = DAODBEngine_definst.Workspaces(0).OpenDatabase(MDB2)
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mydb.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mydb.Execute("drop table " + file)
		
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MDB1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mydb = DAODBEngine_definst.Workspaces(0).OpenDatabase(MDB1)
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object MDB2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mydb.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mydb.Execute("SELECT " + file + ".* INTO " + file + " in '" + MDB2 + "'  from " + file, DAO.RecordsetOptionEnum.dbFailOnError)
		'UPGRADE_WARNING: Couldn't resolve default property of object Errors. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ACCESS_TO_ACCESS. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ACCESS_TO_ACCESS = Errors
		Exit Function
ERR_Renamed: 
		'UPGRADE_WARNING: Couldn't resolve default property of object Errors. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Errors = 1
		Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Problem occurer during the transfer " + file)
	End Function
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim mystamp, A, mday, k, ans As Object
		
		'Check_directory
		'UPGRADE_WARNING: Couldn't resolve default property of object mday. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mday = LTrim(Str(VB.Day(Today)))
		
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object mday. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mystamp = FileDateTime(Text1.Text & "\" + mday + ".zip") ' Returns "2/12/93 4:35:47 PM".
		
		If Check1.CheckState Then
			MsgBox("Attention ! This is not a normal backup." & Chr(13) & "It will create the file service.zip")
			'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			A = Shell("\TALOS\pkzip.exe  " & Text1.Text & "\service   \talos\recipies.mdb", 1)
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
			If DateDiff(Microsoft.VisualBasic.DateInterval.Day, mystamp, Today) > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object mday. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A = Shell("\TALOS\pkzip.exe  " & Text1.Text & "\" + mday + " \talos\*.mdb \talos\*.dbf", 1)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ans = MsgBox("Allready exists.Overwrite the previous backup?", MsgBoxStyle.YesNo)
				If ans = MsgBoxResult.Yes Then
					'UPGRADE_WARNING: Couldn't resolve default property of object mday. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A = Shell("\TALOS\pkzip.exe  " & Text1.Text & "\" + mday + " \talos\*.mdb \talos\*.dbf", 1)
				End If
			End If
			
		End If
		
		File1.Visible = False
		For k = 1 To 1000
			System.Windows.Forms.Application.DoEvents()
		Next 
		
		'File1.Path = "c:\backup"
		
		File1.Refresh()
		File1.Visible = True
	End Sub
	
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim A, mdir, ans, myvalue, mystamp, Recipies_stamp As Object
		If UCase(VB.Right(File1.FileName, 3)) <> "ZIP" Then
			MsgBox("You must click the file from which I will restore.") 'Δεν δείξατε από ποιό αρχείο θα γίνει η επαναφορά"
			Exit Sub
		End If
		
		
		If UCase(VB.Left(File1.FileName, 3)) = "SER" Then
			MsgBox("This file is for service. The RESTORE procedure will stop.") 'Δεν δείξατε από ποιό αρχείο θα γίνει η επαναφορά"
			Exit Sub
		End If
		
		
		
		
		
		'UPGRADE_WARNING: Couldn't resolve default property of object ans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ans = MsgBox("The current files will be replaced with BACKUP files." & Chr(13) & "Are you sure?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2)
		
		If ans = MsgBoxResult.No Then
			Exit Sub
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object myvalue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		myvalue = InputBox("Give the password 1234567890",  , Space(10))
		
		'UPGRADE_WARNING: Couldn't resolve default property of object myvalue. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If myvalue <> "1234567890" Then Exit Sub
		ChDir("\talos")
		
		If CurDir() = "C:\TALOS" Then
			
			
			
			
			'αντιγραφει το σημερινό recipies.mdb στο    "c:\"
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			mdir = Dir("c:\rec.mdb")
			'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If mdir <> "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mystamp = FileDateTime("\rec.mdb") ' Returns "2/12/93 4:35:47 PM".
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mystamp = System.Date.FromOADate(Today.ToOADate - 1)
			End If
			'εάν αυτό που είναι στο root ειναι παλιό πάρε το καινούριο
			'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
			If DateDiff(Microsoft.VisualBasic.DateInterval.Day, mystamp, Today) > 0 Then
				FileCopy("recipies.mdb", "\rec.mdb")
			End If
			
			' Recipies_stamp = FileDateTime("recipies.mdb")
			
			If Check3.CheckState Then
				'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A = Shell("\TALOS\pkUNzip.exe  -o " & Text1.Text & "\" & File1.FileName & " Coord_tb.mdb", 1)
			ElseIf Check2.CheckState Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A = Shell("\TALOS\pkUNzip.exe  -o " & Text1.Text & "\" & File1.FileName & " -xCoord_tb.mdb", 1)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A = Shell("\TALOS\pkUNzip.exe  -o " & Text1.Text & "\" & File1.FileName, 1)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object Recipies_stamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Recipies_stamp = FileDateTime("recipies.mdb") Then
				MsgBox("The restore procedure was not completed." & Chr(13) & "!!!!")
			Else
				MsgBox("The restore procedure was successful.")
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ans. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ans = MsgBox("Would you like to Try to save the file with today solutions ? ", MsgBoxStyle.YesNo, "Keep the solutions,otherwise make all the today solutions.")
			
			If ans = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ACCESS_TO_ACCESS(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				A = ACCESS_TO_ACCESS("ximitech", "c:\rec.mdb", "c:\talos\recipies.mdb")
				
				'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If A = 0 Then
					MsgBox("The transfer completed.")
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object A. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					A = Shell("\TALOS\pkUNzip.exe  -o " & Text1.Text & "\" & File1.FileName & " recipies.mdb", 1)
					MsgBox("The file with solutions was not saved.")
					MsgBox("The today solutions are not in the memory. Take care of it.")
				End If
			End If
			
		End If
		
	End Sub
	
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim A, mday, mystamp, ans As Object
		
		'Check_directory
		'UPGRADE_WARNING: Couldn't resolve default property of object mday. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mday = LTrim(Str(VB.Day(Today)))
		'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mystamp = "--"
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object mday. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mystamp = FileDateTime(Text1.Text & "\" + mday + ".zip") ' Returns "2/12/93 4:35:47 PM".
		On Error GoTo 0
		'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If mystamp = "--" Then
			MsgBox("Make a backup first")
			Exit Sub
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object mystamp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
			If DateDiff(Microsoft.VisualBasic.DateInterval.Day, mystamp, Today) > 0 Then
				MsgBox("Make a backup first")
				Exit Sub
			End If
		End If
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		
		
		
		
		
		
		
		
		
		On Error Resume Next
		Kill("c:\talos\rec.mdb")
		On Error GoTo 0
		DAODBEngine_definst.CompactDatabase("c:\talos\recipies.mdb", "c:\talos\rec.mdb", DAO.LanguageConstants.dbLangGreek)
		FileCopy("c:\talos\rec.mdb", "c:\talos\recipies.mdb") ' Copy source to target.
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B3B44E51-B5F1-4FD7-AA29-CAD31B71F487"'
		'UPGRADE_ISSUE: Form property Form1.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbNormal
		MsgBox("The procedure succeded!!!")
		'name  rec.mdb as recipies.mdb
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		'Dim A As String
		'
		'
		'A = Dir("C:\MERCVB\BACK*.ZIP", vbNormal)
		'
		'Dim K As Integer
		'
		'For K = 0 To File2.ListCount - 1
		'   A = Left(File2.List(K) + Space(30), 25) + Format(FileLen(File2.Path + "\" + File2.List(K)), "000,000,000") + "  " + Format(FileDateTime(File2.Path + "\" + File2.List(K)), "DD/MM/YYYY")
		'   List1.AddItem A
		'Next
		
		
		'A = FileDateTime(File1.Path + "\" + File1.FileName)
		
		
		
		
		
		
		'Dim a
		'    a = ACCESS_TO_ACCESS("ximitech", "c:\rec.mdb", "c:\talos\recipies.mdb")
		'
		'    If a = 0 Then
		'       MsgBox "Ολοκληρώθηκε με επιτυχία"
		'    Else
		'       MsgBox "Δεν ολοκληρώθηκε η μεταφορά."
		'    End If
		'
	End Sub
	
	Private Sub taxinomisi(ByVal gfolder As String, ByVal riza As String)
		
		Dim thisExtn, f, fsize, fdate, SearchName, itmx, ddate As Object
		
		
		'gfolder = "c:\mercvb"
		'UPGRADE_WARNING: Couldn't resolve default property of object SearchName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SearchName = gfolder & "\" & riza & "*.*"
		'UPGRADE_WARNING: Couldn't resolve default property of object SearchName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = Dir(SearchName, FileAttribute.ReadOnly)
		ListView1.Items.Clear()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Do While f <> ""
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			f = Dir()
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If f = "" Then
				Exit Do
			End If
			
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fdate = FileDateTime(gfolder & "\" & f)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fsize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fsize = FileLen(gfolder & "\" & f)
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			itmx = ListView1.Items.Add(f)
			'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object thisExtn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			itmx.SubItems(1) = UCase(thisExtn)
			'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			itmx.SubItems(2) = fdate
			'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fsize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			itmx.SubItems(3) = VB6.Format(System.Math.Round(fsize / 1024 / 1000, 2), "00000.00")
			'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fsize. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			itmx.SubItems(4) = VB6.Format(fsize, "0000000000")
			'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object fdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			itmx.SubItems(5) = VB6.Format(fdate, "YYYYMMDDHhNnSs")
			'UPGRADE_NOTE: Object itmx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
			itmx = Nothing
		Loop 
		
		
		If FIRST_TIME = 1 Then
			FIRST_TIME = 0
			'UPGRADE_ISSUE: MSComctlLib.ListView property ListView1.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'ListView1.SortKey = 5
			
			ListView1.Sorting = System.Math.Abs(CInt(Not ListView1.Sorting = 1))
			ListView1.Sort()
		End If
		
		
		
		
		
		
		'Dim b, c, A
		'    b = ACCESS_TO_ACCESS("prospau2", "c:\rec.mdb", "c:\talos\recipies.mdb")
		'    c = ACCESS_TO_ACCESS("joblist", "c:\rec.mdb", "c:\talos\recipies.mdb")
		'    A = b + c
		'    If A = 0 Then
		'       MsgBox "Ολοκληρώθηκε με επιτυχία"
		'    Else
		'       MsgBox "Δεν ολοκληρώθηκε η μεταφορά."
		'    End If
		
	End Sub
	
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		'Dim db As Database
		'Dim R As Recordset
		'Set db = OpenDatabase(App.Path + "\pelatesbackup.MDB")
		'
		'
		'Set R = db.OpenRecordset("SELECT * FROM pelates")
		'Do While Not R.EOF
		'   List1.AddItem R("onoma") + ";" + R("dir") + ";" + R("riza")
		'
		'    R.MoveNext
		'
		'Loop
		'
		'
		FORTOSI()
		
		
		
	End Sub
	
	
	Sub FORTOSI()
		
		List1.Items.Clear()
		
		Dim db As DAO.Database
		'UPGRADE_WARNING: Arrays in structure R may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim R As DAO.Recordset
		db = DAODBEngine_definst.OpenDatabase(My.Application.Info.DirectoryPath & "\pelatesbackup.MDB")
		
		
		R = db.OpenRecordset("SELECT * FROM pelates order by ONOMA")
		Do While Not R.EOF
			List1.Items.Add(R.Fields("onoma").Value + ";" + R.Fields("dir").Value + ";" + R.Fields("riza").Value)
			
			R.MoveNext()
			
		Loop 
		
	End Sub
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click



		Dim d() As String
		
		d = Split(VB6.GetItemString(List1, List1.SelectedIndex), ";")
		
        'frmPELATES.Lab1.Text = "select ONOMA,DIR,RIZA,C1,C2,C3,D1,D2,D3,HME,N1,N2,N3 from PELATES WHERE ONOMA='" & d(0) & "'"
		
        'frmPELATES.ShowDialog()
		
		FORTOSI()
		
		
	End Sub
	
	Private Sub Command9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command9.Click
		
		On Error GoTo latos
		
		
		Dim d() As String
		Dim k As Short
		Dim l, nl As Short
		Dim maxSize As Single
		
		Dim mess(10) As String
		
		Dim itmx As Object
		
		Dim deixe As Boolean
		
		
		Dim C As String
		
		
		
		LOG.Visible = True
		
		LOG.Items.Clear()
		
		Dim problem As Boolean
		
		
		
		
		'για ολα τα  αρχεια που με ενδιαφερουν
		For k = 0 To List1.Items.Count - 1
			
			problem = False
			nl = 0
			For l = 1 To 10
				mess(l) = ""
			Next 
			
			
			
			
			
			
			d = Split(VB6.GetItemString(List1, k), ";")
			taxinomisi(d(1), d(2))
			
			
			'MsgBox "ok"
			System.Windows.Forms.Application.DoEvents()
			ListView1.Refresh()
			System.Windows.Forms.Application.DoEvents()
			
			'βρισκω το μέγιστο μέγεθος του αρχείου
			maxSize = 0
			For l = 1 To ListView1.Items.Count
				
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If Val(Replace(ListView1.Items.Item(l).SubItems(3).Text, ",", ".")) > maxSize Then
					'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					maxSize = Val(Replace(ListView1.Items.Item(l).SubItems(3).Text, ",", "."))
				End If
				
			Next 
			
			
			
			
			
			
			
			nl = nl + 1
			mess(nl) = d(0) & "; Μέγιστο μέγεθος ;" & VB6.Format(maxSize, "#####00.00") & ";"
			
			If ListView1.Items.Count > 0 Then
				
				
				nl = nl + 1
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				mess(nl) = ListView1.Items.Item(1).Text & ";" & ListView1.Items.Item(1).SubItems(3).Text & ";" & ListView1.Items.Item(1).SubItems(2).Text
				' ListView1.ListItems(k).ForeColor = vbGreen
				
				'ΗΜΕΡΟΜΗΝΙΑ
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				C = ListView1.Items.Item(1).SubItems(2).Text
				'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
				If DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate(C), Now) > 2 Then
					problem = True
					nl = nl + 1
					mess(nl) = "********************////////*************************" & ";" & ";" & " ΠΡΟΒΛΗΜΑ ΠΑΛΙΟ ΑΡΧΕΙΟ"
				End If
				
				
				
				
				If ListView1.Items.Count > 1 Then
					nl = nl + 1
					'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					mess(nl) = ListView1.Items.Item(2).Text & ";" & ListView1.Items.Item(2).SubItems(3).Text & ";" & ListView1.Items.Item(2).SubItems(2).Text
				End If
				
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				If Val(Replace(ListView1.Items.Item(1).SubItems(3).Text, ",", ".")) < maxSize Then
					'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems() has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					If Val(Replace(ListView1.Items.Item(2).SubItems(3).Text, ",", ".")) < maxSize Then
						problem = True
						nl = nl + 1
						mess(nl) = "********************************************" & ";" & ";" & " ΠΡΟΒΛΗΜΑ ΜΙΚΡΟ ΜΕΓΕΘΟΣ ΑΡΧΕΙΟΥ"
					End If
				End If
				
				
				
				
			Else
				
				
			End If
			
			If sosta.CheckState = System.Windows.Forms.CheckState.Checked Then
				If problem Then deixe = False Else deixe = True
				
			Else
				deixe = problem
				
			End If
			
			
			If deixe Then
				
				For l = 1 To nl
					
					d = Split(mess(l), ";")
					itmx = LOG.Items.Add(d(0))
					'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					itmx.SubItems(1) = d(1)
					'UPGRADE_WARNING: Couldn't resolve default property of object itmx.SubItems. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					itmx.SubItems(2) = d(2)
					'UPGRADE_NOTE: Object itmx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
					itmx = Nothing
					'List2.AddItem mess(l)
					
				Next 
				itmx = LOG.Items.Add("------------------------------------")
				'UPGRADE_NOTE: Object itmx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
				itmx = Nothing
				
			End If
			
			nl = 0
			
			'List2.AddItem "---------------------------"
			
			
			
			
		Next 
		
		
		
		MsgBox("ok")
		
		Exit Sub
		
latos: 
		MsgBox(List1.Text & Chr(13) & Err.Description)
		Resume Next
		
		
		
		
		
		
	End Sub
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		Dim C As String
		'c = Split(List1.List(List1.ListIndex), ";")
		Dim d() As String
		
		d = Split(VB6.GetItemString(List1, List1.SelectedIndex), ";")
		
		
		' List2.Visible = False
		
		
		
		taxinomisi(d(1), d(2))
	End Sub
	
	Private Sub ListView1_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
		Dim ColumnHeader As System.Windows.Forms.ColumnHeader = ListView1.Columns(eventArgs.Column)
		If ColumnHeader.Text = "Size" Then
			'UPGRADE_ISSUE: MSComctlLib.ListView property ListView1.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'ListView1.SortKey = 4
		ElseIf ColumnHeader.Text = "Date" Then 
			'UPGRADE_ISSUE: MSComctlLib.ListView property ListView1.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'ListView1.SortKey = 5
		Else
			'UPGRADE_ISSUE: MSComctlLib.ListView property ListView1.SortKey was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            '	ListView1.SortKey = ColumnHeader.Index - 1
		End If
		ListView1.Sorting = System.Math.Abs(CInt(Not ListView1.Sorting = 1))
		ListView1.Sort()
	End Sub
	
	
	
	
	
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		Me.Close()
	End Sub
	
	Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
		Label1.Text = CStr(FileDateTime(File1.Path & "\" & File1.FileName))
		
	End Sub
	
	Private Sub File1_PathChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.PathChange
		'On Error Resume Next
		' Label1.Caption = File1.filename + " "
		'  If File1.filename <> "" Then
		
		'  Form1.Caption = (File1.Path + "\" + File1.filename)
		' End If
	End Sub
	
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		' Check_directory
		' δημιουργεί το directory \backup αν δεν υπάρχει
		Dim mdir As Object
		FIRST_TIME = 1
		
		'ελεγχω αν υπάρχει το file backup.dat
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mdir = Dir("c:\backup.dat")
		'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If mdir = "" Then
			Text1.Text = "c:\backup"
			savefile()
		End If
		openfile()
		
		
		On Error GoTo create
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mdir = Dir(Text1.Text, FileAttribute.Directory)
		'UPGRADE_WARNING: Couldn't resolve default property of object mdir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If mdir = "" Then
			MkDir(Text1.Text)
		End If
		
		File1.Path = Text1.Text
		Check1.BackColor = Me.BackColor
		
		
		
		Command7_Click(Command7, New System.EventArgs())
		
		
		
		
		
		
		
		Exit Sub
		
create: 
		MkDir(Text1.Text)
		
		
		
		
		
		File1.Path = Text1.Text
	End Sub
	
	
	
	Public Sub savefile()
		Dim file As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		file = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(file, "c:\backup.dat", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(file, Text1.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(file)
		
		
		
	End Sub
	
	Public Sub openfile()
		Dim A As String
		Dim file As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		file = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(file, "c:\backup.dat", OpenMode.Input)
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Input(file, A)
		'UPGRADE_WARNING: Couldn't resolve default property of object file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(file)
		Text1.Text = A
	End Sub
	
	'UPGRADE_ISSUE: MSComctlLib.ListView event ListView1.ItemClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub ListView1_ItemClick(ByVal Item As System.Windows.Forms.ListViewItem)
		On Error Resume Next
		Dim C As String
		
		'UPGRADE_WARNING: Lower bound of collection ListView1.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		C = ListView1.Items.Item(2).Text
		Dim d() As String
		
		d = Split(VB6.GetItemString(List1, List1.SelectedIndex), ";")
		
		'Shell "c:\dos\pkzip.exe -v " + d(1) + "\" + Item, vbMaximizedFocus
		
		Shell("C:\Program Files\WinRAR\WINRAR.EXE " & d(1) & "\" & Item.Text, AppWinStyle.NormalFocus)
		
		
		'**************************************
		' Name: Zip and Unzip - in VB6
		' Description:we want to call "WinRar.exe" from our VB project .
		' By: Zaid Markabi (from psc cd)
		'**************************************
		
		' we need ZipCmd and UnZipCmd ( commands button ) .
		'Private Sub ZipCmd_Click()
		'' we like to zip [ C:\DataFiles ] folder to [ C:\Compressor.rar ] file.
		'Shell App.Path + "\WinRar.exe M C:\Compressor.rar C:\DataFiles"
		'MsgBox "Zipped"
		'End Sub
		'Private Sub UnZipCmd_Click()
		'Shell App.Path + "\WinRar.exe X C:\Compressor.rar C:\"
		'MsgBox "UnZipped"
		'End Sub
		
	End Sub
	
	Private Sub Text1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.Leave
		savefile()
		
		
		
	End Sub
End Class