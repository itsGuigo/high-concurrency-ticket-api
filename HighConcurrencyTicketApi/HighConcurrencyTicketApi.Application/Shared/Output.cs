namespace HighConcurrencyTicketApi.Application.Shared
{
    public class Output
    {
        public bool Success => ErrorMessages.Count == 0;

        public List<string> ErrorMessages { get; } = [];

        public void AddError(string message)
        {
            ErrorMessages.Add(message);
        }

        public void AddErrors(IEnumerable<string> messages)
        {
            ErrorMessages.AddRange(messages);
        }
    }

    public class Output<T> : Output
    {
        public T? Result { get; set; }
    }
}
