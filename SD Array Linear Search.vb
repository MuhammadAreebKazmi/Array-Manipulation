Module Module1

    Sub Main()
        Dim i As Integer = 0
        Dim Isfound As Boolean = False
        Dim X As Integer = 0
        Dim myArray(10) As Integer
        Dim Y As Integer = 0

        'Initialisation
        For i = 1 To 10
            myArray(i) = 0
        Next

        'Populating the arrays
        For i = 1 To 10
            Console.Write("Enter any number: ")
            X = Console.ReadLine()
            myArray(i) = X
        Next

        'Linear Search operation
        Console.Write("Enter any number to be searched in the array: ")
        Y = Console.ReadLine
        Isfound = False
        For i = 1 To 10
            If myArray(i) = Y Then
                Isfound = True
                Exit For
            End If
        Next

        If Isfound Then
            Console.WriteLine("Value is found")
        Else
            Console.WriteLine("Value is not found")
        End If
        Console.ReadKey()
    End Sub

End Module
