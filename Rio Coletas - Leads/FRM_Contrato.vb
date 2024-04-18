
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OfficeOpenXml.Drawing.Chart
Imports NumerosExtensos
Imports NumerosExtensos.Enums
Imports NumerosExtensos.Options
Imports NumerosExtensos.Options.Numerais
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Windows.Media



Public Class FRM_Contrato

    Public TITULOMSGBOX = FRM_INICIAR.TITULOMSGBOX

    Private fecharcontrato As Boolean = False


    Private Async Sub calculaporcent()

        '-calcula mao de obra %
        If Not String.IsNullOrEmpty(txtcoletaVALORCONTRATO.Text) AndAlso IsNumeric(txtcoletaVALORCONTRATO.Text) Then
            Dim valorTotal As Decimal = Decimal.Parse(txtcoletaVALORCONTRATO.Text)
            If IsNumeric(txtPERCENTUALMAODEOBRA.Value) Then
                Dim percentual As Decimal = Decimal.Parse(txtPERCENTUALMAODEOBRA.Value)
                Dim valorPorcentagem As Decimal = (percentual / 100) * valorTotal
                Dim valorPorcentagemFormatado As String = valorPorcentagem.ToString("C")

                txtvalorMAODEOBRA.Text = "% (" & valorPorcentagemFormatado & ")"
            Else
                txtvalorMAODEOBRA.Text = "% (R$ 0,00)"
            End If
        Else
            txtvalorMAODEOBRA.Text = "% (R$ 0,00)"
        End If
        '-calcula mao de obra %



        '-calcula equipamentos %
        If Not String.IsNullOrEmpty(txtcoletaVALORCONTRATO.Text) AndAlso IsNumeric(txtcoletaVALORCONTRATO.Text) Then
            Dim valorTotal As Decimal = Decimal.Parse(txtcoletaVALORCONTRATO.Text)
            If IsNumeric(txtPERCENTUALEQUIPAMENTOS.Value) Then
                Dim percentual As Decimal = Decimal.Parse(txtPERCENTUALEQUIPAMENTOS.Value)
                Dim valorPorcentagem As Decimal = (percentual / 100) * valorTotal
                Dim valorPorcentagemFormatado As String = valorPorcentagem.ToString("C")

                txtvalorEQUIPAMENTOS.Text = "% (" & valorPorcentagemFormatado & ")"
            Else
                txtvalorEQUIPAMENTOS.Text = "% (R$ 0,00)"
            End If
        Else
            txtvalorEQUIPAMENTOS.Text = "% (R$ 0,00)"
        End If
        '-calcula equipamentos %

    End Sub

    Private Sub FRM_Contrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim diretorio As String = AppDomain.CurrentDomain.BaseDirectory & "\Contratos\"

        If My.Computer.FileSystem.DirectoryExists(diretorio) = False Then
            My.Computer.FileSystem.CreateDirectory(diretorio)
        End If


        Me.Text = TITULOMSGBOX
        cbpesomaximo.SelectedIndex = 0
        cbvolumemaximo.SelectedIndex = 0
        cbSEGMENTO.SelectedIndex = 0
        txtcoletaPERIODO.SelectedIndex = 0


        Dim arquivos As String() = Directory.GetFiles(diretorio)
        Dim quantidadeArquivos As Integer = arquivos.Length
        quantidadeArquivos += 1

        txtNUMEROCONTRATO.Value = quantidadeArquivos

        cbcpfcnpj.SelectedIndex = 0

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtcoletaINICIO.Value = Date.Now.ToString("MM/yyyy")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtOBS.Text = "Caixas 0 L e Sacos 0 L"
    End Sub

    Private Sub EmitirPropostaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmitirPropostaToolStripMenuItem.Click


        If String.IsNullOrEmpty(txtclienteNOME.Text) OrElse
   String.IsNullOrEmpty(txtclienteFANTASIA.Text) OrElse
   Not txtclienteCPF.MaskFull OrElse
   Not txtclienteFONE.MaskFull OrElse
   Not txtclienteWHATSAPP.MaskFull OrElse
   String.IsNullOrEmpty(txtclienteEMAIL.Text) OrElse
   String.IsNullOrEmpty(txtclienteRUA.Text) OrElse
   String.IsNullOrEmpty(txtclienteNUMERO.Text) OrElse
   String.IsNullOrEmpty(txtclienteBAIRRO.Text) OrElse
   Not txtclienteCEP.MaskFull OrElse
   String.IsNullOrEmpty(txtclienteCIDADE.Text) OrElse
   String.IsNullOrEmpty(txtclienteUF.Text) OrElse
   String.IsNullOrEmpty(txtcoletaPESOMAXIMO.Text) OrElse
   String.IsNullOrEmpty(txtcoletaVOLUMEMAXIMO.Text) OrElse
   String.IsNullOrEmpty(txtmtrCODIGO.Text) OrElse
   String.IsNullOrEmpty(txtmtrSENHA.Text) Then


            Dim camposVazios As New List(Of String)

            If String.IsNullOrEmpty(txtclienteNOME.Text) Then
                camposVazios.Add("Nome do Cliente")
            End If

            If String.IsNullOrEmpty(txtclienteFANTASIA.Text) Then
                camposVazios.Add("Nome Fantasia do Cliente")
            End If


            If Not txtclienteCPF.MaskFull Then
                camposVazios.Add("CPF/CNPJ do Cliente")
            End If

            If Not txtclienteFONE.MaskFull Then
                camposVazios.Add("Telefone do Cliente")
            End If

            If Not txtclienteWHATSAPP.MaskFull Then
                camposVazios.Add("WhatsApp do Cliente")
            End If


            If String.IsNullOrEmpty(txtclienteEMAIL.Text) Then
                camposVazios.Add("Email do Cliente")
            End If

            If String.IsNullOrEmpty(txtclienteRUA.Text) Then
                camposVazios.Add("Rua do Cliente")
            End If

            If String.IsNullOrEmpty(txtclienteNUMERO.Text) Then
                camposVazios.Add("Número do Cliente")
            End If

            If String.IsNullOrEmpty(txtclienteBAIRRO.Text) Then
                camposVazios.Add("Bairro do Cliente")
            End If

            If Not txtclienteCEP.MaskFull Then
                camposVazios.Add("CEP do Cliente")
            End If

            If String.IsNullOrEmpty(txtclienteCIDADE.Text) Then
                camposVazios.Add("Cidade do Cliente")
            End If

            If String.IsNullOrEmpty(txtclienteUF.Text) Then
                camposVazios.Add("UF do Cliente")
            End If

            If String.IsNullOrEmpty(txtcoletaPESOMAXIMO.Text) Then
                camposVazios.Add("Peso Máximo da Coleta")
            End If

            If String.IsNullOrEmpty(txtcoletaVOLUMEMAXIMO.Text) Then
                camposVazios.Add("Volume Máximo da Coleta")
            End If

            If String.IsNullOrEmpty(txtmtrCODIGO.Text) Then
                camposVazios.Add("Código MTR")
            End If

            If String.IsNullOrEmpty(txtmtrSENHA.Text) Then
                camposVazios.Add("Senha MTR")
            End If

            If String.IsNullOrEmpty(txtcoletaVALORCONTRATO.Text) Then
                camposVazios.Add("Valor do Contrato")
            End If

            If String.IsNullOrEmpty(txtcoletaVALORVOLUMEEXCEDENTE.Text) Then
                camposVazios.Add("Valor do Volume Excedente")
            End If

            If String.IsNullOrEmpty(txtcoletaVALORKILOEXCEDENTE.Text) Then
                camposVazios.Add("Valor do Kilo Excedente")
            End If




            If camposVazios.Count > 0 Then
                Dim camposVaziosTexto As String = String.Join(Environment.NewLine, camposVazios)
                MsgBox("Os seguintes campos estão vazios:" & vbNewLine & vbNewLine & camposVaziosTexto, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, TITULOMSGBOX)
                Exit Sub
            End If

            Exit Sub
        End If



        GERARHTML()

    End Sub

    Private Async Sub GERARHTML()

        Dim directoryPath As String = AppDomain.CurrentDomain.BaseDirectory & "\Contratos\"


        If My.Computer.FileSystem.DirectoryExists(directoryPath) = False Then
            My.Computer.FileSystem.CreateDirectory(directoryPath)

            If My.Computer.FileSystem.DirectoryExists(directoryPath) = False Then
                Return
            End If

        End If


        Dim htmlFileName As String = txtNUMEROCONTRATO.Value & " - Contrato RioColetas - " & txtclienteNOME.Text & ".html"
        Dim htmlFilePath As String = Path.Combine(directoryPath, htmlFileName)
        Dim imageFilePath As String = Path.Combine(directoryPath, "imagem.png")
        My.Resources.logo_riocoletas.Save(imageFilePath)



        Dim meuNumero As Decimal = txtcoletaVALORCONTRATO.Text
        Dim extenso As New Extenso()
        Dim escrever = extenso.Escrever(OpcoesPredefinidas.Predefinicoes(Predefinicoes.MonetarioBRL))
        Dim numeroPorExtenso As String = escrever.Numero(meuNumero.ToString())

        Dim numero2 As Decimal = txtVALIDADE.Value
        Dim extenso2 As New Extenso()
        Dim escrever2 = extenso2.Escrever(OpcoesPredefinidas.Predefinicoes(Predefinicoes.Nenhum))
        Dim numeroPorExtenso2 As String = escrever2.Numero(numero2.ToString())

        Dim volumevalorexcedente As Decimal = txtcoletaVALORVOLUMEEXCEDENTE.Text
        Dim extensovolumevalorexcedente As New Extenso()
        Dim escrevervolumevalorexcedente = extensovolumevalorexcedente.Escrever(OpcoesPredefinidas.Predefinicoes(Predefinicoes.MonetarioBRL))
        Dim numeroPorExtensoevolumevalorexcedente As String = escrevervolumevalorexcedente.Numero(volumevalorexcedente.ToString())

        Dim kgvalorexcedente As Decimal = txtcoletaVALORKILOEXCEDENTE.Text
        Dim extensokgvalorexcedente As New Extenso()
        Dim escreverkgvalorexcedente = extensokgvalorexcedente.Escrever(OpcoesPredefinidas.Predefinicoes(Predefinicoes.MonetarioBRL))
        Dim numeroPorExtensoekgvalorexcedente As String = escreverkgvalorexcedente.Numero(kgvalorexcedente.ToString())

        Dim htmlContent As String = ""
        htmlContent &= "<!DOCTYPE html>"
        htmlContent &= "<html>"
        htmlContent &= "<head>"
        htmlContent &= "<title>Contrato RioColetas -" & txtclienteNOME.Text & "</title>"
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
        htmlContent &= "<div><b>CONTRATO DE COLETA E DESTINO FINAL DE RESÍDUOS DE <br> SERVIÇOS DE SAÚDE (RSS)</b></div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <b>Contrato Nº " & txtNUMEROCONTRATO.Value & "</b></div>"
        htmlContent &= "<br><br>"
        htmlContent &= "<div class=""text-left""> &nbsp; &nbsp; &nbsp; Pelo presente instrumento particular, de um lado RIOCOLETAS TRANSPORTE E COLETAS DE RESÍDUOS LTDA, Pessoa Jurídica, inscrita no CNPJ 15.191.989/000-35, com sede na cidade de Rio do Sul SC, Rua Duque de Caxias, 331, Bairro Jardim América, HERA SUL TRATAMENTO DE RESÍDUOS LTDA, Pessoa Jurídica, inscrita no CNPJ 07.756.675/0001-04, com sede na cidade de Rio Negrinho SC, Estrada Rin432, 2.200, Bairro Rio Preto, doravante denominadas CONTRATADAS e de outro, Pessoa Jurídica, dados cadastrais abaixo, através do seu representante legal, doravante denominada CONTRATANTE, tem entre si, justo e contratado o seguinte: </div>"


        htmlContent &= "<br><br><br>"

        htmlContent &= "<table border='1' style='width: 100%;'>"

        htmlContent &= "<tr>"
        htmlContent &= "<td colspan='2' style='text-align: left;'>Contratante: " & txtclienteNOME.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Nome Fantasia: " & txtclienteFANTASIA.Text & "</td>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>" & cbcpfcnpj.SelectedItem & ": " & txtclienteCPF.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td colspan='2' style='text-align: left;'>Rua: " & txtclienteRUA.Text & ", Nº " & txtclienteNUMERO.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Bairro: " & txtclienteBAIRRO.Text & "</td>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Cidade: " & txtclienteCIDADE.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>CEP: " & txtclienteCEP.Text & "</td>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Fone: " & txtclienteFONE.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td colspan='2' style='text-align: left;'>Email NF-e: " & txtclienteEMAIL.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Seguimento: " & cbSEGMENTO.SelectedItem & "</td>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Whatsapp: " & txtclienteWHATSAPP.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Período da Coleta: " & txtcoletaPERIODO.SelectedItem & "</td>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Início da Coleta: " & txtcoletaINICIO.Text & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Peso Máximo (Kg): " & txtcoletaPESOMAXIMO.Text & " " & cbpesomaximo.SelectedItem & "</td>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Volume Máximo (litros/volumes): " & txtcoletaVOLUMEMAXIMO.Text & " " & cbvolumemaximo.SelectedItem & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: left;'>Valor Do Contrato: R$" & txtcoletaVALORCONTRATO.Text & " (" & numeroPorExtenso & ")</td>"
        htmlContent &= "<td style='width: 50%; text-align: right+;'>Valor Excedente: R$" & txtcoletaVALORKILOEXCEDENTE.Text & " Kg" & "<br>" & "R$: " & txtcoletaVALORVOLUMEEXCEDENTE.Text & " volume 15 L" & "</td>"
        htmlContent &= "</tr>"


        htmlContent &= "<tr>"
        htmlContent &= "<td style='width: 50%; text-align: right+;'>Senha MTR: " & txtmtrSENHA.Text & "<br>" & "Código MTR: " & txtmtrCODIGO.Text & "</td>"

        Dim obs As String
        If txtOBS.Text = Nothing Then
            obs = "Nenhuma informação adicional!"
        Else
            obs = txtOBS.Text
        End If
        htmlContent &= "<td style='width: 50%; text-align: left;'>Observações: " & obs & "</td>"
        htmlContent &= "</tr>"

        htmlContent &= "</table>"

        htmlContent &= "<br><br>"


        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DO OBJETO, CERTIFICADO E OUTROS DOCUMENTOS </b></div>"
        htmlContent &= "<div style='text-align: justify;'>CLÁUSULA PRIMEIRA: O presente contrato tem por objeto a coleta, transporte externo, tratamento e destinação final adequada de Resíduos de Serviços de Saúde (RSS). A CONTRATADA compromete-se a fornecer o CDF – Certificado de Destinação Final e o MTR – Manifesto Transporte de carga, bem como o fornecimento das Licenças Ambientais de Transporte e de Destinação Final e outros documentos pertinentes aos serviços prestados. Parágrafo único: A CONTRATADA se obriga a prestar os serviços dentro das exigências dos órgãos ambientais federais, estaduais e municipais, com mão-de-obra especializada e qualificada, equipamentos, utensílios, veículos, entre outros, para a competente execução dos serviços.</div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> CLASSIFICAÇÃO DOS RESÍDUOS </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA SEGUNDA: São considerados como Resíduos de Serviços de Saúde (RSS) os seguintes resíduos: GRUPO ''A'' – Resíduos com a possível presença de agentes biológicos que, por suas características de maior virulência ou concentração, podem apresentar risco de infecção. GRUPO ''B'' – Resíduos contendo substâncias químicas que podem apresentar risco à saúde pública ou ao meio ambiente dependendo de suas características de inflamabilidade, corrosividade, reatividade e toxicidade. GRUPO ''E'' – Materiais perfurocortantes ou escarificantes, tais como: lâminas de barbear, agulhas, escalpes, ampolas de vidro, brocas, limas endodônticas, pontas diamantadas, lâminas de bisturi, lancetas, tubos capilares, micropipetas, lâminas e lamínulas, espátulas e todo os utensílios de vidro quebrados no laboratório (pipetas, tubos de coleta sanguínea e placas de petri) e outros similares, que devem estar acondicionados em recipientes de material rígido, adequado para cada tipo de substância química, respeitadas às suas características físico-químicas e seu estado físico de acordo com a NBR 9191, e identificados de acordo com a NBR 7500, da ABNT. Parágrafo Segundo: A CONTRATANTE deverá portar o Plano de Gerenciamento de Resíduos de Serviços de Saúde (PGRSS), assim como treinamento e equipamentos necessários para o correto acondicionamento dos resíduos gerados em função da atividade.</div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DA RESPONSABILIDADE </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA TERCEIRA: É de responsabilidade da CONTRATANTE, a verificação e autenticidade dos resíduos. Bem como, se ocorrer, multas, taxas, impostos, operação de aterro, com relação aos resíduos e seus destinos, quando desrespeitados a classificação de resíduos que regem este contrato. Parágrafo Único: A CONTRATADA é responsável por eventuais danos causados decorrentes da execução da prestação de serviços, desde o momento da coleta, durante o transporte, tratamento e destino final dos resíduos.</div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DOS EMPREGADOS </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA QUARTA: A CONTRATADA suportará integralmente as despesas de alimentação, deslocamento e transporte dos seus empregados, contratados para a execução do presente instrumento, bem como os respectivos riscos. Parágrafo Único: A CONTRATADA fará com que seus empregados trabalhem devidamente uniformizados e protegidos por EPI´s (Equipamento de Proteção Individual) necessários ao trabalho e o risco existente, obedecendo as normas de segurança e medicina do trabalho, alimentação, deslocamento e transporte dos seus empregados, contratados para a execução do presente instrumento, bem como os respectivos riscos. Parágrafo Único: A CONTRATADA fará com que seus empregados trabalhem devidamente uniformizados e protegidos por EPI´s (Equipamento de Proteção Individual) necessários ao trabalho e o risco existente, obedecendo as normas de segurança e medicina do trabalho. </div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> RELAÇÃO DE TRABALHO </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA QUINTA: Declaram as partes que as disposições do presente contrato de prestação de serviço não serão constituídas de relação empregatícia da CONTRATANTE com a CONTRATADA, e vice-versa, ou terceiros que a mesma utilizar para a execução dos serviços, sendo de inteira responsabilidade da CONTRATADA todas as obrigações leais de qualquer natureza, respondendo a mesma, por qualquer responsabilidade em relação aos serviços e a quem executar os mesmos. Parágrafo Único: A CONTRATADA responde de forma exclusiva pelos salários de seus empregados e terceiros contratados para a execução deste, acidentes de trabalho, PIS, FGTS, INSS etc., e quaisquer outros encargos de natureza trabalhista e previdenciária, assumindo, de forma exclusiva, a responsabilidade por qualquer demanda judicial. </div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DA COLETA </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA SEXTA: Para a realização da coleta dos resíduos de saúde, os mesmos deverão estar devidamente acondicionados (material perfurocortantes não podem exceder o limite das caixas conforme NBR 13.853 da ABNT) ou embalados (infectantes em sacos brancos leitosos, conforme NBR 9191 da ABNT) e disponíveis em local de fácil acesso, inclusive de seus veículos coletores permitindo assim, a execução do serviço independente de autorização prévia.</div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DA CORREÇÃO </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA SÉTIMA: Os valores expressos nesse contrato terão a vigência de 12 meses, a contar da data de assinatura do mesmo, sendo que após esse período, será incidido o acréscimo correspondente ao IGP-M do período ou outro índice caso seja constado o desequilíbrio/financeiro do presente contrato.</div>"

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DO PAGAMENTO E COBRANÇA </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA OITAVA: Será emitida uma nota fiscal com boleto bancário, que deverá ser quitado no prazo de 15(quinze) dias após o deslocamento para as coletas dos resíduos. O não pagamento em 07 (sete) dias após o vencimento dará o direito à CONTRATADA de suspender os serviços sem aviso prévio indo automaticamente para cartório. O não pagamento implicará em cobrança de multa e juros. Parágrafo Primeiro: A ausência de resíduos para coleta não exime a CONTRATANTE do pagamento do valor do contrato. Uma vez que gera custos de deslocamento do veículo para a coleta, custos de mão-de-obra e tempo. Parágrafo Segundo: Ocorrendo o não pagamento de duas parcelas o contrato poderá ser cancelado pela contratada a qualquer momento, havendo assim a emissão de Nota Fiscal e Boleto referente à multa rescisória com vencimento para 15 dias. Parágrafo Terceiro: Será fornecido, de acordo com os valores do contrato, os sacos plásticos e as caixas para perfurocortantes. </div>"

        htmlContent &= "<br>"


        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DO PRAZO DO CONTRATO </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁSULA NONA: O prazo da prestação de serviço será de " & txtVALIDADE.Value & " (" & numeroPorExtenso2 & " ) " & "meses. A rescisão do presente contrato antes do término convencionado acima poderá ser solicitada pelo CONTRATANTE, por escrito, cabendo à interessada o pagamento do valor de 02 (duas) mensalidades. Parágrafo Único: Atingida a data de término convencionada nesta cláusula, salvo novo ajuste escrito, passará o contrato a vigorar por prazo indeterminado. </div>"
        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> RETENÇÃO DE IMPOSTO </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁUSULA DÉCIMA: A CONTRATADA e a CONTRATANTE reconhecem e aceitam a retenção, pela CONTRATANTE, do ISSQN, quando a prestação dos serviços forem prestados fora do Munícipio do Contratado, bem como da retenção da contribuição previdenciária devida ao INSS, Observando o art. 121 da Instrução Normativa RFB nº 971/2009, observada ainda a legislação complementar e superveniente. Parágrafo Primeiro: Para tanto, a CONTRATADA declara que sua composição de preços tem a seguinte participação: </div>"

        htmlContent &= "<br>"

        If Not String.IsNullOrEmpty(txtcoletaVALORCONTRATO.Text) AndAlso IsNumeric(txtcoletaVALORCONTRATO.Text) Then
            Dim valorTotal As Decimal = Decimal.Parse(txtcoletaVALORCONTRATO.Text)
            If IsNumeric(txtPERCENTUALMAODEOBRA.Value) Then
                Dim percentual As Decimal = Decimal.Parse(txtPERCENTUALMAODEOBRA.Value)
                Dim valorPorcentagem As Decimal = (percentual / 100) * valorTotal
                Dim valorPorcentagemFormatado As String = valorPorcentagem.ToString("C")
                htmlContent &= "<div style='text-align: justify;'><b> I Percentual relativo à mão-de-obra: " & txtPERCENTUALMAODEOBRA.Value & "% do contrato (" & valorPorcentagemFormatado & ").</b></div>"

            Else
                htmlContent &= "<div style='text-align: justify;'><b> I Percentual relativo à mão-de-obra: " & txtPERCENTUALMAODEOBRA.Value & "% do contrato (R$ 0,00).</b></div>"
            End If
        Else
            htmlContent &= "<div style='text-align: justify;'><b> I Percentual relativo à mão-de-obra: " & txtPERCENTUALMAODEOBRA.Value & "% do contrato (R$ 0,00).</b></div>"
        End If

        If Not String.IsNullOrEmpty(txtcoletaVALORCONTRATO.Text) AndAlso IsNumeric(txtcoletaVALORCONTRATO.Text) Then
            Dim valorTotal As Decimal = Decimal.Parse(txtcoletaVALORCONTRATO.Text)
            If IsNumeric(txtPERCENTUALEQUIPAMENTOS.Value) Then
                Dim percentual As Decimal = Decimal.Parse(txtPERCENTUALEQUIPAMENTOS.Value)
                Dim valorPorcentagem As Decimal = (percentual / 100) * valorTotal
                Dim valorPorcentagemFormatado As String = valorPorcentagem.ToString("C")
                htmlContent &= "<div style='text-align: justify;'><b> II Percentual relativo a equipamentos: " & txtPERCENTUALEQUIPAMENTOS.Value & "% do contrato (" & valorPorcentagemFormatado & ").</b></div>"

            Else
                htmlContent &= "<div style='text-align: justify;'><b> II Percentual relativo a equipamentos: " & txtPERCENTUALEQUIPAMENTOS.Value & "% do contrato (R$ 0,00).</b></div>"
            End If
        Else
            htmlContent &= "<div style='text-align: justify;'><b> II Percentual relativo a equipamentos: " & txtPERCENTUALEQUIPAMENTOS.Value & "% do contrato (R$ 0,00).</b></div>"
        End If

        htmlContent &= "<br>"

        htmlContent &= "<div style='text-align: justify;'> Parágrafo Segundo: Durante o prazo de vigência do presente Contrato, se houver qualquer alteração na legislação brasileira que venha a majorar ou diminuir os ônus das Partes contratantes, os valores ora contratados serão revistos, a fim de adequá-los às modificações havidas, compensando-se qualquer diferença decorrente dessas alterações, tais como:</div>"

        htmlContent &= "<div style='text-align: justify;'> I.	Criação de novos tributos, taxas, contribuições;</div>"
        htmlContent &= "<div style='text-align: justify;'> II.	Extinção de tributos, taxas e contribuições existentes;</div>"
        htmlContent &= "<div style='text-align: justify;'> III.	Alteração de alíquotas e;</div>"
        htmlContent &= "<div style='text-align: justify;'> IV.	Alteração de bases de cálculo. </div>"

        htmlContent &= "<br>"


        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> VALOR DO CONTRATO </b></div>"
        htmlContent &= "<div style='text-align: justify;'> CLÁSULA DÉCIMA PRIMEIRA: A CONTRATANTE está ciente que o valor do serviço contratado será de <b>R$ " & txtcoletaVALORCONTRATO.Text & " (" & numeroPorExtenso & ") mais impostos (ISS)</b> conforme alíquota do município e o pagamento ocorrerá " & txtcoletaPERIODO.SelectedItem & ", mesmo na ausência dos resíduos, com limite de coleta de <b>" & txtlimiteLITROS.Value & " litro(s) ou " & txtlimiteKG.Value & " kilo(s). E cobrado R$ " & txtcoletaVALORVOLUMEEXCEDENTE.Text & " (" & numeroPorExtensoevolumevalorexcedente & ") o Kg do valor excedente ou  R$ " & txtcoletaVALORKILOEXCEDENTE.Text & " (" & numeroPorExtensoekgvalorexcedente & ") a cada 15 litros excedente.</b></div>"
        htmlContent &= "<div style='text-align: justify;'> </div>"

        htmlContent &= "<br>"


        htmlContent &= "<div style='text-align: justify;'> &nbsp; &nbsp;<b> DA EXISTÊNCIA DO FORO </b></div>"
        htmlContent &= "<div style='text-align: justify;'>CLAUSULA DÉCIMA SEGUNDA: As partes autorizam, expressamente, a outra parte a dar conhecimento da existência do presente contrato aos Órgãos Ambientais competentes para fiscalizar, tanto quanto sua alteração, modificação, suspensão e ou encerramento. </div>"
        htmlContent &= "<div style='text-align: justify;'> Para dirimir qualquer dúvida que venha ocorrer com relação a este contrato, as partes elegem o Foro da Comarca de Rio do Sul-SC, renunciando a qualquer outro por mais especial que seja.</div>"
        htmlContent &= "<div style='text-align: justify;'> E, por sim estarem em pleno acordo em tudo quando neste instrumento particular foi lavrado, datam e assinam em duas vias de igual teor, com duas testemunhas para que reproduzam os efeitos legais e jurídicos.</div>"

        htmlContent &= "<br><br><br>"

        Dim culture As New CultureInfo("pt-BR")
        htmlContent &= "<div class=""text-right"">Timbó, " & Date.Now.ToString("dd 'de' MMMM 'de' yyyy", culture) & "</div>"
        htmlContent &= "<br><br><br><br><br><br><br><br><br><br><br><br><br>"



        htmlContent &= "<div style=""width: 100%;"">"
        htmlContent &= "<div style=""width: 50%; float: left; text-align: center;"">"
        htmlContent &= "<hr style=""border: none; border-top: 2px solid black; width: 70%;""><br>"
        htmlContent &= "<span style=""position:relative; bottom: 5px;"">Cliente: " & txtclienteNOME.Text & " <br> " & txtclienteCPF.Text & "</span>"
        htmlContent &= "</div>"
        htmlContent &= "<div style=""width: 50%; float: right; text-align: center;"">"
        htmlContent &= "<hr style=""border: none; border-top: 2px solid black; width: 70%;""><br>"
        htmlContent &= "<span style=""position:relative; bottom: 5px;"">RioColetas Transporte e Coleta de Residuos LTDA <br> 15.191.989/000-35.</span>"
        htmlContent &= "</div>"
        htmlContent &= "<div style=""clear: both;""></div>"
        htmlContent &= "</div>"

        htmlContent &= "<br><br><br><br><br><br><br><br><br><br><br><br><br>"



        htmlContent &= "<div style=""width: 100%;"">"
        htmlContent &= "<div style=""width: 50%; float: left; text-align: center;"">"
        htmlContent &= "<hr style=""border: none; border-top: 2px solid black; width: 70%;""><br>"
        htmlContent &= "<span style=""position:relative; bottom: 5px;"">Testemunha I</span>"
        htmlContent &= "</div>"
        htmlContent &= "<div style=""width: 50%; float: right; text-align: center;"">"
        htmlContent &= "<hr style=""border: none; border-top: 2px solid black; width: 70%;""><br>"
        htmlContent &= "<span style=""position:relative; bottom: 5px;"">Testemunha II</span>"
        htmlContent &= "</div>"
        htmlContent &= "<div style=""clear: both;""></div>"
        htmlContent &= "</div>"

        htmlContent &= "<br><br><br><br>"

        htmlContent &= "<div style=""width: 100%;"">"
        htmlContent &= "<div style=""width: 50%; float: left;"">"
        htmlContent &= "CPF: ________________________<br>"
        htmlContent &= "</div>"
        htmlContent &= "<div style=""width: 50%; float: right;"">"
        htmlContent &= "CPF: ________________________<br>"
        htmlContent &= "</div>"
        htmlContent &= "<div style=""clear: both;""></div>"
        htmlContent &= "</div>"



        htmlContent &= "<script>"
        htmlContent &= "window.onload = function() {"
        htmlContent &= "window.print();"
        htmlContent &= "};"
        htmlContent &= "</script>"

        htmlContent &= "</div>"

        htmlContent &= "</body>"
        htmlContent &= "</html>"




        ' Salva o conteúdo HTML em um arquivo
        File.WriteAllText(htmlFilePath, htmlContent)

        ' Abre o arquivo HTML no navegador padrão
        Process.Start(htmlFilePath)
    End Sub

    Private Async Sub txtcoletaVALORCONTRATO_Leave(sender As Object, e As EventArgs) Handles txtcoletaVALORCONTRATO.Leave
        Dim valor As Decimal
        If Decimal.TryParse(txtcoletaVALORCONTRATO.Text, valor) Then
            txtcoletaVALORCONTRATO.Text = valor.ToString("N2")
        End If

        calculaporcent()
    End Sub

    Private Sub txtcoletaVALORVOLUMEEXCEDENTE_Leave(sender As Object, e As EventArgs) Handles txtcoletaVALORVOLUMEEXCEDENTE.Leave
        Dim valor As Decimal
        If Decimal.TryParse(txtcoletaVALORVOLUMEEXCEDENTE.Text, valor) Then
            txtcoletaVALORVOLUMEEXCEDENTE.Text = valor.ToString("N2")
        End If
    End Sub

    Private Sub txtcoletaVALORKILOEXCEDENTE_Leave(sender As Object, e As EventArgs) Handles txtcoletaVALORKILOEXCEDENTE.Leave
        Dim valor As Decimal
        If Decimal.TryParse(txtcoletaVALORKILOEXCEDENTE.Text, valor) Then
            txtcoletaVALORKILOEXCEDENTE.Text = valor.ToString("N2")
        End If
    End Sub

    Private Sub txtPERCENTUALMAODEOBRA_ValueChanged(sender As Object, e As EventArgs) Handles txtPERCENTUALMAODEOBRA.ValueChanged
        calculaporcent()

    End Sub

    Private Sub txtPERCENTUALEQUIPAMENTOS_ValueChanged(sender As Object, e As EventArgs) Handles txtPERCENTUALEQUIPAMENTOS.ValueChanged
        calculaporcent()
    End Sub

    Private Sub txtclienteCEP_Leave(sender As Object, e As EventArgs) Handles txtclienteCEP.Leave

        Try
            '   https://api.brasilaberto.com/v1/zipcode/

            Dim cep As String = txtclienteCEP.Text
            ' URL da API para consultar o CEP
            Dim apiUrl As String = "https://api.brasilaberto.com/v1/zipcode/" & cep

            ' Crie uma instância do HttpClient
            Using httpClient As New HttpClient()
                ' Envie uma solicitação GET para a API e obtenha a resposta
                Dim jsonResponse As String = httpClient.GetStringAsync(apiUrl).Result

                ' Desserializar a resposta JSON e extrair o nome da cidade
                Dim city As String = JObject.Parse(jsonResponse)("result")("city").ToString()
                Dim uf As String = JObject.Parse(jsonResponse)("result")("stateShortname").ToString


                txtclienteCIDADE.Text = city
                txtclienteUF.Text = uf
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtclienteNUMERO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclienteNUMERO.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcoletaVALORCONTRATO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoletaVALORCONTRATO.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtcoletaVALORVOLUMEEXCEDENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoletaVALORVOLUMEEXCEDENTE.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcoletaVALORKILOEXCEDENTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoletaVALORKILOEXCEDENTE.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcoletaVOLUMEMAXIMO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoletaVOLUMEMAXIMO.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcoletaPESOMAXIMO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoletaPESOMAXIMO.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> ","c) AndAlso (e.KeyChar <> Convert.ToChar(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub LimparCamposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparCamposToolStripMenuItem.Click

        If MsgBox("Tem certeza que deseja limpar os campos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TITULOMSGBOX) = MsgBoxResult.Yes Then
            LimparCampos()
        Else
            Exit Sub
        End If





    End Sub

    Private Sub LimparCampos()
        txtclienteNOME.Text = Nothing
        txtclienteCPF.Text = Nothing
        txtclienteFONE.Text = Nothing
        txtclienteWHATSAPP.Text = Nothing
        txtclienteEMAIL.Text = Nothing
        txtclienteRUA.Text = Nothing
        txtclienteNUMERO.Text = Nothing
        txtclienteBAIRRO.Text = Nothing
        txtclienteCEP.Text = Nothing
        txtclienteCIDADE.Text = Nothing
        txtclienteUF.Text = Nothing
        txtcoletaPESOMAXIMO.Text = Nothing
        txtcoletaVOLUMEMAXIMO.Text = Nothing
        txtmtrCODIGO.Text = Nothing
        txtmtrSENHA.Text = Nothing
        txtcoletaVALORCONTRATO.Text = Nothing
        txtcoletaVALORVOLUMEEXCEDENTE.Text = Nothing
        txtcoletaVALORKILOEXCEDENTE.Text = Nothing

        cbSEGMENTO.SelectedIndex = 0
        txtclienteFANTASIA.Text = Nothing
        txtcoletaPERIODO.SelectedIndex = 0
        txtcoletaINICIO.Value = Date.Now.ToString("MM/yyyy")

        cbcpfcnpj.SelectedIndex = 0

        txtcoletaVALORCONTRATO.Text = "0,00"
        txtcoletaVALORVOLUMEEXCEDENTE.Text = "0,00"
        txtcoletaVALORKILOEXCEDENTE.Text = "0,00"

        txtOBS.Text = Nothing
        txtVALIDADE.Value = 24
        txtPERCENTUALMAODEOBRA.Value = 20
        txtPERCENTUALEQUIPAMENTOS.Value = 80
        txtlimiteLITROS.Value = 60
        txtlimiteKG.Value = 10


    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click

        FRM_INICIAR.Show()
        FRM_INICIAR.ShowInTaskbar = True
        FRM_INICIAR.WindowState = FormWindowState.Normal
        fecharcontrato = True
        Me.Close()
    End Sub

    Private Sub FRM_Contrato_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If fecharcontrato = True Then
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub AsdasdasdasdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsdasdasdasdToolStripMenuItem.Click
        txtclienteNOME.Text = "TESTE"
        txtclienteCPF.Text = "10234499940"
        txtclienteFONE.Text = "4733827005"
        txtclienteWHATSAPP.Text = "47992922182"
        txtclienteEMAIL.Text = "TESTE"
        txtclienteRUA.Text = "TESTE"
        txtclienteNUMERO.Text = "TESTE"
        txtclienteBAIRRO.Text = "TESTE"
        txtclienteCEP.Text = "89120000"
        txtclienteCIDADE.Text = "TESTE"
        txtclienteUF.Text = "TESTE"
        txtcoletaPESOMAXIMO.Text = "TESTE"
        txtcoletaVOLUMEMAXIMO.Text = "TESTE"
        txtmtrCODIGO.Text = "TESTE"
        txtmtrSENHA.Text = "TESTE"
        txtcoletaVALORCONTRATO.Text = "TESTE"
        txtcoletaVALORVOLUMEEXCEDENTE.Text = "TESTE"
        txtcoletaVALORKILOEXCEDENTE.Text = "TESTE"

        cbSEGMENTO.SelectedIndex = 0
        txtclienteFANTASIA.Text = "TESTE"
        txtcoletaPERIODO.SelectedIndex = 0
        txtcoletaINICIO.Value = Date.Now.ToString("MM/yyyy")

        txtcoletaVALORCONTRATO.Text = "120,00"
        txtcoletaVALORVOLUMEEXCEDENTE.Text = "12,00"
        txtcoletaVALORKILOEXCEDENTE.Text = "12,00"

        txtOBS.Text = "TESTE"
        txtVALIDADE.Value = 24
        txtPERCENTUALMAODEOBRA.Value = 20
        txtPERCENTUALEQUIPAMENTOS.Value = 80
        txtlimiteLITROS.Value = 60
        txtlimiteKG.Value = 10
    End Sub

    Private Sub cbcpfcnpj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcpfcnpj.SelectedIndexChanged

        If cbcpfcnpj.SelectedItem = "CPF" Then
            txtclienteCPF.Mask = "000,000,000-00"
        ElseIf cbcpfcnpj.SelectedItem = "CNPJ" Then
            txtclienteCPF.Mask = "00,000,000/0000-00"


        End If


    End Sub

    Private Sub txtclienteCEP_Enter(sender As Object, e As EventArgs) Handles txtclienteCEP.Enter
        txtclienteCEP.SelectAll()
    End Sub

    Private Sub txtclienteCPF_Enter(sender As Object, e As EventArgs) Handles txtclienteCPF.Enter
        txtclienteCPF.SelectAll()

    End Sub

    Private Sub txtclienteFONE_Enter(sender As Object, e As EventArgs) Handles txtclienteFONE.Enter

        txtclienteFONE.SelectAll()
    End Sub

    Private Sub cbSEGMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSEGMENTO.SelectedIndexChanged

    End Sub
End Class