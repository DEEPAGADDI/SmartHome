Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Modify
    Dim q1var, q2var As String
    Dim tempvar As String

   

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        If TextBox3.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("All fields are mandatory")
            Exit Sub
        End If
        If TextBox8.Text <> TextBox9.Text Then
            MsgBox("Password didnt match")
            Exit Sub
        End If

        If vbNo = MsgBox("Are you sure you want modify this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim cmd1 As New SqlCommand("Delete from Adduser where UserID='" & ComboBox1.Text & "'", connection)
        cmd1.ExecuteNonQuery()
        If connection.State = ConnectionState.Open Then connection.Close()
        saverecords()
        Button3.Enabled = False
        Button4.Enabled = False

    End Sub
    Sub saverecords()

        If ComboBox1.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If
        If TextBox5.Text = "" Then
            MsgBox("Please enter the necessary details")
            Exit Sub
        End If

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd0 As New SqlCommand("select UserID from Adduser where UserID='" & (ComboBox1.Text) & "'", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            MsgBox("This record is already present in the database")
            If connection.State = ConnectionState.Open Then connection.Close()
            Exit Sub
        End If

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        q1var = "insert into Adduser("
        q2var = " values("
        q1var = q1var & "UserID" & ","
        q2var = q2var & "'" & (ComboBox1.Text) & "',"
        q1var = q1var & "Name" & ","
        q2var = q2var & "'" & (TextBox2.Text) & "',"
        q1var = q1var & "Contact" & ","
        q2var = q2var & "'" & (TextBox3.Text) & "',"
        q1var = q1var & "Address" & ","
        q2var = q2var & "'" & (TextBox4.Text) & "',"
        q1var = q1var & "Email" & ","
        q2var = q2var & "'" & (TextBox5.Text) & "',"
        q1var = q1var & "AdhaarNo" & ","
        q2var = q2var & "'" & (TextBox6.Text) & "',"
        q1var = q1var & "UserName" & ","
        q2var = q2var & "'" & (TextBox7.Text) & "',"
        q1var = q1var & "Password" & ","
        q2var = q2var & "'" & (TextBox8.Text) & "',"
        q1var = q1var & "ConfirmPassword" & ","
        q2var = q2var & "'" & (TextBox9.Text) & "',"
        q1var = q1var & "Question" & ","
        q2var = q2var & "'" & (ComboBox2.Text) & "',"
        q1var = q1var & "Answer" & ")"
        q2var = q2var & "'" & (TextBox10.Text) & "')"
        'MsgBox(q1Var & q2Var)
        Dim cmd1 As New SqlCommand(q1var & q2var, connection)
        cmd1.ExecuteNonQuery()
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        MsgBox("Modifed Successfully")
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub


    Private Sub Modify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd1 As New SqlCommand("Select UserID From Adduser Order By UserID", connection)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        While D1.Read
            ComboBox1.Items.Add(D1(0).ToString)
        End While
    End Sub

  



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If vbNo = MsgBox("Are you sure you want delete this record", MsgBoxStyle.YesNo, "Delete") Then Exit Sub
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim cmd1 As New SqlCommand("Delete from Adduser where UserID='" & ComboBox1.Text & "'", connection)
        cmd1.ExecuteNonQuery()

        If connection.State = ConnectionState.Open Then connection.Close()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        MsgBox("Deleted Successfully")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Adminhomepage.Show()
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        Dim phoneNumber As New Regex("^([6-9]{1})([0-9]{9})")
        TextBox3.MaxLength = 10
        If phoneNumber.IsMatch(TextBox3.Text) Then
            TextBox4.Focus()
        Else
            MsgBox("Not Valid Phone Number")
            TextBox3.Text = ""
            TextBox3.Focus()
        End If
    End Sub

   

    Private Sub TextBox5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Leave
        Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(TextBox5.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.")
            TextBox5.Focus()
            TextBox5.Clear()
        End If
    End Sub


    Public Function ValidateEmail(ByRef emailaddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+])*@(?:[w\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailaddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("please enter alpha text only!")
            TextBox2.Focus()
            TextBox2.Clear()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd1 As New SqlCommand("select * from  Adduser where userID='" & ComboBox1.Text & "'", connection)
        Dim D1 As SqlDataReader = Cmd1.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox2.Text = D1(1)
            TextBox3.Text = D1(2)
            TextBox4.Text = D1(3)
            TextBox5.Text = D1(4)
            TextBox6.Text = D1(5)
            TextBox7.Text = D1(6)
            TextBox8.Text = D1(7)
            TextBox9.Text = D1(8)
            ComboBox2.Text = D1(9)
            TextBox10.Text = D1(10)
        End If
    End Sub

    Private Sub TextBox6_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.Leave
        If Len(TextBox6.Text) < 12 Or Len(TextBox6.Text) > 12 Then
            MsgBox("Please enter 12 digit number")
            TextBox6.Focus()
            TextBox6.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub TextBox6_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox6.LostFocus
        
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
