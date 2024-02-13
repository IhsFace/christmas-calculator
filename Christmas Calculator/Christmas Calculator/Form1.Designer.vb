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
        dtpToday = New DateTimePicker()
        dtpChristmas = New DateTimePicker()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(132, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(524, 59)
        Label1.TabIndex = 0
        Label1.Text = "CHRISTMAS CALCULATOR"
        ' 
        ' dtpToday
        ' 
        dtpToday.Location = New Point(196, 141)
        dtpToday.Name = "dtpToday"
        dtpToday.Size = New Size(400, 39)
        dtpToday.TabIndex = 1
        ' 
        ' dtpChristmas
        ' 
        dtpChristmas.Location = New Point(196, 217)
        dtpChristmas.Name = "dtpChristmas"
        dtpChristmas.Size = New Size(400, 39)
        dtpChristmas.TabIndex = 2
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(207, 317)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(375, 46)
        btnCalculate.TabIndex = 3
        btnCalculate.Text = "How many days till Christmas?"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.ForestGreen
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(dtpChristmas)
        Controls.Add(dtpToday)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpToday As DateTimePicker
    Friend WithEvents dtpChristmas As DateTimePicker
    Friend WithEvents btnCalculate As Button

End Class
