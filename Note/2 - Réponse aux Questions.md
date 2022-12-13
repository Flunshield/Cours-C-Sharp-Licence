
## Question 1


```C#
// Pourquoi b affiche 44 ?
short s = 300;
byte b = (byte)s;
```

**b** affiche **44** car il son type définit en temps que **byte** tandis que le type de **s** est définit en temps que **short**.

Pour rappel, le **Type Short** prend comme valeur -**32 768 à 32 767** (16 bits) et le **type byte** prend comme valeur **0 à 255** (8bits).

Par conséquent, la capacité de **s** étant supérieur à la capacité de **b**, il est normal que **b** n'affiche pas 300. Lorsque la capacité de **b** est atteinte (255 = 11111111), le "compteur de bit" de **b** passe à 00000000 pour la valeur suivant (256) car 256 en binaire c'est 100000000 soit 9 bits.. **b** ne pouvant afficher que 8 byte, celui considère que la valeur est "0" car les 8 premiers bits sont à zéro. 

Voici d'autre exemples : 

```C#
short s = 257;
byte b = (byte)s;
Console.WriteLine(b); // Affiche 1 car 100000001 b ne pouvant affiche que les 8 premier bits alors la console affichera "1"
```

## Question 2

```C#
// Décrire le fonctionnement des enums en C#
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

//Les enums retourner des données dans certains type de donnée.

LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.samedi | LesJoursDeLaSemaine.Dimanche
```

Un **Enum** , est un nom qui définit un ensemble de valeurs. Les Enum sont considérés comme des types de données. Nous pouvons les **utiliser** pour créer des ensembles de constantes pouvant servir à des variables et des propriétés.

Dans l'exemple, nous pouvons voir que la variable **Weekend** de type **LesJoursDeLaSemaine** prend comme valeur **Samedi** et **Dimanche** de l'enum **LesJoursDeLaSemaine**.

## Question 3
Expliquer la différence entre :
```C#
int[,] a = new int[1,2];
int[,,] b = new int[1,2,3];
```

La différence entre nos deux tableaux sont :
- a est un tableau à deux dimensions.
- b un tableau à trois dimensions.

## Question 4 :
Que signifie le terme "assembly" (assemblage) ?

## Question 5
Citez un exemple reel d'un usage pertinent du mot clef **Private**.

Nous devons utiliser le mot-clef **Private** dans le cas où notre classe pourrait interagir avec une base de donnée. Cela permettra d'éviter d'utiliser la classe à l'extérieur de son périmètre.

Exemple de classe : Une classe qui gère l'ajout et le retrait d'argent sur nos comptes.
