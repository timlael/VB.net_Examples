Module arrayApl
    Sub Main()
        ' a standard 11 element array
        Dim n(10) As Integer  ' n is an array of 11 integers '
        ' a dynamically sized array
        Dim marks() As Integer
        ' a multi-dimensional array
        Dim a(,) As Integer = {{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}}
        ' a jagged array of 5 array of integers
        Dim b As Integer()() = New Integer(4)() {}
        b(0) = New Integer() {0, 0}
        b(1) = New Integer() {1, 2}
        b(2) = New Integer() {2, 4}
        b(3) = New Integer() {3, 6}
        b(4) = New Integer() {4, 8}
        ' method example arrays
        Dim list As Integer() = {34, 72, 13, 44, 25, 30, 10}
        Dim temp As Integer() = list

        Dim i, j As Integer

        ' initialize elements of array n '         
        For i = 0 To 10
            n(i) = i + 100         ' set element at location i to i + 100
        Next i

        Console.WriteLine("Array n's element values:")
        Console.WriteLine()
        ' output each array n element's value '
        For j = 0 To 10
            Console.WriteLine("Element({0}) = {1}", j, n(j))
        Next j
        Console.WriteLine()

        ' sizing dynamic arrays using redim and redim preserve
        ReDim marks(2)
        marks(0) = 85
        marks(1) = 75
        marks(2) = 90
        ReDim Preserve marks(10)
        marks(3) = 80
        marks(4) = 76
        marks(5) = 92
        marks(6) = 99
        marks(7) = 79
        marks(8) = 75
        Console.WriteLine("Dynamic array element values:")
        Console.WriteLine()
        For i = 0 To 10
            Console.WriteLine(i & vbTab & marks(i))
        Next i
        Console.WriteLine()

        Console.WriteLine("Multi-dimensional array element values:")
        Console.WriteLine()
        ' output each multi-dimensional array (a) element's value '
        For i = 0 To 4
            For j = 0 To 1
                Console.WriteLine("a[{0},{1}] = {2}", i, j, a(i, j))
            Next j
        Next i
        Console.WriteLine()

        Console.WriteLine("Jagged array element values:")
        Console.WriteLine()
        ' output each jagged array element's value 
        For i = 0 To 4
            For j = 0 To 1
                Console.WriteLine("b[{0},{1}] = {2}", i, j, b(i)(j))
            Next j
        Next
        Console.WriteLine()

        Console.WriteLine("Examples of array method use:")
        Console.WriteLine()
        Console.Write("Original Array: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        ' reverse the array
        Array.Reverse(temp)
        Console.Write("Reversed Array: ")
        For Each i In temp
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()
        'sort the array
        Array.Sort(list)
        Console.Write("Sorted Array: ")
        For Each i In list
            Console.Write("{0} ", i)
        Next i
        Console.WriteLine()

        Console.ReadKey()
    End Sub
End Module

'Array Class Properties

'Property Name              Description
'IsFixedSize                Gets a value indicating whether the Array has a fixed size.
'IsReadOnly                 Gets a value indicating whether the Array is read-only.
'Length                     Gets a 32-bit integer that represents the total number of elements in all the dimensions of the Array.
'LongLength                 Gets a 64-bit integer that represents the total number of elements in all the dimensions of the Array.
'Rank                       Gets the rank (number of dimensions) of the Array.

'Array Class Methods

'Method Name                                                                                    Description
'Public Shared Sub Clear(array As Array, index As Integer, length As Integer)                   Sets a range of elements in the Array to zero, to false, or to null, depending on the element type.
'Public Shared Sub Copy(sourceArray As Array, destinationArray As Array, length As Integer)     Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 32-bit integer.
'Public Sub CopyTo(array As Array, index As Integer)                                            Copies all the elements of the current one-dimensional Array to the specified one-dimensional Array starting at the specified destination Array index. The index is specified as a 32-bit integer.
'Public Function GetLength(dimension As Integer) As Integer                                     Gets a 32-bit integer that represents the number of elements in the specified dimension of the Array.
'Public Function GetLongLength(dimension As Integer) As Long                                    Gets a 64-bit integer that represents the number of elements in the specified dimension of the Array.
'Public Function GetLowerBound(dimension As Integer) As Integer                                 Gets the lower bound of the specified dimension in the Array.
'Public Function GetType As Type                                                                Gets the Type of the current instance (Inherited from Object).
'Public Function GetUpperBound(dimension As Integer) As Integer                                 Gets the upper bound of the specified dimension in the Array.
'Public Function GetValue(index As Integer) As Object                                           Gets the value at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.
'Public Shared Function IndexOf(array As Array, value As Object) As Integer                     Searches for the specified object and returns the index of the first occurrence within the entire one-dimensional Array.
'Public Shared Sub Reverse(array As Array)                                                      Reverses the sequence of the elements in the entire one-dimensional Array.
'Public Sub SetValue(value As Object, index As Integer)                                         Sets a value to the element at the specified position in the one-dimensional Array. The index is specified as a 32-bit integer.
'Public Shared Sub Sort(array As Array)                                                         Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array.
'Public Overridable Function ToString() As String                                               Returns a string that represents the current object (Inherited from Object).
