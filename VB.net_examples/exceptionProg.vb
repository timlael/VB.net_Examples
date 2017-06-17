Module exceptionProg
    Public Class TempIsZeroException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Public Class Temperature
        Dim temperature As Integer = 999

        Sub showTemp()
            If (temperature = 999) Then
                Dim message As String
                message = "Invalid Temperature (" & CStr(temperature) & ") found"
                Throw (New TempIsZeroException(message))
            Else
                Console.WriteLine("Temperature: {0}", temperature)
            End If
        End Sub
    End Class

    Sub division(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer

        Try
            result = num1 \ num2

        Catch e As DivideByZeroException
            Console.WriteLine()
            Console.WriteLine("Exception caught: {0}", e)

        Finally
            Console.WriteLine("Result: {0}", result)
        End Try
    End Sub

    Sub Main()
        division(25, 0)

        Console.WriteLine()

        Dim temp As Temperature = New Temperature()
        Try
            temp.showTemp()
        Catch e As TempIsZeroException
            Console.WriteLine("TempIsZeroException: {0}", e.Message)
        End Try

        Console.WriteLine()

        Try
            Throw New ApplicationException("A custom exception is being thrown here...")
        Catch e As Exception
            Console.WriteLine(e.Message)
        Finally
            Console.WriteLine("Now inside the Finally Block")
        End Try

        Console.ReadKey()
    End Sub
End Module