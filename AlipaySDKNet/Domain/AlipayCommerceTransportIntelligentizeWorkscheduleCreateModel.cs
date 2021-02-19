using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeWorkscheduleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIntelligentizeWorkscheduleCreateModel : AopObject
    {
        /// <summary>
        /// 城市代码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 公交业主ID
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 下行首站的临时停车容量，大于等于0整数
        /// </summary>
        [XmlElement("down_first_station_capacity")]
        public long DownFirstStationCapacity { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [XmlElement("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 休息时间列表
        /// </summary>
        [XmlArray("rest_time_list")]
        [XmlArrayItem("rest_time")]
        public List<RestTime> RestTimeList { get; set; }

        /// <summary>
        /// 服务任务名称
        /// </summary>
        [XmlElement("service_task_name")]
        public string ServiceTaskName { get; set; }

        /// <summary>
        /// 使用时刻表中部分方向的数据计算排班，不传表示使用全量的时刻表数据计算排班
        /// </summary>
        [XmlElement("timetable_direction")]
        public string TimetableDirection { get; set; }

        /// <summary>
        /// 单个车次结束后的驻站时长（单位：分钟），不传则由算法自行决策驻站时长
        /// </summary>
        [XmlElement("trip_break_time")]
        public long TripBreakTime { get; set; }

        /// <summary>
        /// 上行首站的临时停车容量，大于等于0整数
        /// </summary>
        [XmlElement("up_first_station_capacity")]
        public long UpFirstStationCapacity { get; set; }

        /// <summary>
        /// 班型列表
        /// </summary>
        [XmlArray("work_pattern_list")]
        [XmlArrayItem("work_pattern")]
        public List<WorkPattern> WorkPatternList { get; set; }
    }
}
