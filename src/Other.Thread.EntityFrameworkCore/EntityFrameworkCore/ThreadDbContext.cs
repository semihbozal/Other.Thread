using Microsoft.EntityFrameworkCore;
using Other.Thread.Entities.Accounting;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Other.Thread.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class ThreadDbContext :
    AbpDbContext<ThreadDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Safe> Safes { get; set; }

    public DbSet<RevenueGroup> RevenueGroups { get; set; }

    #endregion

    public ThreadDbContext(DbContextOptions<ThreadDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(OtherThreadConsts.DbTablePrefix + "YourEntities", OtherThreadConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        builder.Entity<Account>(b =>
        {
            b.ToTable(OtherThreadConsts.DbTablePrefix + "Accounts",
                OtherThreadConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            b.Property(x => x.Phone).HasMaxLength(50);
            b.Property(x => x.Address).HasMaxLength(500);
            b.Property(x => x.Email).HasMaxLength(100);
        });

        builder.Entity<Safe>(b =>
        {
            b.ToTable(OtherThreadConsts.DbTablePrefix + "Safes",
                OtherThreadConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(10);
            b.Property(x => x.Name).IsRequired().HasMaxLength(50);
            b.Property(x => x.Description).HasMaxLength(500);
            b.Property(x => x.Bank).HasMaxLength(50);
            b.Property(x => x.BankBranch).HasMaxLength(50);
            b.Property(x => x.AccountNo).HasMaxLength(50);
            b.Property(x => x.IBAN).HasMaxLength(50);
            b.Property(x => x.IsDefault).IsRequired().HasDefaultValue(false);
            b.HasIndex(x => x.Code).IsUnique();
        });

        builder.Entity<RevenueGroup>(b =>
        {
            b.ToTable(OtherThreadConsts.DbTablePrefix + "RevenueGroups",
                OtherThreadConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(10);
            b.Property(x => x.Name).IsRequired().HasMaxLength(50);
            b.Property(x => x.Description).HasMaxLength(500);
        });
    }
}
