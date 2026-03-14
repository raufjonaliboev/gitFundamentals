namespace DefaultNamespace;

public record CreateCartRequest
{
    public long Id { get; init; }
    public string DeviceId { get; init; }
    public List<string> Items { get; init; }
    //and other properties
}