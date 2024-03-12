using ImageResolutionLimiter.Source.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace ImageResolutionLimiter.Source
{
    internal class ImageProcessor
    {
        public void ProcessImages(string folderPath, bool backup, int maxX, int maxY, string[] formats)
        {
            Debug.WriteLine($"// Start images processing //");

            if (folderPath.Last() != '\\') folderPath += '\\';

            var imageFiles = new List<string>();
            foreach (string format in formats)
            {
                imageFiles.AddRange(Directory.GetFiles(folderPath, $"*{format}", SearchOption.AllDirectories));
            }

            Debug.WriteLine($"Files to process: {imageFiles.Count}");

            if (backup) CreateFolderBackup(folderPath);
            int id = 0;

            foreach (string imagePath in imageFiles)
            {
                Debug.WriteLine($"#{id} File: ({imagePath}) ");

                try
                {
                    Bitmap image = GetImage(imagePath);

                    int origWidth = image.Width;
                    int origHeight = image.Height;

                    Debug.WriteLine($"Size: {origWidth}, {origHeight}");

                    // size limit
                    int newWidth = Math.Min(image.Width, maxX);
                    int newHeight = Math.Min(image.Height, maxY);

                    // proportional resize
                    if (origHeight != origWidth)
                    {
                        if (origWidth > origHeight)
                        {
                            int difference = origWidth / origHeight;
                            newHeight = newWidth / difference;
                        }
                        else
                        {
                            int difference = origHeight / origWidth;
                            newWidth = newHeight / difference;
                        }
                    }

                    Bitmap resized = new Bitmap(image, new Size(newWidth, newHeight));
                    SaveImage(imagePath, resized, image.RawFormat);

                    Debug.WriteLine($"New size: {resized.Width}, {resized.Height}");
                    Debug.WriteLine($"Result: success");

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error: {ex.Message}");
                    Debug.WriteLine($"Result: failed.");
                }


                Debug.WriteLine(string.Empty);
                Debug.WriteLine(string.Empty);

                id++;
            }
            Debug.WriteLine($"End of files processing");
            Debug.WriteLine(string.Empty);
        }

        private void SaveImage(string imagePath, Bitmap resized, ImageFormat format)
        {
            resized.Save(imagePath, format);
        }

        private Bitmap GetImage(string path)
        {
            var imageBinaryData = File.ReadAllBytes(path);
            Bitmap image;
            using (var stream = new MemoryStream(imageBinaryData))
            {
                image = new Bitmap(stream);
            }

            return image;
        }

        private void CreateFolderBackup(string folderPath)
        {
            string backupFolder = Path.Combine(new DirectoryInfo(folderPath).Parent.FullName, "backup " + DateTime.Now.ToString().Replace(':', '_')); ;
            Directory.CreateDirectory(backupFolder);
            DirectoryHelper.CopyDirectory(folderPath, backupFolder, true);
        }
    }
}