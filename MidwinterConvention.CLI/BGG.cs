using System;
using System.Collections.Generic;
using System.Text;

namespace MidwinterConvention.CLI
{
    public class BGG
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class items
        {

            private itemsItem[] itemField;

            private string termsofuseField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("item")]
            public itemsItem[] item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string termsofuse
            {
                get
                {
                    return this.termsofuseField;
                }
                set
                {
                    this.termsofuseField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItem
        {

            private object[] itemsField;

            private ItemsChoiceType[] itemsElementNameField;

            private string typeField;

            private uint idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("description", typeof(string))]
            [System.Xml.Serialization.XmlElementAttribute("image", typeof(string))]
            [System.Xml.Serialization.XmlElementAttribute("link", typeof(itemsItemLink))]
            [System.Xml.Serialization.XmlElementAttribute("maxplayers", typeof(itemsItemMaxplayers))]
            [System.Xml.Serialization.XmlElementAttribute("maxplaytime", typeof(itemsItemMaxplaytime))]
            [System.Xml.Serialization.XmlElementAttribute("minage", typeof(itemsItemMinage))]
            [System.Xml.Serialization.XmlElementAttribute("minplayers", typeof(itemsItemMinplayers))]
            [System.Xml.Serialization.XmlElementAttribute("minplaytime", typeof(itemsItemMinplaytime))]
            [System.Xml.Serialization.XmlElementAttribute("name", typeof(itemsItemName))]
            [System.Xml.Serialization.XmlElementAttribute("playingtime", typeof(itemsItemPlayingtime))]
            [System.Xml.Serialization.XmlElementAttribute("poll", typeof(itemsItemPoll))]
            [System.Xml.Serialization.XmlElementAttribute("statistics", typeof(itemsItemStatistics))]
            [System.Xml.Serialization.XmlElementAttribute("thumbnail", typeof(string))]
            [System.Xml.Serialization.XmlElementAttribute("yearpublished", typeof(itemsItemYearpublished))]
            [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public ItemsChoiceType[] ItemsElementName
            {
                get
                {
                    return this.itemsElementNameField;
                }
                set
                {
                    this.itemsElementNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemLink
        {

            private string typeField;

            private uint idField;

            private string valueField;

            private bool inboundField;

            private bool inboundFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool inbound
            {
                get
                {
                    return this.inboundField;
                }
                set
                {
                    this.inboundField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool inboundSpecified
            {
                get
                {
                    return this.inboundFieldSpecified;
                }
                set
                {
                    this.inboundFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemMaxplayers
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemMaxplaytime
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemMinage
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemMinplayers
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemMinplaytime
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemName
        {

            private string typeField;

            private byte sortindexField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte sortindex
            {
                get
                {
                    return this.sortindexField;
                }
                set
                {
                    this.sortindexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemPlayingtime
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemPoll
        {

            private itemsItemPollResults[] resultsField;

            private string nameField;

            private string titleField;

            private ushort totalvotesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("results")]
            public itemsItemPollResults[] results
            {
                get
                {
                    return this.resultsField;
                }
                set
                {
                    this.resultsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort totalvotes
            {
                get
                {
                    return this.totalvotesField;
                }
                set
                {
                    this.totalvotesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemPollResults
        {

            private itemsItemPollResultsResult[] resultField;

            private string numplayersField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("result")]
            public itemsItemPollResultsResult[] result
            {
                get
                {
                    return this.resultField;
                }
                set
                {
                    this.resultField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string numplayers
            {
                get
                {
                    return this.numplayersField;
                }
                set
                {
                    this.numplayersField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemPollResultsResult
        {

            private string valueField;

            private ushort numvotesField;

            private ushort levelField;

            private bool levelFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort numvotes
            {
                get
                {
                    return this.numvotesField;
                }
                set
                {
                    this.numvotesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort level
            {
                get
                {
                    return this.levelField;
                }
                set
                {
                    this.levelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool levelSpecified
            {
                get
                {
                    return this.levelFieldSpecified;
                }
                set
                {
                    this.levelFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatistics
        {

            private itemsItemStatisticsRatings ratingsField;

            private byte pageField;

            /// <remarks/>
            public itemsItemStatisticsRatings ratings
            {
                get
                {
                    return this.ratingsField;
                }
                set
                {
                    this.ratingsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte page
            {
                get
                {
                    return this.pageField;
                }
                set
                {
                    this.pageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatings
        {

            private itemsItemStatisticsRatingsUsersrated usersratedField;

            private itemsItemStatisticsRatingsAverage averageField;

            private itemsItemStatisticsRatingsBayesaverage bayesaverageField;

            private itemsItemStatisticsRatingsRank[] ranksField;

            private itemsItemStatisticsRatingsStddev stddevField;

            private itemsItemStatisticsRatingsMedian medianField;

            private itemsItemStatisticsRatingsOwned ownedField;

            private itemsItemStatisticsRatingsTrading tradingField;

            private itemsItemStatisticsRatingsWanting wantingField;

            private itemsItemStatisticsRatingsWishing wishingField;

            private itemsItemStatisticsRatingsNumcomments numcommentsField;

            private itemsItemStatisticsRatingsNumweights numweightsField;

            private itemsItemStatisticsRatingsAverageweight averageweightField;

            /// <remarks/>
            public itemsItemStatisticsRatingsUsersrated usersrated
            {
                get
                {
                    return this.usersratedField;
                }
                set
                {
                    this.usersratedField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsAverage average
            {
                get
                {
                    return this.averageField;
                }
                set
                {
                    this.averageField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsBayesaverage bayesaverage
            {
                get
                {
                    return this.bayesaverageField;
                }
                set
                {
                    this.bayesaverageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("rank", IsNullable = false)]
            public itemsItemStatisticsRatingsRank[] ranks
            {
                get
                {
                    return this.ranksField;
                }
                set
                {
                    this.ranksField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsStddev stddev
            {
                get
                {
                    return this.stddevField;
                }
                set
                {
                    this.stddevField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsMedian median
            {
                get
                {
                    return this.medianField;
                }
                set
                {
                    this.medianField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsOwned owned
            {
                get
                {
                    return this.ownedField;
                }
                set
                {
                    this.ownedField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsTrading trading
            {
                get
                {
                    return this.tradingField;
                }
                set
                {
                    this.tradingField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsWanting wanting
            {
                get
                {
                    return this.wantingField;
                }
                set
                {
                    this.wantingField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsWishing wishing
            {
                get
                {
                    return this.wishingField;
                }
                set
                {
                    this.wishingField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsNumcomments numcomments
            {
                get
                {
                    return this.numcommentsField;
                }
                set
                {
                    this.numcommentsField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsNumweights numweights
            {
                get
                {
                    return this.numweightsField;
                }
                set
                {
                    this.numweightsField = value;
                }
            }

            /// <remarks/>
            public itemsItemStatisticsRatingsAverageweight averageweight
            {
                get
                {
                    return this.averageweightField;
                }
                set
                {
                    this.averageweightField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsUsersrated
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsAverage
        {

            private decimal valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsBayesaverage
        {

            private decimal valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsRank
        {

            private string typeField;

            private ushort idField;

            private string nameField;

            private string friendlynameField;

            private string valueField;

            private string bayesaverageField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string friendlyname
            {
                get
                {
                    return this.friendlynameField;
                }
                set
                {
                    this.friendlynameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string bayesaverage
            {
                get
                {
                    return this.bayesaverageField;
                }
                set
                {
                    this.bayesaverageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsStddev
        {

            private decimal valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsMedian
        {

            private byte valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsOwned
        {

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsTrading
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsWanting
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsWishing
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsNumcomments
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsNumweights
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemStatisticsRatingsAverageweight
        {

            private decimal valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItemYearpublished
        {

            private ushort valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
        public enum ItemsChoiceType
        {

            /// <remarks/>
            description,

            /// <remarks/>
            image,

            /// <remarks/>
            link,

            /// <remarks/>
            maxplayers,

            /// <remarks/>
            maxplaytime,

            /// <remarks/>
            minage,

            /// <remarks/>
            minplayers,

            /// <remarks/>
            minplaytime,

            /// <remarks/>
            name,

            /// <remarks/>
            playingtime,

            /// <remarks/>
            poll,

            /// <remarks/>
            statistics,

            /// <remarks/>
            thumbnail,

            /// <remarks/>
            yearpublished,
        }


    }
}
