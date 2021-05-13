Public Class CMergeSort
    Structure values
        Dim count As Integer
        Dim swaps As Integer
    End Structure

    Function DoSort(ByVal array() As Integer, ByRef tracker As values) As Integer()
        Dim lista As New List(Of Integer())
        For i = 0 To array.Length - 1
            Dim subarray(0) As Integer
            subarray(0) = array(i)
            lista.Add(subarray)
        Next
        While lista.Count > 1
            Dim i As Integer = 0
            While i < lista.Count - 1
                Dim resultofmerge As Integer() = merge(lista(i), lista(i + 1), tracker)
                lista.RemoveRange(i, 2)
                lista.Insert(i, resultofmerge)
                i += 1
            End While
        End While
        Return lista(0)
    End Function
    Function merge(array() As Integer, arraytwo() As Integer, ByRef tracker As values) As Integer()
        Dim listresult As New List(Of Integer)
        Dim listleftarray As List(Of Integer) = New List(Of Integer)(array)
        Dim listrightarray As List(Of Integer) = New List(Of Integer)(arraytwo)
        While listleftarray.Count > 0 Or listrightarray.Count > 0
            tracker.count += 1
            If listleftarray.Count = 0 Then
                listresult.Add(listrightarray(0))
                listrightarray.RemoveAt(0)
            ElseIf (listrightarray.Count = 0) Then
                listresult.Add(listleftarray(0))
                listleftarray.RemoveAt(0)

            ElseIf listleftarray(0) <= listrightarray(0) Then
                listresult.Add(listleftarray(0))
                listleftarray.RemoveAt(0)
            Else
                listresult.Add(listrightarray(0))
                listrightarray.RemoveAt(0)

            End If
        End While
        Return listresult.ToArray()

    End Function
    'Function MergeSort(ByRef array() As Integer, bottomindexer As Integer, topindexer As Integer, ByRef holder As values)
    '    If (bottomindexer < topindexer) Then
    '        Dim midIndex = Math.Floor((bottomindexer + topindexer) / 2)
    '        MergeSort(array, bottomindexer, midIndex, holder)
    '        MergeSort(array, midIndex + 1, topindexer, holder)
    '        Merge(array, bottomindexer, midIndex, topindexer, holder)
    '        If holder.count = 0 Then
    '            MsgBox(holder.count)

    '        End If
    '    End If
    '    ' MsgBox("yeh")
    '    'For i = 0 To array.Length - 1
    '    '    MsgBox(array(i))
    '    'Next

    'End Function

    'Sub Merge(ByVal array() As Integer, lowIndex As Integer, midIndex As Integer, highIndex As Integer, ByRef valus As values)
    '    'create two arrays for each side of merge sort
    '    Dim n1 = midIndex - lowIndex + 1
    '    Dim n2 = highIndex - midIndex

    '    Dim L(n1) As Integer
    '    Dim R(n2) As Integer
    '    Dim k As Integer = lowIndex

    '    Dim counterI = 0
    '    Dim counterJ = 0
    '    'fills the two arrays
    '    While (counterI < n1)
    '        L(counterI) = array(lowIndex + counterI)
    '        counterI = counterI + 1
    '    End While


    '    While (counterJ < n2)
    '        R(counterJ) = array(midIndex + 1 + counterJ)
    '        counterJ = counterJ + 1
    '    End While
    '    'reset variables
    '    k = lowIndex
    '    Dim i As Integer = 0
    '    Dim j As Integer = 0
    '    'go through and compare arrays
    '    While (i < n1 And j < n2)
    '        'MsgBox("yo")
    '        ' valus.count += 1
    '        If (L(i) <= R(j)) Then
    '            array(k) = L(i)
    '            i = i + 1
    '            valus.count += 1
    '        Else
    '            valus.count += 1
    '            array(k) = R(j)
    '            j = j + 1
    '        End If
    '        k = k + 1
    '    End While
    '    ' valus.count += 1

    '    While (i < n1)
    '        array(k) = L(i)
    '        i = i + 1
    '        k = k + 1
    '        valus.count += 1

    '    End While
    '    'valus.count += 1

    '    While (j < n2)
    '        array(k) = R(j)
    '        j = j + 1
    '        k = k + 1
    '        valus.count += 1

    '    End While
    '    'MsgBox(valus.count)

    '    '  MsgBox("end of merge")
    'End Sub
End Class
