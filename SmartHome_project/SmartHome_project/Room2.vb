Imports System.Data.SqlClient

Public Class Room2
    Dim a, b, c, d As String
    Private Sub Room2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd1 As New SqlCommand("select * from Room2 where Code='" & 1 & "'", connection)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            a = D1(0).ToString
            b = D1(1).ToString
            c = D1(2).ToString
            d = D1(3).ToString
            ' MsgBox(a & b & c & d)
        End If
        If a = "1" Then
            Label5.Text = "ON"
        Else
            Label5.Text = "OFF"
        End If

        If b = "1" Then
            Label6.Text = "ON"
        Else
            Label6.Text = "OFF"
        End If

        If c = "1" Then
            Label7.Text = "ON"
        Else
            Label7.Text = "OFF"
        End If

        If d = "1" Then
            Label8.Text = "ON"
        Else
            Label8.Text = "OFF"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class