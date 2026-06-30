# Roadmap

## Vision

Créer un city-builder entièrement **data-driven** permettant au joueur de développer une civilisation de la **Préhistoire jusqu'au Futur**.

L'objectif est de construire un moteur de simulation modulaire, facilement extensible et capable d'accueillir de nouvelles ressources, bâtiments, technologies et mécaniques de jeu sans modifier le cœur de l'application.

---

# Versions

## v0.1.0 — Fondations du moteur ✅

### Objectif

Mettre en place les fondations techniques du projet.

### Simulation

- [x] Gestion du temps
- [x] Gestion de la ville
- [x] Ressources génériques
- [x] Productions génériques
- [x] Construction générique

### Architecture

- [x] ScriptableObjects
- [x] BuildingData
- [x] ResourceData
- [x] ResourceDatabase
- [x] BuildingDatabase
- [x] ProductionData
- [x] ResourceCost

### Interface

- [x] Interface utilisateur dynamique
- [x] Input System

### Projet

- [x] Dépôt Git
- [x] Documentation initiale

---

## v0.2.0 — Première simulation jouable ✅

### Objectif

Construire une première ville sur une carte.

### Monde

- [x] Génération procédurale
- [x] Paramètres de génération
- [x] Rendu de la carte

### Simulation

- [x] Architecture de sauvegarde
- [x] Implémentation de la sauvegarde
- [x] Chargement de la sauvegarde
- [x] Placement des bâtiments
- [x] Rendu des bâtiments

### Interface

- [x] HUD
- [x] BottomBar
- [x] BuildButton Prefab
- [x] BuildMenu
- [x] Génération automatique des boutons
- [ ] Sélection d'un bâtiment
- [ ] Placement via l'interface
- [ ] Icônes des bâtiments
- [ ] Tooltip des bâtiments
- [ ] Informations sur les bâtiments

---

## v0.3.0 — Première ville autonome

### Objectif

Permettre à une ville de fonctionner sans intervention permanente du joueur.

### Population

- [ ] Citoyens
- [ ] Logements
- [ ] Besoins
- [ ] Croissance démographique

### Production

- [ ] Zones de production
- [ ] Conditions de placement
- [ ] Fertilité
- [ ] Gisements
- [ ] Forêts exploitables

### Économie

- [ ] Entrepôts
- [ ] Routes
- [ ] Transport des ressources

---

## v0.4.0 — Économie avancée

### Objectif

Créer une véritable chaîne de production.

### Économie

- [ ] Marchés
- [ ] Commerce
- [ ] Import / Export
- [ ] Échanges entre villes

### Ressources

- [ ] Ressources transformées
- [ ] Chaînes de production
- [ ] Artisanat
- [ ] Industrie

---

## v0.5.0 — Civilisation

### Objectif

Faire évoluer la civilisation à travers les âges.

- [ ] Technologies
- [ ] Arbre de recherche
- [ ] Époques historiques
- [ ] Culture
- [ ] Bonheur
- [ ] Religion

---

## v0.6.0 — Monde vivant

### Objectif

Créer un environnement dynamique.

- [ ] IA des villes
- [ ] Diplomatie
- [ ] Commerce entre civilisations
- [ ] Armées
- [ ] Catastrophes naturelles
- [ ] Climat
- [ ] Événements aléatoires

---

## v1.0.0 — Première version complète

### Objectif

Première version jouable et stable.

### Finalisation

- [ ] Équilibrage
- [ ] Optimisations
- [ ] Effets visuels
- [ ] Musiques & sons
- [ ] Tutoriel
- [ ] Documentation complète
- [ ] Version Release