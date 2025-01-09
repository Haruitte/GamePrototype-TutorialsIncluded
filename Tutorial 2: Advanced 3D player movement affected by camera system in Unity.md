# Advanced 3D player movement affected by a camera system in Unity

## This Tutorial will focus on making a controllable character in a 3D environment for Unity.

## Prerequisites:

This tutorial needs a camera system for the controls to work, as it needs to identify where the camera is facing to establish where the cube should face. 

It is advised you have a Camera system already made and established, or you know how to make one before continuing. (You can also follow along on my previous tutorial which does cover how to make a camera system).

## Step 1: Making the base parts of the System:

To start open a new scene in Unity, or an existing one if youplan on implementng this movement to an pre-existing scene with a gameObject you plan on making the "Player"

We will be using the assets that can be made in Unity as placeholders, for this we will be creating by going to GameObject at the top of Unity, then going to the dropdown, 3D Object selecting Cube and renaming this to “Player”. 

For the ground we will need to do the same thing, but instead of Cube, we will select Plane instead and naming it “Floor”.

Before continuing, select the Floor, and go to the top right of Unity, there you will see a dropdown. Click on it, and change Floor from untagged to ground.

![image](https://github.com/user-attachments/assets/b05c9801-5316-4202-a2a9-1c11693592f5)

(It should look like this now)

This will be important so the Cube will know what its touching so it knows when its grounded.

Going back to the cube, we need to give it a way to interact with the other items in the scene, and we can do this by adding components to the Player.

## Step 2: Adding components to our game objects:

Selecting the Player, if you go to the right, you will see a spot to “Add Component”. Here we will click that and add two things. Rigidbody and Capsule Collider.

Rigidbody will, in short, give our item to act under the controls of physics, giving weight to our model. Capsule Collider will detect when our item is colliding with an object. 

Do note the Cube will most likely already have the box collider assigned to it. To get rid of this, look at where it says Box Collider on the right of the screen, then look for the three dots on the right of its name, click that, and hit “remove component”.

![image](https://github.com/user-attachments/assets/fba1b70f-d9e5-45d3-9d1a-944ea5bc28e4)

When done correctly, it should look something like this. Take note of the settings as show here and make sure to copy them to the settings you have made on your own Player.

The reason we are doing this early is just so that once we add our code, we know the object will actually interact with our Floor and not just fall through it. 

As for why we chose Capsule over Box, this is important as if using a box collider, when using this system the box will tip over due to angled slopes, whereas Capsule will have a gab, so it goes up smoothly.
 
When done correctly, it should look something like this. Take note of the settings as show here and make sure to copy them to the settings you have made on your own Player.

The reason we are doing this early is just so that once we add our code, we know the object will actually interact with our Floor and not just fall through it. As for why we chose Capsule over Box, that will come later.

![image](https://github.com/user-attachments/assets/71a93ea3-bab7-43d4-96c9-0259ddf10aac)
 
Your scene should roughly look like this for now.

Before we continue, the first thing to do is start making folders in the assets section for different items. This includes things like Scripts, Presets, and other items, however, you can also use folders to separate different aspects, such as having a folder just for Camera based assets, or one for Player based assets.

To do this, just right click on the assets box, look for “new”, and select Folder. (I did not do this properly, hence why my assets are messy, so take this as a lesson from me.)

In your respective folder for “Player” assets, right click and create, but this time, we will be making a C# script. Name “Player”, and drag that script to “add component” for the cube (Player). Then, double click to open it.

## Step 3: Making the script/code for the movement:

### Making the variables:

![image](https://github.com/user-attachments/assets/b94e9c90-73f5-4931-9559-cb0c09c7f3a0)
 
To explain, the code you see now are known as “Variables”. These are things that act as values, int refers to integer and whole numbers, with float also referring to numbers, but these values can have decimals. These values are what we will use to set characteristics for our player object.

The speed, jumpForce and rotateSpeed defines the movement parameters for the Player, controlling horizontal and vertical movement for our Player.

The code referring to direction, cam rotator and camera forward will work in conjunction with the code we will write later, telling the system what direction the cube is facing, so that when we hold forward on our keyboard, if we are facing east, we will head east.

The other values also use int and floats, but their purposes are to be used as checks; to see if the Player is at a certain value which will then be influenced by later code. And important note is that these variables should be before any of the code that we will be writing, as they will need to be the first thing the computer reads in the lines.

## Step 4: Seprating our code into core aspects, lateral movement:

The next thing to do is to make the code for the actual aspects we plan on influencing on our character. The main things we want to do with our character are “detecting” inputs and “applying” forces onto our characters. To do this, we need to make multiple lines of code for specific actions. A good place to start is detecting movement.

The reason We seperate the code is so that any errors that we ma encounter can be foudn within a smaller block of code, rather than having to scroll through one massive statement.

![image](https://github.com/user-attachments/assets/8a31127c-515f-43b6-818a-05fed02d4ec1)
 
The Statement above refers to the variables we made earlier, and assigns them as code here, where referring to the input, we will get different axes for different directions of our Player (For now, ignore apply jump.).

As shown here, we also use it to offset the angle the camera is facing in Unity, assigning that vale to be zero so any rotations are based on that angle, instead of the angel the camera was at originally when added into Unity.

![image](https://github.com/user-attachments/assets/346b404d-04cc-479d-91fa-66062db1c419)

Here, we now start coding what forces will be applied onto out Player. The first (apply walking) using an if function, looks to see if the input values do no equal zero (which is our base) meaning when a key is pressed, our Player’s input value will change, which will then trigger the code within the if function.

This code does a couple of things, the first is change the velocity of the item to the three axes (with the new Vector3 items laid out as (x,y,z) and different axis being multiplied by external forces, such as x and z being affect by our speed, as those are the axes we travel when walking, and y not having any multiplier as it isn’t affected by lateral movement.).

As you can see, we also call back to direction at the beginning by multiplying all of the factors that may affect it, that being cameraFoward, forwardInput, CamRotator.right and horizontalInput.

This will multiply the afforementioned values andset that as our direction based on the camera with the if statement checking if our x and y movements do not equal zero.

This will trigger the if statement, change the velocity of our "Player" to by the direction our camera is facing in, moving us forward in that direction.

The code referring to quaternion’s is just to dictate what we define as the “front” of our player and being used to smooth the turning of our object as it faces different directions.

## Step 5: Creating our Jump and checking if we are grounded:

Below that is code to apply jump, grabbing the space input and when pressed, applying force horizontally multiplied by jump force we set earlier as a variable. 

For jumping, we also need to make sure that our Player can’t jump at moments they aren’t expected to. We need to find a way to detect when the Player object is grounded, otherwise our player would be able to jump repeatedly and infinitely.

![image](https://github.com/user-attachments/assets/ccd86407-47d8-4701-b9da-01a52b6eb506)

This code here checks when the Player starts contacting another object, and when they stop. The code here simply adds a value to when we are touching something, and removes it when we are not. 

This means that when we jump if the value was zero, it would interact with the code we wrote for jumping earlier, (&& isOnGround > 0) making it so that the pressing Space whilst they are midair would not apply the force again.

If you were to take this code and try to test it, nothing would happen. This is because we haven’t told the computer when to apply this code, so the final thing we need to do is to tell the computer when to run the lines we have made.

![image](https://github.com/user-attachments/assets/b7ad24d8-7bef-46ab-9ea5-4b4b91d05fea)
 
In the space between our Variables and the lines we just wrote, we need to set a Start, and update and a fixed update. Code under start will be run once as soon as the program begins. This is where we set our ground value for that jumping feature, as well as where we tell the code to gather the rigidbody we applied in Unity.

Update and fixed Update are similar, however its important we run Apply Jump and detect movement in update rather than fixed (This is due to the fact fixed updates grabs information at set intervals whilst update does it not as accurately. 

For lateral movement, that’s fine, however since jump is affected by the Player’s velocity, its better to set it to normal update otherwise the Player will not jump correctly.)

![image](https://github.com/user-attachments/assets/b595bbd7-30dc-47cc-8dfb-2f3d85b74f7b)

## Step "6": Re-entering Unity and finalising:
 
After going back into Unity, select the Player object, and drag it into the body, then select the Camera Rotator below inside the Player, and drag that into Cam Rotator (as shown below the body insert).

The finished product should look something like this:

https://github.com/user-attachments/assets/c86ffcd6-ca4f-4893-abdb-a08054207ca3

