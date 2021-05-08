Imports System.IO
Public Class Form1
    Private bubbler As New CBubblesort
    Private merger As New CMergeSort
    Private numberarray(999999) As Integer

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
        objReader.Close()
        filenames()
        dobubble()
        domerge()
    End Sub
    Private Sub filenames()
        Filename.Text = Path.GetFileName(filepath)
    End Sub
    Private Sub domerge()
        Dim holder As New CMergeSort.values
        merger.MergeSort(numberarray, 0, numberarray.Length - 1, holder)
        mergeswaps.Text &= holder.swaps
        mergecompa.Text &= holder.count
    End Sub
    Private Sub dobubble()
        Dim holder As CBubblesort.values
        holder = bubbler.BubbleSort(numberarray)
        bubblecomp.Text &= holder.count
        bubbleswaps.Text &= holder.swaps

        'For i = 0 To numberarray.Length - 1
        '    MsgBox(numberarray(i))
        'Next
    End Sub
End Class
