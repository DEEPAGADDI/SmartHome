Imports System.Data.SqlClient

Public Class USERLOGIN

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()

        Dim cmd1 As New SqlCommand("select * from adduser where UserName='" & UCase(UsernameTextBox.Text) & "' and Password='" & PasswordTextBox.Text & "'", connection)
        Dim d2 As SqlDataReader = cmd1.ExecuteReader
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("All fields are mandatory")
            Exit Sub
        End If

        If d2.HasRows Then
            MsgBox("Login successful")
        Else
            MsgBox("Login failed")
            Exit Sub
        End If
        Me.Close()
        USERHOMEPAGE.Show()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Forgotpassword.Show()

    End Sub

  
    

    
    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            PasswordTextBox.UseSystemPasswordChar = False
        Else
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub
   

    Private Sub USERLOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PasswordTextBox.UseSystemPasswordChar = True
    End Sub
End Class
