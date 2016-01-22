Imports System.ComponentModel
Imports System.Globalization


Public Class bllidioma

    Private _id_idioma As Integer
    Public Property  id_idioma() As Integer
        Get
            Return _id_idioma
        End Get
        Set(ByVal value As Integer)
            _id_idioma = value
        End Set
    End Property

    Shared Sub cambiaridioma(formito As Form, _id_idioma As Integer)

        Try
            Static culturita As CultureInfo

            ' Asignar el nuevo objeto CultureInfo al subproceso actual.
            If _id_idioma = 1 Then
                culturita = New CultureInfo("es-AR")
            End If
            If _id_idioma = 2 Then
                culturita = New CultureInfo("en-US")
            End If

            Threading.Thread.CurrentThread.CurrentCulture = culturita

            ' Obtenemos los recursos del formulario especificado.
            '
            Dim crm As New ComponentResourceManager(formito.GetType())

            ' Aplicar el nuevo objeto CultureInfo a los recursos del formulario.
            '
            crm.ApplyResources(formito, "$this", culturita)

            ' Aplicar los recursos a todos los controles del formulario,
            ' y a los que puedan existir en otros controles, como por
            ' ejemplo, en cualquier control Panel.
            '
            Dim controles As List(Of Control) = bllidioma.listadecontroles(formito)


            For Each ctrl As Control In controles

                crm.ApplyResources(ctrl, ctrl.Name, culturita)

                If (Not (TypeOf ctrl Is MenuStrip)) Then Continue For

                Dim menuStrip As MenuStrip = DirectCast(ctrl, MenuStrip)
                Dim menuItems As List(Of ToolStripMenuItem) = bllidioma.listademenu(menuStrip)

                For Each mi As ToolStripMenuItem In menuItems
                    crm.ApplyResources(mi, mi.Name, culturita)
                    If (mi.DropDownItems.Count > 0) Then
                        Dim toolStrip As List(Of ToolStripItem) = bllidioma.listastripitems(mi)
                        For Each item As ToolStripItem In toolStrip
                            crm.ApplyResources(item, item.Name, culturita)
                        Next
                    End If
                Next

            Next

        Catch ex As CultureNotFoundException
            MessageBox.Show( _
                String.Format("No se admite la referencia cultura '{0}' especificada."), _
                "Error referencia cultural")
        Catch
            Throw

        End Try

    End Sub

    ''' <summary>
    ''' Obtiene una lista de controles existentes en el control contenedor
    ''' principal especificado, incluyendo aquellos contenidos a su vez en
    ''' otros controles hijos.
    ''' </summary>
    ''' <param name="parentContainer">Objeto Control que actúa de contenedor principal.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function listadecontroles(parentContainer As Control) As List(Of Control)

        If (parentContainer Is Nothing) Then Return Nothing

        Dim controles As New List(Of Control)

        For Each ctrl As Control In parentContainer.Controls
            controles.Add(ctrl)
            controles.AddRange(bllidioma.listadecontroles(ctrl))

        Next

        Return controles

    End Function

    ''' <summary>
    ''' Obtiene una lista de controles ToolStripMenuItem existentes
    ''' en el objeto MenuStrip principal especificado.
    ''' </summary>
    ''' <param name="parentContainer">Objeto MenuStrip principal.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function listademenu(parentContainer As MenuStrip) As List(Of ToolStripMenuItem)

        If (parentContainer Is Nothing) Then Return Nothing

        Dim menuItems As New List(Of ToolStripMenuItem)

        For Each item As ToolStripMenuItem In parentContainer.Items
            menuItems.Add(item)
        Next

        Return menuItems

    End Function

    ''' <summary>
    ''' Obtiene una lista de controles ToolStripItem existentes
    ''' en el objeto ToolStripMenuItem principal especificado.
    ''' </summary>
    ''' <param name="parentContainer">Objeto ToolStripMenuItem principal.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Shared Function listastripitems(parentContainer As ToolStripMenuItem) As List(Of ToolStripItem)

        If (parentContainer Is Nothing) Then Return Nothing

        Dim menuItems As New List(Of ToolStripItem)

        For Each item As ToolStripItem In parentContainer.DropDownItems
            menuItems.Add(item)
        Next

        Return menuItems

    End Function



End Class
