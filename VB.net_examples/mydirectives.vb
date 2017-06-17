Module mydirectives
    Public Class ExternalSourceTester

        Sub TestExternalSource()

        #ExternalSource("e:\vbnet\Projects\Test1\Test1\directives.vb", 5)
            Console.WriteLine("This is external code.")
        #End ExternalSource

        End Sub
    End Class

    Sub Main()
        Dim t As New ExternalSourceTester()
        t.TestExternalSource()
        Console.WriteLine("In Main")
        Console.ReadKey()

    End Sub



End Module
