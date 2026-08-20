<p align="Center">
<img src="../../includes/logo.png" alt="drawing" width="100"/>
</p>

<h4 align="Center">
1SY - Analyse Objet
</h4>

<h3 align="Center">
TP1 - Analyse objet d'une application de location de véhicules
</h3>

<p align="Center">
<img src="../../includes/rentit.png" alt="drawing" width="400"/>
</p>

## Mise en situation

RentIT, une jeune entreprise œuvrant dans la location de véhicules,
souhaite informatiser ses opérations en créant un système basé sur les
technologies web.

Un invité peut consulter le site web librement afin de vérifier
l'ensemble des véhicules. Il pourra en effectuer la réservation dans la
mesure où il accepte de devenir membre, ce qui implique de s'enregistrer
dans le système en fournissant ses coordonnées et ses informations
personnelles, incluant sa date de naissance. Il peut également faire
valider (ajouter) immédiatement une carte de crédit s'il le désire.
Sinon, cette opération sera effectuée lors de la réservation. Une carte
valide est une carte vérifiée par le SAC (système d'autorisation de
crédit).

Un membre qui désire réserver un véhicule devra avoir 500 \$ de crédit
libre sur sa carte de crédit, montant qui sera débloqué à son retour si
le véhicule est remis à temps et intact. Il choisira ensuite une
succursale de départ, la date et l'heure de prise de possession ainsi
que la succursale de retour (qui peut différer de la succursale de
départ). RentIT présentera alors la liste des véhicules disponibles (non
réservés) selon le groupe d'âge.

Il faut avoir un minimum de 18 ans afin de louer un véhicule compact.
Pour les berlines, l'âge passe à 21 ans et à 25 ans pour les véhicules
de luxe.

Quand un membre se présente au comptoir pour prendre possession d'un
véhicule, il est accueilli par un préposé à la location qui s'occupe de
préparer le véhicule pour la location. Il notera le kilométrage du
véhicule et son niveau d'essence, puis prendra des photos de l'état
initial du véhicule pour enfin procéder au paiement (effectué à
l'avance), soit en argent, par débit (après autorisation de
l'institution financière) ou par carte de crédit après confirmation du
SAC (système d'autorisation de crédit).

Il effectuera les mêmes opérations lors du retour du véhicule, mais
pourra, au besoin, réclamer des frais de location supplémentaires, le
cas échéant (dépassement du kilométrage, dommages, plein d'essence non
fait), qui seront débités sur la carte de crédit (les 500 \$
préalablement gelés). Une facture est envoyée au client pour des
dommages excédant les 500 \$.

La liste des véhicules disponibles à la location est gérée par le
gérant, qui œuvre dans l'entreprise et effectue aussi les tâches d'un
préposé à la location.

Seuls les invités peuvent utiliser le système sans être authentifiés.

Un véhicule peut être placé hors circulation pour de multiples raisons
(bris, entretien, etc.) et replacé en circulation plus tard.

## Votre mandat

Effectuer l'analyse objet de l'application RentIT.

Vous devrez élaborer un document Word propre qui sera remis aux
propriétaires de RentIT.

Ce document doit minimalement contenir :

1.  Le diagramme de cas d'utilisation (en équipe).
2.  Les [cas d'utilisation](./includes/UseCaseTemplate.zip) les plus
    importants selon votre jugement (un par étudiant, individuellement).
3.  Le diagramme de séquence du cas d'utilisation au point #2 (un par
    étudiant, individuellement).
4.  Le modèle du domaine (en équipe).
5.  Le diagramme d'état d'une voiture (en équipe).

Vous devez également remettre, individuellement sur Omnivox, un .zip du
répertoire principal de travail où se trouvent les documents PlantUML.

<hr>
<p align="Center">
<img src="../../includes/end.png" alt="drawing" width="150"/>
</p>
