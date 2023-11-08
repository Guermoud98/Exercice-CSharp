# TP 5 : Classes abstraites DotNet  

Objectifs :  
• Créer une classe abstraite.  
• Dériver une classe abstraite  
• Implémenter une méthode abstraite  
Enoncé :
1. Soit la classe abstraite Employé caractérisée par les attributs suivants :  
• Matricule  
• Nom  
• Prénom  
• Date de naissance  
La classe Employé doit disposer des méthodes suivantes :  
• Un constructeur d’initialisation sachant que lors de la création d’un employé, son
matricule est incrémenté selon le nombre d’employés créés.  
• Des propriétés pour les différents attributs  
• La méthode toString  
• Une méthode abstraite calculerSalaire.  
2. Un ouvrier est un employé qui se caractérise par sa date d’entrée à la société.  
• Tous les ouvriers ont une valeur commune appelée SMIG=2500 DH  
• L’ouvrier a un salaire mensuel qui est : Salaire = SMIG + (Ancienneté en année) *100.  
• De plus, le salaire ne doit pas dépasser SMIG*2.  
3. Un cadre est un employé qui se caractérise par un indice.  
• Le cadre a un salaire qui dépend de son indice :  
o Indice 1 : salaire mensuel 13000 DH  
o Indice 2 : salaire mensuel 15000 DH  
o Indice 3 : salaire mensuel 17000 DH  
o Indice 4 : salaire mensuel 20000 DH  

4. Un patron est un employé qui se caractérise par un chiffre d’affaires et un pourcentage.  
• Le chiffre d’affaires est commun entre les patrons.  
• Le patron a un salaire annuel qui est égal à x% du chiffre d’affaires : Salaire =
CA*pourcentage/100  

Travail à faire :  
1. Créer la classe abstraite Employé.  
2. Créer la classe Ouvrier, la classe Cadre et la classe Patron qui héritent de la classe
Employé, et prévoir les Constructeurs et la méthode ToString de chacune des 3
classes.  
3. Implémenter la méthode CalculerSalaire() qui permet de calculer le salaire pour
chacune des classes.  
4. Créer une classe Program pour tester les méthodes des classes crées  
5. Dans la classe Program, créez un tableau contenant 3 employés, en stockant un objet
de chaque classe à l'intérieur, puis appelez les méthodes ToString et CalculerSalaire
pour chaque élément du tableau.  