<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.radioST = New System.Windows.Forms.RadioButton()
        Me.radioSC = New System.Windows.Forms.RadioButton()
        Me.radioOBC = New System.Windows.Forms.RadioButton()
        Me.radioGen = New System.Windows.Forms.RadioButton()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbState)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.radioST)
        Me.GroupBox1.Controls.Add(Me.radioSC)
        Me.GroupBox1.Controls.Add(Me.radioOBC)
        Me.GroupBox1.Controls.Add(Me.radioGen)
        Me.GroupBox1.Controls.Add(Me.dob)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 429)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Registration Form"
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"Rajasthan", "Gujarat", "Maharashtra"})
        Me.cmbState.Location = New System.Drawing.Point(181, 353)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(205, 21)
        Me.cmbState.TabIndex = 23
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(181, 207)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(205, 49)
        Me.txtAddress.TabIndex = 22
        '
        'radioST
        '
        Me.radioST.AutoSize = True
        Me.radioST.Location = New System.Drawing.Point(340, 172)
        Me.radioST.Name = "radioST"
        Me.radioST.Size = New System.Drawing.Size(39, 17)
        Me.radioST.TabIndex = 21
        Me.radioST.TabStop = True
        Me.radioST.Text = "ST"
        Me.radioST.UseVisualStyleBackColor = True
        '
        'radioSC
        '
        Me.radioSC.AutoSize = True
        Me.radioSC.Location = New System.Drawing.Point(291, 172)
        Me.radioSC.Name = "radioSC"
        Me.radioSC.Size = New System.Drawing.Size(39, 17)
        Me.radioSC.TabIndex = 20
        Me.radioSC.TabStop = True
        Me.radioSC.Text = "SC"
        Me.radioSC.UseVisualStyleBackColor = True
        '
        'radioOBC
        '
        Me.radioOBC.AutoSize = True
        Me.radioOBC.Location = New System.Drawing.Point(235, 172)
        Me.radioOBC.Name = "radioOBC"
        Me.radioOBC.Size = New System.Drawing.Size(47, 17)
        Me.radioOBC.TabIndex = 19
        Me.radioOBC.TabStop = True
        Me.radioOBC.Text = "OBC"
        Me.radioOBC.UseVisualStyleBackColor = True
        '
        'radioGen
        '
        Me.radioGen.AutoSize = True
        Me.radioGen.Location = New System.Drawing.Point(181, 172)
        Me.radioGen.Name = "radioGen"
        Me.radioGen.Size = New System.Drawing.Size(48, 17)
        Me.radioGen.TabIndex = 18
        Me.radioGen.TabStop = True
        Me.radioGen.Text = "GEN"
        Me.radioGen.UseVisualStyleBackColor = True
        '
        'dob
        '
        Me.dob.Location = New System.Drawing.Point(181, 137)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(200, 20)
        Me.dob.TabIndex = 17
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(181, 104)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(205, 21)
        Me.cmbGender.TabIndex = 16
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(181, 391)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(205, 20)
        Me.txtCity.TabIndex = 15
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(181, 312)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(205, 20)
        Me.txtContact.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(181, 273)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(205, 20)
        Me.txtEmail.TabIndex = 12
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(181, 69)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(205, 20)
        Me.txtCourse.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(181, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(205, 20)
        Me.txtName.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "City:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 315)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Contact:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Category:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(193, 463)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 498)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents radioST As System.Windows.Forms.RadioButton
    Friend WithEvents radioSC As System.Windows.Forms.RadioButton
    Friend WithEvents radioOBC As System.Windows.Forms.RadioButton
    Friend WithEvents radioGen As System.Windows.Forms.RadioButton
    Friend WithEvents dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cmbState As ComboBox
End Class
