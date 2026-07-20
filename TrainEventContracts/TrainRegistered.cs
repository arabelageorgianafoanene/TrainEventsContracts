using TrainEventContracts.Common;

namespace TrainEventContracts
{
    public record TrainRegistered : TrainEvent
    {
        public string TrainName { get; init; }
        public DateTime CreatedTime { get; init; }
        public string TrainStatus { get; init; }
    }
}