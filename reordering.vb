Sub ReorderingInput()
'
' ReorderingInput Macro
'

'
    Columns("AF:AF").Select
    Selection.Cut
    Columns("A:A").Select
    Selection.Insert Shift:=xlToRight
    Columns("AG:AG").Select
    Selection.Cut
    Columns("C:C").Select
    Selection.Insert Shift:=xlToRight
    Columns("K:K").Select
    Selection.Cut
    Columns("D:D").Select
    Selection.Insert Shift:=xlToRight
    ActiveWindow.SmallScroll ToRight:=2
    Columns("K:K").Select
    Selection.Cut
    Columns("H:H").Select
    Selection.Insert Shift:=xlToRight
    Columns("AH:AH").Select
    Selection.Cut
    Columns("I:I").Select
    Selection.Insert Shift:=xlToRight
    Columns("Y:Y").Select
    Selection.Cut
    Columns("J:J").Select
    Selection.Insert Shift:=xlToRight
    Columns("K:K").Select
    Selection.Insert Shift:=xlToRight
    Range("K1").Select
    ActiveCell.FormulaR1C1 = "Fiscal Week For WOS"
    Columns("AJ:AJ").Select
    Selection.Cut
    Columns("L:L").Select
    Selection.Insert Shift:=xlToRight
    Columns("AK:AN").Select
    Selection.Cut
    Columns("M:M").Select
    Selection.Insert Shift:=xlToRight
    Columns("U:U").Select
    Selection.Cut
    Columns("Q:Q").Select
    Selection.Insert Shift:=xlToRight
    Columns("U:U").Select
    Selection.Cut
    Columns("R:R").Select
    Selection.Insert Shift:=xlToRight
    Columns("AO:AW").Select
    Selection.Cut
    Columns("T:T").Select
    Selection.Insert Shift:=xlToRight
    Columns("AG:AG").Select
    Selection.Cut
    Columns("AC:AC").Select
    Selection.Insert Shift:=xlToRight
    Columns("AX:BC").Select
    Selection.Cut
    ActiveWindow.SmallScroll ToRight:=-1
    Columns("AD:AD").Select
    Selection.Insert Shift:=xlToRight
    ActiveWindow.SmallScroll ToRight:=15
    Range("AW9").Select
End Sub
