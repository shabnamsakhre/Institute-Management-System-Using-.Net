<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.course_txt = New System.Windows.Forms.TextBox()
        Me.desp_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.duration_txt = New System.Windows.Forms.ComboBox()
        Me.fee_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(550, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 108)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(325, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(557, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RTSoft Solutions Institute Management System Software"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(26, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "    COURSES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name of Course"
        '
        'course_txt
        '
        Me.course_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course_txt.Location = New System.Drawing.Point(125, 319)
        Me.course_txt.Name = "course_txt"
        Me.course_txt.Size = New System.Drawing.Size(400, 34)
        Me.course_txt.TabIndex = 4
        '
        'desp_txt
        '
        Me.desp_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desp_txt.Location = New System.Drawing.Point(686, 319)
        Me.desp_txt.Multiline = True
        Me.desp_txt.Name = "desp_txt"
        Me.desp_txt.Size = New System.Drawing.Size(400, 74)
        Me.desp_txt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(681, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(121, 486)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Duration"
        '
        'duration_txt
        '
        Me.duration_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.duration_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duration_txt.FormattingEnabled = True
        Me.duration_txt.Items.AddRange(New Object() {"3 Months", "6 Months", "6 - 12 Months", "1 Years", "2 Years", "3 Years", "4 Years", "5 Years"})
        Me.duration_txt.Location = New System.Drawing.Point(127, 522)
        Me.duration_txt.Name = "duration_txt"
        Me.duration_txt.Size = New System.Drawing.Size(400, 33)
        Me.duration_txt.TabIndex = 8
        '
        'fee_txt
        '
        Me.fee_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fee_txt.Location = New System.Drawing.Point(688, 526)
        Me.fee_txt.Name = "fee_txt"
        Me.fee_txt.Size = New System.Drawing.Size(400, 34)
        Me.fee_txt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(683, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 29)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fees of Course"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.save_btn.Location = New System.Drawing.Point(677, 643)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(200, 60)
        Me.save_btn.TabIndex = 11
        Me.save_btn.Text = "SAVE"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.clear_btn.Location = New System.Drawing.Point(344, 643)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(200, 60)
        Me.clear_btn.TabIndex = 12
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 754)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.fee_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.duration_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.desp_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.course_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form16"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RTSoft Solutions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents course_txt As TextBox
    Friend WithEvents desp_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents duration_txt As ComboBox
    Friend WithEvents fee_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents clear_btn As Button
End Class
