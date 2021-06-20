using HepsiPayQuiz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiPayQuiz.Models
{
    interface IRover
    {
        Plateau plateau { get; set; }

        Position position { get; set; }

        Direction heading { get; set; }
    }
}
