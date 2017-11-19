Option Strict Off
Option Explicit On
Friend Class EDObject
	'Public Type EDObject        ' for maintain list of controls
	Public ControlRef As Object
	Public WhenAdd As Boolean
	Public WhenEdit As Boolean
	Public WhenNormal As Boolean
	Public InitialValue As Object
	'End Type
End Class