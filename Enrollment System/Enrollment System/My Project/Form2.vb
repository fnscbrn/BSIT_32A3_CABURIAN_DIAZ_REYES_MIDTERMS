Imports System.Data.OleDb
Public Class Form2
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\User\Documents\Enrollment System\Enrollment System\bin\Debug\StudentDatabase1.accdb")

    Private Sub LoadStudentTable()
        Try
            Dim sql As String = "SELECT * FROM tblStudents"
            Dim da As New OleDbDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            tblStudents.DataSource = dt
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentTable()
    End Sub

    Private Sub bkpg_Click(sender As Object, e As EventArgs) Handles bkpg.Click
        Form1.Show
        Hide
    End Sub

    Private Sub LoadStudentData()
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Reuel D. Caburian\source\repos\Enrollment System\Enrollment System\bin\Debug\StudentDatabase1.accdb")
            Dim da As New OleDbDataAdapter("SELECT * FROM tblStudents", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            tblStudents.DataSource = dt
        Catch ex As Exception
            MsgBox("Failed to load student data: " & ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If tblStudents.SelectedRows.Count = 0 Then
            MsgBox("Please select a row to delete.", vbExclamation)
            Return
        End If

        Dim selectedRow As DataGridViewRow = tblStudents.SelectedRows(0)
        Dim regNum As Integer = CInt(selectedRow.Cells("RegNumber").Value)

        Dim confirm = MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion)
        If confirm = vbNo Then Return

        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Reuel D. Caburian\source\repos\Enrollment System\Enrollment System\bin\Debug\StudentDatabase1.accdb")
            conn.Open()

            Dim cmd As New OleDbCommand("DELETE FROM tblStudents WHERE RegNumber = ?", conn)
            cmd.Parameters.AddWithValue("?", regNum)
            cmd.ExecuteNonQuery()

            conn.Close()

            MsgBox("Record deleted successfully.", vbInformation)

            ' Optional: Refresh the DataGridView
            LoadStudentData()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
        End Try
    End Sub
End Class