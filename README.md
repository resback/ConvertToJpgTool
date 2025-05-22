# ConvertToJpgTool

## 📌 Descripción
**ConvertToJpgTool** es una aplicación de consola para **Windows 11** que añade una opción al menú contextual, permitiendo convertir imágenes a formato **JPG** con una compresión del **85%**, sin abrir ventanas ni requerir configuraciones adicionales.

## 🚀 Características
✅ Conversión rápida y automática al hacer clic derecho sobre una imagen  
✅ Compatible con múltiples formatos: **PNG, JPG, JPEG, BMP, WEBP**  
✅ Mantiene las dimensiones originales de la imagen  
✅ Soporte para conversión de **varias imágenes** al mismo tiempo  
✅ Integración en el **menú contextual de Windows 11**  

## 🔧 Instalación
1. **Publica la aplicación en Visual Studio** (como `self-contained` o `framework-dependent`).  
2. **Ejecuta `ContextMenu.bat`** para registrar la opción en el menú contextual.  
3. **Coloca el ejecutable en la ruta deseada** y asegúrate de incluir todas sus dependencias.  
4. **Haz clic derecho sobre una imagen y selecciona "Convertir a JPG"** para probar la conversión.  

## 📜 Uso
Para convertir imágenes manualmente desde la consola:
`sh``
ConvertToJpgTool.exe C:\ruta\a\imagen.png

## Para procesar múltiples imágenes:

ConvertToJpgTool.exe C:\ruta\a\imagen1.png C:\ruta\a\imagen2.bmp
