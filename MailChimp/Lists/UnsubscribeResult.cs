﻿using System.Runtime.Serialization;

namespace MailChimpApiV2.Lists
{
    [DataContract]
    public class UnsubscribeResult
    {
        /// <summary>
        /// whether the call worked. reallistically this will always be true as errors will be thrown otherwise.
        /// </summary>
        [DataMember(Name = "complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
