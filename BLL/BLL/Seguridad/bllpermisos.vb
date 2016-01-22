Public Class bllpermisos
#Region "Propiedades"
    Protected _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property


    Private _PatentesUsuario As DataSet
    Public Property PatentesUsuario() As DataSet
        Get
            Return _PatentesUsuario
        End Get
        Set(ByVal value As DataSet)
            _PatentesUsuario = value
        End Set
    End Property

    Private _PatenteFamilia As DataSet
    Public Property FamiliaPatente() As DataSet
        Get
            Return _PatenteFamilia
        End Get
        Set(ByVal value As DataSet)
            _PatenteFamilia = value
        End Set
    End Property

    Protected _seto As DataSet
    Public Property seto() As DataSet
        Get
            Return _seto
        End Get
        Set(ByVal value As DataSet)
            _seto = value
        End Set
    End Property




#End Region




    'metodo que retorna true si el usuario tiene esa patente habilitada
    Public Function permiso(ByVal patente As Integer) As Boolean
        Dim respuesta As Boolean = False
        Dim existe As Boolean = False
        'recorro la tabla de permisos del usuario y retorno por existe si respondio patentes o le corresponde a familia
        For Each fila As DataRow In _PatentesUsuario.Tables(0).Rows()


            If fila.ItemArray(0) = patente Then 'controlo si la patente esta contenida en usuario_patente
                existe = True 'marco que la patente fue atendida por patente_usuario

                If fila.ItemArray(1) = False And fila.ItemArray(2) = True Then 'como esta contenido, consulto si no esta bloqueado
                    ' como no esta bloqueado cambio la variable de retorno
                    respuesta = True
                End If

            End If

        Next


        'consulta si lo respondio patentes 
        If existe = False Then
            For Each fila As DataRow In _PatenteFamilia.Tables(0).Rows
                If fila.ItemArray(0) = patente Then
                    respuesta = True

                End If
            Next

        End If

        Return respuesta
    End Function




End Class
