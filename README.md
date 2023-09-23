# SAE_Mastermind

Règles du jeu :
-
Cette application a pour rôle de simuler des parties de Mastermind en langage VB.NET.
Le premier joueur doit élaborer une combinaison difficilement déchiffrable à l’aide de caractères sans la dévoiler à l’autre joueur. 
Le second joueur doit alors deviner cette combinaison. A chaque proposition, des indices sont donnés au second joueur pour l’aider.

Ces indices sont :
- Si le caractère est bleu, alors ce caractère est bien dans la 
combinaison, mais pas à sa bonne place.
- Si le caractère est vert, alors ce caractère est dans la combinaison, 
et à la bonne place.
- Si le caractère est resté gris, alors ce caractère n’est pas dans la 
combinaison.

Le joueur qui a conçu la combinaison secrète gagne si son adversaire ne trouve pas la 
combinaison en 15 coups, tandis que le second joueur gagne s’il trouve la combinaison en
maximum 15 propositions.

Options :
-
Si l’utilisateur le souhaite, il peut modifier certains parametres de jeu liées aux parties. 
Des options tels que :
- Le nombre de caracteres jouables
- La longueur de la combinaison à chercher
- Personnalisation des couleurs
- Choix de la limite de proposition
- Choix de la limite de temps

Exemple :
-

Liste des caracères : § € £ ¥ @  
Code couleur : $\textcolor{grey}{\textsf{Absent}}$ $\textcolor{blue}{\textsf{Présent}}$ $\textcolor{green}{\textsf{Bien placé}}$  

J1 doit entrer une combinaison en 5 caractères :  
*J1 : § € € @ £*  

J2 doit trouver la combinaison pour gagner :  
*J2 : € § ¥ @ €*  
T1 : $\textcolor{blue}{\textsf{€ §}}$ $\textcolor{grey}{\textsf{¥}}$ $\textcolor{green}{\textsf{@}}$ $\textcolor{blue}{\textsf{€}}$  
*J2 : § € @* $\textcolor{green}{\textsf{@}}$ *@*  
T2 : $\textcolor{green}{\textsf{§ €}}$ $\textcolor{blue}{\textsf{@}}$ $\textcolor{green}{\textsf{@}}$ $\textcolor{blue}{\textsf{@}}$  
*J2 :* $\textcolor{green}{\textsf{§ €}}$ *€* $\textcolor{green}{\textsf{@}}$ *£*  
T3 : $\textcolor{green}{\textsf{§ € € @ £}}$

J2 a trouvé en 3 tours et marque 1 point


En pratique :
-
À chaque partie, l’application sauvegarde le nom, le score, le meilleur temps pour deviner une combinaison, le nombre de parties jouées en tant que premier joueur, 
ainsi qu’en tant que second joueur et le cumul du temps passé à tenter de deviner des combinaisons pour chaque joueur. 
Ces données sont enregistrées dans un fichier pour pouvoir etre affiché lors de prochain lancement de programme.

Conclusion :
-
