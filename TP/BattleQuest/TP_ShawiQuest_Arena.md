# Travail pratique — ShawiQuest Arena

**Application console en C# · Durée suggérée de 3 à 4 heures avec une boucle de combat fournie**

## Énoncé à remettre aux étudiants

Un aventurier affronte un golem dans une arène. À chaque tour, le joueur choisit sa tactique, prépare son arme et attaque. Si le golem survit, il riposte. Le combat se termine lorsque l’un des combattants atteint zéro point de vie (PV).

### 1. Changer de tactique pendant le combat

Au début de chaque tour, le joueur peut conserver sa tactique ou en choisir une autre. Chaque tactique calcule les dégâts de base à partir de la force du joueur et des PV actuels du golem.

| Tactique | Calcul des dégâts de base |
| --- | --- |
| Attaque normale | Inflige des dégâts égaux à la force du joueur. |
| Attaque puissante | Double la force du joueur, avec une chance sur deux de rater. |
| Attaque de finition | Triple la force du joueur si le golem possède 10 PV ou moins. Sinon, inflige la moitié de la force. |

La boucle de combat doit pouvoir demander au joueur d’attaquer de la même façon, quelle que soit la tactique sélectionnée.

### 2. Combiner les effets de l’arme

Une épée ordinaire porte le nom « Épée » et transmet les dégâts de base. Avant chaque attaque, le joueur peut lui appliquer chacun des effets suivants une fois, dans l’ordre de son choix.

| Effet | Modification apportée |
| --- | --- |
| Feu | Ajoute 3 aux dégâts et ajoute « de feu » à la description. |
| Amplification | Double les dégâts obtenus jusque-là et ajoute « amplifiée » à la description. |

Pour une attaque normale de 10 dégâts, vérifie les deux combinaisons suivantes.

| Ordre d’application | Description obtenue | Dégâts attendus |
| --- | --- | --- |
| Feu, puis amplification | Épée de feu amplifiée | (10 + 3) × 2 = **26** |
| Amplification, puis feu | Épée amplifiée de feu | (10 × 2) + 3 = **23** |

Une attaque ratée inflige toujours **0 dégât**, même avec une épée enchantée.

### 3. Réagir aux blessures du joueur

Lorsque les PV du joueur changent, deux éléments doivent pouvoir réagir indépendamment.

- Le **journal de combat** affiche la perte réelle et les PV restants. Si le joueur possède 4 PV et reçoit 7 dégâts, le journal indique une perte de 4 PV et affiche 0 PV restant.
- Le **compagnon** avertit le joueur lorsque ses PV passent de plus de 10 à une valeur comprise entre 1 et 10 inclusivement. S’il passe de 12 à 9 PV, le compagnon l’avertit. S’il passe ensuite de 9 à 6 PV, le compagnon garde le silence.

Le joueur peut congédier son compagnon pendant le combat. Le journal continue alors de fonctionner. La classe `Player` doit pouvoir gérer les blessures sans connaître les classes qui affichent le journal ou l’avertissement.

### Démonstration finale demandée

En une partie, change de tactique, montre que l’ordre des enchantements influence les dégâts, puis congédie le compagnon avant de franchir le seuil critique. Au franchissement du seuil, le journal doit afficher la blessure et le compagnon doit rester silencieux.

---

## Retour en classe — Notes pour l’enseignant

| Patron | Application dans ShawiQuest Arena | Question à poser aux étudiants |
| --- | --- | --- |
| **Strategy** | Le joueur délègue le calcul des dégâts de base à sa tactique active. Il peut remplacer cette tactique entre deux tours. | Comment ajouter une contre-attaque sans modifier la méthode `Player.Attack()` ? |
| **Decorator** | Chaque enchantement enveloppe l’arme obtenue jusque-là. Il reprend sa description et ses dégâts, puis les modifie. | Comment produire les résultats 26 et 23 avec les deux mêmes classes d’enchantement ? |
| **Observer** | Le journal et le compagnon s’abonnent aux changements de PV. Le compagnon peut se désabonner en cours de partie. En C#, un événement `HealthChanged` convient bien. | Quand le compagnon quitte l’arène, pourquoi le journal reçoit-il encore les changements de PV ? |
