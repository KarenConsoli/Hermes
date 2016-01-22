Imports DAL
Public Class bllbackup


    Shared Function crear_backup(ByVal destino As String, ByVal partes As Integer) As Boolean
        Dim data As New daldatos
        'como se llaman las partes que se van a guardar
        Dim fecha_hoy As Date = Today.Date
        'convertirlo a string para guardarlo como parte del nombre del backup
        Dim fecha_cadena As String
        Dim boolito As Boolean
        fecha_cadena = fecha_hoy.ToString("dd-MM-yyyy")
        'consulta para hacer el backup
        Dim backup_consulta As String
        'si la cantidad de partes es = 1
        If partes = 1 Then
            'se hace consulta
            backup_consulta = "BACKUP DATABASE campo TO DISK = '" & destino & "\Hermes-" & fecha_cadena & ".bak'"
        Else
            backup_consulta = "BACKUP DATABASE campo TO DISK = '" & destino & "\HermesParte01-" & fecha_cadena & ".bak'"

            For i As Integer = 1 To partes - 1
                ' se declara un string parte para poder guardarlo en la consulta backup
                Dim Parte As String = "Parte" & (i + 1).ToString("00")
                ' se concatena la consulta con las partes
                backup_consulta += String.Concat(", DISK = '" & destino & "\Hermes" & Parte & "-" & fecha_cadena & ".bak'")
            Next
        End If
        Try
            data.EjecutarConsulta(backup_consulta)
            boolito = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            boolito = False

        End Try


        Return boolito


    End Function
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

        'Dim consulta As String = "alter database 'campo' set offline"
        'data.EjecutarConsulta("consulta")
        'si la cantidad de partes es = 1
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
            restore_consulta += String.Concat(" WITH REPLACE " & _
                                                "ALTER DATABASE Campo SET MULTI_USER")
        End If


        Try
            seto = data.EjecutarConsulta(restore_consulta)
            MsgBox("Restore Realizado con Éxito")
            boolito = True
            ' consulta = "alter database 'campo' set online"
            ' data.EjecutarConsulta("consulta")
        Catch ex As Exception
            Return MsgBox("Seleccione todas las partes del Backup")
            boolito = False
        End Try


        Return boolito

    End Function
End Class
