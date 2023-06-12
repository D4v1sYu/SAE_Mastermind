# SAE_Mastermind

Cette application a pour rôle de simuler des parties de Mastermind. Les règles du jeu 
sont simples, deux joueurs doivent s’affronter. Le premier joueur doit élaborer une 
combinaison difficilement déchiffrable à l’aide de caractères sans la dévoiler à l’autre joueur. 
Le second joueur doit alors deviner cette combinaison. A chaque proposition, des indices sont 
donnés au second joueur pour l’aider.

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