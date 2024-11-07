using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FishUnitTests
{
    [TestClass]
    public class ServerUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void NoImageFound()
        {
            //When the server is called with a name of a fish that is not contained in the resources an exception is thrown.

            var imageServer = new MediaServer.ResourceFileServer();
            var image = imageServer.LoadImage("This Fish Doesnt Exist");
        }

        [TestMethod]
        public void ImageFound()
        {
            //When the server is called with a name of a fish that is contained in the resources it is returned as an image.

            var imageServer = new MediaServer.ResourceFileServer();
            var image = imageServer.LoadImage("OrangeFish");

            Assert.AreEqual(image.GetType(), typeof(System.Drawing.Bitmap));
        }
    }
}
