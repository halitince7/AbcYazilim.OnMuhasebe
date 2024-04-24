
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace AbcYazilim.OnMuhasebe.Parametreler;
public class FirmaParametre : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public Guid? DepoId { get; set; }

    // Navigation Properties
    public IdentityUser User { get; set; }
    public Sube Sube { get; set; }
    public Donem Donem { get; set; }
    public Depo Depo { get; set; }
}
