#include "global_variable.inc"


Function syncData
	'Data to HMI	
	outData(0) = z
	outData(1) = x
	outData(2) = c
	outData(3) = v

	'Data from c#
	q = inData(0)
	w = inData(10)
	e = inData(11)
	r = inData(12)
Fend
Function parsingData(data$ As String)
	Integer i
	Integer j
	'j = 0
	
	'For i = 1 To Len(data$) Step +1
		
		'If data(1) = "," Then
			'j = j + 1
			'DataTemp$(j) = ""
		'Else
			'DataTemp$(j) = DataTemp$(j) + data$(i)
		'EndIf
		

	'Next
	
Fend

