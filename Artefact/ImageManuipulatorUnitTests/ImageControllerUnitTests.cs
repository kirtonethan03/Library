/// Authors: Tom & Ethan
using ImageManipulatorController.Validator;
using ImageManuipulatorUnitTests.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImageManuipulatorUnitTests
{
    /// <summary>
    /// This test helps verify the functionality of image loading 
    /// and validation within the image controller
    /// </summary>
    [TestClass]
    public class ImageControllerUnitTests
    {
        [TestMethod]
        public void LoadImages_ValidateImages()
        {
            var imageStore = new DummyImageStore();
            var images = imageStore.LoadImages();

            var imageValidator = new PngValidator();
            imageValidator.ValidateImages(images);
            // checks that there are 4 images objects 
            Assert.AreEqual(images.Count, 4);
        }
    }
}
