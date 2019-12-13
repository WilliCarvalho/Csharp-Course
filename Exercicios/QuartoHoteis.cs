using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class QuartoHoteis
    {
        public int Room { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public QuartoHoteis(int room, string name, string email)
        {
            Room = room;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }
    }
}
