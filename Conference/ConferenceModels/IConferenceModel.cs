namespace ConferenceModels
{
    public interface IConferenceModel
    {
        int Id { get; set; }
        string GetDescription { get; }
    }
}
