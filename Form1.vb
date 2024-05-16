Imports System.Buffers
Imports System.IO
Imports System.Linq.Expressions
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Dim ruta As String = "C:\Users\Cronwell\Desktop\"
    Dim openFileDialog1 As New OpenFileDialog()
    Dim fileReader As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
        openFileDialog1.InitialDirectory = ruta
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBox1.Text = openFileDialog1.FileName()
        End If

        Try
            fileReader = My.Computer.FileSystem.ReadAllText(TextBox1.Text)
        Catch ex As Exception
            Return
        End Try

        Compilador(fileReader)

    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop
        'TextBox1.Text = e.Data.GetData(DataFormats.Text)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Limpiar()
            MyFiles = e.Data.GetData(DataFormats.FileDrop)

            Me.TextBox1.Text = MyFiles(0)

            fileReader = My.Computer.FileSystem.ReadAllText(TextBox1.Text)

            Compilador(fileReader)

        End If
    End Sub

    Private Sub Compilador(RutaArchivo As String)
        Dim regularExpresion As String = "([^\n]+)"
        Dim regex As Regex = New Regex(regularExpresion)
        fileReader = My.Computer.FileSystem.ReadAllText(TextBox1.Text)
        Dim match As MatchCollection = Regex.Matches(fileReader, regularExpresion)
        Dim listaFilas As New ArrayList
        Dim listaVariables As New ArrayList
        Dim listaTerminales As New ArrayList
        Dim listaProducciones As New ArrayList
        Dim listaProduccionesRecursivas As New ArrayList
        Dim variable As String = ""
        Dim produccion As String
        Dim listaVariablesUnicas As New ArrayList
        Dim listaTerminalesUnicas As New ArrayList

        'Agregamos las filas a una lista separada por salto de linea
        For Each m As Match In match
            For Each c As Capture In m.Captures
                listaFilas.Add(c.Value)
                Me.DataGridView1.Rows.Add(c.Value)
            Next
        Next

        'Buscamos las variables al inicio de cada fila
        For Each item As String In listaFilas
            'Buscamos en la fila todas las variables
            regularExpresion = "(.+\=)"
            match = Regex.Matches(item, regularExpresion)
            For Each m As Match In match
                For Each c As Capture In m.Captures
                    listaVariables.Add(c.Value.Replace("=", ""))
                    variable = c.Value
                Next
            Next

            'Buscamos en la fila todos las terminales las cuales se encuentran entre comillas simples
            regularExpresion = "('[^A-Z']+')"
            match = Regex.Matches(item, regularExpresion)

            For Each m As Match In match
                For Each c As Capture In m.Captures
                    'Enabled caso de que se encuentre la letra e entre comillas sera excluida como la cadena vacia
                    If c.Value.Contains("'e'") Then
                        listaTerminales.Add(c.Value.Replace("'", ""))
                    Else
                        listaTerminales.Add(c.Value)
                    End If
                Next
            Next

            'Buscamos todas las producciones de la fila.
            regularExpresion = "(\=\s?|\|\s?)('[^A-Z'|]+'|[A-Z]\d?|e)+"
            match = Regex.Matches(item, regularExpresion)
            For Each m As Match In match
                For Each c As Capture In m.Captures
                    produccion = c.Value.Replace("=", "").Replace("|", "").Replace("'e'", "e")
                    listaProducciones.Add(produccion)
                    Me.DataGridView4.Rows.Add(variable.Replace("=", ""), c.Value.Replace("=", "").Replace("|", "").Replace("'e'", "e"))
                    Me.DataGridView16.Rows.Add(variable & c.Value.Replace("=", "").Replace("|", "").Replace("'e'", "e"))
                    listaProduccionesRecursivas.Add(variable & produccion)
                Next
            Next
        Next

        'Agregamos a una lista solo las variables no duplicadas
        For Each varItem In listaVariables
            If Not (listaVariablesUnicas.Contains(varItem)) Then
                listaVariablesUnicas.Add(varItem)
                Me.DataGridView2.Rows.Add(varItem)
            End If
        Next

        'Agregamos a una lista las terminales no duplicadas
        For Each item In listaTerminales
            If Not (listaTerminalesUnicas.Contains(item)) Then
                If Not item.Contains("e") Then
                    listaTerminalesUnicas.Add(item)
                    Me.DataGridView3.Rows.Add(item)
                End If
            End If
        Next

        'Eliminamos la recursividad
        QuitarRecursividad(listaVariablesUnicas, listaProduccionesRecursivas)
    End Sub

    Private Sub QuitarRecursividad(ByVal listaVariables As ArrayList, ByVal listaProducciones As ArrayList)
        Dim finRecursiva As New ArrayList
        'Recorrido de todas las variables unicas
        For Each variable As String In listaVariables
            Dim recursiva As Boolean = False
            Dim ambigua As Boolean = True
            Dim varRecursiva As New ArrayList
            Dim modRecursiva As New ArrayList

            Dim varLen As Integer = variable.Length
            Dim proLen As Integer = 0
            Dim regularExpresion As String = "([^\n]+)"
            Dim re As String = ""
            Dim re2 As String = ""
            Dim re3 As String = ""
            Dim regex As Regex = New Regex(regularExpresion)
            Dim match As MatchCollection = Regex.Matches(fileReader, regularExpresion)
            Dim match2 As MatchCollection
            Dim match3 As Match
            Dim match4 As Match
            varRecursiva.Clear()

            'Recorrido de todas las producciones validas
            For Each produccion As String In listaProducciones

                'Validamos que las producciones comienzen con las variables
                regularExpresion = "(.+\=)"
                match = Regex.Matches(produccion, regularExpresion)
                For Each m As Match In match
                    For Each c As Capture In m.Captures

                        Dim valor As String = c.Value.Replace("=", "")

                        If valor = variable Then
                            re = "(\=\s?|\|\s?)('[^A-Z'|]+'|[A-Z]\d?|e)+"
                            match2 = Regex.Matches(produccion, re)

                            For Each m2 As Match In match2
                                For Each c2 As Capture In m2.Captures

                                    Dim Valor2 As String = c2.Value.Replace("=", "")

                                    re2 = "^[A-Z]\d?"

                                    match3 = Regex.Match(Valor2, re2)

                                    If match3.Success Then
                                        If variable.Length <= match3.Value.Length Then
                                            If variable = match3.Value Then
                                                recursiva = True
                                            End If
                                        End If
                                    End If
                                Next
                            Next
                            varRecursiva.Add(produccion)
                        End If
                    Next
                Next
            Next

            If recursiva = True Then
                For Each varRecur As String In varRecursiva
                    re2 = "=([A-Z]\d?)$"
                    match3 = Regex.Match(varRecur, re2)

                    If match3.Success Then
                        ambigua = False
                    End If

                Next

                If ambigua = False Then
                    Dim variableRecursiva As String = ""
                    Dim listRecursiva As New ArrayList

                    For Each varRecur As String In varRecursiva

                        re = "(.+\=)"
                        match3 = Regex.Match(varRecur, re)

                        If match3.Success Then
                            variableRecursiva = match3.Value
                        End If

                        re = ("(\=\s?|\|\s?)('[^A-Z'|]+'|[A-Z]\d?|e)+")
                        match = Regex.Matches(varRecur, re)


                        For Each m As Match In match
                            For Each c As Capture In m.Captures
                                re3 = ("^=([A-Z]\d?)$")
                                match4 = Regex.Match(c.Value, re3)

                                If match4.Success Then
                                    modRecursiva.Add(variableRecursiva.Replace("=", "") & c.Value.Replace(variableRecursiva.Replace("=", ""), "") & variableRecursiva.Replace("=", "'"))
                                Else
                                    modRecursiva.Add(variableRecursiva.Replace("=", "'") & c.Value.Replace(variableRecursiva.Replace("=", ""), "") & variableRecursiva.Replace("=", "'"))
                                End If

                            Next
                        Next

                    Next

                    modRecursiva.Add(variableRecursiva.Replace("=", "'=") & "'e'")

                    For Each varRecur As String In modRecursiva
                        'Me.DataGridView16.Rows.Add(varRecur)
                        finRecursiva.Add(varRecur)
                    Next
                    modRecursiva.Clear()
                Else
                    For Each varRecur As String In varRecursiva
                        'Me.DataGridView15.Rows.Add(varRecur)
                        finRecursiva.Add(varRecur)
                    Next
                End If

            Else
                For Each varRecur As String In varRecursiva
                    'Me.DataGridView15.Rows.Add(varRecur)
                    finRecursiva.Add(varRecur)
                Next
            End If
        Next

        sinRecursividad(finRecursiva)

    End Sub

    Private Sub sinRecursividad(ByVal listaVariables As ArrayList)
        Dim listVarRec As New ArrayList
        Dim listProdRec As New ArrayList
        Dim regularExpresion As String
        Dim match As MatchCollection
        Dim listaTerminales As New ArrayList
        Dim listaTerminalesUnicas As New ArrayList

        For Each varRecur As String In listaVariables
            Dim lista As String() = varRecur.Split("="c)
            listProdRec.Add(lista(1).ToString)
            Me.DataGridView13.Rows.Add(lista(0), lista(1).ToString.Replace("'e'", "e"))


            If Not (listVarRec.Contains(lista(0).ToString)) Then
                listVarRec.Add(lista(0).ToString)
                Me.DataGridView15.Rows.Add(lista(0).ToString)
            End If

        Next


        For Each varRecur As String In listProdRec
            'If Not (listProdRec.Contains(lista(1).ToString)) Then
            '    listProdRec.Add(lista(1).ToString)
            '    Me.DataGridView14.Rows.Add(lista(1).ToString)
            'End If

            'Buscamos en la fila todos las terminales las cuales se encuentran entre comillas simples
            regularExpresion = "('[^A-Z']+')"
            match = Regex.Matches(varRecur, regularExpresion)

            For Each m As Match In Match
                For Each c As Capture In m.Captures
                    'Enabled caso de que se encuentre la letra e entre comillas sera excluida como la cadena vacia
                    If c.Value.Contains("'e'") Then
                        listaTerminales.Add(c.Value.Replace("'", ""))
                    Else
                        listaTerminales.Add(c.Value)
                    End If
                Next
            Next
        Next

        For Each item In listaTerminales
            If Not (listaTerminalesUnicas.Contains(item)) Then
                If Not item.Contains("e") Then
                    listaTerminalesUnicas.Add(item)
                    Me.DataGridView14.Rows.Add(item)
                End If
            End If
        Next

    End Sub

    Private Sub Limpiar()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView2.Rows.Clear()
        Me.DataGridView3.Rows.Clear()
        Me.DataGridView4.Rows.Clear()
        Me.DataGridView6.Rows.Clear()
        Me.DataGridView7.Rows.Clear()
        Me.DataGridView10.Rows.Clear()
        Me.DataGridView11.Rows.Clear()
        Me.DataGridView13.Rows.Clear()
        Me.DataGridView14.Rows.Clear()
        Me.DataGridView15.Rows.Clear()
        Me.DataGridView16.Rows.Clear()
        Me.TextBox1.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '242, 242, 242 Gris
        '255, 255, 153 Amarillo
        '66, 148, 182 Azul
        '44, 182, 99 Verde

        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Label1.ForeColor = Color.FromArgb(66, 148, 182)
        Label2.ForeColor = Color.FromArgb(66, 148, 182)
        Label3.ForeColor = Color.FromArgb(66, 148, 182)
        Label4.ForeColor = Color.FromArgb(66, 148, 182)
        Label5.ForeColor = Color.FromArgb(66, 148, 182)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar()
    End Sub
End Class
