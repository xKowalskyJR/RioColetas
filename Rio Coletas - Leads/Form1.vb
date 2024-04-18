Imports System.IO
Imports OfficeOpenXml
Imports System.Text
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Collections.Generic


Public Class Form1


    Public TITULOMSGBOX = FRM_INICIAR.TITULOMSGBOX


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Me.Text = TITULOMSGBOX

        If DataGridView1.Rows.Count = 0 Then
            gbopcoes.Enabled = False
        Else
            gbopcoes.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Exibe o diálogo para selecionar o arquivo Excel
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName

            ' Carrega o arquivo Excel utilizando o EPPlus
            Using package As New ExcelPackage(New FileInfo(filePath))
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0)

                ' Limpa o DataGridView
                DataGridView1.Rows.Clear()
                DataGridView1.Columns.Clear()

                ' Adiciona as colunas "LOCAL" e "TELEFONE" no DataGridView
                DataGridView1.Columns.Add("LOCAL", "LOCAL")
                DataGridView1.Columns.Add("TELEFONE", "TELEFONE")
                DataGridView1.Columns.Add("CATEGORIA", "CATEGORIA")
                DataGridView1.Columns.Add("ENDEREÇO", "ENDEREÇO")

                '' Adiciona as colunas restantes do Excel no DataGridView
                'For col As Integer = 1 To worksheet.Dimension.End.Column
                '    DataGridView1.Columns.Add("Column " & col.ToString(), "Column " & col.ToString())
                'Next

                ' Adiciona as linhas no DataGridView
                For row As Integer = 1 To worksheet.Dimension.End.Row
                    Dim values(worksheet.Dimension.End.Column + 1) As Object
                    For col As Integer = 1 To worksheet.Dimension.End.Column
                        values(col - 1) = worksheet.Cells(row, col).Value
                    Next
                    DataGridView1.Rows.Add(values)
                Next
            End Using

            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.Width = 200
            Next
        End If



        If DataGridView1.Rows.Count = 0 Then
            gbopcoes.Enabled = False
        Else
            gbopcoes.Enabled = True
        End If

    End Sub


    Private Sub ExcluirDuplicados()
        ' Dicionário para armazenar os valores da segunda coluna e suas contagens
        Dim contagemValores As New Dictionary(Of String, Integer)

        ' Lista para armazenar as linhas a serem excluídas
        Dim linhasExcluir As New List(Of DataGridViewRow)

        ' Iterar pelas linhas do DataGridView
        For Each row As DataGridViewRow In DataGridView1.Rows
            ' Verificar se a célula da segunda coluna não está vazia
            If Not row.Cells(1).Value Is Nothing Then
                Dim valor As String = row.Cells(1).Value.ToString()

                ' Verificar se o valor já está no dicionário
                If contagemValores.ContainsKey(valor) Then
                    ' Se já estiver, adicionamos a linha à lista de linhas a serem excluídas
                    linhasExcluir.Add(row)
                Else
                    ' Se não estiver, adicionamos ao dicionário com uma contagem de 1
                    contagemValores.Add(valor, 1)
                End If
            End If
        Next

        ' Remover as linhas duplicadas
        For Each row In linhasExcluir
            DataGridView1.Rows.Remove(row)
        Next
    End Sub


    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If cbAPAGARCOLUNAS.Checked = True Then
            For i As Integer = DataGridView1.Columns.Count - 1 To 2 Step -1
                DataGridView1.Columns.RemoveAt(i)
            Next
        End If


        Await Task.Delay(50)


        If cbREMOVERCONTATOSSEMTELEFONE.Checked = True Then
            ' Itera pelas linhas do DataGridView
            For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
                ' Verifica se o valor da segunda coluna está em branco
                If DataGridView1.Rows(i).Cells(1).Value Is Nothing OrElse DataGridView1.Rows(i).Cells(1).Value.ToString() = "" Then
                    ' Remove a linha
                    DataGridView1.Rows.RemoveAt(i)
                End If
            Next
        End If


        Await Task.Delay(50)


        If cbREMOVERCARACTERES.Checked = True Then

            ' Itera pelas linhas do DataGridView
            For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
                ' Obtém o valor da segunda coluna
                Dim valor As String = DataGridView1.Rows(i).Cells(1).Value.ToString()

                ' Remove caracteres não numéricos
                valor = System.Text.RegularExpressions.Regex.Replace(valor, "[^\d]", "")

                ' Atualiza o valor na segunda coluna
                DataGridView1.Rows(i).Cells(1).Value = valor

                ' Verifica se o valor está em branco após a remoção de caracteres
                If valor = "" Then
                    ' Remove a linha se estiver em branco
                    DataGridView1.Rows(i).Cells(1).Value = "0"
                End If
            Next

        End If

        Await Task.Delay(50)

        If cbADDCODIGO55.Checked = True Then

            ' Itera pelas linhas do DataGridView
            For i As Integer = DataGridView1.Rows.Count - 1 To 0 Step -1
                ' Obtém o valor da segunda coluna
                Dim valor As String = DataGridView1.Rows(i).Cells(1).Value.ToString()

                ' Remove caracteres não numéricos
                valor = System.Text.RegularExpressions.Regex.Replace(valor, "[^\d]", "")

                ' Adiciona "55" na frente do número
                valor = "55" & valor

                ' Atualiza o valor na segunda coluna
                DataGridView1.Rows(i).Cells(1).Value = valor

                ' Verifica se o valor está em branco após a remoção de caracteres
                If valor = "" Then
                    ' Remove a linha se estiver em branco
                    DataGridView1.Rows(i).Cells(1).Value = "0"
                End If
            Next


        End If


        If cbDuplicados.Checked = True Then

            ExcluirDuplicados()

        End If






        Await Task.Delay(100)

        If cbSalvar.Checked = True Then
            SALVARCSV()
        End If



    End Sub

    Private Async Sub SALVARCSV()

        ' Verifica se há linhas no DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Nenhum arquivo para ser Salvo!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, TITULOMSGBOX)
            Return
        End If

        ' Abre o diálogo de salvar arquivo
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Arquivo CSV|*.csv"
        saveFileDialog1.Title = "Salvar como arquivo CSV"
        saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        saveFileDialog1.FileName = "LEADS - OK.csv"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Using streamWriter As New StreamWriter(saveFileDialog1.FileName, False, Encoding.UTF8)
                    ' Escreve o cabeçalho
                    streamWriter.WriteLine("Número de contato,{{1}}")

                    ' Escreve os dados das linhas
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        Dim line As String = ""
                        ' Adiciona o valor da coluna 1
                        line += row.Cells(1).Value.ToString() + ","
                        ' Adiciona o valor da coluna 0
                        line += row.Cells(0).Value.ToString()
                        ' Escreve a linha no arquivo
                        streamWriter.WriteLine(line)
                    Next
                End Using

                MsgBox("Planilha salva com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, TITULOMSGBOX)

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao salvar o arquivo: " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, TITULOMSGBOX)
            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SALVARCSV()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Restart()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub GerarPropostaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerarPropostaToolStripMenuItem.Click
        FRM_Proposta.ShowDialog()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FRM_INICIAR.Show()
        FRM_INICIAR.ShowInTaskbar = True
        FRM_INICIAR.WindowState = FormWindowState.Normal
    End Sub
End Class
