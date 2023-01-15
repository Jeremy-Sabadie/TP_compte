namespace TP_compte
{
    internal class Client
    {
        //Attributs de la classe:
        private string _Nom;
        private string _Prenom;
        private string _Tel;
        private int _CIN;
        public int _count = 0;
        //constructeur permettant d’initialiser tous les attributs: 
        public Client(string nom, string prenom, string tel, int CIN)
        {
            _Nom = nom;
            _Prenom = prenom;
            _Tel = tel;
            _CIN = CIN;
            //Compteur du nombre de création de compte par les constructeurs.
            Count++;


        }
        //Constructeur permettant d’initialiser le CIN, le nom et le prénom.
        public Client(string nom, string prenom, int CIN)
        {
            _Nom = nom;
            _Prenom = prenom;
            _CIN = CIN;

        }

        //Encapsulation des attributs en utilisant les propriétés
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }
        public string Tel { get => _Tel; set => _Tel = value; }
        public int CIN { get => _CIN; set => _CIN = value; }
        public int Count { get => _count; private set => _count = value; }

        //Méthode Affichzr qui affiche les information du client:
        public void Afficher(Client client)
        {
            Console.WriteLine($"nom:{client.Nom}");
            Console.WriteLine($"nom:{client.Nom}");
            Console.WriteLine($"nom:{client.Nom}");
            Console.WriteLine($"CIN:{client.CIN}");
        }

        //méthode Crediter permettant de Crediter le compte, prenant une somme et un compte en paramètres.

    }
}
