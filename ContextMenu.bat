@echo off
 

:: Ruta donde está tu ejecutable
set "RutaExe=N:\Herramientas\ConvertToJpgTool\ConvertToJpgTool.exe"

:: Añadir clave en el registro
reg add "HKEY_CLASSES_ROOT\*\shell\Convertir a JPG" /ve /t REG_SZ /d "Convertir a JPG" /f
reg add "HKEY_CLASSES_ROOT\*\shell\Convertir a JPG\command" /ve /t REG_SZ /d "\"%RutaExe%\" \"%1\"" /f

echo Opción 'Convertir a JPG' agregada al menú contextual con éxito.
pause