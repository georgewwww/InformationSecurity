namespace KeysVault.Entities
{
    public class Settings
    {
        public int Id { get; set; }

        public string DateTimeFormat { get; set; }
        public bool ShowEmailColumn { get; set; }
        public bool ShowUsernameColumn { get; set; }
        public bool ShowPasswordColumn { get; set; }

        public string Master { get; set; }
    }
}
