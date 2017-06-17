Class Line
    Private length As Double    ' Length of a line

    Public Sub New(ByVal len As Double)   'parameterised constructor
        Console.WriteLine("Object is being created, length = {0}", len)
        length = len
    End Sub

    Public Sub setLength(ByVal len As Double)
        length = len
    End Sub

    Protected Overrides Sub Finalize()  ' destructor
        Console.WriteLine()
        Console.WriteLine("Object is being deleted")
    End Sub

    Public Function getLength() As Double
        Return length
    End Function

    Shared Sub Main()
        Dim line As Line = New Line(10.0)
        Console.WriteLine("Length of line set by constructor : {0}", line.getLength())
        'set line length
        line.setLength(6.0)
        Console.WriteLine("Length of line set by setLength : {0}", line.getLength())
        Console.ReadKey()
    End Sub
End Class