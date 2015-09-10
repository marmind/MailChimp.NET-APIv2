using System.Runtime.Serialization;

namespace MailChimpApiV2.Campaigns
{
    [DataContract]
    public class CampaignActionResult
    {
        /// <summary>
        /// whether the call worked. Realistically 
        /// this will always be true as errors will 
        /// be thrown otherwise.
        /// </summary>
        [DataMember(Name="complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
