Module strings
    Sub Main()
        Dim fname, lname, fullname, greetings As String
        fname = "Tim"
        lname = "Lael"
        fullname = fname + " " + lname
        Console.WriteLine("Full name: {0}", fullname)
        Console.WriteLine()

        'by using string constructor
        Dim letters As Char() = {"H", "e", "l", "l", "o"}
        Dim letters2 As Char() = {"H", "e", "r", "r", "o"}
        greetings = New String(letters)
        Console.WriteLine("Greetings: {0}", greetings)
        Console.WriteLine()

        'methods returning String
        Dim sarray() As String = {"Hello", "From", "Tutorials", "Point"}
        Dim message As String = String.Join(" ", sarray)
        Console.WriteLine("Message: {0}", message)
        Console.WriteLine()

        'formatting method to convert a value
        Dim waiting As DateTime = New DateTime(2017, 6, 14, 11, 47, 0) 'to build a time (YYYY, m, dd, hh, mm, AM/PM(0,1))
        'Dim waiting As DateTime = DateTime.Now for current time
        Dim chat As String = String.Format("Message sent at {0:t} on {0:D}", waiting)
        Console.WriteLine("Message: {0}", chat)
        Console.WriteLine()

        If (String.Compare(letters, letters2) = 0) Then
            Console.WriteLine(letters + " and " + letters2 +
                              " are equal.")
        Else
            Console.WriteLine(letters + " and " + letters2 +
                              " are not equal.")
        End If


        'If (letters.Contains("test")) Then
        '    Console.WriteLine("The sequence 'test' was found.")
        'End If

        Dim str As String
        str = "Last night I dreamt of San Pedro"
        Console.WriteLine(str)
        Dim substr As String = str.Substring(27)
        Console.WriteLine(substr)

        Dim strarray As String() = {"Down the way where the nights are gay",
                            "And the sun shines daily on the mountain top",
                             "I took a trip on a sailing ship",
                            "And when I reached Jamaica",
                            "I made a stop"}
        Dim str2 As String = String.Join(vbCrLf, strarray)
        Console.WriteLine(str2)

        Console.ReadKey()

    End Sub


End Module
