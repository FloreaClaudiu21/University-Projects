Imports System.Numerics

Public Class baseconverter
    Dim numLetter As List(Of String) = New List(Of String) _
                   (New String() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                                  "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                                  "U", "V", "W", "X", "Y", "Z"})
    Public Function IsValidNumBase(str1 As String, base As Byte) As Boolean
        For x As Integer = 0 To str1.Length - 1
            If Not (numLetter.Contains(str1.Substring(x, 1).ToUpper)) Or ((base - 1) < numLetter.IndexOf(str1.Substring(x, 1).ToUpper)) Then
                Return False
            End If
        Next
        Return True
    End Function
    'FROM DECIMAL BASE TO BASE 2 AS STRING'
    Function decimal2base(RESULTB10 As String, RESULT As String, toBase As Byte) As String
        Dim RESULTS As String = Environment.NewLine + "De la baza decimalelor in baza " + toBase.ToString + " calcul: " + Environment.NewLine
        RESULTS += "Divizia | Coeficient | Rest (Cifra)" + Environment.NewLine
        Dim n As Double = Val(RESULTB10)
        While n >= 1
            Dim ROW = (n.ToString + "/" + toBase.ToString + " | ") + (Math.Floor(n / toBase).ToString + " | ") + ((n Mod toBase).ToString + Environment.NewLine)
            n = Math.Floor(n / toBase)
            RESULTS += ROW
        End While
        RESULTS += " = " + RESULT + "(" + toBase.ToString + ")"
        Return RESULTS
    End Function
    'BASE 2 TO DECIMAL CALC AS STRING'
    Function base2decimal(INPUT As String, RESULTB10 As String, FROMBASE As Byte) As String
        Dim d As String
        Dim e As String
        Dim minus As Boolean = False
        Dim txt As String = Environment.NewLine + "De la baza " + FROMBASE.ToString + " in baza decimalelor calcul: " + Environment.NewLine + INPUT + "(" + FROMBASE.ToString() + ") = "
        Dim Len = INPUT.Length
        If (INPUT.ElementAt(0) = "-"c) Then
            minus = True
            Len = Len - 1
            txt = txt + "-["
            INPUT = INPUT.Substring(1)
        End If
        Dim idot = INPUT.IndexOf(".")
        If (idot >= 0) Then
            INPUT = INPUT.Substring(0, idot) + INPUT.Substring(idot + 1, Len)
            Len = Len - 1
        Else
            idot = Len
        End If
        Len = INPUT.Length
        For i = 0 To Len - 1 Step +1
            Dim A1
            d = Val(INPUT.ElementAt(i)).ToString
            A1 = idot - i - 1
            e = A1.ToString()
            txt += "(" + d + " x " + FROMBASE.ToString + "^" + e + ")"
            If (i < Len - 1) Then txt += " + "
        Next
        If (minus) Then
            txt += "]"
        End If
        txt += " = " + RESULTB10 + "(10)".ToString
        Return txt
    End Function
    'CONVERT THE NUMBER'
    Function Convert(base As Byte, convert_to As Byte, inputnumber As String) As String
        If (base < 2 Or base > 36) Or (convert_to < 2 Or convert_to > 36) Then
            Return "Invalid base"
        End If
        If Not (IsValidNumBase(inputnumber, base)) Then
            Return "Invalid Input"
        End If
        If base = convert_to Then
            Return inputnumber
        End If
        Dim decvaltoconvert As BigInteger = 0
        If (base = 10) Then
            decvaltoconvert = CType(inputnumber, BigInteger)
        Else
            Dim place As Integer = 0
            For x As Integer = inputnumber.Length - 1 To 0 Step -1
                'only using integer because .substring will not accept a biginteger value, besides, if its over 2.4billion digits long, u don't want to use this program anyway.
                decvaltoconvert += CType((numLetter.IndexOf(inputnumber.Substring(x, 1).ToUpper) * (BigInteger.Pow(base, CInt(place)))), BigInteger)
                place += 1
            Next
        End If
        If convert_to = 10 Then
            Return decvaltoconvert.ToString
        End If
        'convert into the desired base
        Dim returnstr As String = ""
        While decvaltoconvert > 0
            Dim tempval As BigInteger = 0
            BigInteger.DivRem(decvaltoconvert, CType(convert_to, BigInteger), tempval)
            returnstr = String.Concat(returnstr, numLetter.Item(CType(tempval, Integer)))
            decvaltoconvert = CType(BigInteger.Divide(decvaltoconvert, convert_to), BigInteger)
        End While
        returnstr = StrReverse(returnstr)
        Return returnstr
    End Function
End Class

