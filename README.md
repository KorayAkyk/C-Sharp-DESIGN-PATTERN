
# DESIGN PATTERN C# #

## Comment on est noté ? ##

- Projet application C# console avec des design patterns
- QCM
- Rendre prise de note, repo Git bien documenter avec les prises de note de la semaine et les exercices

## Définition ##

- Schéma d’objet qui permette de trouver une solution à un problème courant
- Conception POO et méthodes de bonne pratiques en POO

## Les Patterns ##

- Pattern de construction
- Pattern de structuration
- Pattern de comportement

## Abstract factory ##

<img src="img/abstract_factory.png" alt="Abstract factory" width="400"/>

- Permet de déresponsabiliser le classe mère. Elle permet de pouvoir modifier un comportement sans modifier la classe mère.
- Design pattern ``Abstract Factory``

La classe Scooter est une classe mère d'héritage.
Les classes filles ScooterElectricité et ScooterEssence ont un "extends" pour que Scooter puisse étendre cette classe.

A quoi sert un pattern ?
Un pattern à pour but de régler tous les problèmes avec les créations de classes et permet de régler le surcharge en lien avec la classe parente

<img src="img/catalogue.png" alt="Abstract factory" width="400"/>

- Création d'une fabrique de vehicule en créant une interface qui contient les signatures des fonctions
- La classes FabriqueVéhiculeElectrique et FabriqueVéhiculeEssence implémente une méthode qui permet de créer un scooter en fonction de son type ScooterElectrique ou ScooterEssence.
- Création d'une classe abstraite Automobile
- Toutes les méthodes seront en Protected

<img src="img/patern_builder.png" alt="Abstract factory" width="400"/>

- Créer un constructeur de liasse de documents sans connaitre
- Structure de données
- Insatnce de classe
- 2 types de documents différents
