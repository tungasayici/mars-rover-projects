using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiPayQuiz.Models
{
    interface IPlateau
    {
        int Min_Width { get; set; }

        int Min_Height { get; set; }

        int Width { get; set; }

        int Height { get; set; }
    }
}
