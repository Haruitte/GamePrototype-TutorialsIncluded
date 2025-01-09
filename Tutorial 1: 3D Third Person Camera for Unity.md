## 3D Third Person Camera for Unity
### This tutorial will look at coding and implementing a third person camera into Unity that will be controlled by the players mouse movements.

### Step 1: Making the scene

The first thing that will be needed to do is to make a new (or open a scene you plan to add this system to) in Unity.

### Step 2: Making the gameObjects

For this tutorial, we will be using the assets that can be made in Unity as placeholders, for this we will be creating by going to GameObject at the top of Unity, then going to the dropdown, 3D Object selecting Cube and renaming this to “Player”. 

For the ground we will need to do the same thing, but instead of Cube, we will select Plane instead and naming it “Floor”.

Before continuing, select the Floor, and go to the top right of Unity, there you will see a dropdown. Click on it, and change Floor from untagged to ground.

![image](https://github.com/user-attachments/assets/13b500d7-be47-4908-8010-9bf534815ef6)
 
(It should look like this now)

This will be important so the Cube will know what its touching so it knows when its grounded.

Going back to the cube, we need to give it a way to interact with the other items in the scene, and we can do this by adding components to the Player.

Selecting the Player, if you go to the right, you will see a spot to “Add Component”. Here we will click that and add two things. Rigidbody and Capsule Collider.

Rigidbody will, in short, give our item to act under the controls of physics, giving weight to our model. Capsule Collider will detect when our item is colliding with an object. 

Do note the Cube will most likely already have the box collider assigned to it. To get rid of this, look at where it says Box Collider on the right of the screen, then look for the three dots on the right of its name, click that, and hit “remove component”.

![image](https://github.com/user-attachments/assets/beb81dd5-b0e5-4a08-89fc-07616aea2629)
 
When done correctly, it should look something like this. Take note of the settings as show here and make sure to copy them to the settings you have made on your own Player.

The reason we are doing this early is just so that once we add our code, we know the object will actually interact with our Floor and not just fall through it. As for why we chose Capsule over Box, this is only important once you add movement to a Player, but for now is just to help in the future with ramps or sloped ground.

### Step 3: Making the components for the Camera to attach and rotate to

![image](https://github.com/user-attachments/assets/740095f9-c882-43d7-b04c-18f30e941f5f)

Once that is done the next thing to do is two make two empty game objects. These will be called Camera Rotator and Camera Pivot. These are just empty shells attached to the cube for the actual camera to hang off.

![image](https://github.com/user-attachments/assets/32222060-0f38-446e-bec0-43b65f4d9221)

To make the gameObjects, right click the area with the Player already there, and “Create Empty” twice. After this, we’re going to create a camera. Do the same process for creating and empty, but select camera instead. After this we can go to the top right and right next to the arrow box we can click on the left of it, and select a colour. 

This will just make seeing the camera easier. From here, you can move it around and position it to your liking.

![image](https://github.com/user-attachments/assets/0a408af1-1ef5-4a16-86b3-d12b32f8a1f3)

(Should look something like this now)

The next step is to make a script for the Camera to interact with the Player’s inputs. To make a script, go to assets and right click the blank space.

### Step 4: Making the Camera Script and explaining what the code does

Before creating the script, I would make a folder to separate files, so instead of selecting C# Script when right clicking, click folder, and rename that to CameraControls. Opening the folder, right click again and create C# script, naming that RotatorControls.

The first step when making the script for the rotator is to make variables. These are in short, creating values that can be referred to in the statements we will be writing.

Here, we have made multiple floats (integer values that can also be decimals) and assigning them names, these referring to the Camera with yaw and pitch, the speed variables being akin to setting a sensitivity.

![image](https://github.com/user-attachments/assets/3f0a3b96-95c8-4d48-b35b-8fa228be6f97)

The SerializeField item before it is special, as despite these variables being private (meaning they don’t show up in unity), by using SF, we can force these lines to appear within Unity’s UI once we have attached the code to one of the Objects.

The transform is for creating a variable within Unity. This is where we will attach one of those empty gameObjects (Camera Rotator specifically) so it knows where to pivot off.

 ![image](https://github.com/user-attachments/assets/f334b05e-967f-4d7d-81c7-948288b7147e)

This statement is to prevent the cursor from moving when moving the camera. This is similar to how in most modern video games, the cursor won’t be usable when tabbed into the game so you don’t accidentally click on something such as the windows bar.
 
![image](https://github.com/user-attachments/assets/f13638a3-9a97-4dd4-911c-73a90d55b04d)

The code here is another statement, however the “void” is to make it so the code cannot return values. 

DetectMouse is, as named, code to detect where your curser is and using the Input.GetAxis function before x and y movements of our mouse (these are then multiplied by our sensitivity we have made as variables before this Mathf.Clamp allows us to limit the rage of the mouse, preventing the camera from entering unintentional areas, i.e. having the camera below the floor or behind a wall. ApplyCameraRotation does as it says, the code changing the angle of from where the rotation pivot is, thus spinning the camera.

 ![image](https://github.com/user-attachments/assets/976b0594-980a-49a8-ab39-54861c255333)

Finally for the script, below the private void start, we make a void update and put the previous statements we made under it so they run under update.

### Step 5: Attaching the script

The next step is to open Unity again, and drag the Rotator controls script onto the camera, this will allow the cameras to follow the code we just made for it. The last step before testing is to drag the Camera Rotator game object, we made earlier from the left column into the script we made from the transform variable at the beginning. 

![image](https://github.com/user-attachments/assets/7367fe34-2b98-46de-9f57-03298209d138)

Drag the Camera Rotator object into to Rotate Pivot on the right of the screen under Rotator Controls.

### Step 6: Finish

Now, after hitting play, this should be the end result.
