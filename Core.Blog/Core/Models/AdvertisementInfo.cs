﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Blog.Core.Models
{
    /// <summary>
    /// Banner 轮播图
    /// </summary>
    public class AdvertisementInfo
    {

        /// <summary>
        /// 分类ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createdate { get; set; }

        /// <summary>
        /// 广告图片
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 广告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 广告链接
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
