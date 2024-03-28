Sub cashformat()
    
    Range("R1").Select
    ActiveCell.FormulaR1C1 = "SoldTo"
     Columns("A:A").Select
    Selection.Insert Shift:=xlToRight
    Range("A1").Select
    ActiveCell.FormulaR1C1 = "Country"
    Columns("O:O").Select
    Selection.Insert Shift:=xlToRight
    Range("O1").Select
    ActiveCell.FormulaR1C1 = "Category"
    Columns("P:P").Select
    Selection.Insert Shift:=xlToRight
    Range("P1").Select
    ActiveCell.FormulaR1C1 = "Promoter"
    Columns("Q:Q").Select
    Selection.Insert Shift:=xlToRight
    Range("Q1").Select
    ActiveCell.FormulaR1C1 = "Frontline"
    Range("Q1").Select
    ActiveCell.FormulaR1C1 = "Frontliner"
    Columns("X:X").Select
    Selection.Insert Shift:=xlToRight
    Range("X1").Select
    ActiveCell.FormulaR1C1 = "EUEmail"
    Columns("Y:Y").Select
    Selection.Insert Shift:=xlToRight
    Range("Y1").Select
    ActiveCell.FormulaR1C1 = "T3Name"
    Columns("Z:Z").Select
    Selection.Insert Shift:=xlToRight
    Range("Z1").Select
    ActiveCell.FormulaR1C1 = "T3ID"
    Columns("AA:AA").Select
    Selection.Insert Shift:=xlToRight
    Range("AA1").Select
    ActiveCell.FormulaR1C1 = "Alias"
    Columns("AB:AB").Select
    Selection.Insert Shift:=xlToRight
    Range("AB1").Select
    ActiveCell.FormulaR1C1 = "T3 Territory"
    Range("AC1").Select
    ActiveCell.FormulaR1C1 = "ValidationRemarks"
    Range("AB2").Select

End Sub
