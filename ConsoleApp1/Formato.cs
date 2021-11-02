using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMax
{
    class Formato
    {
        public int FormatoId { get; }

        public string Description { get;  }

        public int Precio { get;  }
        

        public Formato (int id, int precio, string description)
        {
            FormatoId = id;
            Precio = precio;
            Description = description;




        }




    }
}
