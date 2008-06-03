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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents xoffset As System.Windows.Forms.NumericUpDown
    Friend WithEvents XOffsetLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yoffset As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.xoffset = New System.Windows.Forms.NumericUpDown
        Me.XOffsetLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.yoffset = New System.Windows.Forms.NumericUpDown
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.xoffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yoffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(16, 16)
        Me.TextBox1.MaxLength = 32
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 39)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "the quick brown fox"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Break"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.yoffset)
        Me.GroupBox1.Controls.Add(Me.XOffsetLabel)
        Me.GroupBox1.Controls.Add(Me.xoffset)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Offset"
        '
        'xoffset
        '
        Me.xoffset.Location = New System.Drawing.Point(72, 23)
        Me.xoffset.Maximum = New Decimal(New Integer() {1600, 0, 0, 0})
        Me.xoffset.Name = "xoffset"
        Me.xoffset.Size = New System.Drawing.Size(56, 20)
        Me.xoffset.TabIndex = 2
        '
        'XOffsetLabel
        '
        Me.XOffsetLabel.Location = New System.Drawing.Point(16, 24)
        Me.XOffsetLabel.Name = "XOffsetLabel"
        Me.XOffsetLabel.Size = New System.Drawing.Size(48, 16)
        Me.XOffsetLabel.TabIndex = 3
        Me.XOffsetLabel.Text = "X Offset"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(136, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Y Offset"
        '
        'yoffset
        '
        Me.yoffset.Location = New System.Drawing.Point(184, 23)
        Me.yoffset.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.yoffset.Name = "yoffset"
        Me.yoffset.Size = New System.Drawing.Size(56, 20)
        Me.yoffset.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Save as CSV"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 174)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.xoffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yoffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim g As Graphics
    Dim myFont As New Font("Times New Roman", 20)
    Dim StringSize As New SizeF
    Dim calc_text As Boolean = False
    Dim xpos = 15
    Dim ypos = 64
    Dim csvwriter As IO.TextWriter

    Private Sub Form1_Paint(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        g = e.Graphics
        If calc_text Then
            ' CalculateTextSize()
            If Me.TextBox1.Text.Length > 0 Then
                MeasureCharacterRangesRegions(e)
            End If
        End If
    End Sub

    Private Sub MeasureCharacterRangesRegions(ByVal e As PaintEventArgs)

        ' taken from the page here
        ' http://msdn.microsoft.com/en-us/library/system.drawing.graphics.measurecharacterranges.aspx

        Dim writer As IO.TextWriter = Console.Out

        If (csvwriter Is Nothing) Then
            writer = Console.Out
        Else
            writer = csvwriter
        End If

        ' Set up string.
        Dim measureString As String = Me.TextBox1.Text
        Dim stringFont As New Font("Times New Roman", 20.0F)

        ' Set character ranges to "First" and "Second".
        Dim characterRanges(Me.TextBox1.Text.Length - 1) As CharacterRange
        Dim i = 0
        For i = 0 To Me.TextBox1.Text.Length - 1
            characterRanges(i) = New CharacterRange(i, 1)
        Next

        ' Create rectangle for layout.
        Dim x As Single = xpos
        Dim y As Single = ypos
        Dim width As Single = 800.0F
        Dim height As Single = 50.0F
        Dim layoutRect As New RectangleF(x, y, width, height)

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
        Dim stringRegionsWhole() As [Region] = e.Graphics.MeasureCharacterRanges(measureString, _
                    stringFont, layoutRect, stringFormatwhole)
        Dim measureRect_whole As RectangleF = stringRegionsWhole(0).GetBounds(e.Graphics)
        Dim roundedRect_whole As Rectangle = Rectangle.Round(measureRect_whole)
        Dim centerx As Integer = (roundedRect_whole.Width / 2) + roundedRect_whole.X
        Dim centery As Integer = (roundedRect_whole.Height / 2) + roundedRect_whole.Y

        writer.WriteLine("Word,Width,Height,,X Location, Y Location")
        writer.WriteLine(Me.TextBox1.Text & "," & _
            roundedRect_whole.Width & "," & _
            roundedRect_whole.Height & ",," & _
            xoffset.Value & "," & _
            yoffset.Value)

        ' Measure up to 32 ranges in string.
        Dim stringRegions() As [Region] = e.Graphics.MeasureCharacterRanges(measureString, _
            stringFont, layoutRect, stringFormat)

        Dim chars = Me.TextBox1.Text.ToCharArray()
        writer.WriteLine("Character,leftEdge,topEdge,rightEdge,bottomEdge")
        For i = 0 To stringRegions.Length - 1
            Dim measureRect_k As RectangleF = stringRegions(i).GetBounds(e.Graphics)
            Dim roundedRect As Rectangle = Rectangle.Round(measureRect_k)
            e.Graphics.DrawRectangle(Pens.Orange, roundedRect)
            'Debug.WriteLine(chars(i) & " " & roundedRect.Width & ":" & roundedRect.Height)
            Dim left_edge = (roundedRect.X) - centerx
            Dim right_edge = (roundedRect.X + roundedRect.Width) - centerx
            Dim top_edge = (roundedRect.Y) - centery
            Dim bottom_edge = (roundedRect.Y + roundedRect.Height) - centery
            writer.WriteLine(chars(i) & "," & _
                xoffset.Value + left_edge & "," & yoffset.Value + top_edge & "," & _
                xoffset.Value + right_edge & "," & yoffset.Value + bottom_edge)
        Next

        ' draw the frame and the center
        e.Graphics.DrawRectangle(Pens.Red, roundedRect_whole)
        e.Graphics.DrawLine(Pens.Green, _
            centerx, ypos - 4, _
            centerx, ypos + roundedRect_whole.Height + 4 _
        )

        writer.Flush()

        If csvwriter Is Nothing Then
            ' we are using the console - leave it open
        Else
            writer.Close()
            csvwriter = Nothing
        End If


    End Sub

    Sub CalculateTextSize()

        Dim sFormat = New StringFormat(StringFormat.GenericTypographic)

        ' the whole word...
        StringSize = g.MeasureString(Me.TextBox1.Text, myFont, New PointF(0, 0), sFormat)
        Debug.WriteLine(Me.TextBox1.Text & " " & StringSize.Width & ":" & StringSize.Height)
        g.DrawString(Me.TextBox1.Text, myFont, Brushes.Black, xpos - 4, ypos)
        g.DrawRectangle(Pens.Red, xpos, ypos, StringSize.Width, StringSize.Height)
        ' the letters...
        Dim chars As Char()
        Dim running_total = 0
        chars = Me.TextBox1.Text.ToCharArray()
        Dim i As Integer
        For i = 0 To chars.Length - 1
            Dim s As String
            s = Me.TextBox1.Text.Substring(0, i + 1)
            ' Console.Out.WriteLine(s)
            StringSize = g.MeasureString(s, myFont, New PointF(0, 0), sFormat)
            Debug.WriteLine(s & " " & StringSize.Width & ":" & StringSize.Height & " -> " & _
                StringSize.Width - running_total)
            running_total = StringSize.Width
            g.DrawLine(Pens.Orange, New Point(xpos + StringSize.Width, ypos + StringSize.Height), _
                New Point(xpos + StringSize.Width, ypos))

        Next
        Debug.WriteLine(running_total)

        calc_text = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If g Is Nothing Then
            ' nothing
        Else
            calc_text = True
            MyBase.Invalidate()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
End Class
