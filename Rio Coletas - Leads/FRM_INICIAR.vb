Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles

Public Class FRM_INICIAR
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSAIR.Click
        Application.Exit()
    End Sub

    Public TITULOMSGBOX As String
    Private Async Sub FRM_INICIAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Public Async Sub VERIFICAATUALIZACAO()

        '   https://raw.githubusercontent.com/xKowalskyJR/Rio-Coletas/main/versao


        ' URL do raw
        Dim url As String = "https://raw.githubusercontent.com/xKowalskyJR/Rio-Coletas/main/versao"

        ' Usando WebClient para obter o conteúdo
        Dim client As New WebClient()
        Dim response As String = client.DownloadString(url)

        ' Remover espaços em branco extras
        Dim versaoOnline As String = response.Trim()

        ' Versão do aplicativo (supondo que você tenha a versão armazenada em uma variável)
        Dim versaoApp As String = Application.ProductVersion

        ' Verificar se as versões são iguais
        If versaoOnline = versaoApp Then
            TITULOMSGBOX = "Rio Coletas - By Mateus Tamanini v" & Application.ProductVersion
        Else
            TITULOMSGBOX = "Rio Coletas - By Mateus Tamanini v" & Application.ProductVersion & " - DESATUALIZADO!"

            If MsgBox("Nova atualização disponível!" & vbNewLine & vbNewLine & "Versão atual: " & Application.ProductVersion & vbNewLine & "Nova Versão:" & versaoOnline & vbNewLine & vbNewLine & "Deseja atualizar agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, TITULOMSGBOX) = MsgBoxResult.Yes Then


                If Directory.Exists(Application.StartupPath & "\update") = False Then
                    Directory.CreateDirectory(Application.StartupPath & "\update")
                End If


                '  https://github.com/xKowalskyJR/Rio-Coletas/raw/main/Rio%20Coletas%20-%20Leads.exe
                '  https://raw.githubusercontent.com/xKowalskyJR/Rio-Coletas/main/Rio%20Coletas%20-%20Leads.exe

                Dim linkprograma As String = "https://raw.githubusercontent.com/xKowalskyJR/Rio-Coletas/main/Rio%20Coletas%20-%20Leads.exe"
                Dim destinationDirectory As String = Application.StartupPath & "\update"

                ' Criar o diretório de destino se não existir
                If Not IO.Directory.Exists(destinationDirectory) Then
                    IO.Directory.CreateDirectory(destinationDirectory)
                End If

                ' Nome do arquivo a ser salvo
                Dim fileName As String = IO.Path.GetFileName(linkprograma)
                fileName = Uri.UnescapeDataString(fileName)


                ' Caminho completo do arquivo de destino
                Dim filePath As String = IO.Path.Combine(destinationDirectory, fileName)

                ' Baixar o arquivo
                Using clientedownload As New WebClient()
                    Try
                        clientedownload.DownloadFile(url, filePath)
                        MsgBox("Arquivo baixado com sucesso em: " & filePath)
                    Catch ex As Exception
                        MsgBox("Ocorreu um erro durante o download do arquivo: " & ex.Message)
                    End Try
                End Using




            End If

        End If

        Await Task.Delay(10)
        Me.Text = TITULOMSGBOX


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim txt As String
        Dim horaAtual As Integer = DateTime.Now.Hour
        Dim bdia As String

        If horaAtual >= 0 AndAlso horaAtual < 12 Then
            bdia = "Bom dia!"
            pbDIA.Image = My.Resources.MANHA
        ElseIf horaAtual >= 12 AndAlso horaAtual < 18 Then
            bdia = "Boa tarde!"
            pbDIA.Image = My.Resources.TARDE
        Else
            bdia = "Boa noite!"
            pbDIA.Image = My.Resources.NOITE
        End If



        lblbomdia.Text = bdia

        txt = Date.Now.ToLongDateString & vbNewLine & Date.Now.ToString("HH:mm:ss") & vbNewLine



        lblinfo.Text = txt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTABELAS.Click

        Me.Hide()
        Me.ShowInTaskbar = False
        Form1.Show()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnPROPOSTA.Click


        Me.Hide()
        Me.ShowInTaskbar = False
        FRM_Proposta.Show()



    End Sub

    Private Sub OPÇÕESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPÇÕESToolStripMenuItem.Click

    End Sub

    Private Sub OrganizadorDeTabelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizadorDeTabelasToolStripMenuItem.Click
        Me.Hide()
        Me.ShowInTaskbar = False
        Form1.Show()
    End Sub

    Private Sub EmissorDePropostaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmissorDePropostaToolStripMenuItem.Click
        Me.Hide()
        Me.ShowInTaskbar = False
        FRM_Proposta.Show()
    End Sub

    Private Sub EmissorDeContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmissorDeContratoToolStripMenuItem.Click
        Me.Hide()
        Me.ShowInTaskbar = False
        FRM_Contrato.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCONTRATO.Click
        Me.Hide()
        Me.ShowInTaskbar = False
        FRM_Contrato.Show()
    End Sub

    Private Sub SAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SAIRToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnTABELAS.MouseEnter
        btnTABELAS.BackColor = Color.LightGray
        btnTABELAS.Font = New Font("Footlight MT Light", 15.5)

    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnTABELAS.MouseLeave
        btnTABELAS.BackColor = Color.DarkGray
        btnTABELAS.Font = New Font("Footlight MT Light", 15)
    End Sub



    Private Sub btnPROPOSTA_MouseEnter(sender As Object, e As EventArgs) Handles btnPROPOSTA.MouseEnter
        btnPROPOSTA.BackColor = Color.LightGray
        btnPROPOSTA.Font = New Font("Footlight MT Light", 15.5)

    End Sub
    Private Sub btnPROPOSTA_MouseLeave(sender As Object, e As EventArgs) Handles btnPROPOSTA.MouseLeave
        btnPROPOSTA.BackColor = Color.DarkGray
        btnPROPOSTA.Font = New Font("Footlight MT Light", 15)

    End Sub



    Private Sub btnCONTRATO_MouseEnter(sender As Object, e As EventArgs) Handles btnCONTRATO.MouseEnter
        btnCONTRATO.BackColor = Color.LightGray
        btnCONTRATO.Font = New Font("Footlight MT Light", 15.5)

    End Sub
    Private Sub btnCONTRATO_MouseLeave(sender As Object, e As EventArgs) Handles btnCONTRATO.MouseLeave
        btnCONTRATO.BackColor = Color.DarkGray
        btnCONTRATO.Font = New Font("Footlight MT Light", 15)

    End Sub

    Private Sub btnSAIR_MouseEnter(sender As Object, e As EventArgs) Handles btnSAIR.MouseEnter
        btnSAIR.BackColor = Color.LightGray
        btnSAIR.Font = New Font("Footlight MT Light", 15.5)


    End Sub

    Private Sub btnSAIR_MouseLeave(sender As Object, e As EventArgs) Handles btnSAIR.MouseLeave
        btnSAIR.BackColor = Color.DarkGray
        btnSAIR.Font = New Font("Footlight MT Light", 15)

    End Sub

    Private Sub lblbomdia_MouseEnter(sender As Object, e As EventArgs) Handles lblbomdia.MouseEnter
        lblbomdia.Font = New Font("Freestyle Script", 50, FontStyle.Bold Or FontStyle.Italic)
    End Sub

    Private Sub lblbomdia_MouseLeave(sender As Object, e As EventArgs) Handles lblbomdia.MouseLeave
        lblbomdia.Font = New Font("Freestyle Script", 45, FontStyle.Bold Or FontStyle.Italic)

    End Sub

    Private Sub FRM_INICIAR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        VERIFICAATUALIZACAO()
    End Sub
End Class