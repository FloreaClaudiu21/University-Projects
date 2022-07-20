Imports System.Threading
Imports System.Runtime.InteropServices

'CONSOLE CLASS'
Public Class console
    Public VISIBLE = False
    Public INSTANCE As IntPtr
    Friend WithEvents TASK As Thread
    Public Sub New()
        _init()
        INSTANCE = GetConsoleWindow()
        hide()
        TASK = New Thread(AddressOf TASK_TICK)
        ''TASK.Start()
        'DISABLE THE CONTROLS OF THE CONSOLE'
        AddHandler System.Console.CancelKeyPress, AddressOf myHandler
        DeleteMenu(GetSystemMenu(GetConsoleWindow(), False), 61536, 0) 'CLOSE'
        DeleteMenu(GetSystemMenu(GetConsoleWindow(), False), 61472, 0) 'MINIMIZE'
        DeleteMenu(GetSystemMenu(GetConsoleWindow(), False), 61488, 0) 'MAXIMIZE'
        Return
    End Sub
    Private Sub OnTimedEvent(s As Object, e As Timers.ElapsedEventArgs)
        While Process.GetProcessesByName("BPO-Proiect-Seminar").Count > 0
            If Not VISIBLE Then
                Continue While
            End If
            Dim CMD As String = System.Console.ReadLine()
            Dim CEX As New CommandConsole()
            CEX.work(Me, CMD)
            Continue While
        End While
        Return
    End Sub
    'INITIALIZE THE CONSOLE'
    Private Function _init() As Boolean
        Return AllocConsole()
    End Function
    'DISPOSE THE CONSOLE'
    Public Function dispose() As Boolean
        Return FreeConsole()
    End Function
    'SHOW THE CONSOLE'
    Public Function show() As Boolean
        VISIBLE = True
        ShowWindow(INSTANCE, 1)
        Return True
    End Function
    'HIDE THE CONSOLE'
    Public Function hide() As Boolean
        VISIBLE = False
        ShowWindow(INSTANCE, 0)
        Return True
    End Function
    'SHOW OR HIDE THE CONSOLE WITH CTRL + O'
    Public Function key_process(msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.O) Then
            If VISIBLE Then
                VISIBLE = False
                hide()
            Else
                VISIBLE = True
                show()
            End If
            Return True
        End If
        Return False
    End Function
    'GET THE CURRENT DATE'
    Private Function current_date() As String
        Dim time = DateTime.Now
        Dim Format As String = "[d-MMM-yyyy|HH:mm:ss]"
        Return time.ToString(Format)
    End Function
    'SEND MESSAGE'
    Public Function message(MSG As String) As Boolean
        Return message(MSG, True)
    End Function
    Public Function message(MSG As String, DAT As Boolean) As Boolean
        If String.IsNullOrEmpty(MSG) Then
            Return False
        End If
        If DAT Then
            System.Console.WriteLine(current_date() + " " + MSG + ".")
            Return True
        End If
        System.Console.WriteLine(MSG)
        Return True
    End Function
    'SEND ERROR MESSAGE'
    Public Function err(MSG As String) As Boolean
        If String.IsNullOrEmpty(MSG) Then
            Return False
        End If
        System.Console.Write(current_date() + " ")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.Write("ERROR: " + MSG + "." + Environment.NewLine)
        System.Console.ForegroundColor = ConsoleColor.White
        Return True
    End Function
    'SEND INFO MESSAGE'
    Public Function info(MSG As String) As Boolean
        If String.IsNullOrEmpty(MSG) Then
            Return False
        End If
        System.Console.Write(current_date() + " ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        System.Console.Write("INFO: " + MSG + "." + Environment.NewLine)
        System.Console.ForegroundColor = ConsoleColor.White
        Return True
    End Function
    'SEND SUCCESS MESSAGE'
    Public Function success(MSG As String) As Boolean
        If String.IsNullOrEmpty(MSG) Then
            Return False
        End If
        System.Console.Write(current_date() + " ")
        System.Console.ForegroundColor = ConsoleColor.Green
        System.Console.Write("SUCCESS: " + MSG + "." + Environment.NewLine)
        System.Console.ForegroundColor = ConsoleColor.White
        Return True
    End Function
    'CONSOLE METHODS'
    Private Declare Auto Function GetConsoleWindow Lib "kernel32.dll" () As IntPtr
    <DllImport("kernel32")> Private Shared Function FreeConsole() As Boolean
    End Function
    <DllImport("kernel32")> Private Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("User32")> Private Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    End Function
    <DllImport("User32")> Private Shared Function DeleteMenu(hMenu As IntPtr, nPosition As Integer, wFlags As Integer) As Integer
    End Function
    <DllImport("User32")> Private Shared Function GetSystemMenu(hWnd As IntPtr, bRevert As Boolean) As IntPtr
    End Function
    'TICK METHOD'
    Sub TASK_TICK()
        While Process.GetProcessesByName("BPO-Proiect-Seminar").Count > 0
            If Not VISIBLE Then
                Continue While
            End If
            Dim CMD As String = System.Console.ReadLine()
            Dim CEX As New CommandConsole()
            CEX.work(Me, CMD)
            Continue While
        End While
        Return
    End Sub
    Protected Shared Sub myHandler(ByVal sender As Object, ByVal args As ConsoleCancelEventArgs)
        args.Cancel = True
    End Sub
End Class
Public Class CommandConsole
    Public Sub work(C As console, CMD As String)
        If String.IsNullOrWhiteSpace(CMD) Then
            Return
        End If
        If Not CMD.StartsWith("/") Then
            Return
        End If
        CMD = CMD.ToLower
        Select Case CMD
            Case "/skiplogin"
                If String.IsNullOrEmpty(main_menu.USER.MAIL) Then
                    MessageBox.Show("Comanda executata cu succes, v-ati logat folosind comand '/skiplogin'!", "Comanda reusita", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Return
                Else
                    C.err("Se pare ca sunteti deja logat ca si utilizatorul '" + main_menu.USER.MAIL + "'")
                End If
                Return
        End Select
        Return
    End Sub
    Public Sub meA()
        If main_menu.InvokeRequired Then
            main_menu.Invoke(New MethodInvoker(AddressOf meA))
        Else
            main_menu.Show()
        End If
    End Sub
End Class