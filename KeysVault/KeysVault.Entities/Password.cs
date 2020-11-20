using System;

namespace KeysVault.Entities
{
    public class Password
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Website { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
