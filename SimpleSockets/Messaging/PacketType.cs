namespace SimpleSockets.Messaging
{
	public enum PacketType
	{
		Message=0,
		Bytes = 1,
		File=2,
		Folder=3,
		Object=4,
		Auth=7
	}
}