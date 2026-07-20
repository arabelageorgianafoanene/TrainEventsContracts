

namespace TrainEventContracts.Common
{
    public abstract record TrainEvent
    {
        public Guid TrainId { get; init; }
        public Guid EventId { get; init; }
        public int EventVersion { get; init; }
        public Guid CorrelationId { get; init; }
    }
}
