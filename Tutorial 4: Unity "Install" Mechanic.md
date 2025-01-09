# Unity “Install” mechanic.

## This tutorial will cover something known as an “install mechanic”, and making it for unity in a 3D environment.

## What is an "Install?"

Before starting the tutorial, the first thing I need to explain is what a “Install” actually is. An install in most games originates from fighting games, when a Player character will build up a resource, normally in the form of a meter, to enter a new “state”.

This state will change what set of abilities are available to the player whilst using the same buttons (i.e. the player will get result “a” when they click “a”, but when in install, they will get result “b” when clicking “a” instead.).

To illustrate this, in this Tutorial we will need some items to illustrate this better:

 - A way to represent what value we are at for the install.
 - A way to show in this tutorial, if we are in install.
 - A way to show the different changes whilst in install.

To do this, I will be taking advantage of Unity’s material system. Our goal for this part of the install is to get the player to change colours to represent different states. This is just to show and test that the “Player” will enter the correct states.

## Step 1: Creating a Scene and the base Assets:

First, create a new scene to begin this project.

We will start by creating our “Player” and a base for them to stand on. This will be done by going into hierarchy and right clicking, then 3D objects. Select cube then repeat the process, selecting plane the second time round.

![image](https://github.com/user-attachments/assets/55af470e-655b-4cf7-90d9-69c6afb6d7b3)

Rearrange it so it looks something like this, you can scale the floor by pressing “e” and dragging the coloured red line to expand it out. Press “q” to go back to select mode and click on the cube and floor to move them around.

## Step 2: Making the Script: Breaking down the Script

The first thing we want to do is to write a script for our install code. My advice is to go into assets and right click, and hit folder. We can call this “InstallSystem”. 

This is where we can keep all the assets for our items involved with managing the install system. Double click this folder to enter it, and right click it again, this time selecting C# Script and naming it “InstallMechanic”.

![image](https://github.com/user-attachments/assets/89e0e369-8cb9-42ad-832e-aaa26441d79a)

## Step 3: Establishing variables:

After Visual Studio has opened, the first thing we should do is start with our variables. These will be values we create and name that will be used later on in the Statements we will be writing.  

At the very top, we start with a Boolean. This is a variable that can only be either true or false. This is what we will assign our install to being at the start, turning it off for our player.

The next two variables our floats, which are values of integers that can be decimals. Here we will make two variables, the first being maxInstall to tell our program what the max value of the install cane be, and below that, we will make the installValue, which will change its value as we charge the install, and as it depletes.

The next two “Slider” variables are to communicate with Unity that we will be using a Unity’s Slider System. To then prepare for this, scroll up in Visual Studio, where you should see some code that starts with using.

![image](https://github.com/user-attachments/assets/f32ea7dc-dab5-4d8a-8b70-ded2eca21238)
 
Add, “using UnityEngine.UI” as seen above. This is just to communicate to Unity that we will be using part of its UI system for this script.

Returning back to the variables, the Sliders will be for making a bar which will tell us what value the Install system will be at. Below we set a float for lerpSpeed. This is to do with the bar as well, which will cause a decaying effect for our Bar when it goes down.

The next variable “Header” is just to clarify what the variables below are referring to, those being the colours our Player cube will switch to in the different states. These are followed by the names of the “states” we will be referring to later in the script, those being:

- idleColour for idle state (when the Player is not in install)
- attackColour for attack state (when the Player is not in install and attacking)
- installColour for install state (when the Player is in Install)
- installAttackColour for install attack state (when the Player is in install and attacking)

Colour is just so that we can assign a colour to these values when we go back into Unity.

## Step 4: Establishing values at script start:

![image](https://github.com/user-attachments/assets/1cb2fc33-46b0-4798-9463-7d237aaad9a5)

The final parts are to refer back to Unity, as we will be using assigning a Material to our Player to change their colour, this is just to tell Unity that we using that Material in this script, with the mesh renderer also to do with the Player’s game object.

We then need to assign some values at the start of the game, these being what the installValue should start at, and what we will be affecting within Unity.
 
Since this needs to run as soon as the game would start, we shall put that code under a void Start like so. Here, we establish the installValue, and refer back to our variables, making a new “player material” for our colour changing that will represent the different states.

## Step 5: Making statements for checking the Install, matching it to the meter and chaging its colour:

Below this, we want to write code to check which of the four states the Player is in to switch the colour of our Player when depending on the state they’re in.

![image](https://github.com/user-attachments/assets/5dd83768-7a09-48f9-9880-9bdd6f2345b1)
 
As an example, we will be writing four these statements for each of the states. To break down what these statements do, the first line is to assign a name to this statement, and making it a “void” statement, meaning the values won’t be returned. The if statement here is to check if the install value is at zero, then, if it is, it changes the Boolean variable we made for install to be false (since we have determined the value from the if statement to not meet the requirement of being in install). The next line just sets changes the colour of our material once it re-enters Unity.

Now to show what it would look like to check if the Install was true, we change the parameters of the if statement.

![image](https://github.com/user-attachments/assets/014a636c-2204-4a3e-9645-c64311229833)
 
Here, it is similar to the code we wrote before, but this time it checks if the install is false and if and install value are equal to the max install variable we made earlier (which is set to be 100) is true. This will then change the install value to true, then will change its colour in response to this.

## Step 6: Changing Install values and grouping Statements:

The next thing we need to do is repeat this process but if the Player is attacking for both no Install and true Install.

![image](https://github.com/user-attachments/assets/bc4cb477-cb14-48ad-acd2-10feaef3172b)
 
Here instead of checking the install value, we check if the Player is attacking, and whether or not the install is true or false so we get different colours depending on the state of the Player. To simulate attacking for this tutorial, we will assign attack as “MouseButton(0)” (Left click) as our attacks. It will then change the colour of the Player like we did with the previous statements.

We then need to write code on how to increase the meter, and how to make it decrease once we are in install (as install isn’t a permanent state our Player will be in). 

![image](https://github.com/user-attachments/assets/eb568c23-5059-451d-bffb-ccb0bb5dd23d)
 
This code focuses on changing the value of install. The first is a flat increase and the second is a decrease over time. We haven’t assigned these values yet but we will assign a separate a value to them. For now, this code also adds a limit to how much and how little they decrease by, as well as setting the meter to change as well.

![image](https://github.com/user-attachments/assets/0084ca63-0420-4e8e-bb8d-c5345070a1f4)
 
Here we are just gathering the if statements from before and grouping them together under a new statement (ColourSwitch). 

![image](https://github.com/user-attachments/assets/d2452bd2-bfe2-4b5b-aabc-fd39a4ea0af5)
 
Above this we make a new statement, that being an if statement called SliderCheck. This will just mean when we make our Slider for the Install Meter it will correct the value of the slider to our Install value to match. The Mathf.Lerp is to limit how much the meter can adjust at a time; this will make the meter look smoother as it goes up and down with the values changing.

## Step 7: Tying Scripts to update and adding attack functions:

![image](https://github.com/user-attachments/assets/05751069-1552-40a7-abe8-36c921493d45)
 
Above this, we focus on connecting all our statements together in update from before, but we also add the value changers here. This is how we control the colour of the Player when they’re attacking and how we change the install value, as shown with decrease install and increase install, with the if statement changing the colour of the Player whilst we attack.

## Step 8: Creating Material and Mesh Renderer in Unity, assigning Colours:

![image](https://github.com/user-attachments/assets/d0a835e4-4e06-4427-8220-096c5f689a2c)
 
After heading back into Unity, we’re going to need to assign the script we just made to our cube. Select the cube (our Player) and grab the script from assets, and drag it onto the inspector on the right, to add component. 

![image](https://github.com/user-attachments/assets/af22c1d4-231f-46e5-98aa-835ed233499c)
 
Before continuing, we need to make a material for our Player. To do this, in our folder for our Install system, we’re going to right click inside the folder, and hit create. You should fine a button called material, and after clicking it, we’re going to name that material PlayerIdle.

![image](https://github.com/user-attachments/assets/04219500-ec5e-4c91-a437-f3cd54da5b71)
 
From there, go back to add component and select “Mesh Renderer” and add it.

![image](https://github.com/user-attachments/assets/d68cb38e-4e39-4c3b-9ccf-90f938f3ca2e)

We can then drag PlayerIdle Our material) and Mesh Renderer to the spots you see here, as well as assigning colours to our State Colours we named before (They can be whatever colour you would like, but I have assigned them as such here).

![image](https://github.com/user-attachments/assets/c4ac95d6-864b-4977-8ac6-6148d79f6a4c)

## Step 9: Creating the Meter to represent our Install Value:
 
Your Install Script should look something like this (which is different from the image earlier where there were items already attached to the Install Slider and Ease Install Slider.), however we have to add one last thing before we can make sure it works, that being a meter to see our values.

Go to the hierarchy and right click to create a Canvas (this will create an event system, do not worry about that as it is what will be controlling the canvas) and within the canvas, create an empty game object and name it Install. (To make it easier to see, click 2D and select the object again.)

![image](https://github.com/user-attachments/assets/57da5eb4-8267-4345-9b73-76b68076f012)

Here you can modify its dimensions to your preference, then create a UI image and call it Background, dragging that into the we just made.

![image](https://github.com/user-attachments/assets/da525fcc-2a52-4737-8adc-ac70e83c2748)
 
After this, go to the Inspector on the left for the Background and assign the Anchor preset to as seen above. This will make it so the background colour is tied to the size of Install game object we made. I set the colour to grey, and it should expand out to match whatever colour you’ve chosen to the size of the install meter (which in this case is grey).

![image](https://github.com/user-attachments/assets/5cceeee9-0414-46a8-8c92-0cba5dcc6186)
 
Now, we repeat this process, but instead of calling it background, it will be called Fill. Attach this to the Install meter I the hierarchy so it is under the Background and repeat what we did for the Background, but changing the colour. This will be the colour of the meter, which in this case, will be set to orange.

![image](https://github.com/user-attachments/assets/14ee671a-be77-459b-a2b7-344f04779251)

Now go back to the game object we made in the hierarchy called install and go to add component in the inspector, hit the button and search for slider and add it. Drag the game object we made called fill from the hierarchy into the “fill rect” in the slider component we just added.

![image](https://github.com/user-attachments/assets/4f5db962-3e88-4791-801c-5b79269099e8)
 
Now, go back to the Install mechanic script and drag the Install object from the canvas in hierarchy to the Install Slider in the Install Mechanic Script and the end result should look like this:


