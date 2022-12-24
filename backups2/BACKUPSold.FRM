VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Object = "{5E9E78A0-531B-11CF-91F6-C2863C385E30}#1.0#0"; "MSFLXGRD.OCX"
Begin VB.Form Form1 
   BackColor       =   &H00C0E0FF&
   Caption         =   "Form1"
   ClientHeight    =   11535
   ClientLeft      =   1620
   ClientTop       =   1530
   ClientWidth     =   17820
   LinkTopic       =   "Form1"
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   11535
   ScaleWidth      =   17820
   WindowState     =   2  'Maximized
   Begin VB.CommandButton Command11 
      Caption         =   "ΟΛΑ"
      Height          =   315
      Left            =   12495
      TabIndex        =   21
      Top             =   1020
      Width           =   2100
   End
   Begin VB.CommandButton Command10 
      Caption         =   "MONO TA OK"
      Height          =   315
      Left            =   12495
      TabIndex        =   20
      Top             =   615
      Width           =   2100
   End
   Begin MSFlexGridLib.MSFlexGrid log 
      Height          =   5535
      Left            =   8340
      TabIndex        =   19
      Top             =   3720
      Width           =   9435
      _ExtentX        =   16642
      _ExtentY        =   9763
      _Version        =   393216
      Rows            =   200
      Cols            =   5
      FixedCols       =   0
   End
   Begin VB.CommandButton Command9 
      Caption         =   "ΠΡΟΒΛΗΜΑΤΙΚΑ"
      Height          =   315
      Left            =   12480
      TabIndex        =   18
      Top             =   225
      Width           =   2100
   End
   Begin VB.CommandButton Command8 
      Caption         =   "προσθετω-διορθωνω  εγγραφές"
      Height          =   495
      Left            =   12420
      TabIndex        =   17
      Top             =   1920
      Width           =   2280
   End
   Begin VB.ListBox List1 
      Height          =   3375
      Left            =   270
      TabIndex        =   16
      Top             =   240
      Width           =   11970
   End
   Begin VB.CommandButton Command7 
      Caption         =   "φορτωση πίνακα"
      Height          =   495
      Left            =   12420
      TabIndex        =   15
      Top             =   2520
      Width           =   2280
   End
   Begin VB.CommandButton Command5 
      Caption         =   "ταξινομηση"
      Height          =   360
      Left            =   4440
      TabIndex        =   14
      Top             =   12120
      Width           =   3255
   End
   Begin MSComctlLib.ListView ListView1 
      Height          =   7680
      Left            =   240
      TabIndex        =   13
      Top             =   3720
      Width           =   8025
      _ExtentX        =   14155
      _ExtentY        =   13547
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   0   'False
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   6
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Text            =   "Name"
         Object.Width           =   6703
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Text            =   "Extn"
         Object.Width           =   1235
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Text            =   "Date"
         Object.Width           =   3175
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Text            =   "MB-Size"
         Object.Width           =   1058
      EndProperty
      BeginProperty ColumnHeader(5) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   4
         Text            =   "SizeFormatted"
         Object.Width           =   0
      EndProperty
      BeginProperty ColumnHeader(6) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   5
         Text            =   "DateFormatted"
         Object.Width           =   0
      EndProperty
   End
   Begin VB.CommandButton Command4 
      Caption         =   "Command4"
      Height          =   360
      Left            =   9075
      TabIndex        =   12
      Top             =   14190
      Visible         =   0   'False
      Width           =   990
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   1155
      TabIndex        =   10
      Top             =   15780
      Visible         =   0   'False
      Width           =   2010
   End
   Begin VB.CheckBox Check3 
      Caption         =   "Coordinates of machine only"
      Height          =   270
      Left            =   165
      TabIndex        =   9
      Top             =   15330
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.CheckBox Check2 
      Caption         =   "Data Files(Recipies/Solutions) only"
      Height          =   270
      Left            =   165
      TabIndex        =   8
      Top             =   14955
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.CheckBox Check1 
      Caption         =   "Only the files to service(email)"
      Height          =   255
      Left            =   165
      TabIndex        =   6
      Top             =   12915
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.CommandButton Command6 
      Caption         =   "EXIT"
      Height          =   495
      Left            =   12420
      TabIndex        =   5
      Top             =   3120
      Width           =   2280
   End
   Begin VB.CommandButton Command3 
      Caption         =   "Compact Database"
      Height          =   735
      Left            =   5880
      TabIndex        =   3
      Top             =   14175
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.CommandButton Command2 
      Caption         =   "RESTORE"
      Height          =   615
      Left            =   165
      TabIndex        =   2
      Top             =   14220
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.FileListBox File1 
      Height          =   675
      Left            =   5880
      Pattern         =   "*.zip"
      TabIndex        =   1
      Top             =   15015
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.CommandButton Command1 
      Caption         =   "BACKUP"
      Height          =   495
      Left            =   165
      TabIndex        =   0
      Top             =   12180
      Visible         =   0   'False
      Width           =   3000
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Path"
      Height          =   255
      Left            =   210
      TabIndex        =   11
      Top             =   15795
      Visible         =   0   'False
      Width           =   840
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Ver. 2.01"
      Height          =   255
      Left            =   240
      TabIndex        =   7
      Top             =   5280
      Width           =   1935
   End
   Begin VB.Label Label1 
      BackColor       =   &H0080FFFF&
      BackStyle       =   0  'Transparent
      Height          =   495
      Left            =   4680
      TabIndex        =   4
      Top             =   2400
      Width           =   3375
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim FIRST_TIME As Integer


Option Explicit
Private Sub Check_directory()
' δημιουργεί το directory \backup αν δεν υπάρχει
Dim mdir
On Error GoTo create
  mdir = Dir(Text1.Text + "\*.zip")
If mdir = "" Then
  MkDir Text1.Text
End If
Exit Sub

create:
  MkDir Text1.Text

End Sub

Function ACCESS_TO_ACCESS(file, MDB1, MDB2)
'ΜΕΤΑΦΟΡΑ ΑΡΧΕΙΟΥ FILE ΑΠΟ MDB1 ΣΕ MDB2 DATABASE
Dim Errors, mydb
'On Error GoTo ERR
Errors = 0
    Set mydb = Workspaces(0).OpenDatabase(MDB2)
    mydb.Execute "drop table " + file



    Set mydb = Workspaces(0).OpenDatabase(MDB1)
    mydb.Execute "SELECT " + file + ".* INTO " + file + " in '" + MDB2 + "'  from " + file, dbFailOnError
    ACCESS_TO_ACCESS = Errors
    Exit Function
ERR:
  Errors = 1
  Resume Next
  MsgBox "Problem occurer during the transfer " + file
End Function


Private Sub Command1_Click()
Dim mday, A, k, mystamp, ans

'Check_directory
mday = LTrim(Str(Day(Date)))

