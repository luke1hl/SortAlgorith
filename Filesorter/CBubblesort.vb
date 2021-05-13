Public Class CBubblesort
    Structure values
        Dim count As Int64
        Dim swaps As Int64
    End Structure
    Function BubbleSort(ByVal Numlist() As Integer) As values
        Dim valuesstructure As New values

        valuesstructure.swaps = 0
        valuesstructure.count = 0
        Dim Swapvalue As Integer
        For ii = 0 To Numlist.Length - 1
            For i = 0 To Numlist.Length - 2
                valuesstructure.count += 1

                If Numlist(i) > Numlist(i + 1) Then
                    valuesstructure.swaps += 1
                    Swapvalue = Numlist(i)
                    Numlist(i) = Numlist(i + 1)
                    Numlist(i + 1) = Swapvalue
                End If
            Next
        Next

        Return valuesstructure

    End Function
End Class
