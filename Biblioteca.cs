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

        public void AggiungiLibro(Libro l)
        {
            _libri.Add(l);
        }

        public Libro RicercaLibro(string titolo)
        {
            Libro libroDaCercare; 
            foreach(Libro l in _libri)
            {
                if (l.Titolo == titolo)
                    libroDaCercare = l;
            }

            return libroDaCercare;
        }

        public List<Libro> RicercaLibriPerAutore(string autore)
        {
            List<Libro> _libriStessoAutore = new List<Libro>();
            foreach(Libro l in _libri)
            {
                if (l.Autore = autore)
                    _libriStessoAutore.Add(l);
            }

            return _libriStessoAutore;
        }

        public int NumeroLibri()
        {
            int numeroLibri = _libri.Count;
            return numeroLibri;
        }

    }
}
