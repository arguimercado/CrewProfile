using System;

namespace CrewProfile.Core.Models
{
    public class Crew
    {
        public int RowId { get; set; }

        public int Oceanist { get; set; }

        public string Surname { get; set; }
        public string Middlename { get; set; }

        public string Firstname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string RefreshToken { get; set; }

        public DateTime? RefreshTokenExpiry { get; set; }
    }
}
