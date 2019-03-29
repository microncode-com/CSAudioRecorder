Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CSAudioRecorderSample
    Public Partial Class frmID3TagsEditor
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub LoadFile(ByVal multimedia_file As String)
            Try
                ClearAllFields()
                audioRecorder1.OpenID3Tags(txtMediaFile.Text)
                txtTagTitle.Text = audioRecorder1.TagTitle
                txtTagAlbum.Text = audioRecorder1.TagAlbum
                txtTagComment.Text = audioRecorder1.TagComment
                txtTagCopyright.Text = audioRecorder1.TagCopyright
                txtTagYear.Text = audioRecorder1.TagYear
                txtTagLyrics.Text = audioRecorder1.TagLyrics
                DisplayGenres()
                DisplayArtists()
                DisplayImages()
                DisplayComposers()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
            End Try
        End Sub

        Private Sub ClearAllFields()
            txtTagTitle.Text = ""
            txtTagAlbum.Text = ""
            txtTagComment.Text = ""
            txtTagCopyright.Text = ""
            txtTagYear.Text = ""
            txtTagLyrics.Text = ""
            lstTagArtists.Items.Clear()
            lstTagComposers.Items.Clear()
            lstTagGenres.Items.Clear()
            lstTagImages.Items.Clear()
            picImage.Image = Nothing
        End Sub

        Private Sub cmdOpenMediaFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtMediaFile.Text = openFileDialog1.FileName
                LoadFile(txtMediaFile.Text)
            End If
        End Sub

        Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                audioRecorder1.TagTitle = txtTagTitle.Text
                audioRecorder1.TagAlbum = txtTagAlbum.Text
                audioRecorder1.TagComment = txtTagComment.Text
                audioRecorder1.TagCopyright = txtTagCopyright.Text
                audioRecorder1.TagLyrics = txtTagLyrics.Text
                Dim floatrating As Single

                If Not Single.TryParse(cboTagRating.Text, floatrating) Then
                    floatrating = 0
                End If

                audioRecorder1.TagYear = txtTagYear.Text
                audioRecorder1.SetID3Tags(txtMediaFile.Text)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
            End Try
        End Sub

        Private Sub lstTagImages_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If lstTagImages.Items.Count > 0 Then picImage.Image = audioRecorder1.TagImages(lstTagImages.SelectedIndex).Image
        End Sub

        Private Sub lstTagImages_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTagImages.Items.Count > 0 Then picImage.Image = audioRecorder1.TagImages(lstTagImages.SelectedIndex).Image
        End Sub

        Private Sub DisplayArtists()
            lstTagArtists.Items.Clear()
            If audioRecorder1.TagArtists Is Nothing Then Return

            For Each artist As String In audioRecorder1.TagArtists
                lstTagArtists.Items.Add(artist)
            Next

            If lstTagArtists.Items.Count > 0 Then lstTagArtists.SelectedIndex = 0
        End Sub

        Private Sub cmdTagArtistsAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As String = ""

            If Core.InputBox("Add artist", "Artist name:", value) = DialogResult.OK Then
                audioRecorder1.TagArtists.Add(value)
            End If

            DisplayArtists()
        End Sub

        Private Sub cmdTagArtistsRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTagArtists.Items.Count = 0 Then Return
            audioRecorder1.TagArtists.RemoveAt(lstTagArtists.SelectedIndex)
            DisplayArtists()
        End Sub

        Private Sub cmdTagArtistsUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagArtists.Items.Count = 0 OrElse lstTagArtists.SelectedIndex = 0 Then Return
            selected_index = lstTagArtists.SelectedIndex
            audioRecorder1.TagArtists = Core.Switch(audioRecorder1.TagArtists, selected_index, selected_index - 1)
            DisplayArtists()
            lstTagArtists.SelectedIndex = selected_index - 1
        End Sub

        Private Sub cmdTagArtistsDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagArtists.SelectedIndex = (lstTagArtists.Items.Count - 1) Then Return
            selected_index = lstTagArtists.SelectedIndex
            audioRecorder1.TagArtists = Core.Switch(audioRecorder1.TagArtists, selected_index, selected_index + 1)
            DisplayArtists()
            lstTagArtists.SelectedIndex = selected_index + 1
        End Sub

        Private Sub DisplayComposers()
            lstTagComposers.Items.Clear()
            If audioRecorder1.TagComposers Is Nothing Then Return

            For Each composer As String In audioRecorder1.TagComposers
                lstTagComposers.Items.Add(composer)
            Next

            If lstTagComposers.Items.Count > 0 Then lstTagComposers.SelectedIndex = 0
        End Sub

        Private Sub cmdComposersAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim value As String = ""

            If Core.InputBox("Add composer", "Composer name:", value) = DialogResult.OK Then
                audioRecorder1.TagComposers.Add(value)
            End If

            DisplayComposers()
        End Sub

        Private Sub cmdComposersRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTagComposers.Items.Count = 0 Then Return
            audioRecorder1.TagComposers.RemoveAt(lstTagComposers.SelectedIndex)
            DisplayComposers()
        End Sub

        Private Sub cmdTagComposersUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagComposers.Items.Count = 0 OrElse lstTagComposers.SelectedIndex = 0 Then Return
            selected_index = lstTagComposers.SelectedIndex
            audioRecorder1.TagComposers = Core.Switch(audioRecorder1.TagComposers, selected_index, selected_index - 1)
            DisplayComposers()
            lstTagComposers.SelectedIndex = selected_index - 1
        End Sub

        Private Sub cmdTagComposersDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagComposers.SelectedIndex = (lstTagComposers.Items.Count - 1) Then Return
            selected_index = lstTagComposers.SelectedIndex
            audioRecorder1.TagComposers = Core.Switch(audioRecorder1.TagComposers, selected_index, selected_index + 1)
            DisplayComposers()
            lstTagComposers.SelectedIndex = selected_index + 1
        End Sub

        Private Sub DisplayGenres()
            lstTagGenres.Items.Clear()
            If audioRecorder1.TagGenres Is Nothing Then Return

            For Each genre As String In audioRecorder1.TagGenres
                lstTagGenres.Items.Add(genre)
            Next

            If lstTagGenres.Items.Count > 0 Then lstTagGenres.SelectedIndex = 0
        End Sub

        Private Sub cmdGenresAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            If cboTagGenres.Text IsNot "" Then audioRecorder1.TagGenres.Add(cboTagGenres.Text)
            DisplayGenres()
        End Sub

        Private Sub cmdGenresRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTagGenres.Items.Count = 0 Then Return
            audioRecorder1.TagGenres.RemoveAt(lstTagGenres.SelectedIndex)
            DisplayGenres()
        End Sub

        Private Sub cmdTagGenresUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagGenres.Items.Count = 0 OrElse lstTagGenres.SelectedIndex = 0 Then Return
            selected_index = lstTagGenres.SelectedIndex
            audioRecorder1.TagGenres = Core.Switch(audioRecorder1.TagGenres, selected_index, selected_index - 1)
            DisplayGenres()
            lstTagGenres.SelectedIndex = selected_index - 1
        End Sub

        Private Sub cmdTagGenresDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagGenres.SelectedIndex = (lstTagGenres.Items.Count - 1) Then Return
            selected_index = lstTagGenres.SelectedIndex
            audioRecorder1.TagGenres = Core.Switch(audioRecorder1.TagGenres, selected_index, selected_index + 1)
            DisplayGenres()
            lstTagGenres.SelectedIndex = selected_index + 1
        End Sub

        Private Sub DisplayImages()
            lstTagImages.Items.Clear()
            If audioRecorder1.TagImages Is Nothing Then Return

            For Each img In audioRecorder1.TagImages
                lstTagImages.Items.Add(img.Mine_Type & vbTab & img.Type & vbTab & img.Description)
            Next

            If lstTagImages.Items.Count > 0 Then
                lstTagImages.SelectedIndex = 0
                picImage.Image = audioRecorder1.TagImages(lstTagImages.SelectedIndex).Image
            End If
        End Sub

        Private Sub cmdImagesAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            openFileDialog1.Filter = "(Image Files)|*.jpg;*.jpeg;*.png|jpg, | *.jpg|jpeg, | *.jpeg|png, | *.png"

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim img As Image = audioRecorder1.AddImageFromFile(openFileDialog1.FileName)
                Me.picImage.Image = img
            End If

            DisplayImages()
        End Sub

        Private Sub cmdImagesRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lstTagImages.Items.Count = 0 Then Return
            audioRecorder1.TagImages.RemoveAt(lstTagImages.SelectedIndex)
            DisplayImages()
        End Sub

        Private Sub cmdTagImagesUp_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagImages.Items.Count = 0 OrElse lstTagImages.SelectedIndex = 0 Then Return
            selected_index = lstTagImages.SelectedIndex
            audioRecorder1.TagImages = Core.Switch(audioRecorder1.TagImages, selected_index, selected_index - 1)
            DisplayImages()
            lstTagImages.SelectedIndex = selected_index - 1
        End Sub

        Private Sub cmdTagImagesDown_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim selected_index As Integer = 0
            If lstTagImages.SelectedIndex = (lstTagImages.Items.Count - 1) Then Return
            selected_index = lstTagImages.SelectedIndex
            audioRecorder1.TagImages = Core.Switch(audioRecorder1.TagImages, selected_index, selected_index + 1)
            DisplayImages()
            lstTagImages.SelectedIndex = selected_index + 1
        End Sub

        Private Sub cmdClear_Click(ByVal sender As Object, ByVal e As EventArgs)
            If txtMediaFile.Text Is "" Then Return
            Dim dialogResult As DialogResult = MessageBox.Show("'Clear All Tags' will delete all the ID3 tags in the multimedia file, continue?", "Warning", MessageBoxButtons.OKCancel)

            If dialogResult = DialogResult.OK Then
                audioRecorder1.ClearAllTags(txtMediaFile.Text)
                LoadFile(txtMediaFile.Text)
                picImage.Image = Nothing
            End If
        End Sub
    End Class
End Namespace
