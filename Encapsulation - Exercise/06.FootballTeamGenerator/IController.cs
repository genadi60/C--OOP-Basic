public interface IController
{
	void CreateTeam(string[] data);

	Player CreatePlayer(string[] data);

	Stats CreateStats(string[] data);

    void AddPlayer(string[] data);

    void RemovePlayer(string[] data);

    string RatingTeam(string[] data);
}