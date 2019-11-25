Module Module1

    Sub Main()
        Dim i As Integer = 0
        Dim myArray(10) As Integer
        Dim X As Integer = 0
        Dim j As Integer = 0

        'Initialisation for Single-Dimension Array
        For i = 1 To 10
            myArray(i) = 0
        Next

        'Population
        For i = 1 To 10
            Console.Write("Input X ")
            X = Console.ReadLine
            myArray(i) = X
        Next

        'Bubble Sort (non-robust)
        For j = 1 To 10
            For i = 1 To 9
                If myArray(i) > myArray(i + 1) Then
                    X = myArray(i)
                    myArray(i) = myArray(i + 1)
                    myArray(i + 1) = X
                End If
            Next
        Next

        'Output
        For i = 1 To 10
            Console.WriteLine(myArray(i))
        Next
        Console.ReadKey()

    End Sub

End Module
