
'importamos las bibliotecas necesarias para la conexion
Imports System.Data
Imports System.Data.SqlClient
'hola clase data
Public Class daldatos
    'crear variable de conexion
    Dim cin As SqlConnection
    'creamos la funcion ejecutar consulta 
    'donde la sentencia es un  string por referencia
    'y todo es un data set
    'porque en negocios el return de esta funcion va directo a un data set


    Public Function EjecutarConsulta(ByRef Query As String) As DataSet

    
        Try
            'soy un seto desentendido
            Dim seto As New DataSet
            'abrir conexion
            Abrir()
            'hola soy un inadaptado
           
            Dim adapter As New SqlDataAdapter(Query, cin)
            'lleno el adapter con el seto
            adapter.Fill(seto)
            'vacio el adapter(?)
            adapter.Dispose()
            'cerramos la conexion 
            Cerrar()
            'retorna el seto
            Return seto
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Function

        End Try
    End Function
    Public Sub Abrir()
        'hola soy la funcion altanera
        'declaramos la conexion
        Try
            cin = New SqlConnection
            cin.ConnectionString = "Data Source=KAREN-PC\KAREN;Initial Catalog=Campo;Integrated Security=True"
            'cin.ConnectionString = "Data Source=090W8117\SQL_UAI;Initial Catalog=Campo;Integrated Security=True"
            'y la abrimos
            cin.Open()
        Catch ex As Exception
            '  cin.ConnectionString = "Data Source=090W81106\SQL_UAI;Initial Catalog=master;Integrated Security=True"
            '  cin.ConnectionString = "Data Source=090W8117\SQL_UAI;Initial Catalog=Campo;Integrated Security=True"
            MsgBox(ex.ToString)

        End Try
        
    End Sub
    Public Sub Cerrar()
        'hola soy una funcion bajon
        'vaciamos la conexion 
        cin.Dispose()
        'y por si al podrido le falto algo que entender la vaciamos de vuelta.
        cin = Nothing
    End Sub
    Public Sub builder(ByVal query As String, ByVal seto As DataSet)
        'soy un seto desentendido

        'abrir conexion
        Abrir()
        'hola soy un inadaptado
        Dim adapter As New SqlDataAdapter(query, cin)
        'lleno el adapter con el seto
        adapter.Fill(seto)

        'retorna el seto
        'para actualizar base de datos SI O SI
        'creamos el constructor como sqlcommandbuilder del adaptador
        Dim builder As New SqlCommandBuilder(adapter)
        Try
            'inserta comando desde el adapter al builder
            adapter.InsertCommand = builder.GetInsertCommand
            'elimina comando desde el adpater al builder
            adapter.DeleteCommand = builder.GetDeleteCommand
            'modifica comando desde el adapter al builder
            adapter.UpdateCommand = builder.GetUpdateCommand
            'SI O SI PONER ESTO
            'Actualiza adapter desde la celda seleccionada el primer valor de seto
            adapter.Update(seto.Tables(0))
            '        'vacio el adapter(?)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        adapter.Dispose()
        'cerramos la conexion 
        Cerrar()
    End Sub
End Class
