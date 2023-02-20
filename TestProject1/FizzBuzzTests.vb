Imports NUnit.Framework
Imports FizzBuzz


Namespace TestProject1

    Public Class FizzBuzzTests

        <Test>
        Public Sub OneReturnsOne()
            Dim fizzBuzzResult As String = FizzBuzzify(1)

            Assert.AreEqual("1", fizzBuzzResult)
        End Sub

        <Test>
        Public Sub TwoReturnsTwo()
            Dim fizzBuzzResult As String = FizzBuzzify(2)
            Assert.AreEqual("2", fizzBuzzResult)
        End Sub

        <Test>
        Public Sub ThreeIsFizz()
            Dim fizzBuzzResult As String = FizzBuzzify(3)
            Assert.AreEqual("Fizz", fizzBuzzResult)
        End Sub

        <Test>
        Public Sub FiveisBuzz()
            Dim fizzBuzzResult As String = FizzBuzzify(5)
            Assert.AreEqual("Buzz", fizzBuzzResult)
        End Sub

        <Test>
        Public Sub FifteenisFizzBuzz()
            Dim fizzBuzzResult As String = FizzBuzzify(15)
            Assert.AreEqual("FizzBuzz", fizzBuzzResult)
        End Sub
    End Class

End Namespace