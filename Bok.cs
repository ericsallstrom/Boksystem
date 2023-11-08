namespace Boksystem
{
    public class Bok : Media, IUtlånbar
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int ISBN { get; set; }
        public bool Utlånad { get; set; }

        public Bok(string titel, string författare, int isbn)
        {
            Titel = titel;
            Författare = författare;
            ISBN = isbn;
            Utlånad = false;
        }

        public override void SpelaUpp()
        {            
        }
        public override void VisaInfo()
        {            
        }
        public void LånaUt()
        {
            Utlånad = true;
        }
        public void Återlämna()
        {
            Utlånad = false;
        }
        public virtual void SkrivUtinfo()
        {
        }      
    }
}