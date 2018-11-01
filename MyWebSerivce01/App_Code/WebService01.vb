Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://www.almoe.com/")>
<WebServiceBinding(ConformsTo:=WsiProfiles.None)>
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<System.Web.Script.Services.ScriptService>
Public Class WebService01
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod(MessageName:="twoparameter", Description:="addition of two integers")>
    Public Function add(ByVal a As Integer, ByVal b As Integer) As Integer
        Return (a + b)
    End Function

    <WebMethod(MessageName:="threeparameter", Description:="addition of three integers")>
    Public Function add(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Return (a + b + c)
    End Function
End Class