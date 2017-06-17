' Base class
Class Shape
    Protected width As Double
    Protected length As Double
    Protected radius As Double
    Protected height As Double

    Public Sub setWidth(ByVal w As Double)
        width = w
    End Sub

    Public Sub setLength(ByVal l As Double)
        length = l
    End Sub

    Public Sub setRadius(ByVal r As Double)
        radius = r
    End Sub

    Public Sub setHeight(ByVal h As Double)
        height = h
    End Sub
End Class

        ' Derived class
Class RectangleClass : Inherits Shape
        Public Sub New(ByVal l As Double, ByVal w As Double)
            setLength(l)
            setWidth(w)
        End Sub

        Public Function GetArea() As Double
            Return (width * length)
        End Function

        Public Overridable Sub Display()
            Console.WriteLine("Length: {0}", length)
            Console.WriteLine("Width: {0}", width)
            Console.WriteLine("Area: {0}", GetArea())
        End Sub
    End Class

    'Derived class
    Class Tabletop : Inherits RectangleClass
        Private cost As Double
        Public Sub New(ByVal l As Double, ByVal w As Double)
            MyBase.New(l, w)
        End Sub
        Public Function GetCost() As Double
            Dim cost As Double
            cost = GetArea() * 70
            Return cost
        End Function
        Public Overrides Sub Display()
            MyBase.Display()
            Console.WriteLine("Cost: {0}", GetCost())
        End Sub
        'end class Tabletop
    End Class

    Class RectangleTester
        Shared Sub Main()
            Dim t As Tabletop = New Tabletop(4.5, 7.5)
            t.Display()
            Console.ReadKey()
        End Sub
    End Class