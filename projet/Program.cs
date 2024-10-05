// See https://aka.ms/new-console-template for more information
using System;

class MarcheFruits
{
    static void Main()
    {
        string[] panier = new string[5];
        int nombreFruits = 0;
        bool quitter = false;

        while (!quitter)
        {
            Console.WriteLine("\n--- Marché des fruits ---");
            Console.WriteLine("1. Ajouter un fruit");
            Console.WriteLine("2. Retirer un fruit");
            Console.WriteLine("3. Afficher le panier");
            Console.WriteLine("4. Rechercher un fruit");
            Console.WriteLine("5. Quitter");
            Console.Write("Choisissez une option (1-5) : ");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    if (nombreFruits < 5)
                    {
                        Console.Write("Entrez le nom du fruit à ajouter : ");
                        string fruitAjout = Console.ReadLine();
                        if (Array.IndexOf(panier, fruitAjout) == -1)
                        {
                            panier[nombreFruits] = fruitAjout;
                            nombreFruits++;
                            Console.WriteLine($"{fruitAjout} a été ajouté au panier.");
                        }
                        else
                        {
                            Console.WriteLine("Le fruit est déjà dans le panier !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Le panier est plein (maximum 5 fruits) !");
                    }
                    break;

                case "2":
                    Console.Write("Entrez le nom du fruit à retirer : ");
                    string fruitRetrait = Console.ReadLine();
                    int indexRetrait = Array.IndexOf(panier, fruitRetrait);
                    if (indexRetrait != -1)
                    {
                        panier[indexRetrait] = null;
                        nombreFruits--;
                        // Réorganiser le tableau après retrait
                        for (int i = indexRetrait; i < panier.Length - 1; i++)
                        {
                            panier[i] = panier[i + 1];
                        }
                        panier[panier.Length - 1] = null;
                        Console.WriteLine($"{fruitRetrait} a été retiré du panier.");
                    }
                    else
                    {
                        Console.WriteLine("Le fruit n'est pas dans le panier.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nFruits dans le panier :");
                    if (nombreFruits == 0)
                    {
                        Console.WriteLine("Le panier est vide.");
                    }
                    else
                    {
                        foreach (string fruit in panier)
                        {
                            if (fruit != null)
                            {
                                Console.WriteLine("- " + fruit);
                            }
                        }
                    }
                    break;

                case "4":
                    Console.Write("Entrez le nom du fruit à rechercher : ");
                    string fruitRecherche = Console.ReadLine();
                    if (Array.IndexOf(panier, fruitRecherche) != -1)
                    {
                        Console.WriteLine($"{fruitRecherche} est dans le panier.");
                    }
                    else
                    {
                        Console.WriteLine($"{fruitRecherche} n'est pas dans le panier.");
                    }
                    break;

                case "5":
                    quitter = true;
                    Console.WriteLine("Merci d'avoir joué !");
                    break;

                default:
                    Console.WriteLine("Option non valide, veuillez choisir entre 1 et 5.");
                    break;
            }
        }
    }
}

