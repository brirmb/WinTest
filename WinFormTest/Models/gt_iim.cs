namespace WinFormTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gt_iim
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string iid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string iprod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string idesc { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal iadj { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal irct { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal iiss { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal iopb { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal iyiss { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal iytdu { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal iysls { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal imsls { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2)]
        public string iclas { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(2)]
        public string iums { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(2)]
        public string iump { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal iumcn { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1)]
        public string iityp { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal ilead { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal ivend { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal iven2 { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal icusa { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal iprda { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal imin { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal ildte { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal ilist { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal iscst { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal iacst { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal ifcst { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal ilevl { get; set; }

        [Key]
        [Column(Order = 28)]
        public decimal ionod { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(2)]
        public string idisc { get; set; }

        [Key]
        [Column(Order = 30)]
        public decimal inseq { get; set; }

        [Key]
        [Column(Order = 31)]
        public decimal itseq { get; set; }

        [Key]
        [Column(Order = 32)]
        public decimal icyc { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(30)]
        public string idraw { get; set; }

        [Key]
        [Column(Order = 34)]
        public decimal imtdu { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(1)]
        public string imrp { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(1)]
        public string iact { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(1)]
        public string iordp { get; set; }

        [Key]
        [Column(Order = 38)]
        public decimal iyrct { get; set; }

        [Key]
        [Column(Order = 39)]
        public decimal ilots { get; set; }

        [Key]
        [Column(Order = 40)]
        public decimal iyadj { get; set; }

        [Key]
        [Column(Order = 41)]
        public decimal imcos { get; set; }

        [Key]
        [Column(Order = 42)]
        public decimal iycos { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(1)]
        public string imust { get; set; }

        [Key]
        [Column(Order = 44)]
        public decimal iordc { get; set; }

        [Key]
        [Column(Order = 45)]
        public decimal iaveu { get; set; }

        [Key]
        [Column(Order = 46)]
        [StringLength(30)]
        public string idsce { get; set; }

        [Key]
        [Column(Order = 47)]
        public decimal iwght { get; set; }

        [Key]
        [Column(Order = 48)]
        [StringLength(7)]
        public string iabbt { get; set; }

        [Key]
        [Column(Order = 49)]
        [StringLength(1)]
        public string iabc { get; set; }

        [Key]
        [Column(Order = 50)]
        [StringLength(10)]
        public string ipfdv { get; set; }

        [Key]
        [Column(Order = 51)]
        public decimal ipack { get; set; }

        [Key]
        [Column(Order = 52)]
        public decimal ilabl { get; set; }

        [Key]
        [Column(Order = 53)]
        [StringLength(4)]
        public string idrf { get; set; }

        [Key]
        [Column(Order = 54)]
        public decimal iclng { get; set; }

        [Key]
        [Column(Order = 55)]
        public decimal icwid { get; set; }

        [Key]
        [Column(Order = 56)]
        [StringLength(15)]
        public string ipitm { get; set; }

        [Key]
        [Column(Order = 57)]
        [StringLength(150)]
        public string isitm { get; set; }

        [Key]
        [Column(Order = 58)]
        [StringLength(3)]
        public string ibuyc { get; set; }

        [Key]
        [Column(Order = 59)]
        [StringLength(10)]
        public string ifeno { get; set; }

        [Key]
        [Column(Order = 60)]
        [StringLength(2)]
        public string iumr { get; set; }

        [Key]
        [Column(Order = 61)]
        public decimal iumrc { get; set; }

        [Key]
        [Column(Order = 62)]
        [StringLength(3)]
        public string ifii { get; set; }

        [Key]
        [Column(Order = 63)]
        [StringLength(5)]
        public string taxc1 { get; set; }

        [Key]
        [Column(Order = 64)]
        public decimal saflg { get; set; }

        [Key]
        [Column(Order = 65)]
        public decimal iioq { get; set; }

        [Key]
        [Column(Order = 66)]
        public decimal ibtch { get; set; }

        [Key]
        [Column(Order = 67)]
        public decimal iyuse { get; set; }

        [Key]
        [Column(Order = 68)]
        [StringLength(1)]
        public string icycf { get; set; }

        [Key]
        [Column(Order = 69)]
        public decimal ipers { get; set; }

        [Key]
        [Column(Order = 70)]
        public decimal istyl { get; set; }

        [Key]
        [Column(Order = 71)]
        public decimal ipody { get; set; }

        [Key]
        [Column(Order = 72)]
        public decimal itfdy { get; set; }

        [Key]
        [Column(Order = 73)]
        [StringLength(1)]
        public string ifrfg { get; set; }

        [Key]
        [Column(Order = 74)]
        [StringLength(1)]
        public string isact { get; set; }

        [Key]
        [Column(Order = 75)]
        public decimal iumat { get; set; }

        [Key]
        [Column(Order = 76)]
        public decimal ivuli { get; set; }

        [Key]
        [Column(Order = 77)]
        public decimal ivulp { get; set; }

        [Key]
        [Column(Order = 78)]
        [StringLength(1)]
        public string inccfg { get; set; }

        [Key]
        [Column(Order = 79)]
        [StringLength(2)]
        public string iwhs { get; set; }

        [Key]
        [Column(Order = 80)]
        [StringLength(1)]
        public string isofl { get; set; }

        [Key]
        [Column(Order = 81)]
        public decimal ilcc { get; set; }

        [Key]
        [Column(Order = 82)]
        [StringLength(1)]
        public string ijit { get; set; }

        [Key]
        [Column(Order = 83)]
        public decimal iuncn { get; set; }

        [Key]
        [Column(Order = 84)]
        public decimal imaxr { get; set; }

        [Key]
        [Column(Order = 85)]
        public decimal iminr { get; set; }

        [Key]
        [Column(Order = 86)]
        public decimal ipctk { get; set; }

        [Key]
        [Column(Order = 87)]
        [StringLength(18)]
        public string igtec { get; set; }

        [Key]
        [Column(Order = 88)]
        public decimal imaxp { get; set; }

        [Key]
        [Column(Order = 89)]
        public decimal imtdp { get; set; }

        [Key]
        [Column(Order = 90)]
        public decimal iytdp { get; set; }

        [Key]
        [Column(Order = 91)]
        public decimal itgqy { get; set; }

        [Key]
        [Column(Order = 92)]
        public decimal iarrt { get; set; }

        [Key]
        [Column(Order = 93)]
        public decimal imxin { get; set; }

        [Key]
        [Column(Order = 94)]
        public decimal idmtf { get; set; }

        [Key]
        [Column(Order = 95)]
        [StringLength(1)]
        public string idmc1 { get; set; }

        [Key]
        [Column(Order = 96)]
        [StringLength(1)]
        public string idmc2 { get; set; }

        [Key]
        [Column(Order = 97)]
        public decimal imbhd { get; set; }

        [Key]
        [Column(Order = 98)]
        public decimal imbdy { get; set; }

        [Key]
        [Column(Order = 99)]
        public decimal idltr { get; set; }

        [Key]
        [Column(Order = 100)]
        public decimal imqdy { get; set; }

        [Key]
        [Column(Order = 101)]
        public decimal imbwt { get; set; }

        [Key]
        [Column(Order = 102)]
        public decimal impot { get; set; }

        [Key]
        [Column(Order = 103)]
        [StringLength(1)]
        public string imusc { get; set; }

        [Key]
        [Column(Order = 104)]
        [StringLength(2)]
        public string imumb { get; set; }

        [Key]
        [Column(Order = 105)]
        [StringLength(2)]
        public string imuma { get; set; }

        [Key]
        [Column(Order = 106)]
        [StringLength(3)]
        public string ipurc { get; set; }

        [Key]
        [Column(Order = 107)]
        [StringLength(1)]
        public string imsum { get; set; }

        [Key]
        [Column(Order = 108)]
        [StringLength(1)]
        public string ibusy { get; set; }

        [Key]
        [Column(Order = 109)]
        [StringLength(1)]
        public string idscr { get; set; }

        [Key]
        [Column(Order = 110)]
        [StringLength(1)]
        public string impsd { get; set; }

        [Key]
        [Column(Order = 111)]
        [StringLength(6)]
        public string iloc { get; set; }

        [Key]
        [Column(Order = 112)]
        [StringLength(2)]
        public string imcom { get; set; }

        [Key]
        [Column(Order = 113)]
        [StringLength(24)]
        public string iglno { get; set; }

        [Key]
        [Column(Order = 114)]
        [StringLength(3)]
        public string ifci { get; set; }

        [Key]
        [Column(Order = 115)]
        public decimal icond { get; set; }

        [Key]
        [Column(Order = 116)]
        [StringLength(5)]
        public string iref01 { get; set; }

        [Key]
        [Column(Order = 117)]
        [StringLength(5)]
        public string iref02 { get; set; }

        [Key]
        [Column(Order = 118)]
        [StringLength(5)]
        public string iref03 { get; set; }

        [Key]
        [Column(Order = 119)]
        [StringLength(5)]
        public string iref04 { get; set; }

        [Key]
        [Column(Order = 120)]
        [StringLength(5)]
        public string iref05 { get; set; }

        [Key]
        [Column(Order = 121)]
        [StringLength(4)]
        public string iorign { get; set; }

        [Key]
        [Column(Order = 122)]
        [StringLength(15)]
        public string imcomc { get; set; }

        [Key]
        [Column(Order = 123)]
        [StringLength(3)]
        public string imfrmc { get; set; }

        [Key]
        [Column(Order = 124)]
        [StringLength(2)]
        public string imrevl { get; set; }

        [Key]
        [Column(Order = 125)]
        [StringLength(15)]
        public string imform { get; set; }

        [Key]
        [Column(Order = 126)]
        [StringLength(1)]
        public string imcctl { get; set; }

        [Key]
        [Column(Order = 127)]
        [StringLength(15)]
        public string imbndp { get; set; }

        [Key]
        [Column(Order = 128)]
        [StringLength(15)]
        public string imbndc { get; set; }

        [Key]
        [Column(Order = 129)]
        public decimal immndt { get; set; }

        [Key]
        [Column(Order = 130)]
        public decimal immntm { get; set; }

        [Key]
        [Column(Order = 131)]
        [StringLength(10)]
        public string immnus { get; set; }

        [Key]
        [Column(Order = 132)]
        [StringLength(1)]
        public string imbwip { get; set; }

        [Key]
        [Column(Order = 133)]
        [StringLength(2)]
        public string impmth { get; set; }

        [Key]
        [Column(Order = 134)]
        [StringLength(2)]
        public string imcmth { get; set; }

        [Key]
        [Column(Order = 135)]
        public decimal imqled { get; set; }

        [Key]
        [Column(Order = 136)]
        public decimal imalot { get; set; }

        [Key]
        [Column(Order = 137)]
        [StringLength(150)]
        public string imnot1 { get; set; }

        [Key]
        [Column(Order = 138)]
        [StringLength(60)]
        public string imnot2 { get; set; }

        [Key]
        [Column(Order = 139)]
        [StringLength(8)]
        public string immfgr { get; set; }

        [Key]
        [Column(Order = 140)]
        [StringLength(1)]
        public string imvfry { get; set; }

        [Key]
        [Column(Order = 141)]
        [StringLength(15)]
        public string imspec { get; set; }

        [Key]
        [Column(Order = 142)]
        [StringLength(1)]
        public string imtlvl { get; set; }

        [Key]
        [Column(Order = 143)]
        public decimal imqle2 { get; set; }

        [Key]
        [Column(Order = 144)]
        [StringLength(15)]
        public string imsspc { get; set; }

        [Key]
        [Column(Order = 145)]
        [StringLength(1)]
        public string imastb { get; set; }

        [Key]
        [Column(Order = 146)]
        public decimal imcntr { get; set; }

        [Key]
        [Column(Order = 147)]
        [StringLength(60)]
        public string impkd1 { get; set; }

        [Key]
        [Column(Order = 148)]
        [StringLength(60)]
        public string impkd2 { get; set; }

        [Key]
        [Column(Order = 149)]
        [StringLength(10)]
        public string imhzrd { get; set; }

        [Key]
        [Column(Order = 150)]
        [StringLength(15)]
        public string imcstc { get; set; }

        [Key]
        [Column(Order = 151)]
        [StringLength(15)]
        public string imcorp { get; set; }

        [Key]
        [Column(Order = 152)]
        [StringLength(1)]
        public string imqctl { get; set; }

        [Key]
        [Column(Order = 153)]
        public decimal imcqty { get; set; }

        [Key]
        [Column(Order = 154)]
        public decimal idsalw { get; set; }

        [Key]
        [Column(Order = 155)]
        public decimal imrelp { get; set; }

        [Key]
        [Column(Order = 156)]
        [StringLength(12)]
        public string imtccd { get; set; }

        [Key]
        [Column(Order = 157)]
        [StringLength(10)]
        public string imcntt { get; set; }

        [Key]
        [Column(Order = 158)]
        [StringLength(10)]
        public string imptyp { get; set; }

        [Key]
        [Column(Order = 159)]
        [StringLength(1)]
        public string icstcg { get; set; }

        [Key]
        [Column(Order = 160)]
        public decimal imendt { get; set; }

        [Key]
        [Column(Order = 161)]
        public decimal imentm { get; set; }

        [Key]
        [Column(Order = 162)]
        [StringLength(10)]
        public string imenus { get; set; }

        [Key]
        [Column(Order = 163)]
        [StringLength(2)]
        public string imwtum { get; set; }

        [Key]
        [Column(Order = 164)]
        [StringLength(2)]
        public string imvuom { get; set; }

        [Key]
        [Column(Order = 165)]
        public decimal imfprc { get; set; }

        [Key]
        [Column(Order = 166)]
        public decimal imnnwu { get; set; }

        [Key]
        [Column(Order = 167)]
        public decimal imlong { get; set; }

        [Key]
        [Column(Order = 168)]
        [StringLength(2)]
        public string imluom { get; set; }

        [Key]
        [Column(Order = 169)]
        public decimal imwide { get; set; }

        [Key]
        [Column(Order = 170)]
        [StringLength(2)]
        public string imwdum { get; set; }

        [Key]
        [Column(Order = 171)]
        public decimal imhigh { get; set; }

        [Key]
        [Column(Order = 172)]
        [StringLength(2)]
        public string imhuom { get; set; }

        [Key]
        [Column(Order = 173)]
        [StringLength(10)]
        public string imhrmn { get; set; }

        [Key]
        [Column(Order = 174)]
        [StringLength(4)]
        public string imanxn { get; set; }

        [Key]
        [Column(Order = 175)]
        [StringLength(6)]
        public string imunse { get; set; }

        [Key]
        [Column(Order = 176)]
        [StringLength(6)]
        public string imunrl { get; set; }

        [Key]
        [Column(Order = 177)]
        [StringLength(6)]
        public string imunrd { get; set; }

        [Key]
        [Column(Order = 178)]
        [StringLength(6)]
        public string imunai { get; set; }

        [Key]
        [Column(Order = 179)]
        [StringLength(6)]
        public string imunpo { get; set; }

        [Key]
        [Column(Order = 180)]
        [StringLength(6)]
        public string imunop { get; set; }

        [Key]
        [Column(Order = 181)]
        public decimal imflpc { get; set; }

        [Key]
        [Column(Order = 182)]
        public decimal imflpf { get; set; }

        [Key]
        [Column(Order = 183)]
        public decimal imrfpk { get; set; }

        [Key]
        [Column(Order = 184)]
        public decimal imlttm { get; set; }

        [Key]
        [Column(Order = 185)]
        [StringLength(2)]
        public string imlttz { get; set; }

        [Key]
        [Column(Order = 186)]
        public decimal imcctm { get; set; }

        [Key]
        [Column(Order = 187)]
        [StringLength(2)]
        public string imcctz { get; set; }

        [Key]
        [Column(Order = 188)]
        [StringLength(2)]
        public string imctz { get; set; }

        [Key]
        [Column(Order = 189)]
        [StringLength(2)]
        public string imltz { get; set; }

        [Key]
        [Column(Order = 190)]
        [StringLength(10)]
        public string imlpgm { get; set; }

        [Key]
        [Column(Order = 191)]
        [StringLength(2)]
        public string imprm { get; set; }

        [Key]
        [Column(Order = 192)]
        public decimal imecst { get; set; }

        [Key]
        [Column(Order = 193)]
        [StringLength(15)]
        public string imabrv { get; set; }

        [Key]
        [Column(Order = 194)]
        [StringLength(2)]
        public string immfmd { get; set; }

        [Key]
        [Column(Order = 195)]
        [StringLength(1)]
        public string imgsor { get; set; }

        [Key]
        [Column(Order = 196)]
        public decimal imalrq { get; set; }

        [Key]
        [Column(Order = 197)]
        [StringLength(2)]
        public string imbrgc { get; set; }

        [Key]
        [Column(Order = 198)]
        public decimal imldte { get; set; }

        [Key]
        [Column(Order = 199)]
        public decimal imltme { get; set; }

        [Key]
        [Column(Order = 200)]
        [StringLength(10)]
        public string imlusr { get; set; }

        [Key]
        [Column(Order = 201)]
        [StringLength(2)]
        public string imdsfw { get; set; }

        public decimal? serialcolumn { get; set; }
    }
}
