namespace WinFormTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RLDBContext : DbContext
    {
        public RLDBContext()
            : base("name=RLDBContext")
        {
        }

        public virtual DbSet<CheckRecord> CheckRecord { get; set; }
        public virtual DbSet<ephead> ephead { get; set; }
        public virtual DbSet<GSEmployee> GSEmployee { get; set; }
        public virtual DbSet<GSItem> GSItem { get; set; }
        public virtual DbSet<GSProcess> GSProcess { get; set; }
        public virtual DbSet<GSWorkDetail> GSWorkDetail { get; set; }
        public virtual DbSet<GSWorkHead> GSWorkHead { get; set; }
        public virtual DbSet<inventory> inventory { get; set; }
        public virtual DbSet<inventory1> inventory1 { get; set; }
        public virtual DbSet<INVIWM> INVIWM { get; set; }
        public virtual DbSet<keeper> keeper { get; set; }
        public virtual DbSet<morder> morder { get; set; }
        public virtual DbSet<mplan> mplan { get; set; }
        public virtual DbSet<mprocess> mprocess { get; set; }
        public virtual DbSet<rbosys> rbosys { get; set; }
        public virtual DbSet<repair> repair { get; set; }
        public virtual DbSet<securitycheck> securitycheck { get; set; }
        public virtual DbSet<station> station { get; set; }
        public virtual DbSet<tdmbomh> tdmbomh { get; set; }
        public virtual DbSet<tdmbomh2> tdmbomh2 { get; set; }
        public virtual DbSet<vendor> vendor { get; set; }
        public virtual DbSet<zjplan> zjplan { get; set; }
        public virtual DbSet<baseparameter> baseparameter { get; set; }
        public virtual DbSet<glscum> glscum { get; set; }
        public virtual DbSet<GSClass> GSClass { get; set; }
        public virtual DbSet<GSDepart> GSDepart { get; set; }
        public virtual DbSet<GSMachine> GSMachine { get; set; }
        public virtual DbSet<gt_iim> gt_iim { get; set; }
        public virtual DbSet<inviim> inviim { get; set; }
        public virtual DbSet<mprocess_detail> mprocess_detail { get; set; }
        public virtual DbSet<Proc1> Proc1 { get; set; }
        public virtual DbSet<purhph> purhph { get; set; }
        public virtual DbSet<purhpo> purhpo { get; set; }
        public virtual DbSet<purprh> purprh { get; set; }
        public virtual DbSet<purprl> purprl { get; set; }
        public virtual DbSet<salare> salare { get; set; }
        public virtual DbSet<saldim> saldim { get; set; }
        public virtual DbSet<salest> salest { get; set; }
        public virtual DbSet<salhed> salhed { get; set; }
        public virtual DbSet<salmin> salmin { get; set; }
        public virtual DbSet<salsys> salsys { get; set; }
        public virtual DbSet<saltem> saltem { get; set; }
        public virtual DbSet<shiping> shiping { get; set; }
        public virtual DbSet<shiping1> shiping1 { get; set; }
        public virtual DbSet<tdmbap> tdmbap { get; set; }
        public virtual DbSet<tdmbom> tdmbom { get; set; }
        public virtual DbSet<tdmbom2> tdmbom2 { get; set; }
        public virtual DbSet<trtrtm> trtrtm { get; set; }
        public virtual DbSet<tsbord> tsbord { get; set; }
        public virtual DbSet<tsfcbom> tsfcbom { get; set; }
        public virtual DbSet<tsfcbom2> tsfcbom2 { get; set; }
        public virtual DbSet<zsc> zsc { get; set; }
        public virtual DbSet<zxa> zxa { get; set; }
        public virtual DbSet<zxo> zxo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.Repno)
                .IsFixedLength();

            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.Roperator)
                .IsFixedLength();

            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.Rmaintain)
                .IsFixedLength();

            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.RClean)
                .IsFixedLength();

            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.Rput)
                .IsFixedLength();

            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.Radvise)
                .IsFixedLength();

            modelBuilder.Entity<CheckRecord>()
                .Property(e => e.Rdate)
                .IsFixedLength();

            modelBuilder.Entity<ephead>()
                .Property(e => e.epid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ephead>()
                .Property(e => e.epno)
                .IsFixedLength();

            modelBuilder.Entity<ephead>()
                .Property(e => e.epoutno)
                .IsFixedLength();

            modelBuilder.Entity<ephead>()
                .Property(e => e.eppurdate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ephead>()
                .Property(e => e.epstore)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ephead>()
                .Property(e => e.epkeepercode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GSEmployee>()
                .Property(e => e.empid)
                .IsFixedLength();

            modelBuilder.Entity<GSEmployee>()
                .Property(e => e.empname)
                .IsUnicode(false);

            modelBuilder.Entity<GSEmployee>()
                .Property(e => e.empclass)
                .IsUnicode(false);

            modelBuilder.Entity<GSEmployee>()
                .Property(e => e.empdepart)
                .IsUnicode(false);

            modelBuilder.Entity<GSItem>()
                .Property(e => e.itemno)
                .IsFixedLength();

            modelBuilder.Entity<GSItem>()
                .Property(e => e.itemname)
                .IsUnicode(false);

            modelBuilder.Entity<GSItem>()
                .Property(e => e.itemmaterial)
                .IsUnicode(false);

            modelBuilder.Entity<GSItem>()
                .Property(e => e.itemspec)
                .IsUnicode(false);

            modelBuilder.Entity<GSProcess>()
                .Property(e => e.readytime)
                .HasPrecision(4, 2);

            modelBuilder.Entity<GSProcess>()
                .Property(e => e.worktime)
                .HasPrecision(4, 2);

            modelBuilder.Entity<GSWorkDetail>()
                .Property(e => e.readytime)
                .HasPrecision(4, 2);

            modelBuilder.Entity<GSWorkDetail>()
                .Property(e => e.operatetime)
                .HasPrecision(4, 2);

            modelBuilder.Entity<GSWorkDetail>()
                .Property(e => e.subHours)
                .HasPrecision(5, 2);

            modelBuilder.Entity<GSWorkDetail>()
                .Property(e => e.machineHours)
                .HasPrecision(4, 2);

            modelBuilder.Entity<GSWorkDetail>()
                .Property(e => e.workdate)
                .IsFixedLength();

            modelBuilder.Entity<GSWorkDetail>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<GSWorkHead>()
                .Property(e => e.type)
                .IsFixedLength();

            modelBuilder.Entity<GSWorkHead>()
                .Property(e => e.worktime)
                .HasPrecision(6, 2);

            modelBuilder.Entity<GSWorkHead>()
                .Property(e => e.declaredate)
                .IsFixedLength();

            modelBuilder.Entity<inventory>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.Pono)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.Mono)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.ProcCode)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.PoName)
                .IsUnicode(false);

            modelBuilder.Entity<inventory>()
                .Property(e => e.Qty)
                .HasPrecision(10, 2);

            modelBuilder.Entity<inventory>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.WHCode)
                .IsUnicode(false);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.Pono)
                .IsUnicode(false);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.Mono)
                .IsUnicode(false);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.ProcCode)
                .IsUnicode(false);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.PoName)
                .IsUnicode(false);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.Qty)
                .HasPrecision(10, 2);

            modelBuilder.Entity<inventory1>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.WMID)
                .IsUnicode(false);

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.WMwhs)
                .IsUnicode(false);

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmdes)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmarea)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmprov)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmcoty)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmadr1)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmadr2)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmadr3)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmpon1)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmpon2)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmpon3)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmfax1)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmfax2)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmmal1)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmmal2)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmctat)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmtyp)
                .IsFixedLength();

            modelBuilder.Entity<INVIWM>()
                .Property(e => e.wmranh)
                .IsFixedLength();

            modelBuilder.Entity<keeper>()
                .Property(e => e.kpid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<keeper>()
                .Property(e => e.kpcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Mono)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Custname)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Moqty)
                .HasPrecision(9, 0);

            modelBuilder.Entity<morder>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material1)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material2)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material3)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material4)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material5)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material6)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material7)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material8)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Mway)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Material9)
                .IsUnicode(false);

            modelBuilder.Entity<morder>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<mplan>()
                .Property(e => e.Mono)
                .IsUnicode(false);

            modelBuilder.Entity<mplan>()
                .Property(e => e.month)
                .IsUnicode(false);

            modelBuilder.Entity<mplan>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<mplan>()
                .Property(e => e.Spec)
                .IsUnicode(false);

            modelBuilder.Entity<mplan>()
                .Property(e => e.Unit)
                .IsUnicode(false);

            modelBuilder.Entity<mplan>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess>()
                .Property(e => e.mono)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess>()
                .Property(e => e.pono)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess>()
                .Property(e => e.poname)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess>()
                .Property(e => e.unit)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess>()
                .Property(e => e.procCode)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess>()
                .Property(e => e.stationCode)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.sid)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.val1)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.val2)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.val3)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.val4)
                .IsUnicode(false);

            modelBuilder.Entity<rbosys>()
                .Property(e => e.desc)
                .IsUnicode(false);

            modelBuilder.Entity<repair>()
                .Property(e => e.repno)
                .IsFixedLength();

            modelBuilder.Entity<repair>()
                .Property(e => e.repepno)
                .IsFixedLength();

            modelBuilder.Entity<repair>()
                .Property(e => e.repamt)
                .HasPrecision(15, 0);

            modelBuilder.Entity<repair>()
                .Property(e => e.repwho)
                .IsFixedLength();

            modelBuilder.Entity<repair>()
                .Property(e => e.repuser)
                .IsFixedLength();

            modelBuilder.Entity<repair>()
                .Property(e => e.repdate)
                .IsFixedLength();

            modelBuilder.Entity<repair>()
                .Property(e => e.serialno)
                .HasPrecision(18, 0);

            modelBuilder.Entity<securitycheck>()
                .Property(e => e.chkepno)
                .IsFixedLength();

            modelBuilder.Entity<securitycheck>()
                .Property(e => e.chkuser)
                .IsFixedLength();

            modelBuilder.Entity<securitycheck>()
                .Property(e => e.chkdate)
                .IsFixedLength();

            modelBuilder.Entity<securitycheck>()
                .Property(e => e.chkremark)
                .IsFixedLength();

            modelBuilder.Entity<station>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<station>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<station>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhsts)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhmno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhwno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhver)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhcus)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhnam)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhtyp)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhrat)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhmat)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhsiz)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhnot)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tdmbomh>()
                .Property(e => e.bomhunit)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhsts)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhmno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhwno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhver)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhcus)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhnam)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhtyp)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhrat)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhmat)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhsiz)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhnot)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tdmbomh2>()
                .Property(e => e.bomhunit)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vname)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vprov)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vcoty)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vadr)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vphone)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vfax)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vemail)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vcontract)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vterm)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vcurr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vbank)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vacct)
                .IsUnicode(false);

            modelBuilder.Entity<vendor>()
                .Property(e => e.vremark)
                .IsUnicode(false);

            modelBuilder.Entity<zjplan>()
                .Property(e => e.mono)
                .IsUnicode(false);

            modelBuilder.Entity<zjplan>()
                .Property(e => e.item)
                .IsUnicode(false);

            modelBuilder.Entity<zjplan>()
                .Property(e => e.person)
                .IsUnicode(false);

            modelBuilder.Entity<zjplan>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<baseparameter>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<baseparameter>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<baseparameter>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<glscum>()
                .Property(e => e.gcmatv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<glscum>()
                .Property(e => e.gcmcurr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GSClass>()
                .Property(e => e._class)
                .IsUnicode(false);

            modelBuilder.Entity<GSDepart>()
                .Property(e => e.depart)
                .IsUnicode(false);

            modelBuilder.Entity<GSMachine>()
                .Property(e => e.machine)
                .IsUnicode(false);

            modelBuilder.Entity<GSMachine>()
                .Property(e => e.machineName)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iid)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iprod)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idesc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iadj)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.irct)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iiss)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iopb)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iyiss)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iytdu)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iysls)
                .HasPrecision(15, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imsls)
                .HasPrecision(15, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iclas)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iums)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iump)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iumcn)
                .HasPrecision(11, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iityp)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ilead)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ivend)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iven2)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.icusa)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iprda)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imin)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ildte)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ilist)
                .HasPrecision(14, 4);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iscst)
                .HasPrecision(15, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iacst)
                .HasPrecision(15, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ifcst)
                .HasPrecision(15, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ilevl)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ionod)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idisc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.inseq)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.itseq)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.icyc)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idraw)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imtdu)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imrp)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iact)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iordp)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iyrct)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ilots)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iyadj)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcos)
                .HasPrecision(15, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iycos)
                .HasPrecision(15, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imust)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iordc)
                .HasPrecision(15, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iaveu)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idsce)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iwght)
                .HasPrecision(9, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iabbt)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iabc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipfdv)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipack)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ilabl)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idrf)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iclng)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.icwid)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipitm)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.isitm)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ibuyc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ifeno)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iumr)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iumrc)
                .HasPrecision(11, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ifii)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.taxc1)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.saflg)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iioq)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ibtch)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iyuse)
                .HasPrecision(15, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.icycf)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipers)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.istyl)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipody)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.itfdy)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ifrfg)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.isact)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iumat)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ivuli)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ivulp)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.inccfg)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iwhs)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.isofl)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ilcc)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ijit)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iuncn)
                .HasPrecision(9, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imaxr)
                .HasPrecision(9, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iminr)
                .HasPrecision(9, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipctk)
                .HasPrecision(5, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.igtec)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imaxp)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imtdp)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iytdp)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.itgqy)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iarrt)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imxin)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idmtf)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idmc1)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idmc2)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbhd)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbdy)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idltr)
                .HasPrecision(11, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imqdy)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbwt)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.impot)
                .HasPrecision(9, 4);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imusc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imumb)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imuma)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ipurc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imsum)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ibusy)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idscr)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.impsd)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iloc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcom)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iglno)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.ifci)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.icond)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iref01)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iref02)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iref03)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iref04)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iref05)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.iorign)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcomc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imfrmc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imrevl)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imform)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcctl)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbndp)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbndc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.immndt)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.immntm)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.immnus)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbwip)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.impmth)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcmth)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imqled)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imalot)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imnot1)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imnot2)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.immfgr)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imvfry)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imspec)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imtlvl)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imqle2)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imsspc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imastb)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcntr)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.impkd1)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.impkd2)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imhzrd)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcstc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcorp)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imqctl)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcqty)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.idsalw)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imrelp)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imtccd)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcntt)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imptyp)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.icstcg)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imendt)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imentm)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imenus)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imwtum)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imvuom)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imfprc)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imnnwu)
                .HasPrecision(13, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imlong)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imluom)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imwide)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imwdum)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imhigh)
                .HasPrecision(11, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imhuom)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imhrmn)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imanxn)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imunse)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imunrl)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imunrd)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imunai)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imunpo)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imunop)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imflpc)
                .HasPrecision(6, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imflpf)
                .HasPrecision(6, 3);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imrfpk)
                .HasPrecision(15, 2);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imlttm)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imlttz)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcctm)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imcctz)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imctz)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imltz)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imlpgm)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imprm)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imecst)
                .HasPrecision(15, 5);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imabrv)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.immfmd)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imgsor)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imalrq)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imbrgc)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imldte)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imltme)
                .HasPrecision(10, 0);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imlusr)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.imdsfw)
                .IsUnicode(false);

            modelBuilder.Entity<gt_iim>()
                .Property(e => e.serialcolumn)
                .HasPrecision(10, 0);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.improd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imfac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.immode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imium)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.impum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imcvr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imtyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imukg)
                .HasPrecision(18, 5);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imusiz)
                .HasPrecision(18, 5);

            modelBuilder.Entity<inviim>()
                .Property(e => e.immax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<inviim>()
                .Property(e => e.immin)
                .HasPrecision(18, 3);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imsct)
                .HasPrecision(18, 5);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imact)
                .HasPrecision(18, 5);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imnct)
                .HasPrecision(18, 5);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imabc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imbpc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imkpc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<inviim>()
                .Property(e => e.imusr)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess_detail>()
                .Property(e => e.mono)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess_detail>()
                .Property(e => e.pono)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess_detail>()
                .Property(e => e.poname)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess_detail>()
                .Property(e => e.procCode)
                .IsUnicode(false);

            modelBuilder.Entity<mprocess_detail>()
                .Property(e => e.stationCode)
                .IsUnicode(false);

            modelBuilder.Entity<Proc1>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Proc1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Proc1>()
                .Property(e => e.StationSeq)
                .IsUnicode(false);

            modelBuilder.Entity<Proc1>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmrevn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmwhs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmloc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmterm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmtrc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhph>()
                .Property(e => e.pmpst)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdprod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdfac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdqord)
                .HasPrecision(18, 3);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdqrec)
                .HasPrecision(18, 3);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdqiqc)
                .HasPrecision(18, 3);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdpric)
                .HasPrecision(18, 5);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdcur)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purhpo>()
                .Property(e => e.pdusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhid)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhno)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhsord)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhmno)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhtyp)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhstat)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhcur)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhcby)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhcdte)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhctm)
                .HasPrecision(6, 0);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhapby)
                .IsUnicode(false);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhapdte)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhaptm)
                .HasPrecision(6, 0);

            modelBuilder.Entity<purprh>()
                .Property(e => e.prhpgm)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlid)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlno)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlseq)
                .HasPrecision(4, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlprod)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlqty)
                .HasPrecision(12, 2);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlpacst)
                .HasPrecision(14, 4);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlpdte)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prldue)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlrdte)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlfac)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlwhs)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlcur)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlvndm)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlplnc)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlpono)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlsord)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlmno)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prltno)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlstation)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlplnh)
                .HasPrecision(8, 2);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlrule)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlpmt)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlapr)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlnedm)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlum)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlcby)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlcdte)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlctm)
                .HasPrecision(6, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlapby)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlapdte)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlaptm)
                .HasPrecision(6, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlpgm)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlqcqty)
                .HasPrecision(12, 2);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlrtq)
                .HasPrecision(12, 2);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlsoseq)
                .HasPrecision(8, 0);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlmrk)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prloutno)
                .IsUnicode(false);

            modelBuilder.Entity<purprl>()
                .Property(e => e.prlpicno)
                .IsUnicode(false);

            modelBuilder.Entity<saldim>()
                .Property(e => e.diid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<saldim>()
                .Property(e => e.diprod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<saldim>()
                .Property(e => e.dipby)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<saldim>()
                .Property(e => e.dinum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<saldim>()
                .Property(e => e.didum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<saldim>()
                .Property(e => e.dilgth)
                .HasPrecision(18, 5);

            modelBuilder.Entity<saldim>()
                .Property(e => e.diwdth)
                .HasPrecision(18, 5);

            modelBuilder.Entity<saldim>()
                .Property(e => e.dihigh)
                .HasPrecision(18, 5);

            modelBuilder.Entity<saldim>()
                .Property(e => e.diwum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<saldim>()
                .Property(e => e.diunw)
                .HasPrecision(18, 5);

            modelBuilder.Entity<saldim>()
                .Property(e => e.diugw)
                .HasPrecision(18, 5);

            modelBuilder.Entity<salest>()
                .Property(e => e.stid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stpon1)
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stpon2)
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stpon3)
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stfax1)
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stfax2)
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stemai1)
                .IsUnicode(false);

            modelBuilder.Entity<salest>()
                .Property(e => e.stemai2)
                .IsUnicode(false);

            modelBuilder.Entity<salhed>()
                .Property(e => e.edid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salhed>()
                .Property(e => e.edpon)
                .IsUnicode(false);

            modelBuilder.Entity<salhed>()
                .Property(e => e.edfax)
                .IsUnicode(false);

            modelBuilder.Entity<salhed>()
                .Property(e => e.edacct)
                .IsUnicode(false);

            modelBuilder.Entity<salmin>()
                .Property(e => e.miid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salmin>()
                .Property(e => e.miprod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salmin>()
                .Property(e => e.mipric)
                .HasPrecision(18, 5);

            modelBuilder.Entity<salmin>()
                .Property(e => e.micur)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salmin>()
                .Property(e => e.mifac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salsys>()
                .Property(e => e.saidpa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<salsys>()
                .Property(e => e.sapkey)
                .IsUnicode(false);

            modelBuilder.Entity<salsys>()
                .Property(e => e.sadata)
                .IsUnicode(false);

            modelBuilder.Entity<saltem>()
                .Property(e => e.teid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<saltem>()
                .Property(e => e.term)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipso)
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipsono)
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipmno)
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipcustname)
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipname)
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipunit)
                .IsUnicode(false);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipqreq)
                .HasPrecision(10, 0);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipqplan)
                .HasPrecision(10, 0);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipqact)
                .HasPrecision(10, 0);

            modelBuilder.Entity<shiping>()
                .Property(e => e.shipdate)
                .HasPrecision(8, 0);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipsono)
                .IsUnicode(false);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipmno)
                .IsUnicode(false);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipcustname)
                .IsUnicode(false);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipname)
                .IsUnicode(false);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipunit)
                .IsUnicode(false);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipqreq)
                .HasPrecision(10, 0);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipqplan)
                .HasPrecision(10, 0);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipqact)
                .HasPrecision(10, 0);

            modelBuilder.Entity<shiping1>()
                .Property(e => e.shipdate)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tdmbap>()
                .Property(e => e.baptyp)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbap>()
                .Property(e => e.bapres)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbap>()
                .Property(e => e.bapmno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbap>()
                .Property(e => e.bapver)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tdmbap>()
                .Property(e => e.bapwno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbap>()
                .Property(e => e.bappro)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomnam)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bompno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomsiz)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomqua)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomhrc)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomitm)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bommem)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomver)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomdra)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bommat)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomsup)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bompro)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bommno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomwno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomapy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomrmk)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomser)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bompre)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bompur)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomgno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomSpc)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomWeight)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomSumWeight)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomType)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom>()
                .Property(e => e.bomUnit)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomnam)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bompno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomsiz)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomqua)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomhrc)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomitm)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bommem)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomver)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomdra)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bommat)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomsup)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bompro)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bommno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomwno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomapy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomrmk)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomser)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bompre)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bompur)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomgno)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomSpc)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomWeight)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomSumWeight)
                .HasPrecision(15, 3);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomType)
                .IsUnicode(false);

            modelBuilder.Entity<tdmbom2>()
                .Property(e => e.bomUnit)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtid)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtrno)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtseq)
                .HasPrecision(4, 0);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtsts)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rttyp)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtprod)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtfac)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtwhs)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtinv)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtprno)
                .HasPrecision(8, 0);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtsono)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rttno)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtproc)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtapnbr)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtplnc)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtbuyc)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtvend)
                .HasPrecision(8, 0);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtqinv)
                .HasPrecision(12, 2);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtqact)
                .HasPrecision(12, 2);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtqpts)
                .HasPrecision(12, 2);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtqscrp)
                .HasPrecision(12, 2);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtqqty)
                .HasPrecision(12, 2);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtcur)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtscst)
                .HasPrecision(12, 4);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtiump)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtmark)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtcby)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtcdte)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtctm)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtpgm)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtprseq)
                .HasPrecision(4, 0);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rttcount)
                .IsUnicode(false);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtPerWeight)
                .HasPrecision(15, 2);

            modelBuilder.Entity<trtrtm>()
                .Property(e => e.rtSumWeight)
                .HasPrecision(15, 2);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.sid)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordno)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordso)
                .HasPrecision(15, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordms)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordcust)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordcont)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordwtyp)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordcout)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmodel)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordptyp1)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordptyp2)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordts)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordt1)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordtn)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordvno)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordxnum)
                .HasPrecision(5, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordpno)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmat)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmjcz)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmjgg)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordgmcz)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmmcz)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmjjg)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordjdlx)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordgzgs)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordjdcp)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordhkgs)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordxxgs)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmjsm)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordxtme)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordspec)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordsnot)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordpnot)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmod)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordcitem)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordprod)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordman)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordnote)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.orduser)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.orddte)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordrat)
                .HasPrecision(4, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordsiz)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordrlg)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordsch)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordstat)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordpric)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordvso)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordvstat)
                .HasPrecision(1, 0);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordftyp)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordctm)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.orddept)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordmadd)
                .IsUnicode(false);

            modelBuilder.Entity<tsbord>()
                .Property(e => e.ordptyp3)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomseq)
                .HasPrecision(20, 0);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomwno)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bommno)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomitm)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bompno)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomreq)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomisu)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bompry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomrdt)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomqua)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomwhs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomfac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomsts)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomloc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomtme)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bompro)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomver)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bompre)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bommat)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomspc)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomser)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomdra)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomnam)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom>()
                .Property(e => e.bomuit)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomflg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomseq)
                .HasPrecision(20, 0);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomwno)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bommno)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomitm)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bompno)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomreq)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomisu)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bompry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomrdt)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomqua)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomwhs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomfac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomsts)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomloc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomtme)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bompro)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomver)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bompre)
                .HasPrecision(8, 0);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bommat)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomspc)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomser)
                .HasPrecision(10, 0);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomdra)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomnam)
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tsfcbom2>()
                .Property(e => e.bomuit)
                .IsUnicode(false);

            modelBuilder.Entity<zsc>()
                .Property(e => e.zusr)
                .IsUnicode(false);

            modelBuilder.Entity<zsc>()
                .Property(e => e.zpwd)
                .IsUnicode(false);

            modelBuilder.Entity<zsc>()
                .Property(e => e.zdes)
                .IsUnicode(false);

            modelBuilder.Entity<zxa>()
                .Property(e => e.zfun)
                .IsUnicode(false);

            modelBuilder.Entity<zxa>()
                .Property(e => e.zdes)
                .IsUnicode(false);

            modelBuilder.Entity<zxa>()
                .Property(e => e.zusr)
                .IsUnicode(false);

            modelBuilder.Entity<zxa>()
                .Property(e => e.zflg)
                .IsUnicode(false);

            modelBuilder.Entity<zxo>()
                .Property(e => e.zmod)
                .IsUnicode(false);

            modelBuilder.Entity<zxo>()
                .Property(e => e.zfun)
                .IsUnicode(false);

            modelBuilder.Entity<zxo>()
                .Property(e => e.zdes)
                .IsUnicode(false);
        }
    }
}
