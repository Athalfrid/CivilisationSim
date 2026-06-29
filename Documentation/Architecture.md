# Architecture

## Présentation

CivilisationSim est développé selon une architecture **data-driven**.

Le moteur de simulation est indépendant des données du jeu. Les ressources, les bâtiments, les productions et, à terme, les technologies, unités et populations sont définis dans des **ScriptableObjects**.

Cette approche permet d'ajouter ou de modifier du contenu sans avoir à modifier le cœur du moteur.

---

# Architecture générale

```
                    +----------------------+
                    |     GameManager      |
                    +----------+-----------+
                               |
                               |
                    +----------v-----------+
                    |         City         |
                    +----------+-----------+
                               |
         +---------------------+----------------------+
         |                                            |
+--------v---------+                      +-----------v----------+
|     Buildings    |                      |      Resources       |
+--------+---------+                      +-----------+----------+
         |                                            |
+--------v---------+                      +-----------v----------+
|    Building      |                      |    CityResource      |
+--------+---------+                      +-----------+----------+
         |                                            |
+--------v---------+                      +-----------v----------+
|   BuildingData   |                      |    ResourceData      |
+------------------+                      +----------------------+
```

---

# Responsabilités des principales classes

## GameManager

Responsable de la simulation globale.

Rôles :

* Initialiser la ville.
* Initialiser le temps.
* Lancer les ticks de simulation.
* Faire le lien entre Unity et le moteur.

---

## City

Cœur du moteur de simulation.

Responsabilités :

* Gérer les ressources.
* Gérer les bâtiments.
* Gérer la population.
* Produire les ressources.
* Construire les bâtiments.
* Consommer les ressources.

La classe `City` ne dépend pas directement de Unity.

---

## Building

Représente un bâtiment construit dans la ville.

Actuellement, il encapsule simplement un `BuildingData`.

À terme, il contiendra également :

* la position ;
* le niveau ;
* l'état ;
* les travailleurs ;
* les améliorations.

---

## BuildingData

Décrit un type de bâtiment.

Contient notamment :

* l'identifiant ;
* le nom ;
* l'icône ;
* les productions ;
* la capacité de logement ;
* les coûts de construction.

Il s'agit d'un `ScriptableObject`.

---

## ResourceData

Décrit une ressource du jeu.

Exemples :

* Nourriture
* Bois
* Pierre
* Fer
* Or

Chaque ressource possède un identifiant unique.

---

## CityResource

Représente une ressource possédée par la ville.

Contient :

* la référence vers `ResourceData` ;
* la quantité actuellement stockée.

---

## ProductionData

Décrit une production effectuée par un bâtiment.

Contient :

* la ressource produite ;
* la quantité ;
* la probabilité de production.

---

## ResourceCost

Décrit un coût en ressources.

Utilisé actuellement pour la construction des bâtiments.

À terme, il pourra également servir pour :

* les technologies ;
* les améliorations ;
* les unités ;
* les échanges commerciaux.

---

# Philosophie de développement

Le moteur ne manipule pas directement les bâtiments ou les ressources.

Il manipule des données.

Ainsi :

* ajouter une nouvelle ressource ne nécessite aucune modification du moteur ;
* ajouter un nouveau bâtiment ne nécessite aucune modification du moteur ;
* ajouter une nouvelle production ne nécessite aucune modification du moteur.

Le contenu est défini dans les `ScriptableObject`, tandis que le moteur se contente d'interpréter ces données.

---

# Évolutions prévues

Les prochaines versions introduiront notamment :

* un système de carte ;
* le placement des bâtiments ;
* les citoyens ;
* les routes ;
* le commerce ;
* les technologies ;
* les sauvegardes ;
* une intelligence artificielle.
