using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Drawing.Image;

namespace GeneralKnowledge.Test.App.Tests
{
    /// <summary>
    /// Image rescaling
    /// </summary>
    public class RescaleImageTest : ITest
    {
        public void Run()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            // TODO:
            // Grab an image from a public URL and write a function thats rescale the image to a desired format
            // The use of 3rd party plugins is permitted
            // For example: 100x80 (thumbnail) and 1200x1600 (preview)
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri("https://i.kym-cdn.com/entries/icons/original/000/007/263/photo_cat2.jpg"),  "image35.jpeg");

                //OR 

                client.DownloadFileAsync(new Uri("https://i.kym-cdn.com/entries/icons/original/000/007/263/photo_cat2.jpg"), path + "image35.jpeg");
            }

            // Console.WriteLine(path + "/Resources/image35.png");
 
            Image image = new Bitmap ( "image35.jpeg"); 
            Bitmap original = (Bitmap)Image.FromFile("image35.jpeg");
            ResizeImage(original, 50, 50, path);
        }

        public void ResizeImage(Bitmap original, int width, int height, string path)
        {
            Bitmap resized = new Bitmap(original, new Size(height, width));
            resized.Save(path + "/Resources/image38.jpeg");
        }
    }
}