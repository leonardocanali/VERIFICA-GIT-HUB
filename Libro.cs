﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private DateTime _dataPubblicazione;
        private string _editore;
        private int _numeroPag;

        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("ERRORE AUTORE");
                _autore = value;
            }
        }
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("ERRORE TITOLO");
                _titolo = value;
            }
        }
        public string Editore
        {
            get { return _editore; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("ERRORE EDITORE");
                _editore = value;
            }
        }
        public DateTime DataPubblicazione
        {
            get { return _dataPubblicazione; }
            set
            {
                if (value == null || value > DateTime.Now)
                    throw new Exception("ERRORE DATA PUBBLICAZIONE");
                _dataPubblicazione = value;
            }
        }
        public int Pagine
        {
            get { return _numeroPag; }
            set
            {
                if (value <= 0)
                    throw new Exception("ERRORE PAGINE");
                _numeroPag = value;
            }
        }

        public Libro(string autore, string titolo, DateTime data, string editore, int nPag)
        {
            Titolo = titolo;
            Autore = autore;
            DataPubblicazione = data;
            Editore = editore;
            Pagine = nPag;
        }

    }
}
