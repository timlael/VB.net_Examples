Module mybox
    Class Box
        Public length As Double   ' Length of a box
        Public breadth As Double   ' Breadth of a box
        Public height As Double    ' Height of a box

        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub
        Public Sub setBreadth(ByVal bre As Double)
            breadth = bre
        End Sub
        Public Sub setHeight(ByVal hei As Double)
            height = hei
        End Sub
        Public Function getVolume() As Double
            Return length * breadth * height
        End Function
    End Class

    Sub Main()
        Dim Box1 As Box = New Box()        ' Declare Box1 of type Box
        Dim Box2 As Box = New Box()        ' Declare Box2 of type Box
        Dim volume As Double = 0.0     ' Store the volume of a box here

        '' box 1 specification (direct assignment)
        'Box1.height = 5.0
        'Box1.length = 6.0
        'Box1.breadth = 7.0
        '' box 2 specification (direct assignment)
        'Box2.height = 10.0
        'Box2.length = 12.0
        'Box2.breadth = 13.0

        ' box 1 specification (setters)
        Box1.setLength(6.0)
        Box1.setBreadth(7.0)
        Box1.setHeight(5.0)

        'box 2 specification (setters)
        Box2.setLength(12.0)
        Box2.setBreadth(13.0)
        Box2.setHeight(10.0)

        'volume of box 1
        'volume = Box1.height * Box1.length * Box1.breadth (direct calculation)
        volume = Box1.getVolume()
        Console.WriteLine("Volume of Box1 : {0}", volume) ' using function as assigned to volume
        'volume of box 2
        ' volume = Box2.height * Box2.length * Box2.breadth (direct calculation)
        Console.WriteLine("Volume of Box2 : {0}", Box2.getVolume()) ' using function directly
        Console.ReadKey()
    End Sub

End Module
