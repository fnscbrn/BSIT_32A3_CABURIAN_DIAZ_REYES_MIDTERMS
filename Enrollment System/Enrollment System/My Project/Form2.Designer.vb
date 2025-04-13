<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        bkpg = New Button()
        tblStudents = New DataGridView()
        Label1 = New Label()
        btnRemove = New Button()
        CType(tblStudents, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bkpg
        ' 
        bkpg.BackColor = SystemColors.ButtonShadow
        bkpg.ForeColor = SystemColors.ActiveCaptionText
        bkpg.Location = New Point(679, 404)
        bkpg.Name = "bkpg"
        bkpg.Size = New Size(109, 34)
        bkpg.TabIndex = 18
        bkpg.Text = "< Back"
        bkpg.UseVisualStyleBackColor = False
        ' 
        ' tblStudents
        ' 
        tblStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblStudents.Location = New Point(12, 52)
        tblStudents.Name = "tblStudents"
        tblStudents.Size = New Size(776, 334)
        tblStudents.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(316, 40)
        Label1.TabIndex = 20
        Label1.Text = "ENROLLED STUDENTS"
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnRemove.ForeColor = SystemColors.Control
        btnRemove.Location = New Point(12, 392)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(128, 46)
        btnRemove.TabIndex = 21
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRemove)
        Controls.Add(Label1)
        Controls.Add(tblStudents)
        Controls.Add(bkpg)
        Name = "Form2"
        Text = "Form2"
        CType(tblStudents, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bkpg As Button
    Friend WithEvents tblStudents As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRemove As Button
End Class
