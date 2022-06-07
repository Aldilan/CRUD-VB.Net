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
        Me.labelKodeBuku = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.labelJudulBuku = New System.Windows.Forms.Label()
        Me.labelPenerbit = New System.Windows.Forms.Label()
        Me.labelJenisBuku = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.buttonCreate = New System.Windows.Forms.Button()
        Me.buttonUpdate = New System.Windows.Forms.Button()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelKodeBuku
        '
        Me.labelKodeBuku.AutoSize = True
        Me.labelKodeBuku.Location = New System.Drawing.Point(40, 93)
        Me.labelKodeBuku.Name = "labelKodeBuku"
        Me.labelKodeBuku.Size = New System.Drawing.Size(76, 13)
        Me.labelKodeBuku.TabIndex = 0
        Me.labelKodeBuku.Text = "KODE BUKU :"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(212, 20)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(156, 28)
        Me.Title.TabIndex = 1
        Me.Title.Text = "DATA BUKU"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelJudulBuku
        '
        Me.labelJudulBuku.AutoSize = True
        Me.labelJudulBuku.Location = New System.Drawing.Point(40, 131)
        Me.labelJudulBuku.Name = "labelJudulBuku"
        Me.labelJudulBuku.Size = New System.Drawing.Size(81, 13)
        Me.labelJudulBuku.TabIndex = 2
        Me.labelJudulBuku.Text = "JUDUL BUKU :"
        '
        'labelPenerbit
        '
        Me.labelPenerbit.AutoSize = True
        Me.labelPenerbit.Location = New System.Drawing.Point(316, 93)
        Me.labelPenerbit.Name = "labelPenerbit"
        Me.labelPenerbit.Size = New System.Drawing.Size(67, 13)
        Me.labelPenerbit.TabIndex = 3
        Me.labelPenerbit.Text = "PENERBIT :"
        '
        'labelJenisBuku
        '
        Me.labelJenisBuku.AutoSize = True
        Me.labelJenisBuku.Location = New System.Drawing.Point(316, 131)
        Me.labelJenisBuku.Name = "labelJenisBuku"
        Me.labelJenisBuku.Size = New System.Drawing.Size(76, 13)
        Me.labelJenisBuku.TabIndex = 4
        Me.labelJenisBuku.Text = "JENIS BUKU :"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(398, 90)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(398, 128)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'buttonCreate
        '
        Me.buttonCreate.Location = New System.Drawing.Point(43, 187)
        Me.buttonCreate.Name = "buttonCreate"
        Me.buttonCreate.Size = New System.Drawing.Size(75, 23)
        Me.buttonCreate.TabIndex = 9
        Me.buttonCreate.Text = "CREATE"
        Me.buttonCreate.UseVisualStyleBackColor = True
        '
        'buttonUpdate
        '
        Me.buttonUpdate.Location = New System.Drawing.Point(238, 187)
        Me.buttonUpdate.Name = "buttonUpdate"
        Me.buttonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.buttonUpdate.TabIndex = 10
        Me.buttonUpdate.Text = "UPDATE"
        Me.buttonUpdate.UseVisualStyleBackColor = True
        '
        'buttonDelete
        '
        Me.buttonDelete.Location = New System.Drawing.Point(423, 187)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(75, 23)
        Me.buttonDelete.TabIndex = 11
        Me.buttonDelete.Text = "DELETE"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(606, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 455)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonUpdate)
        Me.Controls.Add(Me.buttonCreate)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.labelJenisBuku)
        Me.Controls.Add(Me.labelPenerbit)
        Me.Controls.Add(Me.labelJudulBuku)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.labelKodeBuku)
        Me.Name = "Form1"
        Me.Text = "d"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelKodeBuku As System.Windows.Forms.Label
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents labelJudulBuku As System.Windows.Forms.Label
    Friend WithEvents labelPenerbit As System.Windows.Forms.Label
    Friend WithEvents labelJenisBuku As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents buttonCreate As System.Windows.Forms.Button
    Friend WithEvents buttonUpdate As System.Windows.Forms.Button
    Friend WithEvents buttonDelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
