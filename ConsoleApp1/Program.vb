Imports System

Public Module Program
    Sub Main(args As String())
        Dim i As Integer

        For i = 1 To 100

            Console.WriteLine(FizzBuzzify(i))

        Next i
    End Sub

    Public Function FizzBuzzify(ByVal number As Integer)
        If number = 5 Then
            Return "Buzz"

        ElseIf number = 15 Then
            Return "FizzBuzz"

        ElseIf number Mod 3 = 0 Then
            Return "Fizz"
        End If

        Return number
    End Function

End Module
