using System.Runtime.Serialization;
using System.Collections.Generic;

namespace MailChimpApiV2.Gallery
{
    [DataContract]
    public class GalleryFoldersResult
    {
        /// <summary>
        /// The total matching folders
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        [DataMember(Name = "data")]
        public List<GalleryFolder> Folders
        {
            get;
            set;
        }
    }
}
