# Healthbar for Unity

## This Tutorial will be focused on making a health bar with deteriorating after effects when the user takes/ receives damage.

The first thing to do is to make a new in Unity scene or opening one in which you plan to implement this system into.

To get started go to the hierarchy and right click in it, going down to UI and canvas, and click it. Once that is done you should see two things pop up, a Canvas and an Event system. To make this easier to see, click 2D with canvas selected (as shown in the top right).

![image](https://github.com/user-attachments/assets/8232f8c6-6bca-43cb-8515-71f44f7eb1dc)

Then, within the canvas, create an empty game object and call it Health bar. 

![image](https://github.com/user-attachments/assets/8553d733-f594-4f4b-a504-fab3d5cdc990)
 
Here you can modify its dimensions to your preference, then create a UI image and call it Background, dragging that into the Health bar we just made (Ignore Full Health bar for now and Track systems as that is for something else).

![image](https://github.com/user-attachments/assets/c73d0a41-d4db-4281-b816-d3178c7c1d9a)
 
After this, go to the Inspector on the left for the Background and assign the Anchor preset to as seen above. This will set where the background of the Health Bar is on lock it to the health bar and adjust its sized based on the size of the health bar. Then Select the colour you want for your health bar, for me, this would be grey.

![image](https://github.com/user-attachments/assets/3f356ef7-3baf-4279-8f95-bc3bd73ce219)

Now, we repeat this process, but instead of calling it background, it will be called Fill. Attach this to the Health Bar so it is under the Background and repeat what we did for the Background, but changing the colour, ideally something brighter as this will be the health bar you see normally.

![image](https://github.com/user-attachments/assets/8013d6ef-e671-4337-b71b-ffebe77b637c)

![image](https://github.com/user-attachments/assets/304e4ffb-c167-4238-bdfa-1e3fe91e7c41)

Next, go to add components and a Slider to the health bar.

![image](https://github.com/user-attachments/assets/6070ca5d-abee-41e2-b31b-1dc8e9483e1b)
 
On the Value you can slide that bar up and down to test the colour changes nut make sure to drag Fill from hierarchy into Fill rect first. 

The next thing we are going to do is write code so that we can test taking damage and that it shows up on our health bar as feedback. To create a script, go to hierarchy, right click an empty space and click on C# Script and name this HealthBar

The first thing we need to do is make C# understand Unity’s UI system. To do this, scroll up until you see code that states “using” before it. Below that, put (using UnityEngine.UI;). This is so C# knows what commands you’re using and where they are from.

![image](https://github.com/user-attachments/assets/b474c5cf-80ad-4e30-9523-0f2c4458f8f7)
 
Then below that within the start of the script, we are going to set a list of variables that will be referred to through the code:

![image](https://github.com/user-attachments/assets/e4bc3ec8-d53f-4d0d-afa7-2b1fd8cf9d02)
 
The variables using Slider are to tell Unity to affect the slider we added to the health bar earlier, with the maxHealth assigning what value our health bar can cap at, whilst the variable known as health will be used later. lerpSpeed is a what will allow for a deteriorating effect on the health bar when it fades (this will be more prominent once I show you how it looks at the end).

![image](https://github.com/user-attachments/assets/35c342f8-fb09-4e1f-b018-6afab6ac2dd1)
 
The code above is assigned its name as per what the statements actually do. The first checks whether the health sliders value is equal to the health of the player. If it is not, it will change the slider to whatever the health value is when it changes, making sure it doesn’t display the wrong value on the slider.

The second (ChangingHealthValue) is to simulate taking damage. For this tutorial, as a test, when Mouse1 (Right click) is press the player will take damage just to make sure the slider works, here the value of damage being ten.

ChangingInGameHealth is similar to CheckingHealthValue, but it checks if the healthSlider is not equal to the easeHealthSlider value, and if not, changes the value of the easeHealthSlider (I will call this yellow health as that is what I have named it in my scene.) and match it to the yellow health slider. The lerp function will limit how much of the value can match causing a deteriorating health bar affect to make the animation smoother.

Finally, the take damage at the end is linked to the ChangingHealthValue, where it takes the value (in this case ten) and minuses from the health.

![image](https://github.com/user-attachments/assets/6814fb64-0d3d-409d-a65f-b1ca3e878036)

Then the last thing for the code is plugging them back into the game. This is done by taking the names of the statements and grouping them into another statement which I have called HealthValue. This is plugged into a void update so that it is always checking the statements conditions, and changing them using the code we have written. Then, in void Start, we set health to equal maxHealth at the start of the program running.

Back into Unity, you will notice we do not have a value known as Yellow Health or easeHealthSlider. Duplicate the health bar you have made and then delete the background of the original Health bar, making sure the new Yellow Health is above the hold one (and make sure to change the colour as well to, in this case, yellow).
 
Finally, make another empty game object this time calling it FullHealthBar, then drag the script we made earlier onto it, attaching the other items so it looks like this:
 
Then, drag the HealthBar from the hierarchy onto the Healthslider from the script, and drag the Yellow Health from the hierarchy as well onto the EaseHealthBarSlider. It should when finished look like this:

