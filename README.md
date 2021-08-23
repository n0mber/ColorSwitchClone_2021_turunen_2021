# ColorSwitchClone_2021_turunen_2021

Current implementation:

- Final game scene can be found in **Asset/Scenes/ColorSwitchCloneGAME**
- All scripts are at **Asset/Scripts/***
- first I made collision with physics ignore by detecting sprite renderer's material color. However, with I wasn't able to destroy object when condition false. 
Therefore, I changed obstacles to be trigger and detecting same color by obstacles tag. **See scripts ColorChange and GameOverCollision**
- I slowed down camera, so that the jumping movement could be seen better - however, if the player advances fast, the ball could run out of the screen. 
This doesn't show however, because of the obstacles. **See scripts CameraFollow and Player**
- I wanted to make also obstacles that does other movement than rotate. I made this by creating points and the obstacle transforms its position towards those points.** See scripts MovementPoints and CircularMovement**
- I made also a finish line, so the player gets final score and restart the game. **See scripts Scoring, CollectStar, EndGame and GameOverScript**

Bugs/issues:
- there is a issue with camera rendering when setting Game over screen active
- the random functionality may give same color - the code to ignore same color, doesn't function
- I couldn't get the particle system working so that the instantiation happens ontriggerenter2D, therefore the particle system isn't unfortunately included in my submission


Possible additional features:

I'd like to add more spawning obstacles. 
For example, 
  -"shooting" from the side horizontally or diagonally blades that are different color.
  - There could also be one "shooters" on each side, so that when blades collide, player could to pass them. This feature could be additional to already existing obstacle, such as circle.
  - colored lines that goes down to up, so that player would have to wait right color
 I would try to implement these with particle system or do the spawning with IENumerator/Coroutine.
 
 Other features that I would add to gameplay, would be boosters/special start. Boosters/special start could for example, speed the game or slow the obstacles. 
 With speeded up booster, the value of starts could be higher and therefore player could collect even more start with more difficult setting.
 This could be done by script for collected object. When entering trigger, the camera speed and obstacles rotation speed are adjusted, and the value of score is changed. 
 
 

