﻿using BarakaTop.Domain.Commons;

namespace BarakaTop.Domain.Entities;

public class Radar : Auditable
{
    public string name { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
    public int CountOfIgnore { get; set; }

    public long GroupId { get; set; }
    public Group Group { get; set; }

    public long UserId { get; set; }
    public User User { get; set; }
}
