Imports System.Data.SqlClient

Public Class Userreport
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If connection.State = ConnectionState.Open Then connection.Close()
        connection.Open()
        Dim DS1 As New DataSet
        Dim adp As New SqlDataAdapter("Select * from Adduser", connection)
        adp.Fill(DS1)
        DataGridView1.DataSource = DS1.Tables(0)
        If connection.State = ConnectionState.Open Then connection.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PP1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long
        YPos = 50
        Dim MyFont As New Font("Arial", 22)
        XPos = 10
        e.Graphics.DrawString("Adduser", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        MyFont = New Font("Arial", 11)
        e.Graphics.DrawString("No. 101, 4th floor, UB City, Bangalore - 560001", MyFont, Brushes.Black, XPos, YPos)
        YPos += 100
        XPos = 10
        e.Graphics.DrawString("User List", MyFont, Brushes.Black, XPos, YPos)
        YPos += 50
        XPos = 10
        MyFont = New Font("Arial", 14)
        e.Graphics.DrawString("UserID", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Name", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Contact", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        e.Graphics.DrawString("Email", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 150
        YPos += 50
        For Each r As DataGridViewRow In DataGridView1.Rows

            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(1).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150
            e.Graphics.DrawString(r.Cells(4).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 150

            YPos += 25
        Next
    End Sub

    
    Private Sub Userreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

   
End Class