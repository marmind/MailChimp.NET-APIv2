using System.Runtime.Serialization;

namespace MailChimpApiV2.Folders
{
    [DataContract]
    public class FolderAddResult
    {
        /// <summary>
        /// the folder_id of the newly created folder.
        /// </summary>
        [DataMember(Name = "folder_id")]
        public int NewFolderId
        {
            get;
            set;
        }
    }
}
