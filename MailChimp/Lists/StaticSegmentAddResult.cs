using System.Runtime.Serialization;

namespace MailChimpApiV2.Lists
{
    /// <summary>
    ///  
    /// </summary>
    [DataContract]
    public class StaticSegmentAddResult
    {
        /// <summary>
        /// The ID of the new Static Segment
        /// </summary>
        [DataMember(Name = "id")]
        public int NewStaticSegmentID
        {
            get;
            set;
        }
    }
}
