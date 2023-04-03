using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HMS.Models
{
    public partial class MVCContext : DbContext
    {
        public MVCContext()
        {
        }

        public MVCContext(DbContextOptions<MVCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admission> Admissions { get; set; } = null!;
        public virtual DbSet<AdmissionService> AdmissionServices { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Audit> Audits { get; set; } = null!;
        public virtual DbSet<Barcode> Barcodes { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<CaseCategory> CaseCategories { get; set; } = null!;
        public virtual DbSet<CertificateDate> CertificateDates { get; set; } = null!;
        public virtual DbSet<CertificateType> CertificateTypes { get; set; } = null!;
        public virtual DbSet<Covid19> Covid19s { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Discharge> Discharges { get; set; } = null!;
        public virtual DbSet<Disease> Diseases { get; set; } = null!;
        public virtual DbSet<Doctor> Doctors { get; set; } = null!;
        public virtual DbSet<DoctorPer> DoctorPers { get; set; } = null!;
        public virtual DbSet<ExpenseHead> ExpenseHeads { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<Gtest> Gtests { get; set; } = null!;
        public virtual DbSet<Gtest2> Gtest2s { get; set; } = null!;
        public virtual DbSet<HrtUser> HrtUsers { get; set; } = null!;
        public virtual DbSet<Hrtcompany> Hrtcompanies { get; set; } = null!;
        public virtual DbSet<Itemfox> Itemfoxes { get; set; } = null!;
        public virtual DbSet<LabCovid19> LabCovid19s { get; set; } = null!;
        public virtual DbSet<LabRegent> LabRegents { get; set; } = null!;
        public virtual DbSet<LabSample> LabSamples { get; set; } = null!;
        public virtual DbSet<LabTestRecord> LabTestRecords { get; set; } = null!;
        public virtual DbSet<Mtest> Mtests { get; set; } = null!;
        public virtual DbSet<Mtest2> Mtest2s { get; set; } = null!;
        public virtual DbSet<NormalRange> NormalRanges { get; set; } = null!;
        public virtual DbSet<Otlist> Otlists { get; set; } = null!;
        public virtual DbSet<Otmedicine> Otmedicines { get; set; } = null!;
        public virtual DbSet<Otpatient> Otpatients { get; set; } = null!;
        public virtual DbSet<Panel> Panels { get; set; } = null!;
        public virtual DbSet<Panelprice> Panelprices { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PatientDocument> PatientDocuments { get; set; } = null!;
        public virtual DbSet<PatientMedicine> PatientMedicines { get; set; } = null!;
        public virtual DbSet<PatientTreatment> PatientTreatments { get; set; } = null!;
        public virtual DbSet<PortalVisit> PortalVisits { get; set; } = null!;
        public virtual DbSet<Prescription> Prescriptions { get; set; } = null!;
        public virtual DbSet<Purchase> Purchases { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolesDetail> RolesDetails { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<RoomPatient> RoomPatients { get; set; } = null!;
        public virtual DbSet<RoomsType> RoomsTypes { get; set; } = null!;
        public virtual DbSet<Smsgateway> Smsgateways { get; set; } = null!;
        public virtual DbSet<Smshistroy> Smshistroys { get; set; } = null!;
        public virtual DbSet<Specialty> Specialties { get; set; } = null!;
        public virtual DbSet<StoreTransaction> StoreTransactions { get; set; } = null!;
        public virtual DbSet<SubRoom> SubRooms { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Test2> Test2s { get; set; } = null!;
        public virtual DbSet<TestBkp> TestBkps { get; set; } = null!;
        public virtual DbSet<TestEntry> TestEntries { get; set; } = null!;
        public virtual DbSet<TestList> TestLists { get; set; } = null!;
        public virtual DbSet<TestType> TestTypes { get; set; } = null!;
        public virtual DbSet<Tlist> Tlists { get; set; } = null!;
        public virtual DbSet<Tlist2> Tlist2s { get; set; } = null!;
        public virtual DbSet<Treatment> Treatments { get; set; } = null!;
        public virtual DbSet<TreatmentChart> TreatmentCharts { get; set; } = null!;
        public virtual DbSet<UltraSound> UltraSounds { get; set; } = null!;
        public virtual DbSet<UltraSoundRecord> UltraSoundRecords { get; set; } = null!;
        public virtual DbSet<Vaccination> Vaccinations { get; set; } = null!;
        public virtual DbSet<Xray> Xrays { get; set; } = null!;
        public virtual DbSet<XrayRecord> XrayRecords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
         optionsBuilder.UseSqlServer("server=.\\sql2019; user id=sa; password=notmil;database=MVC;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admission>(entity =>
            {
                entity.ToTable("Admission");

                entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");

                entity.Property(e => e.AdmissionDate).HasColumnType("datetime");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ipaddress");

                entity.Property(e => e.Otid).HasColumnName("OTID");

                entity.Property(e => e.PanelId).HasColumnName("PanelID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Updatedatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedatetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Admission_Doctor");

                entity.HasOne(d => d.Ot)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.Otid)
                    .HasConstraintName("FK_Admission_OTList");

                entity.HasOne(d => d.Panel)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.PanelId)
                    .HasConstraintName("FK_Admission_Panel");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Admission_Patient");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Admission_Rooms");
            });

            modelBuilder.Entity<AdmissionService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("admissionService");

                entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");

                entity.Property(e => e.Charges)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Discount)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.Updatedatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedatetime");

                entity.HasOne(d => d.Admission)
                    .WithMany()
                    .HasForeignKey(d => d.AdmissionId)
                    .HasConstraintName("FK_admissionService_Admission");

                entity.HasOne(d => d.Patient)
                    .WithMany()
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_admissionService_Patient");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Updatedatetime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("USerId");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.Property(e => e.VisitTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_Appointment_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Appointment_Patient");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("Audit");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedatetime");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Audits)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Audit_Patient");
            });

            modelBuilder.Entity<Barcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("barcode");

                entity.Property(e => e.Barcode1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Barcode");

                entity.Property(e => e.Batchno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("batchno");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Expiry)
                    .HasColumnType("datetime")
                    .HasColumnName("expiry");

                entity.Property(e => e.IsExpire).HasColumnName("is_expire");

                entity.Property(e => e.Price)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseCategory>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("CaseCategory");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertificateDate>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Certific__CA1FE464540C7B00");

                entity.ToTable("CertificateDate");

                entity.Property(e => e.CertificateDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("CertificateDate");

                entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

                entity.Property(e => e.Issuedto)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Requested)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.CertificateDates)
                    .HasForeignKey(d => d.CertificateId)
                    .HasConstraintName("FK_CertificateDate_CertificateType");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.CertificateDates)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_CertificateDate_Patient");
            });

            modelBuilder.Entity<CertificateType>(entity =>
            {
                entity.HasKey(e => e.CertificateId)
                    .HasName("PK__Certific__BBF8A7E157DD0BE4");

                entity.ToTable("CertificateType");

                entity.Property(e => e.CertificateId).HasColumnName("CertificateID");

                entity.Property(e => e.CertificateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Covid19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Covid19");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("age");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.Entrydate).HasColumnType("datetime");

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mrno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mrno");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Refer)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Reportindate).HasColumnType("datetime");

                entity.Property(e => e.SampleTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sampledate).HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ward)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Discharge>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__discharg__C03656300DCF0841");

                entity.ToTable("discharge");

                entity.Property(e => e.Did).HasColumnName("DID");

                entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.DischargeTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Upcomingdate).HasColumnType("datetime");

                entity.Property(e => e.Updatedatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedatetime");

                entity.Property(e => e.UserId).HasColumnName("USerID");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("Disease");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DepartmendId).HasColumnName("DepartmendID");

                entity.Property(e => e.Education)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Specialization)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Departmend)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DepartmendId)
                    .HasConstraintName("FK_Doctor_Department");
            });

            modelBuilder.Entity<DoctorPer>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("DoctorPer");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorPers)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_DoctorPer_Doctor");
            });

            modelBuilder.Entity<ExpenseHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExpenseHead");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.ToTable("Form");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.Controller)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<Gtest>(entity =>
            {
                entity.HasKey(e => e.Gcode);

                entity.ToTable("GTest");

                entity.Property(e => e.Gcode).HasColumnName("GCode");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Gname)
                    .HasMaxLength(50)
                    .HasColumnName("GName");

                entity.Property(e => e.Mcode).HasColumnName("MCode");
            });

            modelBuilder.Entity<Gtest2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gtest2");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Gcode).HasColumnName("GCode");

                entity.Property(e => e.Gname)
                    .HasMaxLength(50)
                    .HasColumnName("GName");

                entity.Property(e => e.Mcode)
                    .HasMaxLength(5)
                    .HasColumnName("MCode");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");
            });

            modelBuilder.Entity<HrtUser>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("HrtUser");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastActive).HasColumnType("datetime");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.HrtUsers)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_HrtUser_Branch");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.HrtUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_HrtUser_Roles");
            });

            modelBuilder.Entity<Hrtcompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hrtcompany");

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Contact_no");

                entity.Property(e => e.FldLength).HasColumnName("fldLength");

                entity.Property(e => e.Fldlenght).HasColumnName("fldlenght");

                entity.Property(e => e.Header)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PrintRemarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Itemfox>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("ITEMFOX");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Distributor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mqty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MQTY");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Pkng)
                    .HasMaxLength(10)
                    .HasColumnName("PKNG");

                entity.Property(e => e.Pkqty).HasColumnName("PKQTY");

                entity.Property(e => e.Retail).HasColumnName("RETAIL");

                entity.Property(e => e.TrackNo).HasMaxLength(40);

                entity.Property(e => e.Trp).HasColumnName("TRP");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabCovid19>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lab_covid19");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Sample)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Technology)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabRegent>(entity =>
            {
                entity.HasKey(e => e.RegentId);

                entity.ToTable("LabRegent");

                entity.Property(e => e.RegentId).HasColumnName("RegentID");

                entity.Property(e => e.RegentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LabSample>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.ToTable("LabSample");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CollectBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionDate).HasColumnType("datetime");

                entity.Property(e => e.ReSample).HasColumnName("Re-sample");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Specimen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.LabSamples)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_LabSample_Patient");
            });

            modelBuilder.Entity<LabTestRecord>(entity =>
            {
                entity.HasKey(e => e.LabId);

                entity.ToTable("LabTestRecord");

                entity.Property(e => e.LabId).HasColumnName("LabID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Gname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GName");

                entity.Property(e => e.Heading)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MName");

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderby).HasColumnName("orderby");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Tname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUser)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Updatedatetime).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.LabTestRecords)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_LabTestRecord_Branch");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.LabTestRecords)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_LabTestRecord_Patient");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.LabTestRecords)
                    .HasForeignKey(d => d.TransId)
                    .HasConstraintName("FK_LabTestRecord_TestEntry");
            });

            modelBuilder.Entity<Mtest>(entity =>
            {
                entity.HasKey(e => e.Mcode);

                entity.ToTable("MTest");

                entity.Property(e => e.Mcode).HasColumnName("MCode");

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .HasColumnName("MName");
            });

            modelBuilder.Entity<Mtest2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mtest2");

                entity.Property(e => e.Mcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MCode");

                entity.Property(e => e.Mname)
                    .HasMaxLength(50)
                    .HasColumnName("MName");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");
            });

            modelBuilder.Entity<NormalRange>(entity =>
            {
                entity.HasKey(e => e.RangeId);

                entity.Property(e => e.RangeId).HasColumnName("RangeID");

                entity.Property(e => e.PostiveNegative).HasColumnName("Postive_Negative");

                entity.Property(e => e.RangeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Otlist>(entity =>
            {
                entity.HasKey(e => e.Otid);

                entity.ToTable("OTList");

                entity.Property(e => e.Otid).HasColumnName("OTID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.Otname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OTName");
            });

            modelBuilder.Entity<Otmedicine>(entity =>
            {
                entity.HasKey(e => e.MedicineId);

                entity.ToTable("OTMedicine");

                entity.Property(e => e.MedicineId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MedicineID");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Otid).HasColumnName("OTID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Medicine)
                    .WithOne(p => p.Otmedicine)
                    .HasForeignKey<Otmedicine>(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OTMedicine_OTList");
            });

            modelBuilder.Entity<Otpatient>(entity =>
            {
                entity.HasKey(e => e.OperationId);

                entity.ToTable("OTPatient");

                entity.Property(e => e.OperationId).HasColumnName("OperationID");

                entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.Otid).HasColumnName("OTID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PersonCnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PersonCNIC");

                entity.Property(e => e.PersonWith)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Updatedatetime).HasColumnName("updatedatetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Admission)
                    .WithMany(p => p.Otpatients)
                    .HasForeignKey(d => d.AdmissionId)
                    .HasConstraintName("FK_OTPatient_Admission");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Otpatients)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_OTPatient_Doctor");

                entity.HasOne(d => d.Ot)
                    .WithMany(p => p.Otpatients)
                    .HasForeignKey(d => d.Otid)
                    .HasConstraintName("FK_OTPatient_OTList");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Otpatients)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_OTPatient_Patient");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Otpatients)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_OTPatient_Rooms");

                entity.HasOne(d => d.TechnicianNavigation)
                    .WithMany(p => p.Otpatients)
                    .HasForeignKey(d => d.Technician)
                    .HasConstraintName("FK_OTPatient_HrtUser");
            });

            modelBuilder.Entity<Panel>(entity =>
            {
                entity.ToTable("Panel");

                entity.Property(e => e.PanelId).HasColumnName("PanelID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Panelprice>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__panelpri__CA1FE46433F4B129");

                entity.ToTable("panelprice");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Mrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MRNo");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReferBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Patient_Branch");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Patient_Department");

                entity.HasOne(d => d.Panel)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Panelid)
                    .HasConstraintName("FK_Patient_Panel");
            });

            modelBuilder.Entity<PatientDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatientDocument");

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<PatientMedicine>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("PatientMedicine");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Duration)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entrydate).HasColumnType("datetime");

                entity.Property(e => e.Histroy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Power)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientTreatment>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("PatientTreatment");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Descrption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TreatmentId).HasColumnName("TreatmentID");

                entity.HasOne(d => d.Treatment)
                    .WithMany(p => p.PatientTreatments)
                    .HasForeignKey(d => d.TreatmentId)
                    .HasConstraintName("FK_PatientTreatment_Treatment");
            });

            modelBuilder.Entity<PortalVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("portalVisit");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("datetime")
                    .HasColumnName("entrydate");

                entity.Property(e => e.Ip)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasColumnName("USerId");
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Prescrip__CA1FE4644B7734FF");

                entity.ToTable("Prescription");

                entity.Property(e => e.Dosage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NextAppointment).HasColumnType("datetime");

                entity.Property(e => e.Potency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Prescriptions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("USerID");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Purchase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("purchases");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Distributor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsPurchase).HasColumnName("is_purchase");

                entity.Property(e => e.IsUpdated).HasColumnName("is_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Per).HasColumnName("per");

                entity.Property(e => e.PoNo).HasColumnName("po_no");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("purchase_date");

                entity.Property(e => e.PurchaseItem).HasColumnName("purchaseItem");

                entity.Property(e => e.PurchasePrice).HasColumnName("purchasePrice");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Sno).HasColumnName("sno");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesDetail>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__RolesDet__CA1FE4642D27B809");

                entity.ToTable("RolesDetail");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.RollId).HasColumnName("RollID");

                entity.Property(e => e.Updatatedatetime).HasColumnType("datetime");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.RolesDetails)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_RolesDetail_Forms");

                entity.HasOne(d => d.Roll)
                    .WithMany(p => p.RolesDetails)
                    .HasForeignKey(d => d.RollId)
                    .HasConstraintName("FK_RolesDetail_Roles");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Floor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

                entity.HasOne(d => d.RoomType)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.RoomTypeId)
                    .HasConstraintName("FK_Rooms_RoomsType");
            });

            modelBuilder.Entity<RoomPatient>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("RoomPatient");

                entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");

                entity.Property(e => e.DischargeDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ipaddress");

                entity.Property(e => e.Otid).HasColumnName("OTID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomEntryDate).HasColumnType("datetime");

                entity.Property(e => e.RoomEntryTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.UpdateDatetime).HasColumnType("datetime");

                entity.HasOne(d => d.Admission)
                    .WithMany(p => p.RoomPatients)
                    .HasForeignKey(d => d.AdmissionId)
                    .HasConstraintName("FK_RoomPatient_Admission");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.RoomPatients)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_RoomPatient_Patient");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomPatients)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_RoomPatient_Rooms");
            });

            modelBuilder.Entity<RoomsType>(entity =>
            {
                entity.HasKey(e => e.RoomTypeId);

                entity.ToTable("RoomsType");

                entity.Property(e => e.IsAc)
                    .HasMaxLength(10)
                    .HasColumnName("IsAC")
                    .IsFixedLength();

                entity.Property(e => e.IsBed)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IsPrivate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TypeName)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smsgateway>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smsgateway");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Smshistroy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("smshistroy");

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.Mobileno)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PatientID");

                entity.Property(e => e.Smsdate)
                    .HasColumnType("datetime")
                    .HasColumnName("smsdate");

                entity.Property(e => e.Smsid).ValueGeneratedOnAdd();

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<Specialty>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("Specialty");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<StoreTransaction>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("StoreTransaction");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.SaleDate).HasColumnType("datetime");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StoreTransactions)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_StoreTransaction_ITEMFOX");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.StoreTransactions)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_StoreTransaction_Patient");
            });

            modelBuilder.Entity<SubRoom>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Charges).HasColumnName("charges");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Room_id");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("Supplier");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("supplier");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_test");

                entity.ToTable("Test");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.Duration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gcode).HasColumnName("gcode");

                entity.Property(e => e.IsDynamicRate).HasColumnName("isDynamicRate");

                entity.Property(e => e.Mcode).HasColumnName("mcode");

                entity.Property(e => e.Oldid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OLDID");

                entity.Property(e => e.PerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegendId).HasColumnName("RegendID");

                entity.Property(e => e.Sample)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TestName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test2");

                entity.Property(e => e.Duration)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("duration");

                entity.Property(e => e.Gcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gcode");

                entity.Property(e => e.Mcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mcode");

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.RefPer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref_per");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");

                entity.Property(e => e.TestName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("test_name");

                entity.Property(e => e.TestSample)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("test_sample");

                entity.Property(e => e.TestSno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("test_sno");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e._1).HasColumnName("1");

                entity.Property(e => e._10).HasColumnName("10");

                entity.Property(e => e._11).HasColumnName("11");

                entity.Property(e => e._12).HasColumnName("12");

                entity.Property(e => e._13).HasColumnName("13");

                entity.Property(e => e._14).HasColumnName("14");

                entity.Property(e => e._17).HasColumnName("17");

                entity.Property(e => e._2).HasColumnName("2");

                entity.Property(e => e._3).HasColumnName("3");
            });

            modelBuilder.Entity<TestBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_bkp");

                entity.Property(e => e.CaseType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("case_type");

                entity.Property(e => e.Duration)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("duration");

                entity.Property(e => e.Gcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gcode");

                entity.Property(e => e.Mcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mcode");

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.RefPer).HasColumnName("ref_per");

                entity.Property(e => e.Tcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tcode");

                entity.Property(e => e.TestName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("test_name");

                entity.Property(e => e.TestSample)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("test_sample");

                entity.Property(e => e.TestSno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("test_sno");
            });

            modelBuilder.Entity<TestEntry>(entity =>
            {
                entity.HasKey(e => e.TransId)
                    .HasName("PK__Trans__9E5DDB1C1A14E395");

                entity.ToTable("TestEntry");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Isreported)
                    .HasMaxLength(10)
                    .HasColumnName("ISReported")
                    .IsFixedLength();

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ReportingDate).HasColumnType("datetime");

                entity.Property(e => e.ReportingTime)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("USerId");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TestEntries)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_TestEntry_Doctor");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.TestEntries)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_TestEntry_Patient");
            });

            modelBuilder.Entity<TestList>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__IService__C51BB0EA164452B1");

                entity.ToTable("TestList");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Duration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Technology)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDateTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("USerID");
            });

            modelBuilder.Entity<TestType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__ServiceT__516F03951273C1CD");

                entity.ToTable("TestType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tlist>(entity =>
            {
                entity.HasKey(e => e.Tcode)
                    .HasName("PK_tlist");

                entity.ToTable("TList");

                entity.Property(e => e.Tcode).HasColumnName("TCode");

                entity.Property(e => e.Gcode).HasColumnName("GCode");

                entity.Property(e => e.Heading)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mcode).HasColumnName("MCode");

                entity.Property(e => e.NormalRange)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Orderby).HasColumnName("orderby");

                entity.Property(e => e.Tname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TName");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Tlist2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tlist2");

                entity.Property(e => e.Gcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GCode");

                entity.Property(e => e.Hcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hcode");

                entity.Property(e => e.Mcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MCode");

                entity.Property(e => e.NRange)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("N_Range");

                entity.Property(e => e.Orderby).HasColumnName("orderby");

                entity.Property(e => e.Sno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sno");

                entity.Property(e => e.Tcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TCode");

                entity.Property(e => e.Tname)
                    .HasMaxLength(50)
                    .HasColumnName("TName");

                entity.Property(e => e.Unit).HasMaxLength(100);

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.ToTable("Treatment");

                entity.Property(e => e.TreatmentId).HasColumnName("TreatmentID");

                entity.Property(e => e.TreatmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentChart>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("TreatmentChart");

                entity.Property(e => e.AdmissionId).HasColumnName("AdmissionID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ip");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsAuto).HasColumnName("isAuto");

                entity.Property(e => e.MedicineId).HasColumnName("MedicineID");

                entity.Property(e => e.Otid).HasColumnName("OTID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.TreatmentDate).HasColumnType("datetime");

                entity.Property(e => e.Updatedatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedatetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UltraSound>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK_ultra_sound2");

                entity.ToTable("ultra_sound");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Advise)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("advise");

                entity.Property(e => e.Detail)
                    .HasMaxLength(1533)
                    .IsUnicode(false)
                    .HasColumnName("detail");

                entity.Property(e => e.Heading)
                    .HasMaxLength(833)
                    .IsUnicode(false)
                    .HasColumnName("heading");

                entity.Property(e => e.Impression)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("impression");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(833)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TestId)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("test_id");

                entity.Property(e => e.TestType)
                    .HasMaxLength(333)
                    .IsUnicode(false)
                    .HasColumnName("test_type");

                entity.Property(e => e.Value)
                    .HasMaxLength(822)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<UltraSoundRecord>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("UltraSoundRecord");

                entity.Property(e => e.Advise)
                    .HasMaxLength(3330)
                    .IsUnicode(false)
                    .HasColumnName("advise");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(3330)
                    .IsUnicode(false)
                    .HasColumnName("detail");

                entity.Property(e => e.Heading)
                    .HasMaxLength(3330)
                    .IsUnicode(false)
                    .HasColumnName("heading");

                entity.Property(e => e.Impression)
                    .HasMaxLength(3330)
                    .IsUnicode(false)
                    .HasColumnName("impression");

                entity.Property(e => e.IsProcess).HasColumnName("is_process");

                entity.Property(e => e.Logo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(3330)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.Type)
                    .HasMaxLength(33)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(3330)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("Vaccination");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.InjectionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("injection_date");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ProposeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("propose_date");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.VaccineDate).HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Vaccinations)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_Vaccination_Patient");
            });

            modelBuilder.Entity<Xray>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xray");

                entity.Property(e => e.Xadvise)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("xadvise");

                entity.Property(e => e.Xcolumn)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("xcolumn");

                entity.Property(e => e.Xconclusion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("xconclusion");

                entity.Property(e => e.Xdetail)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("xdetail");

                entity.Property(e => e.Xgno)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("xgno");

                entity.Property(e => e.Xheading)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("xheading");

                entity.Property(e => e.Xmno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("xmno");

                entity.Property(e => e.Xname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("xname");

                entity.Property(e => e.Xtype)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("xtype");
            });

            modelBuilder.Entity<XrayRecord>(entity =>
            {
                entity.HasKey(e => e.Sno);

                entity.ToTable("XrayRecord");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BranchID");

                entity.Property(e => e.Gcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gcode");

                entity.Property(e => e.Mcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mcode");

                entity.Property(e => e.PatientId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PatientID");

                entity.Property(e => e.ServiceId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ServiceID");

                entity.Property(e => e.TestAdvise)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_advise");

                entity.Property(e => e.TestConclusion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_conclusion");

                entity.Property(e => e.TestConclusion1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_conclusion1");

                entity.Property(e => e.TestConclusion2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_conclusion2");

                entity.Property(e => e.TestConclusion3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_conclusion3");

                entity.Property(e => e.TestConclusion4)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_conclusion4");

                entity.Property(e => e.TestDetail)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("test_detail");

                entity.Property(e => e.TestHeading)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("test_heading");

                entity.Property(e => e.TestName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("test_name");

                entity.Property(e => e.TestValue)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("test_value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
