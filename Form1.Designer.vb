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
        TextBox1 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        DataGridView2 = New DataGridView()
        Column2 = New DataGridViewTextBoxColumn()
        DataGridView3 = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        DataGridView4 = New DataGridView()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        DataGridView6 = New DataGridView()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridView7 = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridView10 = New DataGridView()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        DataGridView11 = New DataGridView()
        DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
        DataGridView13 = New DataGridView()
        DataGridViewTextBoxColumn11 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn12 = New DataGridViewTextBoxColumn()
        DataGridView14 = New DataGridView()
        DataGridViewTextBoxColumn13 = New DataGridViewTextBoxColumn()
        DataGridView15 = New DataGridView()
        DataGridViewTextBoxColumn14 = New DataGridViewTextBoxColumn()
        DataGridView16 = New DataGridView()
        DataGridViewTextBoxColumn15 = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView6, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView7, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView10, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView11, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView13, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView14, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView15, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView16, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(297, 121)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(356, 43)
        Label1.TabIndex = 0
        Label1.Text = "CON RECURSIVIDAD"
        ' 
        ' TextBox1
        ' 
        TextBox1.AllowDrop = True
        TextBox1.Font = New Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(178, 62)
        TextBox1.Margin = New Padding(5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1142, 38)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 62)
        Button1.Margin = New Padding(5)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 38)
        Button1.TabIndex = 12
        Button1.Text = "BUSCAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1})
        DataGridView1.Location = New Point(15, 158)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(197, 298)
        DataGridView1.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "LISTA"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column2})
        DataGridView2.Location = New Point(218, 158)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(145, 298)
        DataGridView2.TabIndex = 20
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "VAR"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {Column3})
        DataGridView3.Location = New Point(369, 158)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.RowTemplate.Height = 25
        DataGridView3.Size = New Size(145, 298)
        DataGridView3.TabIndex = 21
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "TER"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' DataGridView4
        ' 
        DataGridView4.AllowUserToAddRows = False
        DataGridView4.AllowUserToDeleteRows = False
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Columns.AddRange(New DataGridViewColumn() {Column4, Column5})
        DataGridView4.Location = New Point(522, 158)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.ReadOnly = True
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.RowTemplate.Height = 25
        DataGridView4.Size = New Size(409, 298)
        DataGridView4.TabIndex = 22
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "VAR"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 50
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "PRODUCCIONES"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 200
        ' 
        ' DataGridView6
        ' 
        DataGridView6.AllowUserToAddRows = False
        DataGridView6.AllowUserToDeleteRows = False
        DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView6.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn3})
        DataGridView6.Location = New Point(963, 158)
        DataGridView6.Name = "DataGridView6"
        DataGridView6.ReadOnly = True
        DataGridView6.RowHeadersWidth = 51
        DataGridView6.RowTemplate.Height = 25
        DataGridView6.Size = New Size(145, 298)
        DataGridView6.TabIndex = 25
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "TER"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 125
        ' 
        ' DataGridView7
        ' 
        DataGridView7.AllowUserToAddRows = False
        DataGridView7.AllowUserToDeleteRows = False
        DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView7.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4})
        DataGridView7.Location = New Point(1114, 516)
        DataGridView7.Name = "DataGridView7"
        DataGridView7.ReadOnly = True
        DataGridView7.RowHeadersWidth = 51
        DataGridView7.RowTemplate.Height = 25
        DataGridView7.Size = New Size(346, 289)
        DataGridView7.TabIndex = 24
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "VAR"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 125
        ' 
        ' DataGridView10
        ' 
        DataGridView10.AllowUserToAddRows = False
        DataGridView10.AllowUserToDeleteRows = False
        DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView10.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn8})
        DataGridView10.Location = New Point(963, 516)
        DataGridView10.Name = "DataGridView10"
        DataGridView10.ReadOnly = True
        DataGridView10.RowHeadersWidth = 51
        DataGridView10.RowTemplate.Height = 25
        DataGridView10.Size = New Size(145, 289)
        DataGridView10.TabIndex = 36
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.HeaderText = "TER"
        DataGridViewTextBoxColumn8.MinimumWidth = 6
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        DataGridViewTextBoxColumn8.Width = 125
        ' 
        ' DataGridView11
        ' 
        DataGridView11.AllowUserToAddRows = False
        DataGridView11.AllowUserToDeleteRows = False
        DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView11.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn9})
        DataGridView11.Location = New Point(1114, 158)
        DataGridView11.Name = "DataGridView11"
        DataGridView11.ReadOnly = True
        DataGridView11.RowHeadersWidth = 51
        DataGridView11.RowTemplate.Height = 25
        DataGridView11.Size = New Size(346, 298)
        DataGridView11.TabIndex = 35
        ' 
        ' DataGridViewTextBoxColumn9
        ' 
        DataGridViewTextBoxColumn9.HeaderText = "VAR"
        DataGridViewTextBoxColumn9.MinimumWidth = 6
        DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        DataGridViewTextBoxColumn9.ReadOnly = True
        DataGridViewTextBoxColumn9.Width = 125
        ' 
        ' DataGridView13
        ' 
        DataGridView13.AllowUserToAddRows = False
        DataGridView13.AllowUserToDeleteRows = False
        DataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView13.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn11, DataGridViewTextBoxColumn12})
        DataGridView13.Location = New Point(520, 507)
        DataGridView13.Name = "DataGridView13"
        DataGridView13.ReadOnly = True
        DataGridView13.RowHeadersWidth = 51
        DataGridView13.RowTemplate.Height = 25
        DataGridView13.Size = New Size(411, 298)
        DataGridView13.TabIndex = 33
        ' 
        ' DataGridViewTextBoxColumn11
        ' 
        DataGridViewTextBoxColumn11.HeaderText = "VAR"
        DataGridViewTextBoxColumn11.MinimumWidth = 6
        DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        DataGridViewTextBoxColumn11.ReadOnly = True
        DataGridViewTextBoxColumn11.Width = 50
        ' 
        ' DataGridViewTextBoxColumn12
        ' 
        DataGridViewTextBoxColumn12.HeaderText = "PRODUCCIONES"
        DataGridViewTextBoxColumn12.MinimumWidth = 6
        DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        DataGridViewTextBoxColumn12.ReadOnly = True
        DataGridViewTextBoxColumn12.Width = 200
        ' 
        ' DataGridView14
        ' 
        DataGridView14.AllowUserToAddRows = False
        DataGridView14.AllowUserToDeleteRows = False
        DataGridView14.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView14.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn13})
        DataGridView14.Location = New Point(369, 507)
        DataGridView14.Name = "DataGridView14"
        DataGridView14.ReadOnly = True
        DataGridView14.RowHeadersWidth = 51
        DataGridView14.RowTemplate.Height = 25
        DataGridView14.Size = New Size(145, 298)
        DataGridView14.TabIndex = 32
        ' 
        ' DataGridViewTextBoxColumn13
        ' 
        DataGridViewTextBoxColumn13.HeaderText = "TER"
        DataGridViewTextBoxColumn13.MinimumWidth = 6
        DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        DataGridViewTextBoxColumn13.ReadOnly = True
        DataGridViewTextBoxColumn13.Width = 125
        ' 
        ' DataGridView15
        ' 
        DataGridView15.AllowUserToAddRows = False
        DataGridView15.AllowUserToDeleteRows = False
        DataGridView15.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView15.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn14})
        DataGridView15.Location = New Point(218, 507)
        DataGridView15.Name = "DataGridView15"
        DataGridView15.ReadOnly = True
        DataGridView15.RowHeadersWidth = 51
        DataGridView15.RowTemplate.Height = 25
        DataGridView15.Size = New Size(145, 298)
        DataGridView15.TabIndex = 31
        ' 
        ' DataGridViewTextBoxColumn14
        ' 
        DataGridViewTextBoxColumn14.HeaderText = "VAR"
        DataGridViewTextBoxColumn14.MinimumWidth = 6
        DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        DataGridViewTextBoxColumn14.ReadOnly = True
        DataGridViewTextBoxColumn14.Width = 125
        ' 
        ' DataGridView16
        ' 
        DataGridView16.AllowUserToAddRows = False
        DataGridView16.AllowUserToDeleteRows = False
        DataGridView16.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView16.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn15})
        DataGridView16.Location = New Point(15, 507)
        DataGridView16.Name = "DataGridView16"
        DataGridView16.ReadOnly = True
        DataGridView16.RowHeadersWidth = 51
        DataGridView16.Size = New Size(197, 298)
        DataGridView16.TabIndex = 30
        ' 
        ' DataGridViewTextBoxColumn15
        ' 
        DataGridViewTextBoxColumn15.HeaderText = "LISTA"
        DataGridViewTextBoxColumn15.MinimumWidth = 6
        DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        DataGridViewTextBoxColumn15.ReadOnly = True
        DataGridViewTextBoxColumn15.Width = 150
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(297, 470)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(342, 43)
        Label2.TabIndex = 27
        Label2.Text = "SIN RECURSIVIDAD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(522, 9)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(383, 43)
        Label3.TabIndex = 38
        Label3.Text = "Carga de Archivo TXT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(953, 470)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 43)
        Label4.TabIndex = 40
        Label4.Text = "FUNCION SIGUIENTE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(953, 121)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(342, 43)
        Label5.TabIndex = 39
        Label5.Text = "FUNCION PRIMERA"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1330, 63)
        Button2.Margin = New Padding(5)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 39)
        Button2.TabIndex = 41
        Button2.Text = "LIMPIAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1469, 819)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(DataGridView10)
        Controls.Add(DataGridView11)
        Controls.Add(DataGridView13)
        Controls.Add(DataGridView14)
        Controls.Add(DataGridView15)
        Controls.Add(DataGridView16)
        Controls.Add(Label2)
        Controls.Add(DataGridView6)
        Controls.Add(DataGridView7)
        Controls.Add(DataGridView4)
        Controls.Add(DataGridView3)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Font = New Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(5)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = ".::LABORATORIO COMPILADORES::."
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView6, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView7, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView10, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView11, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView13, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView14, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView15, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView16, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView7 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView10 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView11 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView13 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView14 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView15 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView16 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
