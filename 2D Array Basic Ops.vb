Module Module1

    Sub Main()
        Dim myArray(5, 4) As String
        Dim column As Integer = 0
        Dim row As Integer = 0

        'Initialisation of Array
        For row = 1 To 5
            For column = 1 To 4
                myArray(row, column) = ""
            Next
        Next

        ' population of 2D Array
        For row = 1 To 5
            For column = 1 To 4
                Console.Write("input: ")
                myArray(row, column) = Console.ReadLine
            Next
        Next

        ' Output
        For row = 1 To 5
            For column = 1 To 4
                Console.Write(myArray(row, column))
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
