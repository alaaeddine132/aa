Explication du code :

    Tableau panier[] :
        Il s'agit d'un tableau de chaînes de caractères avec une taille de 5. Ce tableau représente le panier dans lequel l'utilisateur peut ajouter des fruits.

    Boucle principale while :
        La boucle continue de fonctionner jusqu'à ce que l'utilisateur choisisse de quitter en sélectionnant l'option 5.

    Menu :
        Le menu présente plusieurs options à l'utilisateur :
            Ajouter un fruit (option 1) : L'utilisateur peut ajouter un fruit tant que le panier n'est pas plein (maximum 5 fruits) et que le fruit n'est pas déjà dans le panier.
            Retirer un fruit (option 2) : L'utilisateur peut retirer un fruit du panier. Si le fruit est trouvé, il est retiré et le panier est réorganisé.
            Afficher le panier (option 3) : Affiche tous les fruits actuellement dans le panier. Si le panier est vide, un message l'indique.
            Rechercher un fruit (option 4) : L'utilisateur peut rechercher un fruit dans le panier pour voir s'il y est ou non.
            Quitter le jeu (option 5) : Permet à l'utilisateur de quitter le jeu.

    Gestion des doublons :
        Lors de l'ajout d'un fruit, le programme vérifie si le fruit existe déjà dans le panier. Si c'est le cas, il n'est pas ajouté.

    Gestion du retrait de fruit :
        Lorsqu'un fruit est retiré, les éléments du tableau sont réorganisés pour éviter les "trous" dans le panier.

Comment exécuter :

    Copiez ce code dans un fichier C# (par exemple MarcheFruits.cs).
    Compilez et exécutez le programme avec votre environnement de développement ou en utilisant dotnet run si vous travaillez avec un projet .NET.

Le programme vous demandera ensuite de faire des choix via un menu pour gérer votre panier de fruits.
