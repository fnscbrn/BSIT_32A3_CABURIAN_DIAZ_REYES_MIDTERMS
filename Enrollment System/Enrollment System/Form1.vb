Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb

Public Class Form1
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\User\Documents\Enrollment System\Enrollment System\bin\Debug\StudentDatabase1.accdb")
    Dim sqlCommand As OleDbCommand

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Generate a unique Registration Number
            Dim regNum As Integer = 1000 + CInt(Int((9999 * Rnd()) + 1))

            ' SQL Query to Insert Data
            Dim sqlInsert As String = "INSERT INTO tblStudents (RegNumber, FirstName, MiddleName, LastName, Sex, PhoneNum, Birthdate, " &
                          "HouseNo, Street, Barangay, City, PostalCode, Course, [Section], [SchoolYear], Semester, EnrollmentStatus, [StudentType]) " &
                          "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"


            conn.Open()
            sqlCommand = New OleDbCommand(sqlInsert, conn)
            sqlCommand.Parameters.AddWithValue("?", regNum)
            sqlCommand.Parameters.AddWithValue("?", txtFirstName.Text)
            sqlCommand.Parameters.AddWithValue("?", txtMiddleName.Text)
            sqlCommand.Parameters.AddWithValue("?", txtLastName.Text)
            sqlCommand.Parameters.AddWithValue("?", cbSex.Text)
            sqlCommand.Parameters.AddWithValue("?", txtPhone.Text)
            sqlCommand.Parameters.AddWithValue("?", dtpBirthDate.Value)
            sqlCommand.Parameters.AddWithValue("?", txtHouseNo.Text)
            sqlCommand.Parameters.AddWithValue("?", txtStreet.Text)
            sqlCommand.Parameters.AddWithValue("?", txtBarangay.Text)
            sqlCommand.Parameters.AddWithValue("?", txtCity.Text)
            sqlCommand.Parameters.AddWithValue("?", txtZipCode.Text)
            sqlCommand.Parameters.AddWithValue("?", cbCourse.Text)
            sqlCommand.Parameters.AddWithValue("?", cbSection.Text)
            sqlCommand.Parameters.AddWithValue("?", cbSY.Text)
            sqlCommand.Parameters.AddWithValue("?", cbSemester.Text)
            sqlCommand.Parameters.AddWithValue("?", cbEnrollmentStatus.Text)
            sqlCommand.Parameters.AddWithValue("?", cbStudentType.Text)

            sqlCommand.ExecuteNonQuery()
            MsgBox("Student added successfully.", vbInformation)
            conn.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtRegNum.Text = "" Then
            MsgBox("Please enter a Registration Number to delete.", vbExclamation)
            Return
        End If

        Try
            conn.Open()
            Dim sqlDelete As String = "DELETE FROM tblStudents WHERE RegNumber = ?"
            sqlCommand = New OleDbCommand(sqlDelete, conn)
            sqlCommand.Parameters.AddWithValue("?", txtRegNum.Text)
            sqlCommand.ExecuteNonQuery()
            MsgBox("Record deleted successfully.", vbInformation)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRegNum.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        cbSex.SelectedIndex = -1
        txtPhone.Clear()
        dtpBirthDate.Value = Now
        txtHouseNo.Clear()
        txtStreet.Clear()
        txtBarangay.Clear()
        txtCity.Clear()
        txtZipCode.Clear()
        cbCourse.SelectedIndex = -1
        cbSection.SelectedIndex = -1
        cbSY.SelectedIndex = -1
        cbSemester.SelectedIndex = -1
        cbEnrollmentStatus.SelectedIndex = -1
        cbStudentType.SelectedIndex = -1
    End Sub

    ' Input Validations
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtZipCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZipCode.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub nxtpg_Click(sender As Object, e As EventArgs) Handles nxtpg.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
