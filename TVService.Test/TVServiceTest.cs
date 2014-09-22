using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TVService.Contract;
using System.Collections.Generic;
using TVService.BusinessLogic;

namespace TVService.Test
{
    [TestClass]
    public class TVServiceTest
    {
        static List<Payload> tvList;
        static Television televisionBL;

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            tvList = new List<Payload>();
            tvList.Add(new Payload() { title = "Sons of Anarchy", episodeCount = 0, drm = true,  slug = "show/soa", image = new Image(){ showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/TheTaste1280.jpg" }});
            tvList.Add(new Payload() { title = "The Strain", episodeCount = 12, drm = true,  slug = "show/thestrain", image = new Image(){ showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/TheTaste1280.jpg" }});
            tvList.Add(new Payload() { title = "Boardwalk Empire", episodeCount = 1, drm = true, slug = "show/boardwalkempire", image = new Image() { showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/TheTaste1280.jpg" } });
            tvList.Add(new Payload() { title = "Ray Donovan", episodeCount = 12, drm = false, slug = "show/raydonovan", image = new Image() { showImage = "http://catchup.ninemsn.com.au/img/jump-in/shows/TheTaste1280.jpg" } });
            televisionBL = new Television();
        }


        [TestMethod]
        public void ReturnOnlyDRMEnabledAndHasEps()
        {
            var result = televisionBL.GetDRMEnabledAndHasEpisodes(tvList);
            Assert.IsTrue(result.Exists(x=>x.title.Equals("Boardwalk Empire")));
            Assert.IsTrue(result.Exists(x => x.title.Equals("The Strain")));
            Assert.IsFalse(result.Exists(x=>x.title.Equals("Sons of Anarchy")));
            Assert.IsFalse(result.Exists(x => x.title.Equals("Ray Donovan")));
        }
    }
}
