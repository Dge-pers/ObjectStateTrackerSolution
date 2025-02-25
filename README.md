# Object State Tracker

Ce projet C# implémente un système de suivi des changements d'état d'objets métier. Il permet d'enregistrer et d'afficher l'historique complet des états d'un objet, incluant la date, la description et le nouvel état lors de chaque transition.

## Fonctionnalités

* Suivi des changements d'état d'objets métier.
* Enregistrement de la date, de la description et du nouvel état à chaque transition.
* Affichage de l'historique complet des états d'un objet.
* Tests unitaires avec NUnit pour assurer la qualité du code.

## Structure du Projet

* `ObjectStateTracker/`: Projet principal contenant les classes `BusinessObject`, `StateChange`, `StateHistory`, et `Program`.
* `ObjectStateTracker.Tests/`: Projet de tests unitaires utilisant NUnit.

## Comment Exécuter

1.  Clonez le dépôt.
2.  Ouvrez la solution `ObjectStateTracker.sln` dans Visual Studio.
3.  Exécutez le projet `ObjectStateTracker` pour voir un exemple d'utilisation.
4.  Exécutez les tests unitaires depuis l'Explorateur de tests de Visual Studio.

## Comment Contribuer

1.  Forkez le dépôt.
2.  Créez une branche pour votre fonctionnalité (`git checkout -b feature/NouvelleFonctionnalite`).
3.  Commitez vos modifications (`git commit -am 'Ajout d'une nouvelle fonctionnalité'`).
4.  Poussez vers la branche (`git push origin feature/NouvelleFonctionnalite`).
5.  Ouvrez une pull request.

## Dépendances

* [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
* [NUnit](https://nunit.org/)

## Auteur

* \[Votre Nom]

## Licence

Ce projet est sous licence \[Votre Licence].
