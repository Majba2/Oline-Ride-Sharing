﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Oline_Ride_Share_idb_project.Server.Model
{
    public class RideTrack : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RideTrackId { get; set; }
        [ForeignKey("RideBook")]
        public int RideBookId { get; set; }
        public virtual RideBook? RideBooks { get; set; }
        public float RideTrackLatitude { get; set; } 
        public float RideTrackLongitude { get; set; }
        public DateTime Timestamp { get; set; }
        public int Distance { get; set; }
        public DateTime TrackTime { get; set; }
    }
}