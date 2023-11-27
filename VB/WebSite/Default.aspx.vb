Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Web


Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub grid_HeaderFilterFillItems(ByVal sender As Object, ByVal e As ASPxGridViewHeaderFilterEventArgs)
		If e.Column.FieldName <> "CategoryNameNull" Then
			Return
		End If

		e.Values.Insert(0, FilterValue.CreateShowBlanksValue(e.Column, "Blanks"))
		e.Values.Insert(1, FilterValue.CreateShowNonBlanksValue(e.Column, "Non Blanks"))
	End Sub
End Class
