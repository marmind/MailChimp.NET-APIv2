﻿using System.Runtime.Serialization;

namespace MailChimpApiV2.Lists
{
    /// <summary>
    ///  
    /// </summary>
    [DataContract]
    public class SegmentAddResult
    {
        /// <summary>
        /// The ID of the new Segment
        /// </summary>
        [DataMember(Name = "id")]
        public int NewSegmentID
        {
            get;
            set;
        }
    }
}