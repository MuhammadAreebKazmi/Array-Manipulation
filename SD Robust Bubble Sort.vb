Module Module1

    Sub Main()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim isSorted As Boolean = True
        Dim X As Integer = 0
        Dim myArray(10) As Integer

        'Initialisation
        For i = 1 To 5
            myArray(i) = 0
        Next

        'Populate
        For i = 1 To 5
            Console.Write("Enter the value of X: ")
            X = Console.ReadLine
            myArray(i) = X
        Next

        'Robust code for Bubble Sort
        For j = 4 To 1 Step -1
            isSorted = True
            For i = 1 To j
                If myArray(i) > myArray(i + 1) Then
                    X = myArray(i)
                    myArray(i) = myArray(i + 1)
                    myArray(i + 1) = X
                    isSorted = False
                End If
            Next
            If isSorted = True Then
                Exit For
            End If
        Next

        'Output
        For i = 1 To 5
            Console.WriteLine(myArray(i))
        Next
        Console.ReadKey()

    End Sub

End Module
