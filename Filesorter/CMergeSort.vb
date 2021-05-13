Public Class CMergeSort
    Structure values
        Dim count As Integer
        Dim swaps As Integer
    End Structure

    Function DoSort(ByRef array() As Integer, ByRef tracker As values) As Integer()
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
    Function merge(ByRef array() As Integer, arraytwo() As Integer, ByRef tracker As values) As Integer()
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

End Class
