namespace TP_compte;

internal class Client
{
    //Attributs de la classe:
    private string _Nom;
    private string _Prenom;
    private string _Tel;
    private int _CIN;
    private static int count = 0;

    //constructeur permettant d’initialiser tous les attributs: 
    public Client(string nom, string prenom, string tel, int CIN)
    {
        Nom = nom;
        Prenom = prenom;
        Tel = tel;
        this.CIN = CIN;
        //Compteur du nombre de création de compte par les constructeurs.
        Count++;


    }
    //Constructeur permettant d’initialiser le CIN, le nom et le prénom.
    public Client(string nom, string prenom, int CIN)
    {
        Nom = nom;
        Prenom = prenom;
        this.CIN = CIN;
        Compte BankCompt;
        int Count;


    }
    //Constructeur quirécupère les valeurs des propriétés en console:
    public Client()
    {
        Console.WriteLine($"Compte {Count}");
        Console.WriteLine("Donner leCIN:");
        CIN = int.Parse(Console.ReadLine());
        Console.WriteLine("Donner le nom:");
        Nom = Console.ReadLine();
        Console.WriteLine("Donner leCIprénom:");
        Prenom = Console.ReadLine();
        Console.WriteLine("Donner le numéro de téléphone:");
        Tel = Console.ReadLine();
        Console.WriteLine("Montant à déposer?");
        Amount = int.Parse(Console.ReadLine());
        Count++;
    }

    //Encapsulation des attributs en utilisant les propriétés
    public string Nom { get => _Nom; set => _Nom = value; }
    public string Prenom { get => _Prenom; set => _Prenom = value; }
    public string Tel { get => _Tel; set => _Tel = value; }
    public int CIN { get => _CIN; set => _CIN = value; }
    public static int Count { get => count; set => count = value; }

    public int Amount { get; set; }

    //Méthode Afficher qui affiche les information du client:
    public void Afficher(Client client)
    {
        Console.WriteLine("Détail du compte:");
        Console.WriteLine($"prénom:{client.Prenom}");
        Console.WriteLine($"téléphone:{client.Tel}");
        Console.WriteLine($"nom:{client.Nom}");
        Console.WriteLine($"CIN:{client.CIN}");
    }
}
//méthode Crediter permettant de Crediter le compte, prenant une somme et un compte en paramètres.
//méthode Crediter permettant de Crediter le compte, prenant une somme et un compte en paramètres.
//méthode Crediter permettant de Crediter le compte, prenant une somme et un compte en paramètres.




