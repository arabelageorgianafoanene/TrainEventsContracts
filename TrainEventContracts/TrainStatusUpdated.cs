
using TrainEventContracts.Common;

namespace TrainEventContracts
{
	public record TrainStatusUpdated : TrainEvent
	{	
		public string TrainName { get; init; }
		public DateTime UpdatedTime { get; init; }
		public string OldTrainStatus { get; init; }
        public string NewTrainStatus { get; init; }
    }
}