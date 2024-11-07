/// Authors: Tom & Ethan
using ImageManipulatorModel;
using System.Collections.Generic;

namespace ImageManuipulatorUnitTests.TestData
{
    /// <summary>
    /// Provides a simple implementation of the IImageStore interface, returns a 
    /// list of dummy Image objects for testing purposes, simulating the behavior of an image store
    /// </summary>
    public class DummyImageStore : IImageStore
    {
        public List<Image> LoadImages()
        {
            // use of a list for the dummy images
            return new List<Image>()
            {
                new Image()
                {
                    ImageID = 1,
                    FileName = "ImagePath1.png"
                },
                new Image()
                {
                    ImageID = 2,
                    FileName = "ImagePath2.png"
                },
                new Image()
                {
                    ImageID = 3,
                    FileName = "ImagePath3.png"
                },
                new Image()
                {
                    ImageID = 4,
                    FileName = "ImagePath4.png"
                },
                // here is our file implemented to be caught by the test to show that the validator works
                new Image()
                {
                    ImageID = 99,
                    FileName = "NotARealpng.jpg"
                }
            };
        }
    }
}
