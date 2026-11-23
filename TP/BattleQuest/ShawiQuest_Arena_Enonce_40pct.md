# Travail pratique — ShawiQuest Arena

**Pondération de 40 % de la note finale du cours**  
**Application console en C# · .NET 10 · Visual Studio 2026**

## Mandat

À l’entrée de l’arène, l’aventurier a une épée en main, une hache dans son sac et un compagnon à ses côtés. Devant lui se tient un golem. Le joueur décide comment l’attaquer, avec quelle arme et dans quel ordre enchanter son coup. Sa préparation peut changer jusqu’au moment où il confirme l’attaque.

Développez le jeu complet. Votre travail sera évalué sur son fonctionnement et sur votre capacité à répartir les responsabilités entre les objets. Vous devrez notamment expliquer comment votre conception permet d’ajouter une tactique, un enchantement ou une réaction aux blessures.

## 1. Faire jouer une partie complète

| État initial | Valeur |
| --- | --- |
| Aventurier | 14 points de vie (PV), force de 10 |
| Inventaire | Épée et hache, épée équipée |
| Tactique active | Attaque normale |
| Golem | 60 PV, riposte de 3 dégâts |
| Compagnon et journal de combat | Tous deux actifs |

Au début de chaque tour, affichez les PV des deux combattants, l’arme équipée et la tactique active. Le joueur peut changer d’arme, changer de tactique et congédier son compagnon avant de préparer son coup. Ces choix ne consomment pas le tour.

Lorsque le joueur confirme son attaque, affichez le nom de l’arme préparée, indiquez si le coup touche et mettez à jour les PV du golem. Si le golem survit, il riposte exactement une fois, même si l’attaque a raté. Dès qu’un combattant atteint 0 PV, annoncez la victoire ou la défaite. Les PV ne descendent jamais sous zéro. Une saisie invalide doit permettre de reprendre le choix en cours.

## 2. Choisir une tactique et une arme

La **tactique** détermine si le coup touche et calcule ses dégâts de base. Utilisez les PV du golem au moment de l’attaque, avant de lui retirer des points.

| Tactique | Règle |
| --- | --- |
| Normale | Touche et inflige des dégâts de base égaux à la force. |
| Puissante | A une chance sur deux de rater. Si elle touche, elle inflige le double de la force. |
| Finition | Touche. Si le golem a 10 PV ou moins, elle inflige le triple de la force. Au-dessus de 10 PV, elle inflige la moitié de la force, arrondie à l’entier inférieur. |

Sur un coup réussi, **l’épée** transmet les dégâts de base et **la hache** leur ajoute 2. Un coup raté inflige toujours **0 dégât**, même avec une hache enchantée.

L’arme et la tactique sont deux choix indépendants qui persistent entre les tours. Par exemple, passer de l’épée à la hache conserve la tactique de finition. Revenir ensuite à l’attaque normale conserve la hache.

## 3. Préparer le coup avant de le confirmer

Au début de la préparation, présentez l’arme équipée sans enchantement. Le joueur peut confirmer immédiatement ou ajouter jusqu’à deux enchantements, chacun une seule fois. Après chaque ajout, affichez le nom obtenu. Si le joueur choisit deux fois le même effet, conservez le premier choix et laissez-le poursuivre.

| Enchantement | Effet sur les dégâts obtenus jusque-là | Ajout au nom |
| --- | --- | --- |
| Feu | Ajoute 3. | « de feu » |
| Amplification | Multiplie par 2. | « amplifiée » |

Le menu doit offrir deux actions distinctes.

- **Recommencer la préparation** efface les enchantements du coup en cours. Le joueur retrouve son arme de base et sa tactique active. Les PV restent identiques et le golem attend.
- **Confirmer** termine la préparation et déclenche une seule attaque. Au tour suivant, le joueur retrouve son arme de base et peut choisir de nouveaux enchantements.

L’ordre choisi doit être visible dans le nom et dans le calcul. Voici les résultats attendus avec une force de 10 et une attaque normale.

| Arme préparée | Calcul | Dégâts |
| --- | --- | ---: |
| Épée de feu amplifiée | (10 + 3) × 2 | 26 |
| Épée amplifiée de feu | (10 × 2) + 3 | 23 |
| Hache de feu amplifiée | (10 + 2 + 3) × 2 | 30 |
| Hache amplifiée de feu | ((10 + 2) × 2) + 3 | 27 |

## 4. Réagir aux blessures de l’aventurier

Le **journal** affiche les PV réellement perdus et les PV restants à chaque blessure. Par exemple, si le joueur a encore 2 PV et que le golem lui inflige 3 dégâts, le journal annonce une perte de 2 PV et un solde de 0.

Le **compagnon** avertit le joueur lorsqu’il passe de plus de 10 PV à une valeur entre 1 et 10 inclusivement. Un passage de 11 à 8 déclenche l’avertissement. Un passage de 8 à 5 ne le répète pas. Si le joueur congédie le compagnon, celui-ci cesse de réagir pour le reste de la partie. Le journal continue ses annonces.

## 5. Concevoir la solution

