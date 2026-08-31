<p align="Center"><img src="../../includes/logo.png" alt="drawing" width="100"/></p>
<h4 align="Center">1SY - Analyse Objet</h4>

# 🏋🏻‍♂️ Exercices 03 - Modèle du domaine

#### 📁 [Structure à utiliser](../includes/rules.md)

## 👩‍🍳 Question 01 - Les recettes de madame Giblotte

Considérant ces entités :

- `Book` (livre)
- `Recipe` (recette)
- `Ingredient` (ingrédient)

1. Dessinez le modèle du domaine d’un livre de recettes contenant de 50 à 75 recettes ainsi que des trucs et astuces beauté.

2. Dessinez le modèle du domaine d'un livre uniquement composé de recettes au nombre exact de 100.

## ✍️ Question 02 - ZenLease

Dessinez le modèle du domaine d’un mini système de gestion de condos locatifs contenant ces entités :

- `Tenant` locataire avec l'attribut _nom_.
- `Unit` unité d'appartement avec son numéro de porte.
- `Building` bâtiment avec son adresse.
- `Group` représentant un groupe de bâtiments dans un secteur donné, exemple : _Le domaine des tournesols_.
- `Lease` bail avec une date de renouvellement et l'option de renouveler.

> Un locataire peut louer plusieurs unités, ce qui générera autant de baux.

## 🎫 Question 03 - ZenLease Ticket Manager

Reprenez la solution du numéro 2, validée par l'enseignant, et ajoutez-y la possibilité de générer des appels de service de locataires `Request` qui demandent des réparations ou de l'entretien de façon urgente, importante ou régulière. Chaque priorité `Priority` répondra différemment à la fonction de vérification : déclenchée toutes les heures pour les urgences, toutes les 24 h pour les priorités importantes et toutes les semaines pour les régulières.

> La fonction de vérification `triggateUpdate()` est une fonction qui sera déclenchée selon la priorité afin d'envoyer une notification au contremaître d'entretien pour qu'il n'oublie pas le travail à effectuer.

## 😄 Question 04 - CSBuddySnap

Dans notre réseau social de messages éphémères, un membre, `Member` (nom), peut se faire de 1 à 5000 amis `Friend`. Pour ce qui est des communications, il sera possible, bien entendu, de communiquer à deux (tout comme dans Messenger), mais aussi de créer un groupe `Group` (nom) s'il y a au moins une personne de plus dans la conversation. Nous désirons finalement être en mesure de célébrer les anniversaires d’amitié.

> Prétendons ici que nous ne conservons aucun historique des conversations.

Réfléchissez aux entités nécessaires et aux liens entre elles et dessinez cette partie du modèle du domaine du réseau social.

## 🌳 Question 05 - L'arbre qui regardera vers le ciel.

Dessinez le modèle du domaine de la structure des répertoires et des fichiers de votre ordinateur comprenant ces entités :

- `Node` nœud abstrait.
- `File` fichier.
- `Folder` répertoire.

Un fichier est un nœud et un répertoire est un nœud qui est composé de répertoires et de fichiers.

Ajoutez-y correctement les attributs :

- `name` nom : string
- `data` contenu : byte[]

> Nous travaillerons avec les répertoires réguliers ici, et non pas les _smart folders_.

## ✈️ Question 06 - Si j'avais les ailes d'un ange...

Dessinez le modèle du domaine d’une partie d’un système de gestion des vols d’avion incluant ces entités :

- `Airline` compagnie aérienne (nom).
- `Flight` vol vendu par la compagnie aérienne (#vol, heure de départ, heure d'arrivée). Exemple : un vol de Montréal à Porto.
- `Airport` aéroport (nom, noIdentification).
- `City` ville (nom).

Pour ce cas-ci, fiez-vous au fonctionnement de ce type de système dans la vie de tous les jours.

> 💡 N'oubliez pas qu'il y a une origine et une destination.

### ✈️ 06.01 (DÉFI)

Ajoutez le principe d'escale `Stopover` à une copie du modèle du domaine #05.

## 🇨🇦 Question 07 - Canadian Tire

Dessinez le modèle du domaine d’un système de gestion de vente au détail que vous voudriez vendre au magasin `Canadian Tire`. Il existe plusieurs succursales à travers le Canada qui ont toutes un inventaire différent. Nous voulons pouvoir créer des circulaires qui seront identiques pour toutes les succursales. Prenez en considération que vous voudriez être en mesure de vendre ce même système de gestion à plusieurs autres clients que Canadian Tire.

### 🇨🇦 07.01 (DÉFI)

Recopiez le diagramme de la question précédente et ajoutez la possibilité d'effectuer des ventes.

<hr><p align="Center"><img src="../../includes/end.png" alt="drawing" width="150"/></p>
