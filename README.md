# TowerDefenseGame
***
A tower defense game made in unity
## Table of Contents
1. [General Info](#general-info)
2. [Usage](#Usage)
3. [Installation](#installation)
4. [Important Files](#Important-Files)
5. [Remaining Bugs/Collaboration](#Bugs/Colaboration)
### General Info
This project is a work in progress tower defense game. 
So far it contains, a intangible track layout, Start and Stop points, moving Enemies, A game controller, and turret assets and materials.
#### Usage
The program is ran in unity and has scripts for the enemies, game controller, and waypoints in C#. Currently not finished, but easily could be collaborated on.
##### Installation
How to install:
1. Pull from github to desktop
2. Copy all files from pull into project folder in unity 
3. Open Unity project
4. Assign Enemy, Start, and Text prefabs to game controller and scripts to their appropriate prefabs of the same names.
5. Press place and it should look like this image:
![better run]https://github.com/HotFunyun23/TowerDefenseGame/blob/main/better%20run.PNG
###### Important-Files
All important files for this project are contained within the assets folder, the rest are github settings.
1. Imports Folder
+ Currently all of the turret's data is stored here along with nothing else.
2. Materials Folder
+End: distinguises end color
+Enemy: distinguises Enemy color
+GroundPlane: distinguises GroundPlane color
+Ground: distinguises Ground color
+Start: distinguises Start color
3. Prefabs Folder
+ Enemy.Prefab: holds enemy data
+ Waypoint.Prefab: holds waypoints data
+ Node.Prefab: holds the nodes' data
4. Scenes
+ Main Scene: Hosts main scene were all game objects are
5. Enemy.cs: holds enemy class code
6. Wave_Controller.cs: holds game controller class code
7. Waypoints.cs: golds waypoint class code
#######Bugs/Colaboration
Currently the only bug is that the turret will not work, also its materials are having trouble importing.
If you were to collaborate in this project some good stepping stones would be as follows:
1. Make turret track enemy prefab
2. Add health to enemy script so when they spawn its a set value
3. Make it so Turrets do damage to said healthbar
