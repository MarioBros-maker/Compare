<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Material
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MaterialLabela = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialLabelb = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MaterialLabela
        '
        Me.MaterialLabela.AutoSize = True
        Me.MaterialLabela.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabela.Depth = 0
        Me.MaterialLabela.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabela.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabela.Location = New System.Drawing.Point(38, 149)
        Me.MaterialLabela.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabela.Name = "MaterialLabela"
        Me.MaterialLabela.Size = New System.Drawing.Size(25, 19)
        Me.MaterialLabela.TabIndex = 1
        Me.MaterialLabela.Text = "a="
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(98, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("黑体", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(37, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "请输入数字："
        '
        'MaterialLabelb
        '
        Me.MaterialLabelb.AutoSize = True
        Me.MaterialLabelb.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabelb.Depth = 0
        Me.MaterialLabelb.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabelb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabelb.Location = New System.Drawing.Point(258, 149)
        Me.MaterialLabelb.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabelb.Name = "MaterialLabelb"
        Me.MaterialLabelb.Size = New System.Drawing.Size(25, 19)
        Me.MaterialLabelb.TabIndex = 4
        Me.MaterialLabelb.Text = "b="
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(309, 148)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 26)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Depth = 0
        Me.Button1.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Icon = Nothing
        Me.Button1.Location = New System.Drawing.Point(394, 244)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(51, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "比较"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("黑体", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(34, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("黑体", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(135, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "b"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("黑体", 23.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(78, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "."
        '
        'Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 313)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MaterialLabelb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MaterialLabela)
        Me.Font = New System.Drawing.Font("黑体", 12.0!)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Material"
        Me.Text = "比较程序"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabela As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MaterialLabelb As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
