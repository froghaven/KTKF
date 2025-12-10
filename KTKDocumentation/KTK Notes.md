


## **INFUSTRUCTURE**
* **Card \& Deck Database**
* **Deck Building System**
* **Battle System**
* **(Integration Systems)**



## **Battle**
***Formation Position***s  ( Deck / Hand / King / PILL1 / PILL2 / FL1 / FL2 / FL3 )
**Formations** (Player1, Player2..., OP1, OP2)
**Field** (Formations, ENVIRO, DISC)


## **Deck Builder**

##### **Deck Construction Requirements**
1 **Deck** = 4/20 Cards 	(MIN/MAX)
1 **King** 			                (MIN/MAX)
2/10 **Guardians** 		    (MIN/MAX)
1/3 **Environments** 	    (MIN/MAX)
**Items** 			                (**NO** MIN/MAX)

##### **Cards**
***Type*** 	  ( King / Pillar / Core / Noxious / Echo / Beast / Item / Enviro)
***Element*** ( Spirit / Chaos / Space / Time / Nature )
***Ability***    (Effect, Description)
***Name***
***ATK***
***HP***
**ID**

##### **Ability Query System** 
(An ability's effect(s) is represented in a query, that is plugged into a method and processed during compile.)


Expression Examples : 
- ( Ability that target a single opponent's guardian and reduces their health )
	[OP1; PILL2; HP-1]
	
- ( Ability that targets the player's front row, and increases ATK stat by 2 )
	[P1; Row1;  ATK+2]
	
- ( Ability attacks lane 1 of both players, then adds every guardian that fell in the attack to the player's hand, from the discard pile )
	[P1,OP1; Lane1; HP-1] 
	[P1; Deck, Hand; ]
###### **Query Expression Parts** (and valid inputs)
- **Field Target(s)** : ( P1, P2, P3, OP1, OP2, OP3 )
- **Formation Target(s)** : 
	Deck
	Hand 
	Enviro
	DISC 
	King
	PILL1
	PILL2
	FL1
	FL2
	FL3 
	Row1
	Row2 
	Row3
	Lane1
	Lane2
	Lane3
- **Target Type(s)** : (P1->)
- **Effect(s)** : 
	+Hand
	-HP
	-ATK
	
	
	
