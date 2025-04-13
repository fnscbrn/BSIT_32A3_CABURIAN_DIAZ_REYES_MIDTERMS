<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtMiddleName = New TextBox()
        txtPhone = New TextBox()
        txtHouseNo = New TextBox()
        txtBarangay = New TextBox()
        txtZipCode = New TextBox()
        txtStreet = New TextBox()
        txtCity = New TextBox()
        GroupBox1 = New GroupBox()
        cbSex = New ComboBox()
        Label19 = New Label()
        dtpBirthDate = New DateTimePicker()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox3 = New GroupBox()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        cbEnrollmentStatus = New ComboBox()
        cbStudentType = New ComboBox()
        cbSemester = New ComboBox()
        cbSY = New ComboBox()
        cbSection = New ComboBox()
        cbCourse = New ComboBox()
        Label12 = New Label()
        txtRegNum = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        nxtpg = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(301, 40)
        Label1.TabIndex = 0
        Label1.Text = "ENROLLMENT FORM"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(13, 40)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(138, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(178, 40)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(138, 23)
        txtLastName.TabIndex = 2
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Location = New Point(335, 40)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(138, 23)
        txtMiddleName.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(178, 93)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(138, 23)
        txtPhone.TabIndex = 5
        ' 
        ' txtHouseNo
        ' 
        txtHouseNo.Location = New Point(13, 36)
        txtHouseNo.Name = "txtHouseNo"
        txtHouseNo.Size = New Size(138, 23)
        txtHouseNo.TabIndex = 6
        ' 
        ' txtBarangay
        ' 
        txtBarangay.Location = New Point(335, 36)
        txtBarangay.Name = "txtBarangay"
        txtBarangay.Size = New Size(138, 23)
        txtBarangay.TabIndex = 7
        ' 
        ' txtZipCode
        ' 
        txtZipCode.Location = New Point(178, 93)
        txtZipCode.Name = "txtZipCode"
        txtZipCode.Size = New Size(138, 23)
        txtZipCode.TabIndex = 8
        ' 
        ' txtStreet
        ' 
        txtStreet.Location = New Point(178, 36)
        txtStreet.Name = "txtStreet"
        txtStreet.Size = New Size(138, 23)
        txtStreet.TabIndex = 9
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(13, 93)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(138, 23)
        txtCity.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbSex)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(dtpBirthDate)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtFirstName)
        GroupBox1.Controls.Add(txtMiddleName)
        GroupBox1.Controls.Add(txtPhone)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Location = New Point(12, 59)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(489, 132)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Student Information"
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Items.AddRange(New Object() {"Male", "Female"})
        cbSex.Location = New Point(13, 93)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(138, 23)
        cbSex.TabIndex = 33
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(335, 77)
        Label19.Name = "Label19"
        Label19.Size = New Size(59, 13)
        Label19.TabIndex = 21
        Label19.Text = "Birth Date"
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Format = DateTimePickerFormat.Short
        dtpBirthDate.Location = New Point(335, 93)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(138, 23)
        dtpBirthDate.TabIndex = 20
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(178, 77)
        Label11.Name = "Label11"
        Label11.Size = New Size(87, 13)
        Label11.TabIndex = 19
        Label11.Text = "Phone Number"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(13, 77)
        Label10.Name = "Label10"
        Label10.Size = New Size(25, 13)
        Label10.TabIndex = 18
        Label10.Text = "Sex"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(335, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 13)
        Label9.TabIndex = 17
        Label9.Text = "Middle Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(178, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 13)
        Label8.TabIndex = 16
        Label8.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 13)
        Label7.TabIndex = 15
        Label7.Text = "First Name"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtZipCode)
        GroupBox2.Controls.Add(txtCity)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(txtHouseNo)
        GroupBox2.Controls.Add(txtStreet)
        GroupBox2.Controls.Add(txtBarangay)
        GroupBox2.Location = New Point(12, 197)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(489, 132)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Student Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(178, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 13)
        Label6.TabIndex = 14
        Label6.Text = "Postal Code"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 77)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 13)
        Label5.TabIndex = 13
        Label5.Text = "City"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(335, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 13)
        Label4.TabIndex = 12
        Label4.Text = "Barangay"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(178, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 13)
        Label3.TabIndex = 11
        Label3.Text = "Street"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 13)
        Label2.TabIndex = 10
        Label2.Text = "House No."
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label18)
        GroupBox3.Controls.Add(Label17)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(cbEnrollmentStatus)
        GroupBox3.Controls.Add(cbStudentType)
        GroupBox3.Controls.Add(cbSemester)
        GroupBox3.Controls.Add(cbSY)
        GroupBox3.Controls.Add(cbSection)
        GroupBox3.Controls.Add(cbCourse)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(txtRegNum)
        GroupBox3.Location = New Point(507, 59)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(282, 228)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Student Credentials"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(16, 176)
        Label18.Name = "Label18"
        Label18.Size = New Size(76, 13)
        Label18.TabIndex = 32
        Label18.Text = "Student Type"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(143, 122)
        Label17.Name = "Label17"
        Label17.Size = New Size(99, 13)
        Label17.TabIndex = 31
        Label17.Text = "Enrollment Status"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(16, 122)
        Label16.Name = "Label16"
        Label16.Size = New Size(54, 13)
        Label16.TabIndex = 30
        Label16.Text = "Semester"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(143, 73)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 13)
        Label15.TabIndex = 29
        Label15.Text = "School Year"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(16, 73)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 13)
        Label14.TabIndex = 28
        Label14.Text = "Section"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(143, 24)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 13)
        Label13.TabIndex = 21
        Label13.Text = "Course"
        ' 
        ' cbEnrollmentStatus
        ' 
        cbEnrollmentStatus.FormattingEnabled = True
        cbEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Reserved"})
        cbEnrollmentStatus.Location = New Point(143, 138)
        cbEnrollmentStatus.Name = "cbEnrollmentStatus"
        cbEnrollmentStatus.Size = New Size(121, 23)
        cbEnrollmentStatus.TabIndex = 26
        ' 
        ' cbStudentType
        ' 
        cbStudentType.FormattingEnabled = True
        cbStudentType.Items.AddRange(New Object() {"New", "Old", "Regular", "Irregular", "Transferee", "Graduating"})
        cbStudentType.Location = New Point(16, 192)
        cbStudentType.Name = "cbStudentType"
        cbStudentType.Size = New Size(121, 23)
        cbStudentType.TabIndex = 25
        ' 
        ' cbSemester
        ' 
        cbSemester.FormattingEnabled = True
        cbSemester.Items.AddRange(New Object() {"First", "Second"})
        cbSemester.Location = New Point(16, 138)
        cbSemester.Name = "cbSemester"
        cbSemester.Size = New Size(121, 23)
        cbSemester.TabIndex = 24
        ' 
        ' cbSY
        ' 
        cbSY.FormattingEnabled = True
        cbSY.Items.AddRange(New Object() {"2024-2025", "2025-2026"})
        cbSY.Location = New Point(143, 89)
        cbSY.Name = "cbSY"
        cbSY.Size = New Size(121, 23)
        cbSY.TabIndex = 23
        ' 
        ' cbSection
        ' 
        cbSection.FormattingEnabled = True
        cbSection.Items.AddRange(New Object() {"11M1", "11M2", "11M3"})
        cbSection.Location = New Point(16, 89)
        cbSection.Name = "cbSection"
        cbSection.Size = New Size(121, 23)
        cbSection.TabIndex = 22
        ' 
        ' cbCourse
        ' 
        cbCourse.FormattingEnabled = True
        cbCourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        cbCourse.Location = New Point(143, 40)
        cbCourse.Name = "cbCourse"
        cbCourse.Size = New Size(121, 23)
        cbCourse.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(16, 24)
        Label12.Name = "Label12"
        Label12.Size = New Size(116, 13)
        Label12.TabIndex = 21
        Label12.Text = "Registration Number"
        ' 
        ' txtRegNum
        ' 
        txtRegNum.BackColor = SystemColors.ControlDark
        txtRegNum.Location = New Point(16, 40)
        txtRegNum.Name = "txtRegNum"
        txtRegNum.ReadOnly = True
        txtRegNum.Size = New Size(121, 23)
        txtRegNum.TabIndex = 21
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.Highlight
        btnAdd.ForeColor = SystemColors.Control
        btnAdd.Location = New Point(507, 293)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(137, 55)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Add Student"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(650, 293)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(121, 24)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(650, 323)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(121, 24)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' nxtpg
        ' 
        nxtpg.BackColor = SystemColors.ButtonShadow
        nxtpg.ForeColor = SystemColors.ActiveCaptionText
        nxtpg.Location = New Point(680, 404)
        nxtpg.Name = "nxtpg"
        nxtpg.Size = New Size(109, 34)
        nxtpg.TabIndex = 17
        nxtpg.Text = "Student List >"
        nxtpg.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(nxtpg)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(GroupBox3)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtHouseNo As TextBox
    Friend WithEvents txtBarangay As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbCourse As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRegNum As TextBox
    Friend WithEvents cbSY As ComboBox
    Friend WithEvents cbSection As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbEnrollmentStatus As ComboBox
    Friend WithEvents cbStudentType As ComboBox
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents nxtpg As Button
    Friend WithEvents cbSex As ComboBox

End Class
