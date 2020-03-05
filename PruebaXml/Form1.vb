Imports System.Xml

'Ejemplo de como leer un archivo XML

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'En esta función leemos el archivo como texto plano
    Private Sub btnLeerXML_Click(sender As Object, e As EventArgs) Handles btnLeerXML.Click
        Dim lectorXML As New XmlTextReader("C:\Users\redViti\source\repos\PruebaXml\Autores.xml")
        While lectorXML.Read()
            'XMLReader distinge entre nodo, contenido del nodo y elemento final
            Select Case lectorXML.NodeType
                Case XmlNodeType.Element 'nodo
                    tbSalidaXML.Text = tbSalidaXML.Text + "<" + lectorXML.Name & ">\n"
                    Exit Select
                Case XmlNodeType.Text 'contenido del nodo
                    tbSalidaXML.Text = tbSalidaXML.Text + lectorXML.Value
                    Exit Select
                Case XmlNodeType.EndElement 'elemento final
                    tbSalidaXML.Text = tbSalidaXML.Text + ""
                    Exit Select
            End Select
        End While
    End Sub

    'En esta función utilizamos XmlDocument para cargar el documento XML, elegir los nodos que queremos leer,
    'recorrer la lista y mostrarlo en un DataGridView
    Private Sub btnMostrarEsquema_Click(sender As Object, e As EventArgs) Handles btnMostrarEsquema.Click
        Dim documentoXML = New XmlDocument()  'Guarda el doxumento XML
        Dim listaNodos As XmlNodeList 'Guarda la lista de nodos que quermos recorrer
        Dim nodo As XmlNode 'Guarda un nodo concreto
        Dim cont As Integer
        Dim cont1 As Integer
        documentoXML.Load("C:\Users\redViti\source\repos\PruebaXml\Autores.xml") 'Cargamos el archivo XML
        listaNodos = documentoXML.SelectNodes("/Authors_Table/authors") 'Seleccionmaos la lista de nodos
        For cont = 0 To listaNodos.Count() - 1 'Recorremos la lista de nodos
            nodo = listaNodos.Item(cont) 'Cojemos el nodo que nos interesa
            ListadoNodos.Rows.Add() 'Creamos una nueva fila en el DataGridView
            For cont1 = 0 To 8
                'Recorremos los elementos que forman el nodo y mostramos sus contenido
                ListadoNodos.Rows(cont).Cells(cont1).Value = nodo.ChildNodes.Item(cont1).InnerText
            Next

        Next


    End Sub
End Class
