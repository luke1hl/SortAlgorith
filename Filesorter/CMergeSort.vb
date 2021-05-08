Public Class CMergeSort
    Structure values
        Dim count As Integer
        Dim swaps As Integer
    End Structure

    Sub MergeSort(ByVal array() As Integer, bottomindexer As Integer, topindexer As Integer)

        If (bottomindexer < topindexer) Then
            Dim midIndex = Math.Floor((bottomindexer + topindexer) / 2)
            MergeSort(array, bottomindexer, midIndex)
            MergeSort(array, midIndex + 1, topindexer)
            Merge(array, bottomindexer, midIndex, topindexer)
        End If

    End Sub

    Sub Merge(ByVal array() As Integer, lowIndex As Integer, midIndex As Integer, highIndex As Integer)

        Dim n1 = midIndex - lowIndex + 1
        Dim n2 = highIndex - midIndex

        Dim L(n1) As Integer
        Dim R(n2) As Integer

        Dim k As Integer = lowIndex

        Dim counterI = 0
        Dim counterJ = 0

        While (counterI < n1)
            L(counterI) = array(lowIndex + counterI)
            counterI = counterI + 1
        End While


        While (counterJ < n2)
            R(counterJ) = array(midIndex + 1 + counterJ)
            counterJ = counterJ + 1
        End While

        k = lowIndex
        Dim i As Integer = 0
        Dim j As Integer = 0

        While (i < n1 And j < n2)

            If (L(i) <= R(j)) Then
                array(k) = L(i)
                i = i + 1
            Else
                array(k) = R(j)
                j = j + 1
            End If
            k = k + 1
        End While

        While (i < n1)
            array(k) = L(i)
            i = i + 1
            k = k + 1
        End While

        While (j < n2)
            array(k) = R(j)
            j = j + 1
            k = k + 1
        End While

        For q As Integer = 0 To array.Length - 1
            MsgBox(array(q))
        Next
    End Sub
End Class
