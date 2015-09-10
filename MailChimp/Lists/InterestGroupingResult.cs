using System.Runtime.Serialization;

namespace MailChimpApiV2.Lists
{
    [DataContract]
    public class InterestGroupingResult
    {
        /// <summary>
        /// the id of the newly created interest grouping
        /// </summary>
        [DataMember(Name = "id")]
        public int id
        {
            get;
            set;
        }
    }
}
