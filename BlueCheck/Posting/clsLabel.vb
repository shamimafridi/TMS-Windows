Option Strict Off
Option Explicit On
Friend Class clsLabel
	Public WithEvents Lbl As System.Windows.Forms.Label
	
	'UPGRADE_ISSUE: Label event Lbl.Change was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Lbl_Change()
		Lbl.Text = " " & Trim(Lbl.Text)
	End Sub
End Class