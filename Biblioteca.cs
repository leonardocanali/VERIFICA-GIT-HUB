using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private string _orarioApertura;
        private string _orarioChiusura;
        private List<Libro>_libri;

        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            _nome = nome;
            _indirizzo = indirizzo;
            _orarioApertura = orarioApertura;
            _orarioChiusura = orarioChiusura;
            _libri = new List<Libro>();
        }


    }
}
