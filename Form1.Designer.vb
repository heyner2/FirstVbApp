<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnStart
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Go = New System.Windows.Forms.Button()
        Me.btnVariables = New System.Windows.Forms.Button()
        Me.dataTypes = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnSubmitInfo = New System.Windows.Forms.Button()
        Me.lstProfesion = New System.Windows.Forms.ListBox()
        Me.lblProfesion = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAritmetic = New System.Windows.Forms.Button()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.btnLoop = New System.Windows.Forms.Button()
        Me.btnLoopBySteps = New System.Windows.Forms.Button()
        Me.btnLoopWithNewLine = New System.Windows.Forms.Button()
        Me.btnLoopArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Go
        '
        Me.Go.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Go.Location = New System.Drawing.Point(-1, -1)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(158, 81)
        Me.Go.TabIndex = 0
        Me.Go.Text = "Go"
        Me.Go.UseVisualStyleBackColor = False
        '
        'btnVariables
        '
        Me.btnVariables.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVariables.Location = New System.Drawing.Point(152, -1)
        Me.btnVariables.Name = "btnVariables"
        Me.btnVariables.Size = New System.Drawing.Size(158, 81)
        Me.btnVariables.TabIndex = 1
        Me.btnVariables.Text = "Variable Demo"
        Me.btnVariables.UseVisualStyleBackColor = False
        '
        'dataTypes
        '
        Me.dataTypes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dataTypes.Location = New System.Drawing.Point(305, -1)
        Me.dataTypes.Name = "dataTypes"
        Me.dataTypes.Size = New System.Drawing.Size(158, 81)
        Me.dataTypes.TabIndex = 2
        Me.dataTypes.Text = "Data Types"
        Me.dataTypes.UseVisualStyleBackColor = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(551, 7)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(551, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(122, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.AutoSize = True
        Me.txtLastName.Location = New System.Drawing.Point(551, 60)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(58, 13)
        Me.txtLastName.TabIndex = 5
        Me.txtLastName.Text = "Last Name"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(551, 83)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(122, 20)
        Me.txtLast.TabIndex = 6
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(551, 113)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(551, 136)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(122, 20)
        Me.txtGender.TabIndex = 8
        '
        'btnSubmitInfo
        '
        Me.btnSubmitInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmitInfo.Location = New System.Drawing.Point(575, 177)
        Me.btnSubmitInfo.Name = "btnSubmitInfo"
        Me.btnSubmitInfo.Size = New System.Drawing.Size(66, 42)
        Me.btnSubmitInfo.TabIndex = 9
        Me.btnSubmitInfo.Text = "Submit"
        Me.btnSubmitInfo.UseVisualStyleBackColor = False
        '
        'lstProfesion
        '
        Me.lstProfesion.FormattingEnabled = True
        Me.lstProfesion.Items.AddRange(New Object() {"Teacher", "Strudent", "Director", "Futbol Player", "Fireman"})
        Me.lstProfesion.Location = New System.Drawing.Point(695, 33)
        Me.lstProfesion.Name = "lstProfesion"
        Me.lstProfesion.Size = New System.Drawing.Size(74, 69)
        Me.lstProfesion.TabIndex = 10
        '
        'lblProfesion
        '
        Me.lblProfesion.AutoSize = True
        Me.lblProfesion.Location = New System.Drawing.Point(696, 7)
        Me.lblProfesion.Name = "lblProfesion"
        Me.lblProfesion.Size = New System.Drawing.Size(51, 13)
        Me.lblProfesion.TabIndex = 11
        Me.lblProfesion.Text = "Profesion"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(2, 215)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(147, 20)
        Me.txtNum1.TabIndex = 12
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(2, 248)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(147, 20)
        Me.txtNum2.TabIndex = 13
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(40, 298)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(59, 28)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Number  2"
        '
        'btnAritmetic
        '
        Me.btnAritmetic.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAritmetic.Location = New System.Drawing.Point(-1, 80)
        Me.btnAritmetic.Name = "btnAritmetic"
        Me.btnAritmetic.Size = New System.Drawing.Size(158, 46)
        Me.btnAritmetic.TabIndex = 17
        Me.btnAritmetic.Text = "Calculate Aritmetic"
        Me.btnAritmetic.UseVisualStyleBackColor = False
        '
        'txtCountry
        '
        Me.txtCountry.Location = New System.Drawing.Point(176, 225)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(147, 20)
        Me.txtCountry.TabIndex = 18
        '
        'btnGreet
        '
        Me.btnGreet.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGreet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGreet.Location = New System.Drawing.Point(184, 258)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(129, 28)
        Me.btnGreet.TabIndex = 19
        Me.btnGreet.Text = "Greet"
        Me.btnGreet.UseVisualStyleBackColor = False
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(178, 203)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(93, 13)
        Me.lblCountry.TabIndex = 20
        Me.lblCountry.Text = "Enter your country"
        '
        'btnLoop
        '
        Me.btnLoop.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoop.Location = New System.Drawing.Point(152, 80)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(158, 46)
        Me.btnLoop.TabIndex = 21
        Me.btnLoop.Text = "Iterate trough"
        Me.btnLoop.UseVisualStyleBackColor = False
        '
        'btnLoopBySteps
        '
        Me.btnLoopBySteps.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoopBySteps.Location = New System.Drawing.Point(305, 80)
        Me.btnLoopBySteps.Name = "btnLoopBySteps"
        Me.btnLoopBySteps.Size = New System.Drawing.Size(158, 46)
        Me.btnLoopBySteps.TabIndex = 22
        Me.btnLoopBySteps.Text = "Iterate with steps"
        Me.btnLoopBySteps.UseVisualStyleBackColor = False
        '
        'btnLoopWithNewLine
        '
        Me.btnLoopWithNewLine.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoopWithNewLine.Location = New System.Drawing.Point(-1, 122)
        Me.btnLoopWithNewLine.Name = "btnLoopWithNewLine"
        Me.btnLoopWithNewLine.Size = New System.Drawing.Size(158, 46)
        Me.btnLoopWithNewLine.TabIndex = 23
        Me.btnLoopWithNewLine.Text = "Iterate with newline"
        Me.btnLoopWithNewLine.UseVisualStyleBackColor = False
        '
        'btnLoopArray
        '
        Me.btnLoopArray.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoopArray.Location = New System.Drawing.Point(152, 122)
        Me.btnLoopArray.Name = "btnLoopArray"
        Me.btnLoopArray.Size = New System.Drawing.Size(158, 46)
        Me.btnLoopArray.TabIndex = 24
        Me.btnLoopArray.Text = "Iterate an array"
        Me.btnLoopArray.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLoopArray)
        Me.Controls.Add(Me.btnLoopWithNewLine)
        Me.Controls.Add(Me.btnLoopBySteps)
        Me.Controls.Add(Me.btnLoop)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.btnAritmetic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblProfesion)
        Me.Controls.Add(Me.lstProfesion)
        Me.Controls.Add(Me.btnSubmitInfo)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.dataTypes)
        Me.Controls.Add(Me.btnVariables)
        Me.Controls.Add(Me.Go)
        Me.Name = "btnStart"
        Me.Text = "Number 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Go As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents dataTypes As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As Label
    Friend WithEvents txtLast As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnSubmitInfo As Button
    Friend WithEvents lstProfesion As ListBox
    Friend WithEvents lblProfesion As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAritmetic As Button
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents btnGreet As Button
    Friend WithEvents lblCountry As Label
    Friend WithEvents btnLoop As Button
    Friend WithEvents btnLoopBySteps As Button
    Friend WithEvents btnLoopWithNewLine As Button
    Friend WithEvents btnLoopArray As Button
End Class
