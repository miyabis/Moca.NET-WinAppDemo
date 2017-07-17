
Public Class ApplicationExceptionHandler
	Implements Moca.Exceptions.IApplicationExceptionListener

	Public Sub ApplicationException(ex As Exception) Implements Moca.Exceptions.IApplicationExceptionListener.ApplicationException
		MessageBox.Show(ex.Message)
	End Sub

End Class
