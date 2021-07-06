﻿using System.Configuration;

namespace NHapiTools.Base.Configuration
{
    /// <summary>
    /// Configuration element
    /// </summary>
    public class MessageFieldMandatoryRuleElement : BaseMessageRuleElement
    {
        /// <summary>
        /// Field Indicator
        /// </summary>
        [ConfigurationProperty("FieldIndicator", IsRequired = true)]
        public string FieldIndicator
        {
            get
            {
                return (string)this["FieldIndicator"];
            }
            set
            {
                this["FieldIndicator"] = value;
            }
        }
    }
}
