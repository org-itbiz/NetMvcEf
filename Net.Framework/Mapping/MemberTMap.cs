using Net.Framework.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.ModelConfiguration;

namespace Net.Framework.Mapping
{
    public class MemberTMap
    {
    }

    //public class MemberTMap : EntityTypeConfiguration<MemberT>
    //{
    //    public MemberTMap()
    //    {
    //        //primary key
    //        this.HasKey(t => t.MemberId);

    //        //properties
    //        this.Property(t => t.MemberNm)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //        this.Property(t => t.AppId);

    //        this.Property(t => t.RegDt);

    //        //table & column mappings
    //        //this.ToTable("Member");
    //        this.ToTable("Member", "dbo");
    //        this.Property(t => t.MemberId).HasColumnName("Id");
    //        this.Property(t => t.MemberNm).HasColumnName("Member_Nm");
    //        this.Property(t => t.AppId).HasColumnName("App_Id");
    //        this.Property(t => t.RegDt).HasColumnName("Reg_Dt");
    //    }
    //}
}
