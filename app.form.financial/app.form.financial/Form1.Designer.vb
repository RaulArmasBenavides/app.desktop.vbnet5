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
        MenuStrip1 = New MenuStrip()
        FUNCIONESToolStripMenuItem = New ToolStripMenuItem()
        RATEToolStripMenuItem = New ToolStripMenuItem()
        PAYMENTToolStripMenuItem = New ToolStripMenuItem()
        FINANZASFUNCIONESToolStripMenuItem = New ToolStripMenuItem()
        PVToolStripMenuItem = New ToolStripMenuItem()
        DICCIONARIOToolStripMenuItem = New ToolStripMenuItem()
        EJEMPLOToolStripMenuItem = New ToolStripMenuItem()
        ENUMERATIONToolStripMenuItem = New ToolStripMenuItem()
        ASPOSEToolStripMenuItem = New ToolStripMenuItem()
        MATHToolStripMenuItem = New ToolStripMenuItem()
        txtNumeroSinRedondear = New TextBox()
        txtNumeroRedondeado = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FUNCIONESToolStripMenuItem, DICCIONARIOToolStripMenuItem, ASPOSEToolStripMenuItem, MATHToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1441, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FUNCIONESToolStripMenuItem
        ' 
        FUNCIONESToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RATEToolStripMenuItem, PAYMENTToolStripMenuItem, FINANZASFUNCIONESToolStripMenuItem, PVToolStripMenuItem})
        FUNCIONESToolStripMenuItem.Name = "FUNCIONESToolStripMenuItem"
        FUNCIONESToolStripMenuItem.Size = New Size(137, 20)
        FUNCIONESToolStripMenuItem.Text = "FINANCIAL METHODS"
        ' 
        ' RATEToolStripMenuItem
        ' 
        RATEToolStripMenuItem.Name = "RATEToolStripMenuItem"
        RATEToolStripMenuItem.Size = New Size(180, 22)
        RATEToolStripMenuItem.Text = "RATE"
        ' 
        ' PAYMENTToolStripMenuItem
        ' 
        PAYMENTToolStripMenuItem.Name = "PAYMENTToolStripMenuItem"
        PAYMENTToolStripMenuItem.Size = New Size(180, 22)
        PAYMENTToolStripMenuItem.Text = "PAYMENT"
        ' 
        ' FINANZASFUNCIONESToolStripMenuItem
        ' 
        FINANZASFUNCIONESToolStripMenuItem.Name = "FINANZASFUNCIONESToolStripMenuItem"
        FINANZASFUNCIONESToolStripMenuItem.Size = New Size(180, 22)
        FINANZASFUNCIONESToolStripMenuItem.Text = "X"
        ' 
        ' PVToolStripMenuItem
        ' 
        PVToolStripMenuItem.Name = "PVToolStripMenuItem"
        PVToolStripMenuItem.Size = New Size(180, 22)
        PVToolStripMenuItem.Text = "PV c"
        ' 
        ' DICCIONARIOToolStripMenuItem
        ' 
        DICCIONARIOToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EJEMPLOToolStripMenuItem, ENUMERATIONToolStripMenuItem})
        DICCIONARIOToolStripMenuItem.Name = "DICCIONARIOToolStripMenuItem"
        DICCIONARIOToolStripMenuItem.Size = New Size(87, 20)
        DICCIONARIOToolStripMenuItem.Text = "DICTIONARY"
        ' 
        ' EJEMPLOToolStripMenuItem
        ' 
        EJEMPLOToolStripMenuItem.Name = "EJEMPLOToolStripMenuItem"
        EJEMPLOToolStripMenuItem.Size = New Size(155, 22)
        EJEMPLOToolStripMenuItem.Text = "SAMPLE"
        ' 
        ' ENUMERATIONToolStripMenuItem
        ' 
        ENUMERATIONToolStripMenuItem.Name = "ENUMERATIONToolStripMenuItem"
        ENUMERATIONToolStripMenuItem.Size = New Size(155, 22)
        ENUMERATIONToolStripMenuItem.Text = "ENUMERATION"
        ' 
        ' ASPOSEToolStripMenuItem
        ' 
        ASPOSEToolStripMenuItem.Name = "ASPOSEToolStripMenuItem"
        ASPOSEToolStripMenuItem.Size = New Size(90, 20)
        ASPOSEToolStripMenuItem.Text = "DOCUMENTS"
        ' 
        ' MATHToolStripMenuItem
        ' 
        MATHToolStripMenuItem.Name = "MATHToolStripMenuItem"
        MATHToolStripMenuItem.Size = New Size(52, 20)
        MATHToolStripMenuItem.Text = "MATH"
        ' 
        ' txtNumeroSinRedondear
        ' 
        txtNumeroSinRedondear.Location = New Point(67, 67)
        txtNumeroSinRedondear.Name = "txtNumeroSinRedondear"
        txtNumeroSinRedondear.Size = New Size(183, 23)
        txtNumeroSinRedondear.TabIndex = 1
        ' 
        ' txtNumeroRedondeado
        ' 
        txtNumeroRedondeado.Location = New Point(67, 111)
        txtNumeroRedondeado.Name = "txtNumeroRedondeado"
        txtNumeroRedondeado.Size = New Size(183, 23)
        txtNumeroRedondeado.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(268, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Ceilling"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(268, 110)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 4
        Button2.Text = "Display"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1441, 545)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtNumeroRedondeado)
        Controls.Add(txtNumeroSinRedondear)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FUNCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAYMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DICCIONARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJEMPLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENUMERATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FINANZASFUNCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASPOSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MATHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtNumeroSinRedondear As TextBox
    Friend WithEvents txtNumeroRedondeado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PVToolStripMenuItem As ToolStripMenuItem
End Class
