# Learning Journal
## Week One Goals
### Main aim for week one (8/10/24):
Drafts for potential tutorials = 
  - Brainstorm what would be needed in final year game project.
  - Identify main concepts of each idea.
  - Translate into code.


## Week Two Goal
### Coverage of Week two designs (15/10/24):

First task: folowing draft tutorial by Paul to develop understanding of Tutorial making.
Main takeaway's:
  - Give student base concept of what code does.
  - Illustrate clearly what is dont in order: Identify clear stepping points for new learners.
  - Give feedback within tutoial: I.e, outline what should happen, make tutorial respond.
      - i.e. Tutorial for damage: have item change colour during damage.
  - Make tutorial digestable: break down int each part: explain key points.
  - Learning Journal made

Drafts for potential tutorials = 
  - Brainstorm what would be needed in final year game project.
  - Identify main concepts of each idea.
  - Translate into code.

### Ideas for Tutorials
Since we can only have four tutorials, these ideas willl be drafted and picked depenending on how I want to use them
in conjuction to how important I see them to my final game plan and idea:

  - Charging Meter: Install mechanics.
  - 3D Movement (Including Jumping).
  - Double Jump Tutorial.
  - Dash Tutorial.
  - Block Tutorial.
  - Camera Movement.
  - Parry Mechanics.

Potential ideas may be merged depending on time and if i believe they link together strongly.
Ideas may be removed as well if they are either:
  - not important/ not immediately relevant to final game
  - issues in my own understanding for coding behind the concept

First Idea for coding: Install System/Meter
  - will most likley be a system used in the final game plan as part of in game combat and idle states

## Week Three Goals
### Looking at tutorials and starting first (22/10/24)

First task changed:
First tutorial wil be movement instead of meters/install.
  - Movement will be core part of Final project
  - Healthbar will cover basics of meter tutorial

Testing movement and main things needed to be addressed.
  - Basic 8 way movement
  - Jumping
  - Ground Checks
  - Direction

I was able to develop the code for today for basic movement based of Paul's code and combining it with a tutorial I watched online to get basic movement using transform functions to get rudimentary 3D movement in along the x-axis. The main issues at this moment was when jump was spammed, their was no way to detect if the player object was grounded.

## Week Four Goals (29/10/24)
### Contuining where I last left off on the movement Tutorial
  - Attempted to fix the double jump bug by adjusting what was considered ground, however that didn't stop the problem.
  - Realised the issue wasn't to do with the movement, but also because ny having the ground being a boolean, it had to be true or false.
  - Found a solution: Changed the detection for being grounded to a integer, set the base for grounded to zero, but anytime it enters collision, it increase by one, and on exit, minus by one. This meant when the Player was on multiple objects, it wouldn't matter because the ground value is above zero, however once they jump, because they leave the objects it would remove all those values by minusing by the amount that was already on. Once grounded was seen to be zero, if statement would activate: jump would not activate == no double jump possible.

Next steps: Start making a camera tutorial.

Began to follow basic camera tutorial.

## Week Five Goals (05/11/24)
### Continuing 3rd person Camera tutorial coding from last week
 - From the Camera tutorial, issues displayed for getting the pivot point to work.
 - Checking what could be the issue is, look through heirarchy.
 - Issue found, code in wrong place: needed to be assigned to main parent for the Camera which was the PLayer, also needed to attach camera rotator in the code.
 - Rearranged hierarchy, so that the order was Player, Cam Rotator, Camera Pivot then Main Camera. 
 - Wrote code on C sharp from a tutorial so that the Camera would be rotating from the pivot i made in Unit.
 - Had to go between the code and Unity to make sure that the limit for the camera in the code would look good in Unity.

During the camera tutorial, after getting it working, decided to change the how the movement would work. I wanted the camera to show where the "front" of the Player would be so that when the camera was facing a direction, it would assign that as the "front". This way the Player's forward key would always push them in the direction of the camera.

Started working on this, changing the Camera to the First tutorial, and making it so that their could be a prerequisite for the Movement tutorial.
-Main issue: Not sure where to start, or how to make this work.

