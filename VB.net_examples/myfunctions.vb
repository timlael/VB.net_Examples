Module myfunctions
    ' simple function to find max value of two passed numbers
    Function FindMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer
        If (num1 > num2) Then
            result = num1
        Else
            result = num2
        End If
        FindMax = result ' return value by assigning to function name
    End Function
    ' recursive factorial function
    Function factorial(ByVal num As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer
        If (num = 1) Then
            Return 1
        Else
            result = factorial(num - 1) * num
            Return result ' return value by explicit return
        End If
    End Function
    ' Passing Param Array in the case of unnown number of arguments
    Function AddElements(ParamArray arr As Integer()) As Integer
        Dim sum As Integer = 0
        Dim i As Integer = 0
        For Each i In arr
            sum += i
        Next i
        Return sum
    End Function
    ' Passing arrays as arguments
    Function getAverage(ByVal arr As Integer()) As Double
        ' Function getAverage(ByVal arr As Integer(), ByVal size As Integer) As Double
        ' local variables
        Dim i As Integer
        Dim avg As Double
        Dim sum As Integer = 0
        Dim size = arr.Length ' modified example code which had size passed in as if always known
        For i = 0 To size - 1
            sum += arr(i)
        Next i

        avg = sum / size
        Return avg
    End Function

    Sub Main()
        Dim a As Integer = 100
        Dim b As Integer = 200
        Dim res As Integer
        Dim sum As Integer
        ' an int array with 5 elements '
        Dim balance As Integer() = {1000, 2, 3, 17, 50}
        Dim avg As Double

        res = FindMax(a, b)
        Console.WriteLine("Calling FindMax function:")
        Console.WriteLine("Max value is : {0}", res)
        Console.WriteLine()
        'calling the factorial method
        Console.WriteLine("Calling factorial function:")
        Console.WriteLine("Factorial of 6 is : {0}", factorial(6))
        Console.WriteLine("Factorial of 7 is : {0}", factorial(7))
        Console.WriteLine("Factorial of 8 is : {0}", factorial(8))
        Console.WriteLine()

        'calling the AddElements method
        Console.WriteLine("Calling function AddElements using Param Array:")
        sum = AddElements(512, 720, 250, 567, 889)
        Console.WriteLine("The sum is: {0}", sum)
        Console.WriteLine()

        Console.WriteLine("Calling function getAverage with passed Array:")
        'pass pointer to the array as an argument 
        avg = getAverage(balance)
        ' output the returned value '
        Console.WriteLine("Average value is: {0} ", avg)

        Console.ReadKey()
    End Sub
End Module
