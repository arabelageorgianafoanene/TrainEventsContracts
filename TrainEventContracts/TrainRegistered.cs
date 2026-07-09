namespace TrainEventContracts
{
    public record TrainRegistered(
        Guid TrainId,
        string TrainName,
        DateTime CreatedTime,
        string TrainStatus,
        Guid EventId,
        int EventVersion,
        Guid CorrelationId
    );
}