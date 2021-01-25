using System;
using System.Collections.Generic;
using System.Text;
using HaruhiSuzumiya.APP.Models;
using HaruhiSuzumiya.Common.Entity;

namespace HaruhiSuzumiya.APP.Data
{
    /// <summary>
    /// 轮播图 数据
    /// </summary>
    public class CarouselData
    {
        public static IList<Anime> CarouselImages { get; private set; }

        static CarouselData()
        {
            CarouselImages = new List<Anime>
            {
                new Anime() { Name = "overlord", CoverImageUrl = "overlord.jpg", Details = "" },
                new Anime() { Name = "女神异闻录", CoverImageUrl = "nsywl.jpg", Details = "" },
                new Anime() { Name = "我的英雄", CoverImageUrl = "wdyx.jpg", Details = "" },
                new Anime() { Name = "异世界魔王", CoverImageUrl = "ysjmw.jpg", Details = "" }
            };





        }

    }
}
