namespace Boksystem
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

        public override void SkrivUtinfo()
        {
        }
        public override void SpelaUpp()
        {            
        }
        public override void VisaInfo()
        {            
        }
    }
}