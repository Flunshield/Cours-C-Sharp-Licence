## Introduction
### Les interfaces de programmation applicative sont devenues incontournables quel que soit le secteur d’activité. Banque, marketing, digital, le développement des API ne cesse de croître, au même titre que les données à traiter. Mais de quoi parle-t-on exactement et à quoi ça sert ?

Une API, pour **Application programming interface**, est un programme **permettant à deux applications distinctes de communiquer entre elles et d’échanger des données**. Cela évite notamment de recréer et redévelopper entièrement une application pour y ajouter ses informations. Par exemple, elle est là pour **faire le lien** entre des **données déjà existantes** et un **programme indépendant**.

### Qu’est-ce qu’une interface de programmation ?

Les interfaces de programmation permettent à deux applications logicielles de **communiquer entre elles** et d’**échanger des données de manière réciproque**, quel que soit le langage de programmation utilisé.

> Les API jouent ainsi le rôle de **portes d’entrée** dans un logiciel qui ne vous appartient pas.

Les développeurs n’ont alors plus besoin de connaître parfaitement le programme qu’ils souhaitent exploiter, il leur suffira de développer une Application Programming Interface pour entrer dans ce programme.

### À quoi sert une API ?

Inconnue du grand public et invisible lorsque l’on navigue sur Internet ou une application mobile, elle est pourtant devenue capitale pour les entreprises.

> Servant d’intermédiaire entre deux systèmes informatiques indépendants, l’API permet d’**échanger des données** **ou des fonctionnalités** à l’intérieur ou à l’extérieur des entreprises.

A l’ère de l’open data et de la digitalisation de la société, les interfaces de programmation sont au cœur du fonctionnement du web. C’est le cas par exemple pour une **application météo**. Ce n’est pas elle qui va chercher et analyser les informations météorologiques et vous les transmettre mais bien une API qui va se connecter à la base de données où se trouvent ces informations pour les afficher dans votre application. 

Les API procurent ainsi de nombreux avantages, que ce soit côté utilisateurs ou côté fournisseurs. 

-   L’utilisateur peut donc **intégrer les fonctionnalités** du programme dans son application ou son site web.
-   Le fournisseur peut de son côté procéder à des modifications de son programme sans occasionner d’incidence sur les utilisateurs des fonctionnalités. [Mastercard](https://developer.mastercard.com/apis), [Google](https://developers.google.com/apis-explorer), [Facebook](https://developers.facebook.com/docs/graph-api?locale=fr_FR), **Microsoft**, **SNCF**… De plus en plus d’entreprises mettent à dispositions leurs API, que ce soit de manière totalement gratuite ou contre rémunération.

### Quelles sont les applications des API ?

Elles sont partout, et sont **utilisées au quotidien**. Par exemple, si vous souhaitez intégrer une carte Google sur votre site Internet, vous utiliserez une API Google Maps mise à disposition par le géant américain. Idem pour inclure un bouton Like de Facebook, qui met à disposition l’API Facebook Graph. Autre application possible, lorsque vous consultez un site comparateur de prix une API va récupérer les informations dans différentes sources d’informations et les faire remonter dans le site ou l’application que vous interrogez.

> **Les applications sont multiples et infinies : paiement en ligne, site de réservation, consultation d’horaires de transport, météo, affichage de commerces de proximité, consultation de comptes bancaires…**

En effet, elles sont un gain de temps considérable pour les développeurs car elles peuvent être mises en place très rapidement grâce à leur interopérabilité et leur langage de programmation générique.

### Quels sont les différents types d’API ?

Il existe **deux catégories principales d’API** : les **API publiques**, appelées aussi open API, et les **API privées**, connues sous le nom de enterprise API. Les API sécurisées disposent alors d’une clé d’identification, fournie par un service d’authentification et d’autorisation.

Du fait de la grande diversité d’applications client, les API doivent s’appuyer sur un protocole de communication, le **SOAP** (Simple Object Access Protocol) ou le **REST** (Representational State Transfert) afin d’être **compatibles aux diverses plateformes mobiles**, qu’il s’agisse d’une application Windows, Apple ou Android. L’API Rest (ou Restful) est à présent la plus utilisée car elle offre plus de flexibilité.

### Quel avenir pour les API ?

Les interfaces de programmation applicatives sont amenées à durer. Cela permet en effet aux entreprises de moderniser leur système d’information en optimisant l’architecture de leurs outils et en réduisant les coûts de développement. Cela leur permet également d’être plus réactives et de **s’adapter plus facilement à chaque évolution numérique**. Offrant la possibilité de partager des données avec des utilisateurs externes ou des clients, les API simplifient et développent les partenariats et peuvent monétiser certaines données, générant ainsi des revenus.

## Requête HTTP
GET / POST / PUT / DELETE / PATCH.....

## Réponse HTTP
### Liens utiles
[Code HTTP](https://http.cat/)
### JSON / XML
Les réponse http se font sous le format JSON / XML.
#### Format JSON
```JSON
{  
 "fruits": [  
   { "kiwis": 3,  
     "mangues": 4,  
     "pommes": [null](https://www.journaldunet.fr/web-tech/dictionnaire-du-webmastering/1445250-null-definition-informatique-technique-et-variantes/ "Null")  
   },  
   { "panier": true },  
 ],  
 "legumes":  
   { "patates": "amandine",  
     "figues": "de barbarie",  
     "poireaux": false  
   }  
};
```
#### Format XML
```XML 
<?xml version="1.0" ?>  
<root>  
 <fruits>  
   <item>  
     <kiwis>3</kiwis>  
     <mangues>4</mangues>  
     <pommes></pommes>  
   </item>  
   <item>  
     <panier>true</panier>  
   </item>  
 </fruits>  
 <legumes>  
   <patates>amandine</patates>  
   <figues>de barbarie</figues>  
   <poireaux>false</poireaux>  
 </legumes>  
</root>
```

## A faire
 - Une API Web
	 - Logique métier
	 - Architecture :
		 - Entité
		 - controleur
		 - service
Faire fonctionner entity framework core => on créé des classe qui créé la bdd + maj la bdd.
Un readme qui explique ce que j'ai fait.
Utiliser swagger pour faire le front.
Utiliser postman




## Commandes utiles
```dotnet
Pour 
dotnet tool install --global dotnet-ef (install)
dotnet-ef (affiche la licorne)

dotnet restore => permet de restorer dotnet avec la config actuelle.

dotnet-ef migrations add (Nom de la migration) => créé une migration
dotnet-ef migrations add (Nom de la migration) => Met à jour la bdd avec la/les migration(s)

dotnet dev-certs https --trust
dotnet run --launch-profile https
```