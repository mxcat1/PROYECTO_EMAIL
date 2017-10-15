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

    Public Sub inicio()
        servidor = New TcpListener(servidorIP, servidorpuerto)
        servidor.Start()

        mihilo1 = New Thread(New ThreadStart(AddressOf escuchar))
        mihilo1.Start()

    End Sub
    Function escuchar()

        Do Until escucha = False

        Loop


    End Function

End Module
