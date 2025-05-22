
using SkiaSharp;

class Program
{
    static void Main(string[] args)
    {
         if (args.Length == 0)
        {
            Console.WriteLine("No se proporcionó ninguna imagen.");
            return;
        }

        string[] formatosPermitidos = { ".png", ".jpg", ".jpeg", ".bmp", ".webp" };

        foreach (string inputPath in args)
        {
            string extension = Path.GetExtension(inputPath).ToLower();
            if (!formatosPermitidos.Contains(extension))
            {
                Console.WriteLine($"Formato no admitido: {inputPath}");
                continue;
            }

            string outputPath = Path.ChangeExtension(inputPath, ".jpg");

            try
            {
                using (SKBitmap bitmap = SKBitmap.Decode(inputPath))
                using (SKImage image = SKImage.FromBitmap(bitmap))
                using (SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 85))
                using (FileStream fs = File.OpenWrite(outputPath))
                {
                    data.SaveTo(fs);
                }

                Console.WriteLine($"Conversión exitosa: {outputPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir {inputPath}: {ex.Message}");
            }

         

        }
    }
}