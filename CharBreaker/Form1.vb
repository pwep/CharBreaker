Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents xoffset As System.Windows.Forms.NumericUpDown
    Friend WithEvents XOffsetLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yoffset As System.Windows.Forms.NumericUpDown
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents QuitMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents ProcessMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents OpenSaccadeReportFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ySaccadeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents xSaccadeNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PaddingNumeric As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.yoffset = New System.Windows.Forms.NumericUpDown
        Me.XOffsetLabel = New System.Windows.Forms.Label
        Me.xoffset = New System.Windows.Forms.NumericUpDown
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.ProcessMenuItem = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.QuitMenuItem = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.OpenSaccadeReportFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ySaccadeNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.xSaccadeNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PaddingNumeric = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.yoffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xoffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ySaccadeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xSaccadeNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PaddingNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 8)
        Me.TextBox1.MaxLength = 32
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(464, 39)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "the quick brown fox"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.yoffset)
        Me.GroupBox1.Controls.Add(Me.XOffsetLabel)
        Me.GroupBox1.Controls.Add(Me.xoffset)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Word Offset"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Y"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'yoffset
        '
        Me.yoffset.Location = New System.Drawing.Point(104, 24)
        Me.yoffset.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.yoffset.Minimum = New Decimal(New Integer() {1316134912, 2328, 0, -2147483648})
        Me.yoffset.Name = "yoffset"
        Me.yoffset.Size = New System.Drawing.Size(55, 20)
        Me.yoffset.TabIndex = 4
        '
        'XOffsetLabel
        '
        Me.XOffsetLabel.Location = New System.Drawing.Point(8, 24)
        Me.XOffsetLabel.Name = "XOffsetLabel"
        Me.XOffsetLabel.Size = New System.Drawing.Size(11, 16)
        Me.XOffsetLabel.TabIndex = 3
        Me.XOffsetLabel.Text = "X"
        Me.XOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xoffset
        '
        Me.xoffset.Location = New System.Drawing.Point(25, 23)
        Me.xoffset.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.xoffset.Minimum = New Decimal(New Integer() {1316134912, 2328, 0, -2147483648})
        Me.xoffset.Name = "xoffset"
        Me.xoffset.Size = New System.Drawing.Size(56, 20)
        Me.xoffset.TabIndex = 2
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.ProcessMenuItem, Me.MenuItem4, Me.QuitMenuItem})
        Me.MenuItem1.Text = "File"
        '
        'ProcessMenuItem
        '
        Me.ProcessMenuItem.Index = 0
        Me.ProcessMenuItem.Text = "Process..."
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "Dump CSV"
        '
        'QuitMenuItem
        '
        Me.QuitMenuItem.Index = 2
        Me.QuitMenuItem.Text = "Quit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3})
        Me.MenuItem2.Text = "Edit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Select Font..."
        '
        'OpenSaccadeReportFileDialog
        '
        Me.OpenSaccadeReportFileDialog.Filter = "Saccade reports|*.txt|All files|*.*"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.ySaccadeNumericUpDown)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.xSaccadeNumericUpDown)
        Me.GroupBox2.Location = New System.Drawing.Point(184, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 56)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saccade Landing"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(80, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Y"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ySaccadeNumericUpDown
        '
        Me.ySaccadeNumericUpDown.Location = New System.Drawing.Point(104, 24)
        Me.ySaccadeNumericUpDown.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.ySaccadeNumericUpDown.Minimum = New Decimal(New Integer() {1316134912, 2328, 0, -2147483648})
        Me.ySaccadeNumericUpDown.Name = "ySaccadeNumericUpDown"
        Me.ySaccadeNumericUpDown.Size = New System.Drawing.Size(56, 20)
        Me.ySaccadeNumericUpDown.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "X"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xSaccadeNumericUpDown
        '
        Me.xSaccadeNumericUpDown.Location = New System.Drawing.Point(25, 23)
        Me.xSaccadeNumericUpDown.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.xSaccadeNumericUpDown.Minimum = New Decimal(New Integer() {1316134912, 2328, 0, -2147483648})
        Me.xSaccadeNumericUpDown.Name = "xSaccadeNumericUpDown"
        Me.xSaccadeNumericUpDown.Size = New System.Drawing.Size(56, 20)
        Me.xSaccadeNumericUpDown.TabIndex = 2
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 211)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(480, 22)
        Me.StatusBar1.TabIndex = 7
        Me.StatusBar1.Text = "Ready"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.PaddingNumeric)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 56)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Padding"
        '
        'PaddingNumeric
        '
        Me.PaddingNumeric.Location = New System.Drawing.Point(50, 24)
        Me.PaddingNumeric.Name = "PaddingNumeric"
        Me.PaddingNumeric.Size = New System.Drawing.Size(56, 20)
        Me.PaddingNumeric.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Height:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 233)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "CharBreaker"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.yoffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xoffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ySaccadeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xSaccadeNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PaddingNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim g As Graphics
    Dim StringSize As New SizeF
    Dim xpos = 15
    Dim ypos = 64

    Dim sac_landing As New PointF
    Dim hitIndex As Integer = -1
    Dim csvwriter As IO.TextWriter
    Dim processed_output_file As IO.TextWriter

    Dim inReadMode As Boolean = False

    Private Sub Form1_Paint(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        g = e.Graphics
        ' CalculateTextSize()
        If Me.TextBox1.Text.Length > 0 Then
            MeasureCharacterRangesRegions(e)
        End If
    End Sub

    Private Sub writeToFile(ByRef s As String)
        If (csvwriter Is Nothing) Then
            ' writer = Console.Out
        Else
            csvwriter.WriteLine(s)
        End If
    End Sub

    Private Sub closeFile()
        If csvwriter Is Nothing Then
            ' we are using the console - leave it open
        Else
            csvwriter.Flush()
            csvwriter.Close()
            csvwriter = Nothing
        End If
    End Sub
    Private Sub MeasureCharacterRangesRegions(ByVal e As PaintEventArgs)

        ' taken from the page here
        ' http://msdn.microsoft.com/en-us/library/system.drawing.graphics.measurecharacterranges.aspx

        ' Set up string.
        Dim measureString As String = Me.TextBox1.Text
        ' get font from textbox
        Dim stringFont As Font = TextBox1.Font

        ' Set character ranges to "First" and "Second".
        Dim characterRanges(Me.TextBox1.Text.Length - 1) As CharacterRange
        Dim i = 0
        For i = 0 To Me.TextBox1.Text.Length - 1
            characterRanges(i) = New CharacterRange(i, 1)
        Next

        xpos = TextBox1.Location.X - 3
        ypos = TextBox1.Location.Y + TextBox1.Height + 32
        ' Create rectangle for layout.

        Dim x As Single = xpos
        Dim y As Single = ypos

        Dim width As Single = 2000.0F
        Dim height As Single = 500.0F
        Dim layoutRect As New RectangleF(x, y, width, height)

        Dim sacplot As New Rectangle
        Dim show_sacplot As Boolean = False

        ' Set string format.
        Dim stringFormat As New StringFormat
        stringFormat.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        stringFormat.SetMeasurableCharacterRanges(characterRanges) ' a limit of 32 ranges

        ' Draw string to screen.
        e.Graphics.DrawString(measureString, stringFont, Brushes.Black, _
        x, y, stringFormat)

        ' measure the whole word
        Dim characterRangesWhole As CharacterRange() = _
        {New CharacterRange(0, Me.TextBox1.Text.Length)}
        Dim stringFormatwhole = New StringFormat
        stringFormatwhole.FormatFlags = StringFormatFlags.MeasureTrailingSpaces
        stringFormatwhole.SetMeasurableCharacterRanges(characterRangesWhole) ' a limit of 32 ranges
        Dim stringRegionsWhole() As [Region] = e.Graphics.MeasureCharacterRanges( _
            measureString, _
            stringFont, _
            layoutRect, _
            stringFormatwhole _
            )
        Dim measureRect_whole As RectangleF = stringRegionsWhole(0).GetBounds(e.Graphics)
        Dim roundedRect_whole As Rectangle = Rectangle.Round(measureRect_whole)
        Dim centerx As Integer = (roundedRect_whole.Width / 2) + roundedRect_whole.X
        Dim centery As Integer = (roundedRect_whole.Height / 2) + roundedRect_whole.Y

        writeToFile("Word,Width,Height,,X Location, Y Location")
        writeToFile(Me.TextBox1.Text & "," & _
            roundedRect_whole.Width & "," & _
            roundedRect_whole.Height & ",," & _
            xoffset.Value & "," & _
            yoffset.Value)

        ' Measure up to 32 ranges in string.
        Dim stringRegions() As [Region] = e.Graphics.MeasureCharacterRanges(measureString, _
            stringFont, layoutRect, stringFormat)

        Dim chars = Me.TextBox1.Text.ToCharArray()
        writeToFile("Character,leftEdge,bottomEdge,rightEdge,topEdge")
        For i = 0 To stringRegions.Length - 1
            Dim measureRect_k As RectangleF = stringRegions(i).GetBounds(e.Graphics)

            ' add the padding
            measureRect_k.Height = measureRect_k.Height + (2 * PaddingNumeric.Value)
            measureRect_k.Y = measureRect_k.Y - (PaddingNumeric.Value)
            Dim roundedRect As Rectangle = Rectangle.Round(measureRect_k)
            e.Graphics.DrawRectangle(Pens.Orange, roundedRect)

            Dim left_edge = (roundedRect.X) - centerx
            Dim right_edge = (roundedRect.X + roundedRect.Width) - centerx
            Dim bottom_edge = (roundedRect.Y) - centery
            Dim top_edge = (roundedRect.Y + roundedRect.Height) - centery

            Dim charregion As New RectangleF(xoffset.Value + left_edge, yoffset.Value + bottom_edge, right_edge - left_edge, top_edge - bottom_edge)
            'writer.WriteLine(chars(i) & "," & _
            '    xoffset.Value + left_edge & "," & yoffset.Value + bottom_edge & "," & _
            '    xoffset.Value + right_edge & "," & yoffset.Value + top_edge)
            sac_landing.X = Me.xSaccadeNumericUpDown.Value
            sac_landing.Y = Me.ySaccadeNumericUpDown.Value

            Debug.WriteLine("Char: " & charregion.ToString)
            If charregion.Contains(sac_landing) Then
                sacplot.X = roundedRect.X + (sac_landing.X - charregion.X)
                sacplot.Y = roundedRect.Y + (sac_landing.Y - charregion.Y)
                sacplot.Width = 11
                sacplot.Height = 11
                sacplot.X = sacplot.X - 5
                sacplot.Y = sacplot.Y - 5
                show_sacplot = True
                Debug.WriteLine("Sacc: " & sacplot.ToString)
                Debug.WriteLine("HIT! [" & chars(i) & "]")
                hitIndex = i
            Else
                ' keep going
            End If

        Next

        ' draw the frame and the center
        e.Graphics.DrawRectangle(Pens.Red, roundedRect_whole)
        ' vertical center line
        e.Graphics.DrawLine(Pens.Green, _
            centerx, roundedRect_whole.Y - 2, _
            centerx, roundedRect_whole.Y + roundedRect_whole.Height + 2 _
        )
        ' horizontal center line 
        e.Graphics.DrawLine(Pens.Green, _
            centerx - 2, centery, _
            centerx + 2, centery _
        )

        ' draw the saccade plot if it hit a character target
        If show_sacplot = True Then
            g.FillEllipse(Brushes.White, sacplot)
        Else
            hitIndex = -1
        End If

        closeFile()

    End Sub

    Private Sub MenuItem4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim filename As String = Me.TextBox1.Text
        Dim i = 0
        Dim sep = ""
        If IO.File.Exists(filename & ".csv") Then
            i = i + 1
            sep = " " & i
            While (IO.File.Exists(filename & sep & ".csv"))
                i = i + 1
                sep = " " & i
                If (i = 100) Then Exit While
            End While
        End If
        If IO.File.Exists(filename & sep & ".csv") Then
            MessageBox.Show("Cannot safely save csv file as it already exists")
        Else
            Dim final_filename As String = filename & sep & ".csv"
            Dim mywrite As IO.StreamWriter = New IO.StreamWriter(final_filename)
            csvwriter = mywrite
            MyBase.Invalidate()
        End If
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        FontDialog1.Font = TextBox1.Font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine(FontDialog1.Font)
            Debug.WriteLine(FontDialog1.Color)
            Me.TextBox1.Font = FontDialog1.Font
            MyBase.Invalidate()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        MyBase.Invalidate()
    End Sub
    Private Sub xNumberBox_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xoffset.ValueChanged
        MyBase.Invalidate()
    End Sub
    Private Sub yNumberBox_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yoffset.ValueChanged
        MyBase.Invalidate()
    End Sub
    Private Sub sacxNumberBox_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xSaccadeNumericUpDown.ValueChanged
        MyBase.Invalidate()
    End Sub
    Private Sub sacyNumberBox_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ySaccadeNumericUpDown.ValueChanged
        MyBase.Invalidate()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessMenuItem.Click
        If Me.OpenSaccadeReportFileDialog.ShowDialog = DialogResult.OK Then
            Debug.WriteLine("Opening file:" & OpenSaccadeReportFileDialog.FileName)
            stream = OpenSaccadeReportFileDialog.OpenFile()
            Dim thr As New Threading.Thread(AddressOf processFile)
            thr.Start()
        Else
            Debug.WriteLine("No file selected")
        End If
    End Sub

    Dim stream As System.IO.Stream
    Dim index_sac_end_x As Single = -1
    Dim index_sac_end_y As Single = -1
    Dim index_word_string As Single = -1
    Dim index_target_loc As Single = -1


    Public Sub processFile()
        Dim reader As System.IO.StreamReader = New System.IO.StreamReader(stream)
        Dim headerline As String = reader.ReadLine()
        Dim headers() As String = headerline.Split(vbTab)
        Debug.WriteLine("Headers: " & headers.Length & " " & headers(headers.Length - 1))
        ' here are the rules
        ' expectedheader(0) = "CURRENT_SAC_END_X" [format: %0.1f]
        ' expectedheader(1) = "CURRENT_SAC_END_Y" [format: %0.1f]
        ' expectedheader(len-2) = "words" [format: string]
        ' expectedheader(len-1) = "target_loc" [format:"(xxx, yyy)"]
        index_sac_end_x = -1
        index_sac_end_y = -1
        index_word_string = -1
        index_target_loc = -1
        Dim i As Integer = 0
        Dim c As String = ""
        For i = 0 To headers.Length - 1
            c = headers(i)
            If c.Equals("CURRENT_SAC_END_X") Then
                index_sac_end_x = i
            End If
            If c.Equals("CURRENT_SAC_END_Y") Then
                index_sac_end_y = i
            End If
            If c.Equals("target_loc") Then
                index_target_loc = i
            End If
            If c.Equals("words") Then
                index_word_string = i
            End If
        Next

        If foundMyHeaders(index_sac_end_x, index_sac_end_y, index_word_string, index_target_loc) = True Then

            ' we have something we can work with - lets try and write to a file...
            Dim filename As String = makeNewFileNameFromOld(Me.OpenSaccadeReportFileDialog.FileName)
            If IO.File.Exists(filename) Then
                MessageBox.Show("Cannot safely save txt file, as it already exists")
            Else
                StatusBar1.Text = "Processing..."
                Dim mywrite As IO.StreamWriter = New IO.StreamWriter(filename)
                Me.processed_output_file = mywrite
                processed_output_file.WriteLine(headerline & vbTab & "LETTER_NUMBER" & vbTab & "LETTER")

                ' processing remaining lines until the end of the file
                Dim line As String
                Dim linedata() As String
                Dim reading = True
                Dim word_centre As Point
                Dim saccade_point As PointF
                Dim word As String
                Dim sac_x As Single
                Dim sac_y As Single
                While reading = True
                    line = reader.ReadLine()
                    If (line Is Nothing) Then
                        reading = False
                    Else
                        linedata = line.Split(vbTab)
                        ' word
                        word = linedata(index_word_string)
                        TextBox1.Text = word
                        ' location
                        word_centre = getPointFromString(linedata(index_target_loc))
                        Me.xoffset.Value = word_centre.X
                        Me.yoffset.Value = word_centre.Y
                        sac_x = Single.Parse(linedata(index_sac_end_x))
                        sac_y = Single.Parse(linedata(index_sac_end_y))
                        ' saccade_point
                        sac_landing = New PointF(sac_x, sac_y)
                        Me.xSaccadeNumericUpDown.Value = sac_x
                        Me.ySaccadeNumericUpDown.Value = sac_y
                        MyBase.Invalidate()
                        Console.WriteLine(word & word_centre.ToString & sac_landing.ToString)
                        ' give the app time to repaint(!)
                        Threading.Thread.Sleep(200)
                        Dim output As String = line
                        If hitIndex > -1 Then
                            ' remember to add 1 to the hitIndex !!
                            output = output & vbTab & hitIndex + 1 & vbTab & word.Substring(hitIndex, 1)
                        Else
                            output = output & vbTab & "" & vbTab & ""
                        End If
                        Debug.WriteLine(output)
                        Me.processed_output_file.WriteLine(output)
                    End If
                End While
            End If
        Else
                ' do nothing, and drop out of the function
        End If
        stream.Close()
        If Me.processed_output_file Is Nothing Then
            ' we do nothing
        Else
            Me.processed_output_file.Flush()
            Me.processed_output_file.Close()
            StatusBar1.Text = "Ready"
        End If
    End Sub

    Function foundMyHeaders(ByVal sacx, ByVal sacy, ByVal word, ByVal loc)
        Dim msg As String = "Could not find the headings:" & vbCrLf
        Dim found_error = False
        If sacx < 0 Then
            msg = msg & " CURRENT_SAC_END_X" & vbCrLf
            found_error = True
        End If
        If sacy < 0 Then
            msg = msg & " CURRENT_SAC_END_Y" & vbCrLf
            found_error = True
        End If
        If word < 0 Then
            msg = msg & " words" & vbCrLf
            found_error = True
        End If
        If loc < 0 Then
            msg = msg & " target_loc" & vbCrLf
            found_error = True
        End If
        If found_error = True Then
            MessageBox.Show(msg)
        End If
        Return Not found_error
    End Function

    Function getPointFromString(ByVal s As String)
        ' cut the ( off
        Dim substr As String = s.Substring(1, s.Length - 2)
        ' sometimes there is a " first, so we test to see if any ( remain
        If substr.IndexOf("(") > -1 Then
            substr = substr.Substring(1, substr.Length - 2)
        End If
        Dim vals() As String = substr.Split(",")
        Dim p As Point = New Point
        If vals.Length = 2 Then
            p.X = Integer.Parse(vals(0))
            p.Y = Integer.Parse(vals(1))
        End If
        Return p
    End Function

    Private Function makeNewFileNameFromOld(ByVal f As String)
        f = f.Substring(0, f.Length - 4)
        Dim i = 0
        Dim sep = ""
        If IO.File.Exists(f & ".txt") Then
            i = i + 1
            sep = " " & i
            While (IO.File.Exists(f & sep & ".txt"))
                i = i + 1
                sep = " " & i
                If (i = 100) Then Exit While
            End While
        End If

        Dim final_filename As String = f & sep & ".txt"
        Return final_filename
    End Function

    Private Sub PaddingNumeric_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaddingNumeric.ValueChanged
        MyBase.Invalidate()
    End Sub
End Class
