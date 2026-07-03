namespace TrainEventContracts;

public class TrainRegistered
{
    public Guid TrainId { get; init; }
    public string TrainName { get; init; }
    public DateTime CreatedTime { get; int; }
    public TrainStatus TrainStatus { get; init; }
    public Guid EventId { get; init; }
    public int EventVersion { get; init; }
    public Guid CorrelationId { get; init; }
}
