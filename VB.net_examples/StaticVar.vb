Class StaticVar
    Public Shared num As Integer

    Public Sub count()
        num = num + 1
    End Sub

    Public Shared Function getNum() As Integer
        Return num
    End Function

    Shared Sub Main()
        Dim s As StaticVar = New StaticVar()
        s.count()
        s.count()
        s.count()
        Console.WriteLine("Value of variable num: {0}", StaticVar.getNum())
        Console.ReadKey()
    End Sub
End Class
