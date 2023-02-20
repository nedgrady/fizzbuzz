Imports System

Public Module Program
    Sub Main(args As String())
        Dim i As Integer

        For i = 1 To 100

            Console.WriteLine(FizzBuzzify(i))

        Next i
    End Sub

    Public Function FizzBuzzify(ByVal number As Integer)
        If number = 3 Then
            Return "Fizz"

        ElseIf number = 5 Then
            Return "Buzz"

        ElseIf number = 15 Then
            Return "FizzBuzz"
        End If

        Return number
    End Function

End Module
