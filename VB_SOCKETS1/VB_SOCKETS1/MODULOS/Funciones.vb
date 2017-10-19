Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Module Funciones

    'SERVER CONFIGURACION
    Public servidorIP As IPAddress = IPAddress.Parse("127.0.0.1")
    Public servidorpuerto As Integer = 4444
    Public servidor As TcpListener
    Private mihilo1 As Thread 'HILO
    Public escucha As Boolean = True

    'CLIENTE 

    Public cliente As TcpClient
    Public cliente_datos As StreamReader
    Public cliente_envia As StreamWriter

    Public Sub inicio()
        servidor = New TcpListener(servidorIP, servidorpuerto)
        servidor.Start()

        mihilo1 = New Thread(New ThreadStart(AddressOf escuchar))
        mihilo1.Start()

    End Sub
    Function escuchar()
        Dim mensaje As String = ""
        Do Until escucha = False
            If servidor.Pending Then
                cliente = servidor.AcceptTcpClient
                cliente_datos = New StreamReader(cliente.GetStream)
                While cliente_datos.Peek > -1

                    mensaje &= cliente_datos.Read().ToString
                End While
                Return mensaje
            End If

        Loop

        Thread.Sleep(100)

    End Function

    Public Sub enviar(datos As String)
        cliente = New TcpClient(servidorIP.ToString, servidorpuerto)
        cliente_envia = New StreamWriter(cliente.GetStream)
        cliente_envia.Write(datos)

    End Sub

End Module
