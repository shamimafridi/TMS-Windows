Public Class EventViewer
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
    Friend WithEvents lvwEvents As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(EventViewer))
        Me.lvwEvents = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'lvwEvents
        '
        Me.lvwEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvwEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwEvents.Location = New System.Drawing.Point(0, 0)
        Me.lvwEvents.Name = "lvwEvents"
        Me.lvwEvents.Size = New System.Drawing.Size(292, 266)
        Me.lvwEvents.SmallImageList = Me.ImageList1
        Me.lvwEvents.TabIndex = 0
        Me.lvwEvents.View = System.Windows.Forms.View.List
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'EventViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.lvwEvents)
        Me.Name = "EventViewer"
        Me.Text = "EventViewer"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub EventViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillView()
    End Sub
    Private Sub SetupEventsListView()

        With lvwEvents

            'Clear existing data 
            .Clear()

            'Add new columns 
            .Columns.Add("Entry Type", 150, HorizontalAlignment.Left)
            .Columns.Add("Description", 150, HorizontalAlignment.Left)
            .Columns.Add("Date/Time Generated", 100, HorizontalAlignment.Left)
            .Columns.Add("Source", 150, HorizontalAlignment.Left)
            '.Columns.Add("Category", 150, HorizontalAlignment.Left)
            '.Columns.Add("Event", 150, HorizontalAlignment.Left)
            .Columns.Add("User", 150, HorizontalAlignment.Left)
            .Columns.Add("Computer", 150, HorizontalAlignment.Left)

            'Set to Details view 
            .View = View.Details

        End With

    End Sub

    Private Sub FillView()

        'Setup the lvwEvents columns 
        SetupEventsListView()

        'Declare an EventLog and EventLogEntry object. 
        Dim elEvent As New System.Diagnostics.EventLog(My.Settings.ConnectionString & " Log")
        Dim elEventEntry As System.Diagnostics.EventLogEntry

        'Iterate the EventLog and write the data to the list view control. 
        For Each elEventEntry In elEvent.Entries
            Dim li As ListViewItem = Nothing

            If elEventEntry.EntryType = EventLogEntryType.Error Then
                li = New ListViewItem(elEventEntry.EntryType.ToString, 0)
            ElseIf elEventEntry.EntryType = EventLogEntryType.Information Then
                li = New ListViewItem(elEventEntry.EntryType.ToString, 1)
            ElseIf elEventEntry.EntryType = EventLogEntryType.Warning Then
                li = New ListViewItem(elEventEntry.EntryType.ToString, 2)
            End If


            With li
                .Text = elEventEntry.EntryType.ToString
                .SubItems.Add(elEventEntry.Message.ToString)
                .SubItems.Add(elEventEntry.TimeGenerated.ToString)
                .SubItems.Add(elEventEntry.Source.ToString)
                '.SubItems.Add(elEventEntry.Category.ToString)
                '.SubItems.Add(elEventEntry.EventID.ToString)
                '.SubItems.Add(elEventEntry.EventID.ToString)
                'Users are not always associated with an entry so must test for nothing else an exception will be thrown. 
                If elEventEntry.UserName Is Nothing Then
                    .SubItems.Add("N/A")
                Else
                    .SubItems.Add(elEventEntry.UserName.ToString)
                End If

                .SubItems.Add(elEventEntry.MachineName.ToString)

            End With
            lvwEvents.Items.Add(li)
            li = Nothing

        Next

    End Sub


    Private Sub lvwEvents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwEvents.SelectedIndexChanged

    End Sub
End Class
