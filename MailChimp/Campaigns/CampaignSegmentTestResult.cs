using System.Runtime.Serialization;

namespace MailChimpApiV2
{
    [DataContract]
    public class CampaignSegmentTestResult
    {
        /// <summary>
        /// The total number of subscribers matching your segmentation options
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }
    }
}
