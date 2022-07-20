Imports System.IO
'DEDUCERE PERSONALA'
Public Class deducere
    Dim LINES As String()
    Dim LIST As New List(Of deducere_value)
    Dim FILE_NAME As String = Environment.CurrentDirectory + "\deducere.txt"
    'READ THE FILE'
    Public Sub New()
        LINES = My.Resources.deducere.Split(Environment.NewLine)
        If LINES.Count <= 0 Then
            Return
        End If
        'ITERATOR'
        For Each LINE As String In LINES
            'SKIP LINE IS EMPTY OR DOES NOT HAVE SPACES'
            If String.IsNullOrEmpty(LINE) Or Not LINE.Contains(" "c) Then
                Continue For
            End If
            Dim SP As String() = LINE.Split(" ")
            'SKIP LINE IF DOES NOT HAVE ALL THE VALUES'
            If SP.Count < 6 Then
                Continue For
            End If
            Dim NUMBERS As String = SP(0)
            'SKIP IF THE NUMBERS ARE NOT CORRECT'
            If Not NUMBERS.Contains("-"c) Then
                Continue For
            End If
            Dim DV As New deducere_value
            Dim NS As String() = NUMBERS.Split("-")
            Dim F, S, P0, P1, P2, P3, P4ORABOVE As Integer
            Try
                F = Int(NS(0))
                S = Int(NS(1))
                P0 = Int(SP(1))
                P1 = Int(SP(2))
                P2 = Int(SP(3))
                P3 = Int(SP(4))
                P4ORABOVE = Int(SP(5))
            Catch ex As Exception
                Continue For
            End Try
            DV.P0 = P0
            DV.P1 = P1
            DV.P2 = P2
            DV.P3 = P3
            DV.FIRST_NUMBER = F
            DV.SECOND_NUMBER = S
            DV.P4ORABOVE = P4ORABOVE
            LIST.Add(DV)
        Next
        Return
    End Sub
    'RETURNEAZA DEDUCEREA IN FUNCTIE DE SALARIU SI PERSOANELE IN INTRETINERE'
    Public Function get_by_salary(SALARY As String, PINT As Integer) As Integer
        Dim S As Integer
        Try
            S = Int(SALARY)
            Return get_by_salary(S, PINT)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    'RETURNEAZA DEDUCEREA IN FUNCTIE DE SALARIU SI PERSOANELE IN INTRETINERE'
    Public Function get_by_salary(SALARY As Integer, PINT As Integer) As Integer
        If SALARY <= 0 Or SALARY > 3600 Then
            Return 0
        End If
        'ITERATOR'
        MessageBox.Show(PINT.ToString)
        For Each VALUE As deducere_value In LIST
            If SALARY >= VALUE.FIRST_NUMBER And SALARY <= VALUE.SECOND_NUMBER Then
                Select Case PINT
                    Case 0
                        Return VALUE.P0
                    Case 1
                        Return VALUE.P1
                    Case 2
                        Return VALUE.P2
                    Case 3
                        Return VALUE.P3
                    Case 4
                        Return VALUE.P4ORABOVE
                    Case 5
                        Return VALUE.P4ORABOVE
                End Select
            End If
        Next
        Return 0
    End Function
End Class
'STRUCTURE OF VALUES'
Public Structure deducere_value
    Dim P0, P1, P2, P3, P4ORABOVE As Integer
    Dim FIRST_NUMBER, SECOND_NUMBER As Integer
End Structure
