namespace CFilzenFunctionApp.Types
{
    public class PersonRequest
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
    }

    public class PersonResponse
    {
        public int Age { get; set; }
    }
}
