using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
namespace DeckBuilderWASM
{
    public class ImageProcessor
    {
        const int innererAbstand = 25;
        const int aeussererAbstand = 30;
        const int obererAbstand = 50;
        public static async Task<MemoryStream> ProcessImagesWithImageSharp(byte[] imageBytes1, byte[] imageBytes2)
        {
            await Task.Delay(10_000);
            var outputStream = new MemoryStream();
            int totalHeight = 815;
            int totalWidth = 1059;

            using (var image1 = await GetImage(imageBytes1))
            using (var image2 = await GetImage(imageBytes2))
            using (Image<Rgba32> resultImage = new Image<Rgba32>(totalWidth, totalHeight))
            {
                resultImage.Mutate(i => i.BackgroundColor(Color.White));
                image1.Mutate(i => i.Resize(500, 700));
                resultImage.Mutate(ctx => ctx.DrawImage(image1, new Point(aeussererAbstand, obererAbstand), 1f));

                if (image2 != null)
                {
                    image2.Mutate(i => i.Resize(500, 700));
                    resultImage.Mutate(ctx => ctx.DrawImage(image2, new Point(image1.Width + aeussererAbstand + innererAbstand, obererAbstand), 1f));
                }

                await resultImage.SaveAsync(outputStream, new JpegEncoder());
            }

            return outputStream;
        }

        private static async Task<Image> GetImage(byte[] imageBytes)
        {
            if (imageBytes == null)
                return null;
            using var s = new MemoryStream(imageBytes);
            var image = await Image.LoadAsync(s);
            //image.Mutate(i => i.Rotate(RotateMode.Rotate90));
            return image;
        }
    }
}
