### Introduction 


Le framework .NET est l'element central des applications. 

Il est constitue de deux elements : 
   - Le CLR 
   - Des bibliotheques de classes

Le CLR gere l'environnement d'execution des applications, il permet de combiner des assemblages de codes, quel que soit le langage dans lequel ils ont ete ecrits. Une application en C sharp pourra utiliser une lib en VB (visual basic).

Le compilateur est capapble de convertir du code de differents langages en langage intermediaire (IL). 

Chaque type des langages utilises pour le farmework .NET a son equivalent en langage intermediaire. 

Une fois compile l'application se resume a un fichier executable au sein de l'environnement cible.






### Les bibliotheques de classes 

Le framework .NET est compose de plusieurs bibliotheques de classes, classees en espaces de noms, eux memes classe de maniere hierarchique a partir d'un espace de nom racine appele:
``` C#
 System // Espace de nom racine. Il contient les types de bases du framework .NET
 System.Collections // Tous les types permettant de gerer les listes et les tableaux
 
```



### Les types 

.NET est compose de deux types differents : les types valeur et les types reference. 

#### Les  types valeurs 

``` C#
int test = 4; // instruction qui declare une variable de type int et qui lui affecte 
			  // une valeur 4;
int test2; // une declaration de type valeur sans affectation entraine la levee d'une 
			// exception 
test2 = 4; // affectation 


bool b1 = true; // 

bool b2 = b1; // on copie la valeur de b1 sans aucun autre lien

b1 = false;

```



#### Les  types references

Les donnees des types reference sont stockes a un emplacement memoire et un pointeur vers ces donnees est stocke dans la variable.

Les classes et les interfaces sont des types reference. 
Un type reference doit etre instancie avec le mot cle 'new'.

``` C#
Sytem.Collections; // espace de noms 

ArrayList tab1 = new ArrayList();

ArrayList tab2 = new ArrayList(1);

ArrayList tab2 = new(); // on peut omettre le type lorqu'il n'y a pas de parametres.

```

Pour illustrer le fonctionnement des types reference, prenons un exempl : 

``` C#

class Test
{
	public bool booleen;
}

Test C1 = new Test();

C1.booleen = true;

Test C2 = C1;

C1.booleen = false;


```



#### Les identifiants et les mot-cles 


``` C#

string monIdentifiant;
string @monIdentifiant;

string MonIdentifiant;

private bool @lock;

i = 5 % 2; // 1
i = 8 % 2; // 0


```

Les operateurs d'assignation : 

``` C#

int i = 4; 

i += 2; // 6
i -= 2; // 2
i *= 2; // 8
i /= 2; // 2
i %= 2; // 0


int x = 4;
x is int //  renvoie true si x est de type int 

o is DateTime d // renvoie true si o est type DateTime
// La variable o est automatiquement convertie dans le type teste et place dans la 
// nouvelle variable d et utilisable de maniere classique 

var test = new Test(); // inference de type 
const int i = 0;

```


Les instructions de controle

``` C# 
if (x > 4)
{ // on peut omettre les accolades si l'expression ne contient qu'une ligne
	 // expression
} 
else 
{
	// expression2
}
```

``` C#

string myObject = obj?.foo?.bar;

// est equivalent a 

string myObject;

if (obj!=null && obj.foo !=null)
{
	myObject = obj.foo.bar;
}

 //  l'operateur null ?. p

```


La boucle foreach: 

``` C#
foreach (type c in structureDeDonnee)
{
	// expression 
}
```


#### Les espaces de de noms 

##### Declaration d'un espace de nom 
``` C# 
	namespace EspaceDeNom
	{
		class MaClasse {}
	}


```


##### Les conversions 
``` C#
int i = 45; // entier signe sur 32bits

long k = i; // entier signe sur 64bits

long j = 1595495;

int m = (int)j;  // conversion explicite 

short s = 300;

byte b = (byte)s;

```

#### Questions RPI

##### Les enumerations 

