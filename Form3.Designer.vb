﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ProjectName = New System.Windows.Forms.TextBox()
        Me.DeadlineDuration = New System.Windows.Forms.DateTimePicker()
        Me.ProjectTittle = New System.Windows.Forms.Label()
        Me.ProjectGrpBox = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProjectGrpBox.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectName
        '
        Me.ProjectName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProjectName.Location = New System.Drawing.Point(68, 53)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(244, 34)
        Me.ProjectName.TabIndex = 1
        Me.ProjectName.Text = "Demo"
        '
        'DeadlineDuration
        '
        Me.DeadlineDuration.CalendarFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeadlineDuration.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeadlineDuration.Location = New System.Drawing.Point(25, 60)
        Me.DeadlineDuration.MinDate = New Date(2023, 1, 20, 0, 0, 0, 0)
        Me.DeadlineDuration.Name = "DeadlineDuration"
        Me.DeadlineDuration.Size = New System.Drawing.Size(195, 25)
        Me.DeadlineDuration.TabIndex = 2
        Me.DeadlineDuration.Value = New Date(2023, 1, 20, 21, 46, 48, 0)
        '
        'ProjectTittle
        '
        Me.ProjectTittle.AutoSize = True
        Me.ProjectTittle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ProjectTittle.Location = New System.Drawing.Point(68, 33)
        Me.ProjectTittle.Name = "ProjectTittle"
        Me.ProjectTittle.Size = New System.Drawing.Size(88, 17)
        Me.ProjectTittle.TabIndex = 3
        Me.ProjectTittle.Text = "Project Tittle"
        '
        'ProjectGrpBox
        '
        Me.ProjectGrpBox.Controls.Add(Me.NumericUpDown1)
        Me.ProjectGrpBox.Controls.Add(Me.DeadlineDuration)
        Me.ProjectGrpBox.Controls.Add(Me.Label2)
        Me.ProjectGrpBox.Controls.Add(Me.Label1)
        Me.ProjectGrpBox.Location = New System.Drawing.Point(68, 119)
        Me.ProjectGrpBox.Name = "ProjectGrpBox"
        Me.ProjectGrpBox.Size = New System.Drawing.Size(244, 187)
        Me.ProjectGrpBox.TabIndex = 4
        Me.ProjectGrpBox.TabStop = False
        Me.ProjectGrpBox.Text = "Project"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NumericUpDown1.Location = New System.Drawing.Point(25, 136)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(195, 25)
        Me.NumericUpDown1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No of People"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Project Deadline"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(211, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 43)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Create"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(68, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProjectGrpBox)
        Me.Controls.Add(Me.ProjectTittle)
        Me.Controls.Add(Me.ProjectName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.Text = "New-Project wizard"
        Me.ProjectGrpBox.ResumeLayout(False)
        Me.ProjectGrpBox.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectName As TextBox
    Friend WithEvents DeadlineDuration As DateTimePicker
    Friend WithEvents ProjectTittle As Label
    Friend WithEvents ProjectGrpBox As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
