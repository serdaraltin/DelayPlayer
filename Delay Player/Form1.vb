Public Class Form1
    Public progress, mpname, volum As String
    Dim oto, rastgele As Integer
    Private Sub BaWGUIThemeContainer1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BaWGUIThemeContainer1.MouseMove
        Me.Icon = New Icon(Application.StartupPath + "//data//icon.ico")
        If (ListBox1.Items.Count = 0) Then
            Dim dosya As String = ""
            For Each dosya In System.IO.Directory.GetFiles(Application.StartupPath + "//data//mp3")
                Dim info As New System.IO.FileInfo(dosya)
                Dim dosyaad = info.Name
                ListBox1.Items.Add(dosyaad)
            Next
        End If
    End Sub

    Private Sub BaWGUIButton2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BaWGUIButton2.MouseMove
        BaWGUIButton2.Text = "►"
    End Sub

    Private Sub BaWGUIButton3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BaWGUIButton3.MouseMove
        BaWGUIButton3.Text = "◀ ◀"
    End Sub

    Private Sub BaWGUIButton2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaWGUIButton2.MouseLeave
        BaWGUIButton2.Text = "▷"
    End Sub

    Private Sub BaWGUIButton3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaWGUIButton3.MouseLeave
        BaWGUIButton3.Text = "◁ ◁"
    End Sub

    Private Sub BaWGUIButton4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BaWGUIButton4.MouseMove
        BaWGUIButton4.Text = "▶ ▶"
    End Sub

    Private Sub BaWGUIButton4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaWGUIButton4.MouseLeave
        BaWGUIButton4.Text = "▷ ▷"
    End Sub

    Private Sub BaWGUIButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaWGUIButton5.Click
        Dim ac As New OpenFileDialog()
        ac.Multiselect = True
        ac.Title = "Şarkı seçiniz."
        ac.Filter = "Mp3|*mp3"
        If (ac.ShowDialog() = DialogResult.OK) Then
            If (System.IO.File.Exists(Application.StartupPath + "//data//mp3//" + ac.SafeFileName) = False) Then
                System.IO.File.Copy(ac.FileName, Application.StartupPath + "//data//mp3//" + ac.SafeFileName)
                ListBox1.Items.Add(ac.SafeFileName)
            Else
                AxWindowsMediaPlayer1.URL = Application.StartupPath + "//data//mp3//" + ac.SafeFileName
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        BaWGUIProgressBar1.Value = AxWindowsMediaPlayer1.DataBindings.Count
        AxWindowsMediaPlayer1.settings.volume = BaWGUITrackBar1.Value
        Label1.Text = "Ses seviyesi %" + BaWGUITrackBar1.Value.ToString
      
        If (AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = 100 And BaWGUICheckBox2.Checked = True) Then
            oto += 1
            If (oto > ListBox1.Items.Count) Then
                oto = 0
            End If
            AxWindowsMediaPlayer1.URL = Application.StartupPath + "//data//mp3//" + ListBox1.Items(oto).ToString
        End If
    End Sub

    Private Sub BaWGUIButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaWGUIButton2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub BaWGUIButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaWGUIButton1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub BaWGUICheckBox2_CheckedChanged(ByVal sender As System.Object) Handles BaWGUICheckBox2.CheckedChanged
        If (BaWGUICheckBox2.Checked = True) Then
            BaWGUICheckBox1.Checked = False
        End If
    End Sub

    Private Sub BaWGUICheckBox1_CheckedChanged(ByVal sender As System.Object) Handles BaWGUICheckBox1.CheckedChanged
        On Error Resume Next

        Dim karisik As System.Random = New System.Random()
        rastgele = karisik.Next(0, ListBox1.Items.Count)
        If (BaWGUICheckBox1.Checked = True) Then
            BaWGUICheckBox2.Enabled = False
            BaWGUICheckBox2.Checked = False
            AxWindowsMediaPlayer1.URL = Application.StartupPath + "//data//mp3//" + ListBox1.Items(rastgele).ToString
            Label2.Text = ListBox1.Items(rastgele).ToString
        Else
            BaWGUICheckBox2.Enabled = True
        End If

    End Sub
    Private Sub ListBox1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDoubleClick
        On Error Resume Next
        If (ListBox1.SelectedItem.ToString() <> "") Then
            AxWindowsMediaPlayer1.URL = Application.StartupPath + "//data//mp3//" + ListBox1.SelectedItem.ToString()
            Label2.Text = ListBox1.SelectedItem.ToString()
            oto = ListBox1.SelectedItem
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If (Label2.Text <> "") Then
            Label2.Text = Label2.Text.Substring(1) + Label2.Text.Substring(0, 1)
        End If
    End Sub
    Private Sub BaşlatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub DurdurToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        On Error Resume Next
        AxWindowsMediaPlayer1.URL = Application.StartupPath + "//data//mp3//" + ListBox1.SelectedItem.ToString
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        On Error Resume Next
        If (System.IO.File.Exists(Application.StartupPath + "//data//mp3//" + ListBox1.SelectedItem.ToString) = True) Then
            AxWindowsMediaPlayer1.URL = ""
            System.IO.File.Delete(Application.StartupPath + "//data//mp3//" + ListBox1.SelectedItem.ToString)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            Label2.Text = ""
        End If

    End Sub

    Private Sub BaWGUICheckBox3_CheckedChanged(ByVal sender As System.Object) Handles BaWGUICheckBox3.CheckedChanged
        If (BaWGUICheckBox3.Checked = True) Then
            BaWGUITrackBar1.Enabled = False
            BaWGUITrackBar1.Value = 0
        Else
            BaWGUITrackBar1.Enabled = True
            BaWGUITrackBar1.Value = 80
        End If
    End Sub

    Private Sub ListBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseMove
        Me.Icon = New Icon(Application.StartupPath + "//data//icon.ico")
        If (ListBox1.Items.Count = 0) Then
            Dim dosya As String = ""
            For Each dosya In System.IO.Directory.GetFiles(Application.StartupPath + "//data//mp3")
                Dim info As New System.IO.FileInfo(dosya)
                Dim dosyaad = info.Name
                ListBox1.Items.Add(dosyaad)
            Next
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_PositionChange(ByVal sender As System.Object, ByVal e As AxWMPLib._WMPOCXEvents_PositionChangeEvent) Handles AxWindowsMediaPlayer1.PositionChange

    End Sub
End Class
