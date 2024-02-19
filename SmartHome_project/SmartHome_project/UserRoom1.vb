Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Data.SqlClient
Public Class UserRoom1
    Dim command, value As String
    Dim a, b, c, d As String
    Dim q1var, q2var As String
    Private Sub UserRoom1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        SerialPort1.PortName = "com3" 'change com port to match your Arduino port
        SerialPort1.BaudRate = 9600
        SerialPort1.Open()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            command = command + "1"
            CheckBox1.BackColor = Color.Green
        Else
            command = command + "0"
            CheckBox1.BackColor = Color.Red
        End If
        If CheckBox1.Checked = True Then
            a = "1"
        Else
            a = "0"
        End If
        If CheckBox2.Checked = True Then
            command = command + "1"
            CheckBox2.BackColor = Color.Green
        Else
            command = command + "0"
            CheckBox2.BackColor = Color.Red
        End If
        If CheckBox2.Checked = True Then
            b = "1"
        Else
            b = "0"
        End If
        If CheckBox3.Checked = True Then
            command = command + "1"
            CheckBox3.BackColor = Color.Green
        Else
            command = command + "0"
            CheckBox3.BackColor = Color.Red
        End If
        If CheckBox3.Checked = True Then
            c = "1"
        Else
            c = "0"
        End If
        If CheckBox4.Checked = True Then
            command = command + "1"
            CheckBox4.BackColor = Color.Green
        Else
            command = command + "0"
            CheckBox4.BackColor = Color.Red
        End If
        If CheckBox4.Checked = True Then
            d = "1"
        Else
            d = "0"
        End If
        Select Case command
            Case "0000"
                SerialPort1.Write("0")
            Case "0001"
                SerialPort1.Write("1")
            Case "0010"
                SerialPort1.Write("2")
            Case "0011"
                SerialPort1.Write("3")
            Case "0100"
                SerialPort1.Write("4")
            Case "0101"
                SerialPort1.Write("5")
            Case "0011"
                SerialPort1.Write("6")
            Case "0111"
                SerialPort1.Write("7")
            Case "1000"
                SerialPort1.Write("8")
            Case "1001"
                SerialPort1.Write("9")
            Case "1010"
                SerialPort1.Write(":")
            Case "1011"
                SerialPort1.Write(";")
            Case "1100"
                SerialPort1.Write("<")
            Case "1101"
                SerialPort1.Write("=")
            Case "1110"
                SerialPort1.Write(">")
            Case "1111"
                SerialPort1.Write("?")
        End Select
        command = ""
        Dim code As String
        code = "1"
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        q1Var = "update Room1 set "
        q1Var = q1Var & "bulb1 ='" & a & "',"
        q1Var = q1Var & "bulb2 ='" & b & "',"
        q1Var = q1Var & "bulb3 ='" & c & "',"
        q1Var = q1Var & "bulb4 ='" & d & "'"
        q1Var = q1Var & " where Code =" & code & ""
        'MsgBox(q1Var )
        Dim cmd1 As New SqlCommand(q1Var, connection)
        cmd1.ExecuteNonQuery()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub




  
End Class