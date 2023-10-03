namespace BarakaTop.Domain.Commons;

public class Auditable
{
    public long Id { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime UpdateAt { get; set; }
}
