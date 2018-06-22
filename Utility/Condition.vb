Public Class Condition
	Public Shared Function CheckDTOEmptyAndGetQuery(parameter As Object, nameControl As String) As String
		Dim conditionString As String

		If parameter <> Nothing then
			conditionString = "[" + nameControl + "] = " + "@" + nameControl
		Else 
			conditionString = "1 = 1"
		End If

		Return conditionString 

	End Function

	Public Shared Function CheckDTORangeAndGetQuery(minParameter As Object, 
	                                                maxParameter As Object, 
	                                                nameMin As String, 
	                                                nameMax As String, 
	                                                nameControl As String) As String
		Dim conditionString As String

		If minParameter <> Nothing And maxParameter <> Nothing then
			conditionString = "[" + nameControl + "] BETWEEN " + "@" + nameMin + " AND " + "@" + nameMax
		ElseIf minParameter <> Nothing
				conditionString = "[" + nameControl + "] >= " + "@" + nameMin 
		ElseIf maxParameter <> Nothing
				conditionString = "[" + nameControl + "] <= " + "@" + nameMax 
			Else 
				conditionString = "1 = 1"
		End If

		Return conditionString

	End Function
End Class
