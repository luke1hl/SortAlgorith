Imports System.IO
Public Class Form1
    Private bubbler As New CBubblesort
    Private merger As New CMergeSort
    Private numberarray(999999) As Integer
    Private holdernumberarray() As Integer
    Private filepath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.OK
                filepath = OpenFileDialog1.FileName
            Case Else
                MsgBox("you didn't open a file...closing program")
                Environment.Exit(0)
        End Select

        Dim objReader As New System.IO.StreamReader(filepath)

        Dim a As String
        Dim count As Integer = 0
        Do
            a = objReader.ReadLine
            numberarray(count) = a
            count += 1
        Loop Until a Is Nothing
        count -= 2
        ReDim Preserve numberarray(count)
        holdernumberarray = numberarray
        Filename.Text = Path.GetFileName(filepath)

        objReader.Close()
    End Sub
    Private Sub filenames()
        Filename.Text = Path.GetFileName(filepath)
    End Sub
    Private Sub domerge()
        Dim holder As New CMergeSort.values
        MsgBox(checkersort(merger.DoSort(numberarray, holder)))
        mergeswaps.Text &= holder.swaps
        mergecompa.Text &= holder.count

    End Sub
    Private Function checkersort(array() As Integer)
        Dim currentvalue As Integer = Integer.MinValue
        For i = 0 To array.Length - 1
            If currentvalue > array(i) Then
                Return False
            End If
            currentvalue = array(i)
        Next
        Return True

    End Function
    Private Sub dobubble()
        Dim holder As CBubblesort.values
        holder = bubbler.BubbleSort(numberarray)
        bubblecomp.Text &= holder.count
        bubbleswaps.Text &= holder.swaps

        'For i = 0 To numberarray.Length - 1
        '    MsgBox(numberarray(i))
        'Next
    End Sub

    Private Sub dothebubble_Click(sender As Object, e As EventArgs) Handles dothebubble.Click
        dobubble()

    End Sub

    Private Sub dothemerge_Click(sender As Object, e As EventArgs) Handles dothemerge.Click
        domerge()

    End Sub
End Class
