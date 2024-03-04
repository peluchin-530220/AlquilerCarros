Imports System.IO

Module FacturaHTML
    Public FechaRenta As DateTime
    Public NombreCliente As String
    Public IDcliente As Integer
    Public Empleado As String
    Public Factura As Integer
    Public Marca As String
    Public Placa As String
    Public Modelo As String
    Public Fabricado As Integer
    Public Color As String
    Public Tipo As String
    Public SubTotal As Double
    Public Impuestos As Double
    Public Total As Double
    Public Desde As DateTime
    Public Hasta As DateTime

    Public Sub ImpresionFisica()

        'Impresion en HTML
        '-------------------------------------
        Dim web As String

        web &= "<b><p style='font-family:Georgia;font-size:90%;'>PROUDLY RENT A CAR</b>"
        web &= "<p style='font-family:courier;font-size:80%;'>"
        web &= "Viajando contigo siempre<br>"
        web &= "Permiso # 123-456"
        web &= "<p style='font-family:Georgia;font-size:80%;'>"
        web &= "<br>Fecha: " & FechaRenta
        web &= "<br><br>"
        web &= "Cliente: " & NombreCliente
        web &= "<br><br>"
        web &= "Id cliente: " & IDcliente
        web &= "<br><br>"
        web &= "Atendido por: " & Empleado
        web &= "<br><br>"
        web &= "Factura #: " & Factura
        web &= "<br><br>"
        web &= "<p style='font-family:courier;font-size:80%;'>"
        web &= "Detalle servicios<br>"
        web &= "-----------------------------------<br>"
        web &= "Placa: " & Placa & "<br>"
        web &= "Marca: " & Marca & "<br>"
        web &= "Modelo: " & Modelo & "<br>"
        web &= "Año: " & Fabricado & "<br>"
        web &= "Color: " & Color & "<br>"
        web &= "Tipo: " & Tipo & "<br>"
        web &= "Rentado desde: " & Desde & "<br>"
        web &= "Rentado Hasta: " & Hasta & "<br>"
        web &= "-----------------------------------<br>"
        web &= "<p style='font-family:Georgia;font-size:80%;'>"
        web &= "<b>Sub Total: " & Format(SubTotal, "standard")
        web &= "<br>"
        web &= "Impuestos: " & Format(Impuestos, "standard") & "<br>"
        web &= "Total a pagar: " & Format(Total, "standard") & "</b><br><p style='font-family:Georgia;font-size:80%;'>"

        web &= "_________________________________<br><br>"
        web &= "Avenida Venezuela #4568<br>"
        web &= "Sector Los cocos<br>"
        web &= "Teléfono: (888)555-4444 <br>"

        File.WriteAllText("fiscalpos.htm", web)

        System.Diagnostics.Process.Start(String.Concat(System.AppDomain.CurrentDomain.BaseDirectory, "fiscalpos.htm"))




    End Sub
End Module