## Week Six Goals (12/11/24)
### Continue fixing Movement Tutorial and changing so it works with the camera
  - Asked some people and Paul what to do, was shown the main steps
  - Make variables for direction and add a way to grab the Camera's Rotator as the Camera always faces where the mouse is pointed, so we can set that as our front.
  - Make another Variable for where the Camera is facing and then write code to offset the camera's new angle.
  - Had to make some adjustments to the direction code, as I made a mistake thinking that the direction was just based on camera forward, but had to then multiply that by the forward input, camRotator.right and horizontal inputs.
  - Went back into Unity to attach the Cam Rotator to the new Variable I maade for it, but needed to change that to a Serialize field soit would show up in Unity.

After fixing the Camera, spent some time just tweaking how fair it was from the Player in Unity, and finally found a personal preference.

Next Steps: Start Health Tutorial

Started making the Health bar work

  - Started following a tutorial for Health bars online, but didn't like how it appeared at the end of the video so I scrapped it.
  - Found a Health bar that would have a fading secondary bar to show how much damage was lost (akin to dark souls health bar with yellow health)

## Week Seven Goals (19/11/24)
### Continue Health Bar Tutorial from new Video
  - Main issue, along the video the person making it makes a cut in the video, excluding how they do a part of the tutorial
  - Went through with a friend on how to fix the main issue:
  - Issue found, the cut was before the person duplicated the HealthBar, they had removed the script from the orginal but kept it for the duplicated piece (which would become the Yellow Health)
  - Removed the script from the orginal so it would work.
  - Original Healthbar background covered the new health, rearranged hierarchy and removedthe original background.

After I finished this I wasn't sure what to do with the tutorials.
  - Spent some time cleaning my code after being given feedback on the way I had written it.

### In between classes (25/11/24)

After having some time after class previously to fix my code, just kept doing that, optimisng my code so that their would be maximum five lines in a statement so that if their were errors, I would be able to see where ther error could be since the code would be isolated within five lines.
Also fixed some bugs in the Health bar because I didn't save properly the week before, so just had to rearrange hierarchy again.

## Week Eight Goals (26/11/24)
### Deciding Final Tutorial:

I wasn't sure what to do for the final tutorial so went back to doing some fixes for the previous tutorials, as I had messed up in some of my code fixing: made and error where I tried shortening some code but it ended up doing something else.
I fixed this by just going to a previous save of the code, cross comparing the old and the new. Issue was found where I had swapped two variable's positions in the code and placed the Apply Jump movement into fixed update, tried putting it into Update and it started working properly, removing the issue where move and jumping would be lower to the floor.
Began to look at what my last Tutorial could be and chose to make it about the Install meter again:

The reason I did this is because I felt I was comfortable enough with my coding it try get the Install working.
Spent about an hour trying to make code (didn't work) as I did know what I needed to actually start.
Asked Paul, showed me where to start with the coding:

Set Goals:
  - What was Install
  - What did it do?
  - How would we indicate this in the tutorial
  - How would we represent this to the player.

Response:
  - Install was a state the Player would be in when its value reached maximum that would slowly deteriorate and would power up the Player
  - It would change the outcome of an input to something different when it was in install, for example, inputting "a" in normal state would output "a", but inputting "a" in install state would output "b" instead.
  - We could change the colour of the Player when they were in different states so it would be visible to the Player
  - With a meter similar to a health bar

Started the code for this with the help of Paul. Managed to get code for the different states and how to detect the States.
Main issues to combat next:

  - How do we change the colour of the Player
  - Issue where the Install Meter would work onve but would stop working once it came down.
  

## Week Nine Goals (03/11/24)
### Fixing the issues from the previous week.

Continued working on the tutorial for the Install Meter.
Kept having issues for the Player.

 - When trying to make the Player change colour it wouldn't work.
 - Tried to assign the cube directly to change colour but would get errors in Unity.
 - Tried to make fix the Meter butthe fix ended up making the meter not carge at all = reverted this fix.#

Managed to fix the meter by changingthe parameters to be if the meter was above max and below minimum, previous issue was due to the meter's value never hittint 100 exactly, so just changed it to be if it was ever other the max, that being 100.

### After Class:

Got help from a friend, found issue: Needed to assign a mesh and material to the Player Cube so that code could refer to that material, and change the colour there. Went back into the code and added the parameters to fix the 

