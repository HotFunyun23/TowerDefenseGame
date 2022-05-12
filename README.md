# TowerDefenseGame
***
A tower defense game made in unity
## Table of Contents
1. [General Info](#general-info)
2. [Usage](#Usage)
3. [Installation](#installation)
4. [Important Files](#Important-Files)
5. [Remaining Bugs/Collaboration](#Bugs/Collaboration)

### General Info
This project is a work in progress tower defense game. 
So far it contains, a intangible track layout, Start and Stop points, moving Enemies, A game controller, and turret assets and materials.
UPDATE: It now also contains camera movement, a placeable turret, enemy tracking, and a basic placement interface.
#### Usage
The program is ran in unity and has scripts for the enemies, game master, camera, turrets, enemies, bullets, game controller, and waypoints in C#. Currently not finished, but easily could be collaborated on.

##### Installation
How to install:
1. Pull from github to desktop
2. Copy all files from pull into project folder in unity 
3. Open Unity project
4. Assign all scripts to prefabs of the same name
5. Press play and it should look like this image:

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
+Bullet: Distinguishes bullet color
+BulletImpact: Displays on hit bullet animation

3. Prefabs Folder
+ Enemy.Prefab: holds enemy data
+ Waypoint.Prefab: holds waypoints data
+ Node.Prefab: holds the nodes' data
+ StandardTurret.Prefab: Holds Turret data
+ Bullet.Prefab: holds bullet data
+ BulletImpactEffect: holds animation data

4. Scenes
+ Main Scene: Hosts main scene were all game objects are

5. Scripts
+ Enemy.cs: holds enemy class code
+ Wave_Controller.cs: holds game controller class code
+ Waypoints.cs: holds waypoint class code
+ Turret.cs: Holds turret code
+ Node.cs: Holds nodes code
+ CameraController: Holds camera controller code
+ Bullet.cs: Holds bullet code
+ BuildManager.cs: holds build manager code

####### Bugs/Collaboration
No Bugs currently other than download problems.
Wont commit with headers due to import problems so take this piece of text as a header for all scripts:
/*
Tower defense
is a tower defense game
Author: Conor Schaden
Date: 12/17/2020
On My Honor, I confirm that I followed all collaboration policy guidelines, and that the work I am submitting is my own: CMS
*/
If you were to collaborate in this project some good stepping stones would be as follows:
1. Make more turrets
2. Add a shop mechanic
3. add health and health bars