On Error Resume Next
mystamp = FileDateTime(Text1.Text + "\" + mday + ".zip") ' Returns "2/12/93 4:35:47 PM".

If Check1 Then
   MsgBox "Attention ! This is not a normal backup." + Chr(13) + "It will create the file service.zip"
   A = Shell("\TALOS\pkzip.exe  " + Text1.Text + "\service   \talos\recipies.mdb", 1)
Else

    If DateDiff("d", mystamp, Date) > 0 Then
       A = Shell("\TALOS\pkzip.exe  " + Text1.Text + "\" + mday + " \talos\*.mdb \talos\*.dbf", 1)
    Else
        ans = MsgBox("Allready exists.Overwrite the previous backup?", vbYesNo)
        If ans = vbYes Then
           A = Shell("\TALOS\pkzip.exe  " + Text1.Text + "\" + mday + " \talos\*.mdb \talos\*.dbf", 1)
        End If
    End If

End If

File1.Visible = False
For k = 1 To 1000
   DoEvents
Next

'File1.Path = "c:\backup"

File1.Refresh
File1.Visible = True
End Sub


Private Sub Command10_Click()
' OK
    SHOW_LOG 0
End Sub

Private Sub Command11_Click()
'OLA
  SHOW_LOG 2
End Sub

Private Sub Command2_Click()
Dim ans, myvalue, mdir, mystamp, A, Recipies_stamp
If UCase(Right(File1.FileName, 3)) <> "ZIP" Then
      MsgBox "You must click the file from which I will restore."   'Δεν δείξατε από ποιό αρχείο θα γίνει η επαναφορά"
      Exit Sub
End If


If UCase(Left(File1.FileName, 3)) = "SER" Then
      MsgBox "This file is for service. The RESTORE procedure will stop."   'Δεν δείξατε από ποιό αρχείο θα γίνει η επαναφορά"
      Exit Sub
End If





ans = MsgBox("The current files will be replaced with BACKUP files." + Chr(13) + "Are you sure?", vbYesNo + vbDefaultButton2)

If ans = vbNo Then
   Exit Sub
End If

myvalue = InputBox("Give the password 1234567890", , Space(10))

If myvalue <> "1234567890" Then Exit Sub
ChDir "\talos"

If CurDir = "C:\TALOS" Then
   
   
   
   
   'αντιγραφει το σημερινό recipies.mdb στο    "c:\"
    mdir = Dir("c:\rec.mdb")
    If mdir <> "" Then
       mystamp = FileDateTime("\rec.mdb") ' Returns "2/12/93 4:35:47 PM".
    Else
       mystamp = Date - 1
    End If
   'εάν αυτό που είναι στο root ειναι παλιό πάρε το καινούριο
   If DateDiff("d", mystamp, Date) > 0 Then
         FileCopy "recipies.mdb", "\rec.mdb"
   End If
   
   ' Recipies_stamp = FileDateTime("recipies.mdb")
    
   If Check3 Then
       A = Shell("\TALOS\pkUNzip.exe  -o " + Text1.Text + "\" + File1.FileName + " Coord_tb.mdb", 1)
   ElseIf Check2 Then
       A = Shell("\TALOS\pkUNzip.exe  -o " + Text1.Text + "\" + File1.FileName + " -xCoord_tb.mdb", 1)
   Else
     A = Shell("\TALOS\pkUNzip.exe  -o " + Text1.Text + "\" + File1.FileName, 1)
   End If
     
     If Recipies_stamp = FileDateTime("recipies.mdb") Then
        MsgBox "The restore procedure was not completed." + Chr(13) + "!!!!"
     Else
        MsgBox "The restore procedure was successful."
     End If
    
     ans = MsgBox("Would you like to Try to save the file with today solutions ? ", vbYesNo, "Keep the solutions,otherwise make all the today solutions.")
   
If ans = vbYes Then
     A = ACCESS_TO_ACCESS("ximitech", "c:\rec.mdb", "c:\talos\recipies.mdb")
     
     If A = 0 Then
         MsgBox "The transfer completed."
     Else
         A = Shell("\TALOS\pkUNzip.exe  -o " + Text1.Text + "\" + File1.FileName + " recipies.mdb", 1)
        MsgBox "The file with solutions was not saved."
        MsgBox "The today solutions are not in the memory. Take care of it."
     End If
End If
   
End If

End Sub


Private Sub Command3_Click()
Dim mday, mystamp, A, ans

'Check_directory
mday = LTrim(Str(Day(Date)))
mystamp = "--"
On Error Resume Next
   mystamp = FileDateTime(Text1.Text + "\" + mday + ".zip") ' Returns "2/12/93 4:35:47 PM".
On Error GoTo 0
If mystamp = "--" Then
        MsgBox "Make a backup first"
        Exit Sub
Else
    If DateDiff("d", mystamp, Date) > 0 Then
        MsgBox "Make a backup first"
        Exit Sub
    End If
End If
Me.MousePointer = vbHourglass










On Error Resume Next
   Kill "c:\talos\rec.mdb"
On Error GoTo 0
   DBEngine.CompactDatabase "c:\talos\recipies.mdb", "c:\talos\rec.mdb", dbLangGreek
   FileCopy "c:\talos\rec.mdb", "c:\talos\recipies.mdb"    ' Copy source to target.
Me.MousePointer = vbNormal
   MsgBox "The procedure succeded!!!"
   'name  rec.mdb as recipies.mdb
End Sub

Private Sub Command4_Click()
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

Dim fdate, fsize, SearchName, f, itmx, thisExtn, ddate


'gfolder = "c:\mercvb"
SearchName = gfolder & "\" + riza + "*.*"
f = Dir(SearchName, vbReadOnly)
ListView1.ListItems.Clear






Do While f <> ""
            f = Dir()
            If f = "" Then
               Exit Do
            End If
               
            
            
            fdate = FileDateTime(gfolder & "\" & f)
            
    fsize = FileLen(gfolder & "\" & f)
    Set itmx = ListView1.ListItems.Add(, , f)
   ' ListView1.SelectedItem.Width = 100

      itmx.SubItems(1) = UCase(thisExtn)
      itmx.SubItems(2) = fdate
      itmx.SubItems(3) = Format(Round(fsize / 1024 / 1000, 2), "00000.00")
      itmx.SubItems(4) = Format(fsize, "0000000000")
      itmx.SubItems(5) = Format(fdate, "YYYYMMDDHhNnSs")
    Set itmx = Nothing
Loop


If FIRST_TIME = 1 Then
    FIRST_TIME = 0
     ListView1.SortKey = 5

    ListView1.SortOrder = Abs(Not ListView1.SortOrder = 1)
    ListView1.Sorted = True
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


Private Sub Command7_Click()
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
FORTOSI



End Sub


Sub FORTOSI()

List1.Clear

Dim db As Database
Dim R As Recordset
Set db = OpenDatabase(App.Path + "\pelatesbackup.MDB")


Set R = db.OpenRecordset("SELECT * FROM pelates order by ONOMA")
R.MoveFirst
Do While Not R.EOF
   List1.AddItem R("onoma") + ";" + R("dir") + ";" + R("riza")

    R.MoveNext

Loop

End Sub

Private Sub Command8_Click()

 Dim d() As String
  
   d = Split(List1.List(List1.ListIndex), ";")

    frmPELATES.Lab1.Caption = "select ONOMA,DIR,RIZA,C1,C2,C3,D1,D2,D3,HME,N1,N2,N3 from PELATES WHERE ONOMA='" + d(0) + "'"

frmPELATES.Show 1

FORTOSI


End Sub

Private Sub Command9_Click()

   SHOW_LOG 1
End Sub


Sub SHOW_LOG(ByVal VV As Integer)  ' VV=1 PROBL  VV=0 OK  VV=3 ALL
 


On Error GoTo LATOS


Dim d() As String
Dim k As Integer
Dim l As Integer, nl As Integer
Dim maxSize As Single

Dim mess(10) As String

Dim itmx

Dim deixe As Boolean


Dim C As String



log.Visible = True

log.Clear

log.ColWidth(1) = 1200
log.ColWidth(2) = 2000

log.ColWidth(0) = 3300

log.ColWidth(3) = 3000


Dim problem As Boolean

Dim row As Integer






'LOG.Columns.Add New ColumnHeader, "aaaaa"
'LOG.Columns.Add New ColumnHeader, "bbbbb"

'για ολα τα  αρχεια που με ενδιαφερουν
For k = 0 To List1.ListCount - 1
    
    problem = False
    nl = 0
    For l = 1 To 10
       mess(l) = ""
    Next
    
    
    
    
    
    
    d = Split(List1.List(k), ";")
    taxinomisi d(1), d(2)


'MsgBox "ok"
 DoEvents
 ListView1.Refresh
 DoEvents
 
    'βρισκω το μέγιστο μέγεθος του αρχείου
    maxSize = 0
    For l = 1 To ListView1.ListItems.Count
    
      If Val(Replace(ListView1.ListItems(l).SubItems(3), ",", ".")) > maxSize Then
        maxSize = Val(Replace(ListView1.ListItems(l).SubItems(3), ",", "."))
      End If
    
    Next
    
    
    
    
 
 
 
     nl = nl + 1
     mess(nl) = d(0) + "; Μέγιστο μέγεθος ;" + Format(maxSize, "#####00.00") + ";;"
     
    If ListView1.ListItems.Count > 0 Then
    
    
           nl = nl + 1
           mess(nl) = ListView1.ListItems(1).Text + ";" + ListView1.ListItems(1).SubItems(3) + ";" + ListView1.ListItems(1).SubItems(2) + ";"
         ' ListView1.ListItems(k).ForeColor = vbGreen
         
         'ΗΜΕΡΟΜΗΝΙΑ
         C = ListView1.ListItems(1).SubItems(2)
         If DateDiff("D", CDate(C), Now) > 2 Then
                 problem = True
                 nl = nl + 1
                 mess(nl) = "********************////////*************************" + ";" + ";;" + " ΠΡΟΒΛΗΜΑ ΠΑΛΙΟ ΑΡΧΕΙΟ"
         End If
         
         
         
         
         If ListView1.ListItems.Count > 1 Then
                    nl = nl + 1
                    mess(nl) = ListView1.ListItems(2).Text + ";" + ListView1.ListItems(2).SubItems(3) + ";" + ListView1.ListItems(2).SubItems(2) + ";"
         End If
         
      If Val(Replace(ListView1.ListItems(1).SubItems(3), ",", ".")) < maxSize Then
          If Val(Replace(ListView1.ListItems(2).SubItems(3), ",", ".")) < maxSize Then
                   problem = True
                   nl = nl + 1
                  mess(nl) = "********************************************" + ";" + ";;" + " ΠΡΟΒΛΗΜΑ ΜΙΚΡΟ ΜΕΓΕΘΟΣ ΑΡΧΕΙΟΥ"
          End If
      End If
      
         
         
         
    Else
     mess(nl) = "********************************************" + ";" + ";;" + " ΔΕΝ ΕΧΕΙ ΚΑΘΟΛΟΥ ΑΡΧΕΙΑ"
    
    End If
    
'   If sosta.Value = vbChecked Then
'       If problem Then deixe = False Else deixe = True
'       If sosta.Value = vbChecked Then deixe = True
'
'
'   Else  'ATSEKARISTA SOSTA
'
'      deixe = problem
'
'   End If
'
       

'  deixe = True
       
 ' PROBLHMATIKA
 If VV = 1 Then
    If problem = True Then
       deixe = True
    Else
       deixe = False
    End If
 End If
 
 ' OK
 If VV = 0 Then
    If problem = True Then
       deixe = False
    Else
       deixe = True
    End If
 End If
 
 ' ALL
 If VV = 2 Then
     deixe = True
 End If
 
 
 
       
       
       
 '      deixe = problem
    If deixe Then
    
       For l = 1 To nl
         row = row + 1
        d = Split(mess(l), ";")
'        Set itmx = log.ListItems.Add(, , d(0))
'        itmx.SubItems(1) = d(1)
'        itmx.SubItems(2) = d(2)
'        Set itmx = Nothing
'        'List2.AddItem mess(l)
       
         log.TextMatrix(row, 0) = d(0)
         log.TextMatrix(row, 1) = d(1)
         log.TextMatrix(row, 2) = d(2)
         log.TextMatrix(row, 3) = d(3)
         
       
       
       
       
       Next
'     Set itmx = log.ListItems.Add(, , "------------------------------------")
'      Set itmx = Nothing
    
       row = row + 1
    
    
    End If
    
    nl = 0
    
    'List2.AddItem "---------------------------"
 
 
 

Next



MsgBox "ok"

Exit Sub

LATOS:
MsgBox List1.Text + Chr(13) + ERR.Description
Resume Next






End Sub

Private Sub List1_Click()
  Dim C As String
  'c = Split(List1.List(List1.ListIndex), ";")
  Dim d() As String
  
   d = Split(List1.List(List1.ListIndex), ";")
  
  
 ' List2.Visible = False
  
  
  
   taxinomisi d(1), d(2)
End Sub

Private Sub ListView1_ColumnClick(ByVal ColumnHeader As ColumnHeader)
    If ColumnHeader.Text = "Size" Then
        ListView1.SortKey = 4
    ElseIf ColumnHeader.Text = "Date" Then
            ListView1.SortKey = 5
    Else
        ListView1.SortKey = ColumnHeader.Index - 1
    End If
    ListView1.SortOrder = Abs(Not ListView1.SortOrder = 1)
    ListView1.Sorted = True
End Sub






Private Sub Command6_Click()
   Unload Me
End Sub

Private Sub File1_Click()
  Label1.Caption = FileDateTime(File1.Path + "\" + File1.FileName)

End Sub

Private Sub File1_PathChange()
'On Error Resume Next
 ' Label1.Caption = File1.filename + " "
'  If File1.filename <> "" Then
  
'  Form1.Caption = (File1.Path + "\" + File1.filename)
 ' End If
End Sub


Private Sub Form_Load()
' Check_directory
' δημιουργεί το directory \backup αν δεν υπάρχει
Dim mdir
FIRST_TIME = 1

'ελεγχω αν υπάρχει το file backup.dat
 mdir = Dir("c:\backup.dat")
 If mdir = "" Then
    Text1.Text = "c:\backup"
    savefile
 End If
openfile


On Error GoTo create
  mdir = Dir(Text1.Text, vbDirectory)
If mdir = "" Then
  MkDir Text1.Text
End If

File1.Path = Text1.Text
Check1.BackColor = Form1.BackColor



Command7_Click







Exit Sub

create:
  MkDir Text1.Text





 File1.Path = Text1.Text
End Sub



Public Sub savefile()
Dim file
file = FreeFile
Open "c:\backup.dat" For Output As #file
Print #file, Text1.Text
Close #file



End Sub

Public Sub openfile()
Dim A$, file
file = FreeFile
Open "c:\backup.dat" For Input As #file
Input #file, A$
Close #file
Text1.Text = A$
End Sub

Private Sub ListView1_ItemClick(ByVal Item As MSComctlLib.ListItem)
On Error Resume Next
Dim C As String

C = ListView1.ListItems(2).Text
 Dim d() As String
  
   d = Split(List1.List(List1.ListIndex), ";")

'Shell "c:\dos\pkzip.exe -v " + d(1) + "\" + Item, vbMaximizedFocus

Shell "C:\Program Files\WinRAR\WINRAR.EXE " + d(1) + "\" + Item, vbNormalFocus

                
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

Private Sub Text1_LostFocus()
savefile



End Sub


