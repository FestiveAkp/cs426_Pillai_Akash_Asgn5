# cs426_Pillai_Akash_Asgn5

**Game Description and how it relates to the theme:**

A human has a lot of work to get done on their computer, but their cat has other plans.
This is a two player game in which the server plays as the human and the client plays as a cat.
When playing as the human, you have some work to do at your computer, but your pet cat will try their best not to let you.
As the cat, you must step on different plates that are placed around the house in order to stop the human from getting their work done.
This relates to the theme because one of the players is a cat, and the other player has to work on a computer.


**The Formal Elements (FE) in our game are as follows:**

**Players:** human, cat

**Objectives:** capture - the cat is trying to destroy the workflow of the human

**Procedures:**
This is a two player game. The server plays as the human, and the client plays as the cat. The procedures/controls are as follows:

**Human**
Controlled by server (one player)
Can walk through entire house, trying to fix whatever the cat has messed up
Is controlled simultaneously (can be played as while human is being played as)
Movement controlled by WASD keys, camera controlled by mouse
If the cat has turned off gravity, repeatedly press down arrow key to cancel that action

**Cat**
Controlled by client (one player)
Can walk through entire house, causing mayhem
Is controlled simultaneously (can be played as while human is being played as)
Movement controlled by WASD keys, camera controlled by mouse

**Starting Action:** Choose whether you will be the server or client. This starts the game on your end.

**Progression of Action:** The human will try to get their work done on the computer, while the cat will try to sabotage them. There will be many switches placed around the house that the cat can use to keep the human away from their computer, which will disturb the human’s work. When this happens, the human must get up and fix the problem that the cat causes, and then promptly return to work.

**Special Action:** The cat can turn gravity on or off.

**Rules:**
There is a human and a cat. If playing as the human, you must get your work done. If playing as the cat, you must try to distract the human.

**Resources:** 
There are plates around the house that the cat can use to distract the human. One turns off gravity, one turns off the light, etc. The human can also use pressure pads to reverse the effects caused by the cat.

**Conflict:**
The main conflict for the human is his opponent, his pet cat.

**Boundaries:**
Physical: there are walls that don't let either of the characters leave the house.

**Executive Summary:**
Our game is a two player game targeted towards players that don't care to play games that have a story to tell or are very serious. The targeted age range is from 5 to 15. This game is also aimed at all genders.

## Changes for Assignment 5
**Physics Constructs**
- The player can left-click to throw little balls that bounce off of the walls and floor, which helps establish a facet of the relationship between the player and the cat.
- The stovetop inside the kitchen has a particle system mimicing fire, signaling that the player was cooking something in the kitchen before the game began.

**Billboard**
- There's a cactus on the living room table which is a quad that always faces the player, which adds a personal touch to the design of the living room.

**Lights**
- There are two lights, one of which is colored purple, in the living room, which help illuminate and add personality to the room.

**Sounds**
- When the player enters the kitchen, they can hear the sound of food sizzling on the stove, adding to the feeling of being at home
- When the player turns on the computer, they can hear the sound of the computer turning on, providing feedback that the player was successful
- Both sounds are distance-sensitive, and get fainter as the player moves away from the sound source

