using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentFunctionModifyModel : AopObject
    {
        /// <summary>
        /// 区域编码；默认值为1，表示全国范围；编码参考高德地图JS API相关下载中的行政区编码与城市编码表：https://lbs.amap.com/api/javascript-api/download/
        /// </summary>
        [XmlArray("area_codes")]
        [XmlArrayItem("string")]
        public List<string> AreaCodes { get; set; }

        /// <summary>
        /// 类目属性列表
        /// </summary>
        [XmlArray("category_attributes")]
        [XmlArrayItem("app_attribute")]
        public List<AppAttribute> CategoryAttributes { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlArray("category_ids")]
        [XmlArrayItem("string")]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// 服务icon
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 关键字列表；关键词数量最多5个，每个关键词长度在5个字符以内
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称；长度范围在2到10个字符以内
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务结束时间；默认值：23:59:59
        /// </summary>
        [XmlElement("service_time_end")]
        public string ServiceTimeEnd { get; set; }

        /// <summary>
        /// 服务开始时间；默认值：00:00:00
        /// </summary>
        [XmlElement("service_time_start")]
        public string ServiceTimeStart { get; set; }

        /// <summary>
        /// 服务地址列表
        /// </summary>
        [XmlArray("service_urls")]
        [XmlArrayItem("service_url")]
        public List<ServiceUrl> ServiceUrls { get; set; }

        /// <summary>
        /// 短描述；长度范围在5到16个字符以内
        /// </summary>
        [XmlElement("short_desc")]
        public string ShortDesc { get; set; }
    }
}
