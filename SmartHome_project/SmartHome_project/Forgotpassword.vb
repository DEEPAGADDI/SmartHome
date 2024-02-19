Imports System.Data.SqlClient

Public Class Forgotpassword

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd0 As New SqlCommand("select * from Adduser where Question='" & (ComboBox1.Text) & "' and Answer='" & Textanswer.Text & "'", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(7).ToString
            TextBox1.Visible = True
        Else
            MsgBox("INCORRECT ANSWER FOR USERNAME'S QUESTION")
        End If
       
    End Sub

    Private Sub Forgotpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        ComboBox1.Visible = False
        Textanswer.Visible = False
        Button2.Visible = False
        Button3.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd0 As New SqlCommand("select * from Adduser where Username='" & (Textusername.Text) & "'", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            Label2.Visible = True
            Label3.Visible = True
            ComboBox1.Visible = True
            Textanswer.Visible = True
            Button2.Visible = True
            Button3.Visible = True
        Else
            MsgBox("INCORRECT USERNAME")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Textusername.Clear()
        Textanswer.Clear()
        TextBox1.Clear()
        Me.Hide()

        USERLOGIN.Show()
    End Sub

   
End Class