Imports System.IO
Public Class Form1
    Public Shared root = "D:\课件\新建文件夹"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t = New IO.DirectoryInfo(root)


        For Each f In t.GetFiles
            Dim dir = f.CreationTime.ToString("yyyy_MM_dd")
            If Not IO.Directory.Exists(root + "\" + dir) Then
                Directory.CreateDirectory(root + "\" + dir)
            End If
            File.Move(f.FullName, root + "\" + dir + "\" + f.Name)
        Next
    End Sub
End Class
