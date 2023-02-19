Imports NUnit.Framework
Imports FizzBuzz


Namespace TestProject1

    Public Class FizzBuzzTests

        <Test>
        Public Sub OneReturnsOne()
            Dim fizzBuzzResult As Integer = FizzBuzzify(1)

            Assert.AreEqual(fizzBuzzResult, 1)
        End Sub

    End Class

End Namespace