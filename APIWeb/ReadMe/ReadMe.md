**L'API n'est pas terminé, il reste encore à réaliser les classes EquipWeapon() et RemoveWeapon() qui permettrons l'ajout et le retrait des statistique de l'arme.**


Commande initial pour lancer l'API : 
```dotnet
dotnet run --launch-profile https
```

**EndPoint Héro**

Pour créer un héro :
```
https://localhost:7148/addHero
```

Pour visualiser tout les héros créés :
```
https://localhost:7148/getAllHeroes
```

Pour visualiser un héros en particulié :
```
https://localhost:7148/getHeroes/{name}
```

Pour modifier un héro :
```
https://localhost:7148/changeHeroFeature
```

**EndPoint Ennemi**

Pour créer un ennemi :
```
https://localhost:7148/addEnemy
```

Pour visualiser tout les ennemi créés :
```
https://localhost:7148/getAllEnemys
```

Pour visualiser un ennemi en particulié :
```
https://localhost:7148/getEnemy/{name}
```

Pour modifier un ennemi :
```
https://localhost:7148/changeEnemyFeature
```

**EndPoint Armes**

Pour créer une arme :
```
https://localhost:7148/addWeapon
```

Pour visualiser toutes les armes créés :
```
https://localhost:7148/getAllWeapon
```

Pour visualiser une arme en particulié :
```
https://localhost:7148/getWeapon/{id}
```

Pour modifier une arme :
```
https://localhost:7148/changeWeapon
```
