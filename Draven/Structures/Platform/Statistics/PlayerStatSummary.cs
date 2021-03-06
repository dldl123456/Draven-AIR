﻿namespace Draven.Structures.Platform.Statistics
{
    using System;

    using RtmpSharp.IO;

    [Serializable]
    [SerializedName("com.riotgames.platform.statistics.PlayerStatSummary")]
    public class PlayerStatSummary
    {
        [SerializedName("userId")]
        public Double UserId { get; set; }
        [SerializedName("playerStatSummaryType")]
        public String Type { get; set; }
        [SerializedName("rating")]
        public Int32 Rating { get; set; }
        [SerializedName("maxRating")]
        public Int32 MaxRating { get; set; }
        [SerializedName("wins")]
        public Int32 Wins { get; set; }
        [SerializedName("losses")]
        public Int32 Losses { get; set; }
        [SerializedName("leaves")]
        public Int32 Leaves { get; set; }
        [SerializedName("modifyDate")]
        public DateTime ModifyDate { get; set; }
        [SerializedName("aggregatedStats")]
        public SummaryAggStats AggregatedStats { get; set; }
    }
}
