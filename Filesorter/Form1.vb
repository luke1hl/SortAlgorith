Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numberarray() As Array

        Dim filepath As String
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

        objReader.Close()
    End Sub


End Class
