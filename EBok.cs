﻿namespace Boksystem
{
    public class EBok : Bok
    {
        public int Filstorlek { get; set; }
        public string DownloadUrl { get; set; }

        public EBok(string titel, string författare, int isbn, int filstorlek, string downloadUrl) 
            : base(titel, författare, isbn)
        {
            Filstorlek = filstorlek;
            DownloadUrl = downloadUrl;
        }

        public override void SpelaUpp()
        {            
        }
        public override void PausaBoken()
        {
            Console.WriteLine("Uppspelningen av boken har nu pausat.");
        }
        public override void SkrivUtInfo()
        {
            Console.WriteLine($"Titel: {Titel}, Författare: {Författare}, ISBN: {ISBN}, Filstorlek: {Filstorlek}, URL-kod: {DownloadUrl}");

        }
    }
}