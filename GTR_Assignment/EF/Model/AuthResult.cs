namespace GTR_Assignment.EF.Model
{
    public class AuthResult
    {
        public string Token { get; set; }=string.Empty;
        public bool IsSuccess { get; set; }
        public List<string> Errors { get; set; }

    }
}
