public class TrainStatusUpdated
{
	public string TrainId { get; init; }
	public TrainStattus OldStatus { get; init; }
	public string Status { get; init; }
	public DateTime TrainStatusChangedTime { get; init; }
}