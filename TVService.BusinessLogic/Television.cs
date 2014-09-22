using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TVService.Contract;

namespace TVService.BusinessLogic
{
    public class Television
    {
        public List<Response> GetDRMEnabledAndHasEpisodes(List<Payload> list)
        {
            var drmEnabledAndHasEpisodes = list.Where(x => x.drm == true).Where(x => x.episodeCount > 0);
            return drmEnabledAndHasEpisodes.Select(s => new Response()
            {
                title = s.title,
                image = s.image.showImage,
                slug = s.slug
            }).ToList();

        }
    }
}
