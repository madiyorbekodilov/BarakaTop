using BarakaTop.Domain.Commons;

namespace BarakaTop.Domain.Entities;

public class UserRadar : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }

    public long RadarId { get; set; }
    public Radar Radar { get; set; }
}
