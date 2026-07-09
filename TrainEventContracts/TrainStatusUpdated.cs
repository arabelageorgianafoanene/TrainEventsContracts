
namespace TrainEventContracts
{
	public record TrainStatusUpdated(
		Guid TrainId,
		string OldStatus,
		string Status,
		DateTime TrainStatusChangedTime);
}