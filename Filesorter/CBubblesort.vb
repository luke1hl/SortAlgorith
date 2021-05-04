Public Class CBubblesort
    Function BubbleSort(Numlist)
        Dim Count As Integer = 0
        Dim Swapvalue As Integer
        For ii = 0 To Numlist.Length - 2
            For i = 0 To Numlist.Length - 2
                Count += 1
                If Numlist(i) > Numlist(i + 1) Then
                    Swapvalue = Numlist(i)
                    Numlist(i) = Numlist(i + 1)
                    Numlist(i + 1) = Swapvalue
                End If
            Next
        Next
        Return (Count)

    End Function
End Class
