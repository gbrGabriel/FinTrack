namespace FinTrack.Data.Entities;

public abstract class BaseEntity
{
    public DateTime CreationDate { get; set; }
    public DateTime LastChange { get; set; }
}
