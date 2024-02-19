Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Adduser
    Dim tempvar As String
    Dim q1var, q2var, pkvar As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox8.Text <> TextBox9.Text Then
            MsgBox("Password Did'nt Match")
            Exit Sub
        End If
        saverecords()
        disRecords()

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd0 As New SqlCommand("select max(UserID) from Adduser", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = Val(D1(0).ToString) + 1
            If connection.State = ConnectionState.Open Then connection.Close()
            TextBox1.Enabled = False
        End If
    End Sub
    Sub saverecords()

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
      
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("All Fields Are Mandatory")
            Exit Sub
        End If
        Dim Cmd0 As New SqlCommand("select userID from Adduser where userID='" & (TextBox1.Text) & "'", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()


        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        q1var = "insert into Adduser(UserID,Name,Contact,Address,Email,AdhaarNo,UserName,Password,ConfirmPassword,Question,Answer)"
        q2var = "values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & ComboBox1.Text & "','" & TextBox10.Text & "')"
       
        Dim cmd1 As New SqlCommand(q1var & q2var, connection)
        cmd1.ExecuteNonQuery()
        If connection.State = ConnectionState.Open Then connection.Close()
        MsgBox(" User Added Successfully")
        disRecords()
        TextBox1.Text = ""
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




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Adminhomepage.Show()
    End Sub

    

    Private Sub Adduser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd0 As New SqlCommand("select max(UserID) from Adduser", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = Val(D1(0).ToString) + 1
            If connection.State = ConnectionState.Open Then connection.Close()
            TextBox1.Enabled = False
        End If
        disRecords()
    End Sub
  

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkVar = DataGridView1.CurrentRow.Cells(0).Value
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim Cmd0 As New SqlCommand("select * from Adduser where UserID='" & pkvar & "'", connection)
        Dim D1 As SqlDataReader = Cmd0.ExecuteReader()
        If D1.HasRows Then
            D1.Read()
            TextBox1.Text = D1(0).ToString
            TextBox2.Text = D1(1).ToString
            TextBox3.Text = D1(2).ToString
            TextBox4.Text = D1(3).ToString

            TextBox5.Text = D1(4).ToString
            TextBox6.Text = D1(5).ToString
            TextBox7.Text = D1(6).ToString
            TextBox8.Text = D1(7).ToString
            TextBox9.Text = D1(8).ToString
            TextBox10.Text = D1(9)

        Else
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
        End If
        If connection.State = ConnectionState.Open Then connection.Close()

    End Sub
    Sub disRecords()
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select * From Adduser order by userID", connection)
        adp.Fill(DS1)
        DataGridView1.DataSource = DS1.Tables(0)
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub
   


   

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not Regex.Match(TextBox2.Text, "^[a-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("please enter alpha text only!")
            TextBox2.Focus()
            TextBox2.Clear()

        End If
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

   
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
