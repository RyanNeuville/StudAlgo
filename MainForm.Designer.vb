<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOuvrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEnregistrer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitMain = New System.Windows.Forms.SplitContainer()
        Me.lblLineNumbers = New System.Windows.Forms.Label()
        Me.txtPseudoCode = New System.Windows.Forms.RichTextBox()
        Me.splitRight = New System.Windows.Forms.SplitContainer()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.lvVariables = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.toolStripMain = New System.Windows.Forms.ToolStrip()
        Me.btnSI = New System.Windows.Forms.ToolStripButton()
        Me.btnAlors = New System.Windows.Forms.ToolStripButton()
        Me.btnSinon = New System.Windows.Forms.ToolStripButton()
        Me.btnFinSi = New System.Windows.Forms.ToolStripButton()
        Me.btnPour = New System.Windows.Forms.ToolStripButton()
        Me.btnFinPour = New System.Windows.Forms.ToolStripButton()
        Me.btnTantQue = New System.Windows.Forms.ToolStripButton()
        Me.btnFinTantQue = New System.Windows.Forms.ToolStripButton()
        Me.btnConst = New System.Windows.Forms.ToolStripButton()
        Me.btnEcrire = New System.Windows.Forms.ToolStripButton()
        Me.btnLire = New System.Windows.Forms.ToolStripButton()
        Me.btnVar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRun = New System.Windows.Forms.ToolStripButton()
        Me.btnStop = New System.Windows.Forms.ToolStripButton()
        Me.lblExecutionTime = New System.Windows.Forms.Label()
        Me.menuMain.SuspendLayout()
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitMain.Panel1.SuspendLayout()
        Me.splitMain.Panel2.SuspendLayout()
        Me.splitMain.SuspendLayout()
        CType(Me.splitRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitRight.Panel1.SuspendLayout()
        Me.splitRight.Panel2.SuspendLayout()
        Me.splitRight.SuspendLayout()
        Me.toolStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Size = New System.Drawing.Size(1182, 28)
        Me.menuMain.TabIndex = 0
        Me.menuMain.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNouveau, Me.mnuOuvrir, Me.mnuEnregistrer, Me.mnuQuitter})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'mnuNouveau
        '
        Me.mnuNouveau.Name = "mnuNouveau"
        Me.mnuNouveau.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNouveau.Size = New System.Drawing.Size(205, 26)
        Me.mnuNouveau.Text = "Nouveau"
        '
        'mnuOuvrir
        '
        Me.mnuOuvrir.Name = "mnuOuvrir"
        Me.mnuOuvrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOuvrir.Size = New System.Drawing.Size(205, 26)
        Me.mnuOuvrir.Text = "Ouvrir"
        '
        'mnuEnregistrer
        '
        Me.mnuEnregistrer.Name = "mnuEnregistrer"
        Me.mnuEnregistrer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuEnregistrer.Size = New System.Drawing.Size(205, 26)
        Me.mnuEnregistrer.Text = "Enregistrer"
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuQuitter.Size = New System.Drawing.Size(205, 26)
        Me.mnuQuitter.Text = "Quitter"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÀProposToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'ÀProposToolStripMenuItem
        '
        Me.ÀProposToolStripMenuItem.Name = "ÀProposToolStripMenuItem"
        Me.ÀProposToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.ÀProposToolStripMenuItem.Text = "À propos"
        '
        'splitMain
        '
        Me.splitMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splitMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitMain.Location = New System.Drawing.Point(0, 28)
        Me.splitMain.Name = "splitMain"
        '
        'splitMain.Panel1
        '
        Me.splitMain.Panel1.Controls.Add(Me.lblLineNumbers)
        Me.splitMain.Panel1.Controls.Add(Me.txtPseudoCode)
        '
        'splitMain.Panel2
        '
        Me.splitMain.Panel2.Controls.Add(Me.splitRight)
        Me.splitMain.Size = New System.Drawing.Size(1182, 725)
        Me.splitMain.SplitterDistance = 800
        Me.splitMain.TabIndex = 1
        '
        'lblLineNumbers
        '
        Me.lblLineNumbers.BackColor = System.Drawing.Color.LightGray
        Me.lblLineNumbers.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblLineNumbers.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineNumbers.ForeColor = System.Drawing.Color.Black
        Me.lblLineNumbers.Location = New System.Drawing.Point(0, 0)
        Me.lblLineNumbers.Name = "lblLineNumbers"
        Me.lblLineNumbers.Size = New System.Drawing.Size(40, 723)
        Me.lblLineNumbers.TabIndex = 1
        Me.lblLineNumbers.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPseudoCode
        '
        Me.txtPseudoCode.AcceptsTab = True
        Me.txtPseudoCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPseudoCode.BackColor = System.Drawing.Color.White
        Me.txtPseudoCode.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPseudoCode.ForeColor = System.Drawing.Color.Black
        Me.txtPseudoCode.Location = New System.Drawing.Point(39, -4)
        Me.txtPseudoCode.Name = "txtPseudoCode"
        Me.txtPseudoCode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtPseudoCode.Size = New System.Drawing.Size(759, 730)
        Me.txtPseudoCode.TabIndex = 0
        Me.txtPseudoCode.Text = ""
        '
        'splitRight
        '
        Me.splitRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splitRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitRight.Location = New System.Drawing.Point(0, 0)
        Me.splitRight.Name = "splitRight"
        Me.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitRight.Panel1
        '
        Me.splitRight.Panel1.Controls.Add(Me.lblExecutionTime)
        Me.splitRight.Panel1.Controls.Add(Me.txtConsole)
        '
        'splitRight.Panel2
        '
        Me.splitRight.Panel2.Controls.Add(Me.lvVariables)
        Me.splitRight.Size = New System.Drawing.Size(378, 725)
        Me.splitRight.SplitterDistance = 401
        Me.splitRight.TabIndex = 0
        '
        'txtConsole
        '
        Me.txtConsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.txtConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConsole.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.White
        Me.txtConsole.Location = New System.Drawing.Point(0, 0)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConsole.Size = New System.Drawing.Size(376, 399)
        Me.txtConsole.TabIndex = 0
        '
        'lvVariables
        '
        Me.lvVariables.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lvVariables.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvVariables.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVariables.ForeColor = System.Drawing.Color.White
        Me.lvVariables.Location = New System.Drawing.Point(0, 0)
        Me.lvVariables.Name = "lvVariables"
        Me.lvVariables.Size = New System.Drawing.Size(376, 318)
        Me.lvVariables.TabIndex = 0
        Me.lvVariables.UseCompatibleStateImageBehavior = False
        Me.lvVariables.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Valeur"
        Me.ColumnHeader2.Width = 100
        '
        'toolStripMain
        '
        Me.toolStripMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.toolStripMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.toolStripMain.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSI, Me.btnAlors, Me.btnSinon, Me.btnFinSi, Me.btnPour, Me.btnFinPour, Me.btnTantQue, Me.btnFinTantQue, Me.btnConst, Me.btnEcrire, Me.btnLire, Me.btnVar, Me.ToolStripSeparator1, Me.btnRun, Me.btnStop})
        Me.toolStripMain.Location = New System.Drawing.Point(0, 720)
        Me.toolStripMain.Name = "toolStripMain"
        Me.toolStripMain.Size = New System.Drawing.Size(1182, 33)
        Me.toolStripMain.TabIndex = 2
        Me.toolStripMain.Text = "ToolStrip1"
        '
        'btnSI
        '
        Me.btnSI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSI.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSI.Image = CType(resources.GetObject("btnSI.Image"), System.Drawing.Image)
        Me.btnSI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSI.Name = "btnSI"
        Me.btnSI.Size = New System.Drawing.Size(28, 30)
        Me.btnSI.Text = "SI"
        '
        'btnAlors
        '
        Me.btnAlors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAlors.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlors.Image = CType(resources.GetObject("btnAlors.Image"), System.Drawing.Image)
        Me.btnAlors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlors.Name = "btnAlors"
        Me.btnAlors.Size = New System.Drawing.Size(70, 30)
        Me.btnAlors.Text = "ALORS"
        '
        'btnSinon
        '
        Me.btnSinon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSinon.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinon.Image = CType(resources.GetObject("btnSinon.Image"), System.Drawing.Image)
        Me.btnSinon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSinon.Name = "btnSinon"
        Me.btnSinon.Size = New System.Drawing.Size(65, 30)
        Me.btnSinon.Text = "SINON"
        '
        'btnFinSi
        '
        Me.btnFinSi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFinSi.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinSi.Image = CType(resources.GetObject("btnFinSi.Image"), System.Drawing.Image)
        Me.btnFinSi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFinSi.Name = "btnFinSi"
        Me.btnFinSi.Size = New System.Drawing.Size(59, 30)
        Me.btnFinSi.Text = "FIN SI"
        '
        'btnPour
        '
        Me.btnPour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPour.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPour.Image = CType(resources.GetObject("btnPour.Image"), System.Drawing.Image)
        Me.btnPour.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPour.Name = "btnPour"
        Me.btnPour.Size = New System.Drawing.Size(61, 30)
        Me.btnPour.Text = "POUR"
        '
        'btnFinPour
        '
        Me.btnFinPour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFinPour.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinPour.Image = CType(resources.GetObject("btnFinPour.Image"), System.Drawing.Image)
        Me.btnFinPour.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFinPour.Name = "btnFinPour"
        Me.btnFinPour.Size = New System.Drawing.Size(92, 30)
        Me.btnFinPour.Text = "FIN POUR"
        '
        'btnTantQue
        '
        Me.btnTantQue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnTantQue.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTantQue.Image = CType(resources.GetObject("btnTantQue.Image"), System.Drawing.Image)
        Me.btnTantQue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTantQue.Name = "btnTantQue"
        Me.btnTantQue.Size = New System.Drawing.Size(96, 30)
        Me.btnTantQue.Text = "TANT QUE"
        '
        'btnFinTantQue
        '
        Me.btnFinTantQue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnFinTantQue.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinTantQue.Image = CType(resources.GetObject("btnFinTantQue.Image"), System.Drawing.Image)
        Me.btnFinTantQue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFinTantQue.Name = "btnFinTantQue"
        Me.btnFinTantQue.Size = New System.Drawing.Size(127, 30)
        Me.btnFinTantQue.Text = "FIN TANT QUE"
        '
        'btnConst
        '
        Me.btnConst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnConst.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConst.Image = CType(resources.GetObject("btnConst.Image"), System.Drawing.Image)
        Me.btnConst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConst.Name = "btnConst"
        Me.btnConst.Size = New System.Drawing.Size(71, 30)
        Me.btnConst.Text = "CONST"
        '
        'btnEcrire
        '
        Me.btnEcrire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEcrire.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEcrire.Image = CType(resources.GetObject("btnEcrire.Image"), System.Drawing.Image)
        Me.btnEcrire.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEcrire.Name = "btnEcrire"
        Me.btnEcrire.Size = New System.Drawing.Size(75, 30)
        Me.btnEcrire.Text = "ECRIRE"
        '
        'btnLire
        '
        Me.btnLire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLire.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLire.Image = CType(resources.GetObject("btnLire.Image"), System.Drawing.Image)
        Me.btnLire.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLire.Name = "btnLire"
        Me.btnLire.Size = New System.Drawing.Size(50, 30)
        Me.btnLire.Text = "LIRE"
        '
        'btnVar
        '
        Me.btnVar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnVar.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVar.Image = CType(resources.GetObject("btnVar.Image"), System.Drawing.Image)
        Me.btnVar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVar.Name = "btnVar"
        Me.btnVar.Size = New System.Drawing.Size(46, 30)
        Me.btnVar.Text = "VAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'btnRun
        '
        Me.btnRun.AutoSize = False
        Me.btnRun.BackColor = System.Drawing.Color.Green
        Me.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRun.ForeColor = System.Drawing.Color.White
        Me.btnRun.Image = CType(resources.GetObject("btnRun.Image"), System.Drawing.Image)
        Me.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 30)
        Me.btnRun.Text = "RUN"
        '
        'btnStop
        '
        Me.btnStop.AutoSize = False
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnStop.Enabled = False
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 30)
        Me.btnStop.Text = "STOP"
        '
        'lblExecutionTime
        '
        Me.lblExecutionTime.AutoSize = True
        Me.lblExecutionTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.lblExecutionTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblExecutionTime.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExecutionTime.ForeColor = System.Drawing.Color.White
        Me.lblExecutionTime.Location = New System.Drawing.Point(0, 380)
        Me.lblExecutionTime.Name = "lblExecutionTime"
        Me.lblExecutionTime.Size = New System.Drawing.Size(178, 19)
        Me.lblExecutionTime.TabIndex = 1
        Me.lblExecutionTime.Text = "Temps d'exécution : 0 s"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.toolStripMain)
        Me.Controls.Add(Me.splitMain)
        Me.Controls.Add(Me.menuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudAlgo 👨‍💻"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.splitMain.Panel1.ResumeLayout(False)
        Me.splitMain.Panel2.ResumeLayout(False)
        CType(Me.splitMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitMain.ResumeLayout(False)
        Me.splitRight.Panel1.ResumeLayout(False)
        Me.splitRight.Panel1.PerformLayout()
        Me.splitRight.Panel2.ResumeLayout(False)
        CType(Me.splitRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitRight.ResumeLayout(False)
        Me.toolStripMain.ResumeLayout(False)
        Me.toolStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuMain As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNouveau As ToolStripMenuItem
    Friend WithEvents mnuOuvrir As ToolStripMenuItem
    Friend WithEvents mnuEnregistrer As ToolStripMenuItem
    Friend WithEvents mnuQuitter As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÀProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents splitMain As SplitContainer
    Friend WithEvents txtPseudoCode As RichTextBox
    Friend WithEvents lblLineNumbers As Label

    Private Sub txtPseudoCode_TextChanged(sender As Object, e As EventArgs) Handles txtPseudoCode.TextChanged
        Dim lineCount As Integer = txtPseudoCode.Lines.Length
        Dim lineNumbers As String = ""
        For i As Integer = 1 To lineCount
            lineNumbers &= i.ToString() & vbCrLf
        Next
        lblLineNumbers.Text = lineNumbers
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPseudoCode.Text = "1" & vbCrLf
    End Sub

    Friend WithEvents splitRight As SplitContainer
    Friend WithEvents txtConsole As TextBox
    Friend WithEvents lvVariables As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents toolStripMain As ToolStrip
    Friend WithEvents btnSI As ToolStripButton
    Friend WithEvents btnAlors As ToolStripButton
    Friend WithEvents btnSinon As ToolStripButton
    Friend WithEvents btnFinSi As ToolStripButton
    Friend WithEvents btnPour As ToolStripButton
    Friend WithEvents btnFinPour As ToolStripButton
    Friend WithEvents btnTantQue As ToolStripButton
    Friend WithEvents btnFinTantQue As ToolStripButton
    Friend WithEvents btnConst As ToolStripButton
    Friend WithEvents btnEcrire As ToolStripButton
    Friend WithEvents btnLire As ToolStripButton
    Friend WithEvents btnVar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnRun As ToolStripButton
    Friend WithEvents btnStop As ToolStripButton
    Friend WithEvents lblExecutionTime As Label
End Class
