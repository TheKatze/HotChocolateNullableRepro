using static Mutation;

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

    public Task<IEnumerable<KeyValuePair<string, WorkItem?>>> Another_Non_Working_Example(IEnumerable<KeyValuePair<string, WorkItem?>> workItems)
    {
        return Task.FromResult(workItems);
    }

    public record MyOwnKeyValuePair(string Key, WorkItem? Value);
    public Task<IEnumerable<MyOwnKeyValuePair>> But_This_Workaround_Works(IEnumerable<MyOwnKeyValuePair> workItems)
    {
        return Task.FromResult(workItems);
    }

    public record GenericKVPair<TKey, TValue>(TKey Key, TValue Value);
    public Task<IEnumerable<GenericKVPair<string, WorkItem?>>> With_Generics_It_Does_Not_Work(IEnumerable<GenericKVPair<string, WorkItem?>> workItems)
    {
        return Task.FromResult(workItems);
    }
}
