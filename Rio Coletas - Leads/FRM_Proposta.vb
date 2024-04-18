Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OfficeOpenXml.Drawing.Chart

Public Class FRM_Proposta

    Public TITULOMSGBOX = FRM_INICIAR.TITULOMSGBOX
    Private fecharcontrato As Boolean = False

    Private Sub FRM_Proposta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = TITULOMSGBOX



        LIMPARCAMPOS()

    End Sub

    Private Async Sub GRUPOHABILITAR()

        If cbGRUPOA.Checked = True Then
            gbGRUPOA.Enabled = True
        Else
            gbGRUPOA.Enabled = False
        End If


        If cbGRUPOB.Checked = True Then
            gbGRUPOB.Enabled = True
        Else
            gbGRUPOB.Enabled = False
        End If

        If cbGRUPOC.Checked = True Then
            gbGRUPOC.Enabled = True
        Else
            gbGRUPOC.Enabled = False
        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtDATA.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub cbGRUPOA_CheckedChanged(sender As Object, e As EventArgs) Handles cbGRUPOA.CheckedChanged
        GRUPOHABILITAR()
    End Sub

    Private Sub cbGRUPOB_CheckedChanged(sender As Object, e As EventArgs) Handles cbGRUPOB.CheckedChanged
        GRUPOHABILITAR()
    End Sub

    Private Sub cbGRUPOC_CheckedChanged(sender As Object, e As EventArgs) Handles cbGRUPOC.CheckedChanged
        GRUPOHABILITAR()
    End Sub


    Private Async Sub LIMPARCAMPOS()


        cbCLASSE.SelectedIndex = 0
        cbSR.SelectedIndex = 0
        txtDATA.Text = Date.Now.ToString("dd/MM/yyyy")
        numericVALIDADEPROPOSTA.Value = 15

        cbGRUPOA.Checked = False
        cbGRUPOB.Checked = False
        cbGRUPOC.Checked = False



        TABELA01cbprazo.SelectedIndex = 3
        TABELA01cbvolumetotal.SelectedIndex = 0
        TABELA01cbpesototal.SelectedIndex = 0
        TABELA02cbprazo.SelectedIndex = 3
        TABELA02cbvolumetotal.SelectedIndex = 0
        TABELA02cbpesototal.SelectedIndex = 0
        TABELA03cbprazo.SelectedIndex = 3
        TABELA03cbvolumetotal.SelectedIndex = 0
        TABELA03cbpesototal.SelectedIndex = 0

        TABELA01txtvalor.Text = "0,00"
        TABELA02txtvalor.Text = "0,00"
        TABELA03txtvalor.Text = "0,00"

        TABELA01txtvolumetotal.Text = "0,00"
        TABELA02txtvolumetotal.Text = "0,00"
        TABELA03txtvolumetotal.Text = "0,00"

        TABELA01txtpesototal.Text = "0,00"
        TABELA02txtpesototal.Text = "0,00"
        TABELA03txtpesototal.Text = "0,00"

        TABELA01valorvolumeexcedente.Text = "0,00"
        TABELA02valorvolumeexcedente.Text = "0,00"
        TABELA03valorvolumeexcedente.Text = "0,00"

        TABELA01valorkiloexcedente.Text = "0,00"
        TABELA02valorkiloexcedente.Text = "0,00"
        TABELA03valorkiloexcedente.Text = "0,00"
    End Sub

    Private Async Sub GERARHTML()

        Dim directoryPath As String = AppDomain.CurrentDomain.BaseDirectory
        Dim htmlFileName As String = "Proposta RioColetas -" & txtCLIENTE.Text & ".html"
        Dim htmlFilePath As String = Path.Combine(directoryPath, htmlFileName)
        Dim imageFilePath As String = Path.Combine(directoryPath, "imagem.png")
        My.Resources.logo_riocoletas.Save(imageFilePath)

        Dim htmlContent As String = ""
        htmlContent &= "<!DOCTYPE html>"
        htmlContent &= "<html>"
        htmlContent &= "<head>"
        htmlContent &= "<title>Proposta RioColetas -" & txtCLIENTE.Text & "</title>"
        htmlContent &= "<style>footer {position: fixed;bottom: 0;width: 100%;background-color: #fff;color: #fff;text-align: center;padding: 10px 0;font-size: 11px;}</style>"
        htmlContent &= "<style>"
        htmlContent &= "body {"
        htmlContent &= "    margin: 0;"
        htmlContent &= "    padding: 0;"
        htmlContent &= "}"
        htmlContent &= ".container {"
        htmlContent &= "    text-align: center;"
        htmlContent &= "}"
        htmlContent &= ".text {"
        htmlContent &= "    font-weight: bold;"
        htmlContent &= "    text-decoration: underline;"
        htmlContent &= "}"
        htmlContent &= ".text-left {"
        htmlContent &= "    text-align: left;"
        htmlContent &= "    padding-left: 10px;"
        htmlContent &= "}"
        htmlContent &= ".text-right {"
        htmlContent &= "    text-align: right;"
        htmlContent &= "    padding-right: 10px;"
        htmlContent &= "}"
        htmlContent &= "</style>"
        htmlContent &= "</head>"
        htmlContent &= "<body>"
        htmlContent &= "<div class=""container"">"
        htmlContent &= "<br><br>"
        htmlContent &= "<div style=""display: flex; justify-content: center;text-align:center"">"
        htmlContent &= $"<img src=""{imageFilePath}"" style=""width: 400px; height: 100px; opacity: 0.9;display:inline-block;"">"
        htmlContent &= "</div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div class=""text"">Proposta Orçamentária</div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div>" & cbCLASSE.SelectedItem.ToString() & "</div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <b>Ref .:</b> Orçamento para a Prestação de Serviços de Coleta, Transporte, Tratamento e Destinação Final de Resíduos dos Serviços de Saúde (RSS)</div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Prezados " & cbSR.SelectedItem.ToString() & ": " & txtCLIENTE.Text & "</div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Em atenção ao requerido, apresenta-se Proposta Orçamentária (ver Tabela n.º 01) atinente aos serviços de coleta, transporte, tratamento e destinação final de resíduos dos serviços de saúde, em concordância com a RDC nº 222/18 da Agência Nacional de Vigilância Sanitária – ANVISA e da Resolução nº 358/05 do Conselho Nacional do Meio Ambiente - CONAMA. Outras resoluções, leis (Política Nacional de Resíduos Sólidos – Lei 12.350/10) e normas, tal como a NR 32, também serão consideradas.</div>"
        htmlContent &= "<br><br><br>"
        htmlContent &= "<div class=""text""><b>Validade da Proposta: " & numericVALIDADEPROPOSTA.Value & " dias.</b></div>"
        htmlContent &= "<br><br><br><br><br>"
        htmlContent &= "<div class=""text-right"">Timbó, " & Date.ParseExact(txtDATA.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd 'de' MMMM 'de' yyyy") & "</div>"


        htmlContent &= "<br><br><br><br><br><br><br><br><br><br><br><br><br><br>"


        htmlContent &= "<div><b>Francisco Steiner de Souza</b></div>"
        htmlContent &= "<div><b>M.e. Biólogo – (47) 9 9651-1515</b></div>"
        htmlContent &= "<div><b>saude@riocoletas.com.br</b></div>"

        htmlContent &= "<br><br><br>"


        htmlContent &= "<br><br><br>"

        htmlContent &= "<div class=""text"">RioColetas – Gestão de Resíduos Perigosos</div>"

        htmlContent &= "<br><br><br>"



        htmlContent &= "<table style=""margin: 0 auto; border-collapse: collapse; width: 80%;"">"
        htmlContent &= "<tr>"
        htmlContent &= "<th style=""border: 1px solid black; height: 20px;"">Resíduo Saúde (RSS)</th>"
        htmlContent &= "<th style=""border: 1px solid black; height: 20px;"">Classe</th>"
        htmlContent &= "<th style=""border: 1px solid black; height: 20px;"">Valor</th>"
        htmlContent &= "</tr>"


        If cbGRUPOA.Checked = True Then
            '------- tabela 01
            htmlContent &= "<br>"


            htmlContent &= "<tr>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;"">Grupo A – Infectantes" & "<br>" & "Subgrupos: A1, A2, A3, A4, A5." & "<br><br>" & "Grupo E – Perfuro Cortantes</td>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;"">I</td>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;""><b>R$ " & TABELA01txtvalor.Text & " reais " & TABELA01cbprazo.SelectedItem.ToString() & "<br>Volume Total:</b> " & TABELA01txtvolumetotal.Text & " " & TABELA01cbvolumetotal.SelectedItem.ToString & "<br>" & "<b>Peso total: </b>" & TABELA01txtpesototal.Text & " " & TABELA01cbpesototal.SelectedItem.ToString() & "<br><br>" & " Valor volume Excedente: R$ " & TABELA01valorvolumeexcedente.Text & "<br>" & "Valor kilo Excedente: R$ " & TABELA01valorkiloexcedente.Text & "</td>"
            htmlContent &= "</tr>"


            '  htmlContent &= "<br>"
            '------- tabela 01
        End If

        If cbGRUPOB.Checked = True Then
            '------- tabela 02
            '  htmlContent &= "<br>"

            htmlContent &= "<tr>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;"">Grupo B – Químicos" & "</td>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;"">I</td>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;""><b>R$ " & TABELA02txtvalor.Text & " reais " & TABELA02cbprazo.SelectedItem.ToString() & "<br>Volume Total:</b> " & TABELA02txtvolumetotal.Text & " " & TABELA02cbvolumetotal.SelectedItem.ToString & "<br>" & "<b>Peso total: </b>" & TABELA02txtpesototal.Text & " " & TABELA02cbpesototal.SelectedItem.ToString() & "<br><br>" & " Valor volume Excedente: R$ " & TABELA02valorvolumeexcedente.Text & "<br>" & "Valor kilo Excedente: R$ " & TABELA02valorkiloexcedente.Text & "</td>"
            htmlContent &= "</tr>"


            '  htmlContent &= "<br>"
            '------- tabela 02
        End If

        If cbGRUPOC.Checked = True Then
            '------- tabela 03
            '  htmlContent &= "<br>"

            htmlContent &= "<tr>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;"">Grupo E – Perfuro Cortantes" & "</td>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;"">I</td>"
            htmlContent &= "<td style=""border: 1px solid black; height: 50px;""><b>R$ " & TABELA03txtvalor.Text & " reais " & TABELA03cbprazo.SelectedItem.ToString() & "<br>Volume Total:</b> " & TABELA03txtvolumetotal.Text & " " & TABELA03cbvolumetotal.SelectedItem.ToString & "<br>" & "<b>Peso total: </b>" & TABELA03txtpesototal.Text & " " & TABELA03cbpesototal.SelectedItem.ToString() & "<br><br>" & " Valor volume Excedente: R$ " & TABELA03valorvolumeexcedente.Text & "<br>" & "Valor kilo Excedente: R$ " & TABELA03valorkiloexcedente.Text & "</td>"
            htmlContent &= "</tr>"


            '  htmlContent &= "<br>"
            '------- tabela 03
        End If

        htmlContent &= "</table>"


        htmlContent &= "<br><br><br>"

        htmlContent &= "<div class=""text-left""><b>*Forma de Pagamento: 20 dias direto, após a Emissão da Nota Fiscal de Prestação de Serviço.</b></div>"

        htmlContent &= "<br><br>"

        htmlContent &= "<div class=""text"">Informações Adicionais</div>"

        htmlContent &= "<br><br>"

        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <b>Efetuado o atendimento, a <u>RioColetas Saúde, emitirá Nota Fiscal, boleto bancário, certidão de disposição final de resíduos</u> pelo Destinador Final e o <u>MTR (manifesto de transporte de resíduos)</u>, documentos estes que darão subsídio para <u>COMPROVAÇÃO junto aos órgãos ambientais e da agencia nacional de vigilância sanitária (ANVISA), da CORRETA DESTINAÇÃO DOS RESÍDUOS.</u></b></div>"

        htmlContent &= "<br>"

        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <b>Frisa-se, por fim, que todos os <u>VEÍCULOS COLETORES</u> da empresa passaram pelo processo de <u>certificação do INMETRO</u>, sendo que os <u>MOTORISTAS foram treinados e certificados pelo curso MOOP (Movimentação de Cargas Perigosas)</u>, e que a empresa possui <u>APÓLICE DE SEGURO PARA TRANSPORTE DE PRODUTOS PERIGOSOS</u>, - Programa de Prevenção dos Riscos Ambientais (PPRA) e Plano de Emergência em caso de acidentes, alvará de funcionamento e do <u>cadastro de atividade potencialmente poluidora junto ao IBAMA</u>.</b></div>"

        htmlContent &= "<br>"

        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <b><u>Possuímos sistema online de Rastreabilidade e Transparência de todo o processo de Coleta, Transporte e Destinação Final</u>.</b></div>"


        htmlContent &= "<script>"
        htmlContent &= "window.onload = function() {"
        htmlContent &= "window.print();"
        htmlContent &= "};"
        htmlContent &= "</script>"

        htmlContent &= "</div>"
        htmlContent &= "<footer><div style=""font-size: 11px;"" >Vidas impactadas geram resultados...</div></footer>"

        htmlContent &= "</body>"
        htmlContent &= "</html>"




        ' Salva o conteúdo HTML em um arquivo
        File.WriteAllText(htmlFilePath, htmlContent)

        ' Abre o arquivo HTML no navegador padrão
        Process.Start(htmlFilePath)


    End Sub




    '------- TABELA01 INICIO
    Private Sub TABELA01txtvalor_Leave(sender As Object, e As EventArgs) Handles TABELA01txtvalor.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA01txtvalor.Text, valor) Then
            TABELA01txtvalor.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA01txtvolumetotal_Leave(sender As Object, e As EventArgs) Handles TABELA01txtvolumetotal.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA01txtvolumetotal.Text, valor) Then
            TABELA01txtvolumetotal.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA01txtpesototal_Leave(sender As Object, e As EventArgs) Handles TABELA01txtpesototal.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA01txtpesototal.Text, valor) Then
            TABELA01txtpesototal.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA01valorvolumeexcedente_Leave(sender As Object, e As EventArgs) Handles TABELA01valorvolumeexcedente.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA01valorvolumeexcedente.Text, valor) Then
            TABELA01valorvolumeexcedente.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA01valorkiloexcedente_Leave(sender As Object, e As EventArgs) Handles TABELA01valorkiloexcedente.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA01valorkiloexcedente.Text, valor) Then
            TABELA01valorkiloexcedente.Text = valor.ToString("0.00")
        End If
    End Sub

    Private Sub TABELA01txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA01txtvalor.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA01txtvalor.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA01txtvolumetotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA01txtvolumetotal.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA01txtvolumetotal.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA01txtpesototal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA01txtpesototal.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA01txtpesototal.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA01valorvolumeexcedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA01valorvolumeexcedente.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA01valorvolumeexcedente.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA01valorkiloexcedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA01valorkiloexcedente.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA01valorkiloexcedente.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    '------- TABELA01 FINAL

    '------- TABELA02 INICIO
    Private Sub TABELA02txtvalor_Leave(sender As Object, e As EventArgs) Handles TABELA02txtvalor.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA02txtvalor.Text, valor) Then
            TABELA02txtvalor.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA02txtvolumetotal_Leave(sender As Object, e As EventArgs) Handles TABELA02txtvolumetotal.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA02txtvolumetotal.Text, valor) Then
            TABELA02txtvolumetotal.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA02txtpesototal_Leave(sender As Object, e As EventArgs) Handles TABELA02txtpesototal.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA02txtpesototal.Text, valor) Then
            TABELA02txtpesototal.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA02valorvolumeexcedente_Leave(sender As Object, e As EventArgs) Handles TABELA02valorvolumeexcedente.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA02valorvolumeexcedente.Text, valor) Then
            TABELA02valorvolumeexcedente.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA02valorkiloexcedente_Leave(sender As Object, e As EventArgs) Handles TABELA02valorkiloexcedente.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA02valorkiloexcedente.Text, valor) Then
            TABELA02valorkiloexcedente.Text = valor.ToString("0.00")
        End If
    End Sub

    Private Sub TABELA02txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA02txtvalor.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA02txtvalor.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA02txtvolumetotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA02txtvolumetotal.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA02txtvolumetotal.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA02txtpesototal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA02txtpesototal.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA02txtpesototal.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA02valorvolumeexcedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA02valorvolumeexcedente.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA02valorvolumeexcedente.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA02valorkiloexcedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA02valorkiloexcedente.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA02valorkiloexcedente.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    '------- TABELA02 FINAL

    '------- TABELA03 INICIO
    Private Sub TABELA03txtvalor_Leave(sender As Object, e As EventArgs) Handles TABELA03txtvalor.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA03txtvalor.Text, valor) Then
            TABELA03txtvalor.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA03txtvolumetotal_Leave(sender As Object, e As EventArgs) Handles TABELA03txtvolumetotal.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA03txtvolumetotal.Text, valor) Then
            TABELA03txtvolumetotal.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA03txtpesototal_Leave(sender As Object, e As EventArgs) Handles TABELA03txtpesototal.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA03txtpesototal.Text, valor) Then
            TABELA03txtpesototal.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA03valorvolumeexcedente_Leave(sender As Object, e As EventArgs) Handles TABELA03valorvolumeexcedente.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA03valorvolumeexcedente.Text, valor) Then
            TABELA03valorvolumeexcedente.Text = valor.ToString("0.00")
        End If
    End Sub
    Private Sub TABELA03valorkiloexcedente_Leave(sender As Object, e As EventArgs) Handles TABELA03valorkiloexcedente.Leave
        Dim valor As Decimal
        If Decimal.TryParse(TABELA03valorkiloexcedente.Text, valor) Then
            TABELA03valorkiloexcedente.Text = valor.ToString("0.00")
        End If
    End Sub

    Private Sub TABELA03txtvalor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA03txtvalor.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA03txtvalor.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA03txtvolumetotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA03txtvolumetotal.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA03txtvolumetotal.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA03txtpesototal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA03txtpesototal.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA03txtpesototal.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA03valorvolumeexcedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA03valorvolumeexcedente.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA03valorvolumeexcedente.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub TABELA03valorkiloexcedente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TABELA03valorkiloexcedente.KeyPress
        ' Permite apenas números, vírgula e teclas de controle
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
        ' Permite apenas uma vírgula
        If e.KeyChar = "," AndAlso TABELA03valorkiloexcedente.Text.Contains(",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub EmitirPropostaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmitirPropostaToolStripMenuItem.Click


        If cbGRUPOA.Checked = False And cbGRUPOB.Checked = False And cbGRUPOC.Checked = False Then
            MsgBox("Para gerar a proposta, pelo menos uma das classes deve estar selecionada!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, TITULOMSGBOX)
            Exit Sub
        Else
            GERARHTML()
        End If
    End Sub

    Private Sub LimparCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparCamposToolStripMenuItem.Click
        If MsgBox("Tem certeza que deseja limpar os campos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, TITULOMSGBOX) = MsgBoxResult.No Then
            Exit Sub
        Else
            LIMPARCAMPOS()
        End If


    End Sub

    Private Sub FRM_Proposta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If fecharcontrato = True Then
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        FRM_INICIAR.Show()
        FRM_INICIAR.ShowInTaskbar = True
        FRM_INICIAR.WindowState = FormWindowState.Normal
        fecharcontrato = True
        Me.Close()
    End Sub
End Class