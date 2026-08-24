<p align="Center">
<img src="../../includes/logo.png" alt="drawing" width="100"/>
</p>

<h4 align="Center">
1SY - Analyse Objet
</h4>

# 🏋🏻‍♂️ Exercices 02 - Diagrammes de séquence

#### 📁 [Structure à utiliser](../../includes/rules.md)

## 📝 Question 01 - Omnivox

Un étudiant se connecte au portail de son collège afin de consulter ses
notes. Créez le diagramme de séquence dans PlantUML pour le scénario
`nominal` suivant :

1.  L'étudiant ouvre l'application mobile Omnivox et tente d'accéder à
    ses notes.
2.  L'application, non authentifiée, renvoie l'écran de saisie
    d'identifiant.
3.  L'étudiant saisit son identifiant et son mot de passe.
4.  L'application envoie la requête au serveur qui la relance au système
    d'authentification provincial (SAP).
5.  Le SAP confirme l'authentification.
6.  Le serveur renvoie une confirmation d'authentification à
    l'application.
7.  L'application demande au serveur d'obtenir les notes de l'étudiant.
8.  Le serveur consulte la base de données et retourne les notes à
    l'application.

## ✅ Question 02 - Qualitek

On s'intéresse ici au cas d'utilisation `valider pièce` d'un système
d'assurance qualité d'une entreprise œuvrant dans le monde
manufacturier, `Qualitek`.

Un employé inspecte une pièce produite à l'aide d'un scanner 3D afin de
s'assurer qu'elle répond bien aux exigences de qualité de base du
client.

Le système analyse les données 3D reçues afin de valider si la pièce est
conforme. Si elle l'est, il en informe l'employé, qui scanne, à l'aide
d'un scanner régulier, son numéro de série afin de l'ajouter à la base
de données de l'inventaire. Si la pièce n'est pas valide, une procédure
de non-conformité est enclenchée. Cette procédure étant complexe, elle
fait l'objet d'un cas d'utilisation en soi. \> 💡 Indiquez ce cas
d'utilisation dans votre diagramme, mais ne le détaillez pas (`ref`).

Afin de pouvoir effectuer son travail, l'employé doit obligatoirement
s'authentifier. \> 💡 Cas d'utilisation externe également.

Programmez le diagramme de séquence de ce cas d'utilisation dans
PlantUML.

## 💰 Question 03 - Money Money

Transportons-nous dans le monde merveilleux des guichets automatiques
d'institutions financières (pas les guichets mobiles).

Discutez en équipe du fonctionnement de ces guichets et, en utilisant le
template, élaborez un cas d'utilisation détaillé pour
`retirer de l'argent` où il serait approprié d'utiliser au minimum un
des cadres UML (`alt`, `opt` ou `loop`).

Créez ensuite le diagramme de séquence approprié.

<hr>
<p align="Center">
<img src="../../includes/end.png" alt="drawing" width="150"/>
</p>
