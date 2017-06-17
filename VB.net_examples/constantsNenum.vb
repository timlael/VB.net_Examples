Module constantsNenum
    Enum Colors
        'you can set a starting value or set values for each
        'when a value is set, subsequent elements increment
        red = 1
        orange
        yellow
        green = 99
        azure
        blue
        violet
    End Enum

    Sub Main()

        Const PI = 3.14149
        Dim radius, area As Single
        radius = 7
        area = PI * radius * radius
        Console.WriteLine("Area = " & Str(area))
        Console.WriteLine("The color Red is: " & Colors.red)
        Console.WriteLine("The color Yellow is: " & Colors.yellow)
        Console.WriteLine("The color Blue is: " & Colors.blue)
        Console.WriteLine("The color Green is: " & Colors.green)
        Console.ReadKey()

    End Sub

End Module
