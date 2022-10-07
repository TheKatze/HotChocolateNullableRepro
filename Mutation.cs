public class Mutation
{
    public Task<Dictionary<string, int?>> Does_Work(Dictionary<string, int?> workItems)
    {
        return Task.FromResult(workItems);
    }

    public Task<Dictionary<string, string?>> Does_Not_Work(Dictionary<string, string?> workItems)
    {
        return Task.FromResult(workItems);
    }

    public record WorkItem(string Id, string? Description);
    public Task<Dictionary<string, WorkItem?>> Does_Not_Work_Either(Dictionary<string, WorkItem?> workItems)
    {
        return Task.FromResult(workItems);
    }
}
