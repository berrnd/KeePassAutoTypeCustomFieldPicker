rem del AutoTypeCustomFieldPicker.plgx
rem robocopy . .\AutoTypeCustomFieldPicker_Temp *.* /MIR
rem 
rem rd /s /q AutoTypeCustomFieldPicker_Temp\AutoTypeCustomFieldPicker_Temp
rem rd /s /q AutoTypeCustomFieldPicker_Temp\AutoTypeCustomFieldPicker\obj
rem rd /s /q AutoTypeCustomFieldPicker_Temp\AutoTypeCustomFieldPicker\bin
rem rd /s /q AutoTypeCustomFieldPicker_Temp\AutoTypeCustomFieldPicker\Resources
rem 
rem AutoTypeCustomFieldPicker\Resources\KeePass.exe --plgx-create "AutoTypeCustomFieldPicker_Temp"
rem ren AutoTypeCustomFieldPicker_Temp.plgx AutoTypeCustomFieldPicker.plgx
rem 
rem rd /s /q AutoTypeCustomFieldPicker_Temp

AutoTypeCustomFieldPicker\Resources\KeePass.exe --plgx-create