``` C#
// Decrire le fonctionnements des enums en C#
enum LesJoursDeLaSemaine
{
	Lundi,
	Mardi,
	Mercredi,
	Jeudi,
	Vendredi,
	Samedi,
	Dimanche
}

LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;

```

##### Les tableaux

``` C#
	int[] Tableau; // declaration
	Tableau = new int[10]; // initialisation


	int[] Tableau = new int[] { 34, 45, 1, 34 ,43 }; // 

```

###### Les tableaux multidimensionnels

``` C#
	int [,] Tableau = new int[1, 2];
	int [,,] Tableau = new int[5, 2, 3];

	// Expliquez la difference entre ces syntaxes

	int[][] Tableau = new int[3][];
	Tableau[0] = new int[] { 45, 2 };
	Tableau[1] = new int[] { 34, 34, 4, 67 };

	// Tentez de parcourir des tableaux multidimensionnels avec des boucles for
```



















#### Les Types

Les classes en C# representent la grande majorite des types reference. 

``` C#
private class maSuperClasse 
{

}
```
On peut y ajouter des elements: 
 - Des membres (methodes, proprietes) places entre accolades
 - Des attributs et des modificateurs de classe places avant le mot-cle 'class' (niveau d'acces)
 - Des heritages et implementations d'interfaces places apres le nom de la classe 

##### Les niveaux d'acces (portee):
 - public: autorise l'acces pour les types de l'assemblage (assembly) et hors de l'assembly.
 - private: Autorise uniquement l'acces pour les autres membres du type (de la classe par exemple)
 - internal: autorise l'acces pour les types d'assembly.
 - protected: Autorise l'acces uniquement pour les  autres membres du type et pour les types 
		heritant de celui-ci (dans l'assembly et en dehors de l'assembly)
 - protected internal: Autorise l'acces uniquement pour les  autres membres du type et pour les types heritant de celui-ci (dans l'assembly uniquement)

Exercice : 
- Que signifie le terme "assembly" (assemblage) ? 
- Citez un exemple reel d'un usage pertinent du mot cle "private".

Si aucune portee n'est precise sur un membre, il est considere comme private. Une classe sans modificateur sera quant a elle consideree comme public.


Les struct en C# ressemblent aux classes mais sont de type valeur, elles ne supportent pas l'heritage. 


``` C#
	struct Coordinates 
	{
		double Long;
		double Lat;
	}

	Coordinates myGeoPoint = new Coordinates();
```



Un peu de vocabulaire sur les classes 
``` C#

	public class SuperClass 
	{
		protected string filepath = "/dev/"; // champ, une variable qui peut etre un 
											 // type valeur ou un type reference
		public int MyProperty { get; set; } // propriete

		public void WriteFile()
		{
			// ... 
		}	
		
		public void WriteFile(string filePath) 
		{
			// ... exemple de surcharge		
		}
	}

	SuperClass obj = new SuperClass();
	obj.MyProperty



```




##### L'héritage 


Toutes les classes du framework .NET dérivent de la classe 
System.Object.

L'heritage correspond a deux fonctionnalités 

Lors de l'heritage de classe un type dérive d'un type de base 
en prenant tous ses membres accessibles. Cette fonctionnalité
est utile lorsque plusieurs types partagent les mêmes 
fonctionnalités.

``` C# 
public partial class ChildClass: MotherClass
{

}
```

Si aucune classe de base n'est spécifiée, le compilateur 
considère System.Object comme la classe mère.

``` C#
public class ChildClass: System.Object
{

}
/// est equivalent à
public class ChildClass 
{

}

```

Les membres accessibles depuis la clase dérivée sont ceux 
qui ont un niveau d'acces public, protected ou internal (mais vous le saviez déjà...). Cela s'applique aux méthodes et aux 
propriétés:



###### Les membres virtuels 

en déclarant un membre avec le mot-cle virtual, vous autorisez
le membre à être surchargé par les classses dérivées. Cela
s'applique aux méthodes et aux propriétés.
La méthode surchargée doit être explicitement déclarée en 
utilisant le mot-clé override.

La signature de la methode dans la classe fille doit etre 
identique à la signature de la méthode dans la classe mère.