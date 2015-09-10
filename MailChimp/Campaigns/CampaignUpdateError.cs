using System.Runtime.Serialization;

namespace MailChimpApiV2.Campaigns
{
    [DataContract]
    public class CampaignUpdateError
    {

        /// <summary>
        /// the error code
        /// </summary>
        [DataMember(Name = "code")]
        public int Code
        {
            get;
            set;
        }

        /// <summary>
        /// the error message
        /// </summary>
        [DataMember(Name = "msg")]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// the parameter name that failed
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
    }
}
