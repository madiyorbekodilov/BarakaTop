using BarakaTop.Domain.Commons;

namespace BarakaTop.Domain.Entities;

public class Group : Auditable
{
    public string Login { get; set; }
    public string Password { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
