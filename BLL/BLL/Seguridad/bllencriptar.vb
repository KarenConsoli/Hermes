Imports System.Security.Cryptography
Imports System.Text

Public Class bllencriptar
    'propiedad proveedor de encriptación triple des (?)
    Private tripledes As New TripleDESCryptoServiceProvider

    'metodo que crea una matriz de bytes de una logitud especificada a partir del hash de la clave especificada
    Private Function tripleto(ByVal llave As String, ByVal length As Integer) As Byte()
        Dim shacito As New SHA1CryptoServiceProvider

        'llave
        Dim llavero() As Byte = System.Text.Encoding.Unicode.GetBytes(llave)
        'hash o resultado de la encriptacion
        Dim hash() As Byte = shacito.ComputeHash(llavero)
        'reserva el espacio de la matriz
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    'Constructor para incializar el proveedor de 3des
    'Sub New(ByVal key As String)
    '    tripledes.Key = matriz(key, tripledes.KeySize / 8)
    '    tripledes.IV = matriz("", tripledes.BlockSize / 8)
    'End Sub

    'metodo para encryptar
    Public Function encriptar(ByVal texto As String) As String
        tripledes.Key = tripleto("a lo hecho pecho", tripledes.KeySize / 8)
        tripledes.IV = tripleto("", tripledes.BlockSize / 8)

        'convierte el texto plano en una matriz de byte
        Dim textobyte() As Byte = System.Text.Encoding.Unicode.GetBytes(texto)

        'crea un flujo
        Dim msj As New System.IO.MemoryStream

        'crea un codificador para escribir en el flujo
        Dim msjencript As New CryptoStream(msj, tripledes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'usa el flujo encriptado para escribir el byte de la matriz en el flujo
        msjencript.Write(textobyte, 0, textobyte.Length)
        msjencript.FlushFinalBlock()

        'convierte el flujo encriptado en una cadena de impresion
        Return Convert.ToBase64String(msj.ToArray)

    End Function

    'metodo para descriptar
    Public Function desencriptar(ByVal textod As String) As String
        tripledes.Key = tripleto("a lo hecho pecho", tripledes.KeySize / 8)
        tripledes.IV = tripleto("", tripledes.BlockSize / 8)

        'convierte el texto encryptado en una mtriz de bytes
        Dim textoencripbyte() As Byte = Convert.FromBase64String(textod)

        'crea el flujo
        Dim msj As New System.IO.MemoryStream

        'crea el desifrador para escribir en el flujo
        Dim descflujo As New CryptoStream(msj, tripledes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        'usa el flujo encriptado para escribir el el byte de la matriz 
        descflujo.Write(textoencripbyte, 0, textoencripbyte.Length)
        descflujo.FlushFinalBlock()

        'convierte el texto plano del flujo en una cadena
        Return System.Text.Encoding.Unicode.GetString(msj.ToArray)

    End Function

    'metodo de encriptado permanente(sin posibilidad de desencriptar)
    Public Function EncriptadoPermanente(ByVal texto As String) As String
        Dim codificar As New UnicodeEncoding()
        Dim textobyte() As Byte = codificar.GetBytes(texto)
        Dim md5 As New MD5CryptoServiceProvider()
        Dim tablaBytes() As Byte = md5.ComputeHash(textobyte)
        Dim txtcifrado As String = Convert.ToBase64String(tablaBytes).ToString
        Return txtcifrado
    End Function


End Class
