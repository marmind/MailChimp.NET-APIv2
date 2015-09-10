using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimpApiV2.Gallery
{
    [DataContract]
    public class GalleryListResult
    {
        /// <summary>
        /// the total matching items 
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        [DataMember(Name = "data")]
        public List<Gallery> Galleries
        {
            get;
            set;
        }
    }
}