Mobilisez les quatre patrons étudiés. Dans votre diagramme et votre code, on doit pouvoir suivre ces décisions :

- **Strategy** — Le combattant délègue le calcul du coup à la tactique active. L’appel qui déclenche l’attaque est le même pour les trois tactiques.
- **Decorator** — Les deux armes de base et les armes enchantées offrent les mêmes opérations de description et de calcul des dégâts. Chaque enchantement s’applique à l’arme obtenue à l’étape précédente.
- **Builder** — Le menu construit le coup progressivement à partir de l’arme et de la tactique actives. Le constructeur gère l’ordre, les doublons et la préparation en cours. À la confirmation, il produit une attaque prête à être exécutée. Le calcul du coup et la riposte appartiennent à la phase d’exécution.
- **Observer** — Le joueur signale un changement de PV. Le journal et le compagnon réagissent indépendamment. La classe du joueur ignore les classes concrètes qui produisent les messages. Un événement C# ou une interface d’observation conviennent.

Vous choisissez les noms des classes et des interfaces. Gardez la lecture du clavier et l’affichage du menu distincts des règles du combat pour pouvoir vérifier un calcul sans rejouer toute une partie.

## 6. Vérifier le résultat

### Partie de référence

Reproduisez cette séquence à partir de l’état initial. Elle permet de vérifier plusieurs règles en trois tours, sans dépendre du hasard.

| Tour | Décisions | Résultat attendu après le tour |
| --- | --- | --- |
| 1 | Garder l’épée et l’attaque normale. Ajouter Feu, puis Amplification. Confirmer. | Le coup inflige 26 dégâts. Golem à 34 PV, joueur à 11 PV. Le journal affiche la blessure. |
| 2 | Garder l’attaque normale. Équiper la hache, ajouter Feu, puis recommencer la préparation. Confirmer avec la hache seule. | Le coup inflige 12 dégâts. Golem à 22 PV, joueur à 8 PV. Le journal affiche la blessure et le compagnon avertit le joueur. |
| 3 | Garder la hache et l’attaque normale. Ajouter Amplification, puis Feu. Confirmer. | Le coup vaut 27 dégâts. Le golem tombe à 0 PV, le joueur reste à 8 PV et gagne la partie. |

### Autres cas à démontrer

- Refaites le début de la partie en congédiant le compagnon avant la deuxième riposte. Au passage de 11 à 8 PV, seul le journal réagit.
- Avec une force de 10 et une épée ordinaire, vérifiez l’attaque de finition contre un golem à 11 PV, puis à 10 PV. Les dégâts calculés doivent être respectivement de **5** et de **30**.
- Vérifiez les deux issues d’une attaque puissante avec une hache de feu. La réussite vaut **25** et l’échec **0**. Vous pouvez contrôler le tirage dans un test pour reproduire les deux issues.
- Vérifiez le refus d’un enchantement en double, le retour à l’épée après un changement de tactique et la fin de partie lorsque le joueur perd ses derniers PV.

## 7. Remise

Remettez une archive ZIP comprenant les éléments suivants.

1. **Solution Visual Studio** — Incluez le fichier `.slnx`, le projet console `.csproj` et les sources nécessaires. Vérifiez que la solution compile et démarre après extraction.
2. **Diagramme de classes UML** — Montrez les classes et interfaces qui participent aux quatre patrons ainsi que leurs relations. Fournissez un diagramme lisible en PDF ou en image.
3. **Fichier README.md** — Indiquez comment lancer le jeu. Pour chaque patron, nommez les classes concernées et expliquez leur collaboration à partir d’une action du joueur. Consignez vos vérifications dans un tableau précisant le scénario, le résultat attendu et le résultat observé. Les vérifications peuvent être manuelles ou automatisées.

## Grille de correction

| Critère | Éléments évalués | Points |
| --- | --- | ---: |
| Déroulement du combat | État initial et menu utilisable (2), enchaînement attaque et riposte (2), gestion des PV et fin de partie (2). | 6 |
| Tactiques et changement d’arme | Calcul des trois tactiques et traitement du coup raté (3), délégation à la tactique active (2), indépendance et persistance des deux choix (1). | 6 |
| Armes et enchantements | Comportement des deux armes (2), composition réutilisable des enchantements (2), exactitude des noms et des dégâts dans les deux ordres (2). | 6 |
| Construction du coup | Préparation progressive et aperçu (2), gestion des choix facultatifs et des doublons (2), reprise et confirmation avec exécution unique (2). | 6 |
| Réactions aux blessures | Notification indépendante des observateurs (2), journal et perte réelle (1), franchissement du seuil (1), désabonnement du compagnon (1). | 5 |
| Qualité de la solution C# | Compilation et lancement après extraction (1), séparation du menu et des règles (2), lisibilité et cohérence des noms (1). | 4 |
| UML et justification | Relations UML conformes au code (2), explications des quatre patrons appuyées sur une action du jeu (2). | 4 |
| Vérifications | Partie de référence documentée (1), cas limites et résultats observés documentés (2). | 3 |
| **Total** | **Travail valant 40 % de la note finale du cours** | **40** |
