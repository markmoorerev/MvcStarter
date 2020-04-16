using System;
using MvcProjectStarter.Data;
using MvcProjectStarter.Models;
using Xunit;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private async Task<MvcSongContext> GetDbContext()
        {
            var options = new DbContextOptionsBuilder<MvcSongContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new MvcSongContext(options);
            
            var model = new Song
            {
                title = "Sample Song",
                genre = "pop",
                artist = "Blink 365",
                album = "Beegies Album",
                ReleaseDate = DateTime.Now
            };

            databaseContext.Song.Add(model);
            await databaseContext.SaveChangesAsync();

            return databaseContext;
        }
      
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

        [Fact]
        public async Task Test2Async()
        {
            //arrange - create a song and insert it into the DB
            var _context = await GetDbContext();

            var model = new Song
            {
                title = "myNew Song",
                genre = "pop",
                artist = "Nirvana",
                album = "White Album",
                ReleaseDate = DateTime.Now
            };
            

            //act - insert the song into the DB
            await _context.Song.AddAsync(model);
            await _context.SaveChangesAsync();
            var newSong = await _context.Song.FirstOrDefaultAsync(s => s.title == "myNew Song");

            //assert - verify the new song was inputted
            Assert.Equal("myNew Song", newSong.title);

        }
    }
}
