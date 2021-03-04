TODO 21) : Créez dans le dossier Quest3 une classe "Organization" avec comme propriétés
- Une propriété Name
- Une propriété "HeadQuarter" de type PointOfInterest qui représentera le siège de l'organisation 
- Une propriété "CampusList" de type List<Campus> (https://docs.microsoft.com/fr-fr/dotnet/api/system.collections.generic.list-1?view=net-5.0)
TODO 22) : Ajouter un constructeur qui prend en paramètre le nom et le siège de l'organisation', ainsi qu'une liste de campus

Dans le fichier Program.cs de du projet OOPTrainingConsoleApp
TODO 23) :  vous allez modifier la partie qui affiche le HelloWorld pour exécuter les traitements suivants
- Vous allez créer 3 objets Campus représentant les campus suivants : 
	Bordeaux Ynov Campus (capacité 1500 places)
	Toulouse Ynov Campus (capacité 1200 places)
	Paris Ynov Campus (capacité 2500 places)
- Vous allez créer 3 objets HistoricalMonument : 
	la Porte Cailhau de Bordeaux : https://fr.wikipedia.org/wiki/Porte_Cailhau
	l'Obélisque de Louxor : https://fr.wikipedia.org/wiki/Ob%C3%A9lisque_de_Louxor
	le musée des augustins : https://fr.wikipedia.org/wiki/Mus%C3%A9e_des_Augustins_de_Toulouse
- Vous allez ensuite créer une méthode dont la signature sera la suivante : public static void DisplayPointOfInterestList(List<PointOfInterest> poiList), cette méthode sera appelée avec une liste comportant vos campus et vos monuments
Cette méthode affichera dans la console un tableau de la forme suivante avec tous les objets passés en paramètre :
______________________________________________________________________________________________________________________
|  Type    | Nom                                    | Latitude        | Longitude        | Distance par rapport à moi |
|__________|________________________________________|_________________|__________________|____________________________|
| Campus   | Bordeaux Ynov Campus                   | 44.854186       | -0.5663056       |                      2531 m|
|__________|________________________________________|_________________|__________________|____________________________|
| Monument | Porte Cailhau                          | 44.8387609      | -0.5684966       |                      1268 m|
|__________|________________________________________|_________________|__________________|____________________________|
...

Pour la 1ère colonne, trouvez 2 manières différentes de la remplir :
- La première en modifiant la classe PointOfInterest et en utilisant une énumération https://docs.microsoft.com/fr-fr/dotnet/csharp/language-reference/builtin-types/enum
- La deuxième sans avoir à modifier aucune des classes

QUESTION : En C#, que désigne la notion d'"Object initializers" ? Quel est l'intérêt de cette fonctionalité ?