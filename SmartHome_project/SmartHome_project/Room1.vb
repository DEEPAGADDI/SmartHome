Imports System.Data.SqlClient

Public Class Room1
    Dim aa, bb, cc, dd As String
    Private Sub Room1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd1 As New SqlCommand("select * from Room1 where Code='" & 1 & "'", connection)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            aa = D1(0).ToString
            bb = D1(1).ToString
            cc = D1(2).ToString
            dd = D1(3).ToString
        End If

        If aa = "1" Then
            Label5.Text = "ON"
        Else
            Label5.Text = "OFF"
        End If

        If bb = "1" Then
            Label6.Text = "ON"
        Else
            Label6.Text = "OFF"
        End If

        If cc = "1" Then
            Label7.Text = "ON"
        Else
            Label7.Text = "OFF"
        End If

        If dd = "1" Then
            Label8.Text = "ON"
        Else
            Label8.Text = "OFF"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class