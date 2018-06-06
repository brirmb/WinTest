using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormTest
{


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "AIPG")]

    public partial class TltQTransResponse
    {

        private AIPGINFO iNFOField;

        private AIPGQTDETAIL[] qTRANSRSPField;

        /// <remarks/>
        public AIPGINFO INFO
        {
            get
            {
                return this.iNFOField;
            }
            set
            {
                this.iNFOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("QTDETAIL", IsNullable = false)]
        public AIPGQTDETAIL[] QTRANSRSP
        {
            get
            {
                return this.qTRANSRSPField;
            }
            set
            {
                this.qTRANSRSPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AIPGINFO
    {

        private uint tRX_CODEField;

        private byte vERSIONField;

        private byte dATA_TYPEField;

        private string rEQ_SNField;

        private byte rET_CODEField;

        private string eRR_MSGField;

        private string sIGNED_MSGField;

        /// <remarks/>
        public uint TRX_CODE
        {
            get
            {
                return this.tRX_CODEField;
            }
            set
            {
                this.tRX_CODEField = value;
            }
        }

        /// <remarks/>
        public byte VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        public byte DATA_TYPE
        {
            get
            {
                return this.dATA_TYPEField;
            }
            set
            {
                this.dATA_TYPEField = value;
            }
        }

        /// <remarks/>
        public string REQ_SN
        {
            get
            {
                return this.rEQ_SNField;
            }
            set
            {
                this.rEQ_SNField = value;
            }
        }

        /// <remarks/>
        public byte RET_CODE
        {
            get
            {
                return this.rET_CODEField;
            }
            set
            {
                this.rET_CODEField = value;
            }
        }

        /// <remarks/>
        public string ERR_MSG
        {
            get
            {
                return this.eRR_MSGField;
            }
            set
            {
                this.eRR_MSGField = value;
            }
        }

        /// <remarks/>
        public string SIGNED_MSG
        {
            get
            {
                return this.sIGNED_MSGField;
            }
            set
            {
                this.sIGNED_MSGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AIPGQTDETAIL
    {

        private string bATCHIDField;

        private ushort snField;

        private byte tRXDIRField;

        private uint sETTDAYField;

        private ulong fINTIMEField;

        private ulong sUBMITTIMEField;

        private ulong aCCOUNT_NOField;

        private string aCCOUNT_NAMEField;

        private uint aMOUNTField;

        private string cUST_USERIDField;

        private string rEMARKField;

        private ushort rET_CODEField;

        private string eRR_MSGField;

        /// <remarks/>
        public string BATCHID
        {
            get
            {
                return this.bATCHIDField;
            }
            set
            {
                this.bATCHIDField = value;
            }
        }

        /// <remarks/>
        public ushort SN
        {
            get
            {
                return this.snField;
            }
            set
            {
                this.snField = value;
            }
        }

        /// <remarks/>
        public byte TRXDIR
        {
            get
            {
                return this.tRXDIRField;
            }
            set
            {
                this.tRXDIRField = value;
            }
        }

        /// <remarks/>
        public uint SETTDAY
        {
            get
            {
                return this.sETTDAYField;
            }
            set
            {
                this.sETTDAYField = value;
            }
        }

        /// <remarks/>
        public ulong FINTIME
        {
            get
            {
                return this.fINTIMEField;
            }
            set
            {
                this.fINTIMEField = value;
            }
        }

        /// <remarks/>
        public ulong SUBMITTIME
        {
            get
            {
                return this.sUBMITTIMEField;
            }
            set
            {
                this.sUBMITTIMEField = value;
            }
        }

        /// <remarks/>
        public ulong ACCOUNT_NO
        {
            get
            {
                return this.aCCOUNT_NOField;
            }
            set
            {
                this.aCCOUNT_NOField = value;
            }
        }

        /// <remarks/>
        public string ACCOUNT_NAME
        {
            get
            {
                return this.aCCOUNT_NAMEField;
            }
            set
            {
                this.aCCOUNT_NAMEField = value;
            }
        }

        /// <remarks/>
        public uint AMOUNT
        {
            get
            {
                return this.aMOUNTField;
            }
            set
            {
                this.aMOUNTField = value;
            }
        }

        /// <remarks/>
        public string CUST_USERID
        {
            get
            {
                return this.cUST_USERIDField;
            }
            set
            {
                this.cUST_USERIDField = value;
            }
        }

        /// <remarks/>
        public string REMARK
        {
            get
            {
                return this.rEMARKField;
            }
            set
            {
                this.rEMARKField = value;
            }
        }

        /// <remarks/>
        public ushort RET_CODE
        {
            get
            {
                return this.rET_CODEField;
            }
            set
            {
                this.rET_CODEField = value;
            }
        }

        /// <remarks/>
        public string ERR_MSG
        {
            get
            {
                return this.eRR_MSGField;
            }
            set
            {
                this.eRR_MSGField = value;
            }
        }
    }


    ///富友交易查询响应
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "qrytransrsp")]
    public partial class FuiouQueryResponse
    {

        private string retField;

        private string memoField;

        private qrytransrspTrans[] transField;

        /// <remarks/>
        public string ret
        {
            get
            {
                return this.retField;
            }
            set
            {
                this.retField = value;
            }
        }

        /// <remarks/>
        public string memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("trans")]
        public qrytransrspTrans[] trans
        {
            get
            {
                return this.transField;
            }
            set
            {
                this.transField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class qrytransrspTrans
    {

        private string merdtField;

        private string ordernoField;

        private string accntnoField;

        private string accntnmField;

        private string amtField;

        private string entseqField;

        private string memoField;

        private string stateField;

        private string resultField;

        private string reasonField;

        /// <remarks/>
        public string merdt
        {
            get
            {
                return this.merdtField;
            }
            set
            {
                this.merdtField = value;
            }
        }

        /// <remarks/>
        public string orderno
        {
            get
            {
                return this.ordernoField;
            }
            set
            {
                this.ordernoField = value;
            }
        }

        /// <remarks/>
        public string accntno
        {
            get
            {
                return this.accntnoField;
            }
            set
            {
                this.accntnoField = value;
            }
        }

        /// <remarks/>
        public string accntnm
        {
            get
            {
                return this.accntnmField;
            }
            set
            {
                this.accntnmField = value;
            }
        }

        /// <remarks/>
        public string amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

        /// <remarks/>
        public string entseq
        {
            get
            {
                return this.entseqField;
            }
            set
            {
                this.entseqField = value;
            }
        }

        /// <remarks/>
        public string memo
        {
            get
            {
                return this.memoField;
            }
            set
            {
                this.memoField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string result
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
        public string reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }
    }

}
