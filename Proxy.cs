using System;

namespace ProxyPattern
{
    // 1. Subject
    public interface IImage
    {
        void DisplayImage();
    }

    // 2. RealSubject
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadImageFromDisk();
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image: {fileName} from disk...");
        }

        public void DisplayImage()
        {
            Console.WriteLine($"Displaying image: {fileName}");
        }
    }

    // 3. Proxy
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void DisplayImage()
        {
            // Only load the image when it is accessed
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.DisplayImage();
        }
    }

    // Client code
    class Program
    {
        static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("photo1.jpg");
            IImage image2 = new ProxyImage("photo2.jpg");

            // Image not loaded yet
            Console.WriteLine("First access to image1:");
            image1.DisplayImage(); // Load and display image1

            Console.WriteLine("\nSecond access to image1:");
            image1.DisplayImage(); // Only display (already loaded)

            Console.WriteLine("\nAccess to image2:");
            image2.DisplayImage(); // Load and display image2
        }
    }
}
