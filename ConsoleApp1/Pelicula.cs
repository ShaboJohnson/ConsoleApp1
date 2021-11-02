using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMax
{
    class Pelicula
    {
        public int PeliculaId { get; }

        public int GeneroId { get; }

        public string Title { get; }

        public int Year { get;  }

        public Pelicula(int peliculaId, int generoId, string title, int year)

        {
            PeliculaId = peliculaId;
            GeneroId = generoId;
            Title = title;
            Year = year;


        }

    }
}
