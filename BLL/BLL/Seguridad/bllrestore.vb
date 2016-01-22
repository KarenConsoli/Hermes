Imports DAL
Public Class bllrestore
    Private _partes As Integer
    Public Property partes As Integer
        Get
            Return _partes
        End Get
        Set(ByVal value As Integer)
            _partes = value
        End Set
    End Property

    Shared Function ejecutar_restore(ByVal destino As List(Of String)) As Boolean
        'data para elazar con capa datos
        Dim data As New daldatos
        Dim boolito As Boolean
        Dim seto As New DataSet
        'consulta para hacer el backup
        Dim restore_consulta As String

        'si la cantidad de partes es = 1
            '    'si no existe una base llamada "Campo" 
            '    restore_consulta =  "RESTORE DATABASE [campo] FROM  DISK = N'" & destino(0) & "' "
            'End If

            ''si no existe una base llamada "Campo" 
            'restore_consulta = "RESTORE DATABASE [campo] FROM  DISK = N'" & destino(0) & "' "


            'For i As Integer = 0 To destino.Count - 1
            '    restore_consulta += String.Concat(",DISK = N'" & destino(i) & "'")


            'Next
            'restore_consulta += String.Concat(" WITH  FILE = 1,  NOUNLOAD,  STATS = 5")

            If destino.Count = 1 Then
                'si no existe una base llamada "Campo" 
                restore_consulta = "IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Campo') " & _
                                    "CREATE DATABASE [Campo] " & _
                                        "USE master " & _
                                            "ALTER DATABASE Campo SET SINGLE_USER WITH ROLLBACK IMMEDIATE " & _
                                                "RESTORE DATABASE Campo FROM DISK='" & destino.Item(0) & "' WITH REPLACE " & _
                                                    "ALTER DATABASE Campo SET MULTI_USER"
            Else
                restore_consulta = "IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Campo') " & _
                                    "CREATE DATABASE [Campo] " & _
                                        "USE master " & _
                                            "ALTER DATABASE Campo SET SINGLE_USER WITH ROLLBACK IMMEDIATE " & _
                                                "RESTORE DATABASE Campo FROM DISK='" & destino.Item(0) & "'"

                For Each ruta As String In destino
                    If Not ruta = destino.Item(0) Then
                        restore_consulta += String.Concat(", DISK = '" & ruta & "'")
                    End If
                Next
            End If


            Try
                seto = data.EjecutarConsulta(restore_consulta)
                MsgBox("Restore Realizado con Éxito")
                boolito = True
            Catch ex As Exception
                Return MsgBox("Seleccione todas las partes del Backup")
                boolito = False
            End Try


            Return boolito

    End Function
End Class
