using System;
using MvcProjectStarter.Models;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //arrange
        [Fact]
        public void Test1()
        {
            var model = new Song
            {
                title = "myNew Song",
                genre = "pop",
                artist = "Nirvana",
                album = "White Album",
                ReleaseDate = DateTime.Now
            };

        //act
        model.title = "Song of mine";

            //assert
            Assert.Equal("Song of mine", model.title);

        }
    }
}
