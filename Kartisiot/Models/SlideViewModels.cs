using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kartisiot.Models
{
    public static class SlideViewModels
    {
        public static List<SlidesCategory> AllCategories = new List<SlidesCategory>
        {
            new SlidesCategory
            {
                CategoryName = "Patience",
                Slides = new List<SlideViewModel>
                {
                    new SlideViewModel
                    {
                        SlideText = Properties.Resources.Proverbs_16_32,
                        SlideImageSrc = "cold-as-ice-1358993-1279x962.jpg",
                    },
                    new SlideViewModel
                    {
                        SlideText = Properties.Resources.Proverbs_29_22,
                        SlideImageSrc = "cold-as-ice-1358993-1279x962.jpg",
                    }
                }
            }
        };

    }

    public class SlidesCategory
    {
        public string CategoryName { get; set; }
        public List<SlideViewModel> Slides { get; set; }
    }

    public class SlideViewModel
    {
        public string SlideText { get; set; }
        public string SlideImageSrc { get; set; }
    }
}