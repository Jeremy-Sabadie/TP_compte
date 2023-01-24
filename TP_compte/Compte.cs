namespace TP_compte
{
    internal class Compte
    {//Attributs de la classe compte:
        private double Sold;
        private Guid Code = new Guid()//Guid: génère un code aléatoire.
        private Client owner;
        //Constructeur par défault qui incrémente le code du compte lors de sa création:
        public Compte()
        {
            Code++;
        }

        //Attribut solde en lecture seule.
        public double Sold1 { get => Sold; private set => Sold = value; }
        //Attribut code du compte en lecture seule.
        public int Code1 { get => Code; private set => Code = value; }
        internal Client Owner { get => owner; set => owner = value; }
    }
    //Constructeur par défault:

}

