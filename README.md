# Practical 5.1: Physics Engine
In this week’s first lecture, you learned about the Unity physics engine, and how to ‘physics enable’ game objects using colliders and rigidbodies. In this practical, you are going to use this knowledge to implement the physics for a ten pin bowling simulation, which should resemble the environment shown in the following video: https://youtu.be/Fmv4YFL3jnQ 

By the end of this practical, you will be able to: 
- Add a primitive collider component to a game object, and correctly configure it
- Add a rigidbody component to a game object, and correctly configure it
- Use the AddForce function to apply a force to a physics enabled object
- Use the AddTorque function to apply torque to a physics enabled object

## Task 1: Explore the Bowling Alley Project
You have been provided with a Unity project that contains a simple bowling alley scene constructed from primitive shapes and 3D models for a bowling ball and pin (i.e. skittles). 

Once you’ve cloned and downloaded the project, click on the primitive objects that make up the bowling alley. You should notice that each of these objects have box colliders added to them. This means that the physics enabled ball and pins that you will create in the remainder of the practical will be able to interact with them via the physics engine. 

Note: The objects that make up the bowling alley don’t need to have a rigidbody component for objects in the physics engine to interact with them, just a collider.

## Task 2: Create the Physics Enabled Ball and Pins
The bowling alley scene you have been given is missing two very important objects: the ball and the pins! In this task, you will fix this by using the “bowlingball” and “pin” models provided in the “Bowling Alley Assets” folder to add a ball and ten pins to the scene. To complete the task, you should ‘physics enable’ these objects by adding an appropriately configured primitive collider and rigidbody to each. 

You might find it useful to snap objects to grid when placing the pins. Select an object > Change tool handle to Global > Enable Grid snap (The button next to the global button). Grid distance can be edited by going to Edit > Grid and snap settings.

## Task 3: Create a Script to Throw the Ball
In this task you are going to create a script that propels the bowling ball down the lane and into the pins. Your script should allow the user to control how the ball is propelled down the lane using the following controls:

- A&D keys = position of ball when it is thrown
- W&S keys = power with which ball is thrown
- Spacebar = throw ball

I advise you to write an initial script which uses the AddForce method to propel the ball at the pins at a fixed speed. Once you have this working change the script so you can control the direction and power from the keyboard. Remember you can view changes to variables while in play mode if they are public variables. In the future, we will cover showing these in a heads up display.   

Once you have a basic script that is able to propel the ball into the pins, you should experiment with the parameters of the rigidbodies attached to the ball and pins to make them behave as realistically as possible.

## Task 4: Modify your Script to Add Spin
To complete today’s practical, you should modify your script to allow the user to make the ball travel along a curved path, by adding spin. Your script should allow the user to control how much spin is added to the ball, and in which direction, using the Q & E keys. 

## Optional Extensions
If you completed the practical, try these optional tasks during the peer learning session. 

- Use Physics Materials to define additional physical properties of the ball, lane and skittles (see [here](https://docs.unity3d.com/2018.4/Documentation/Manual/class-PhysicMaterial.html))
- Use Kinematic Rigidbodies to add moving obstacles, similar to those found in the game Wii Sports Resort, to the bowling alley (watch a gameplay of that game [here](https://youtu.be/Ntv_QOGbXjo)).
- Use the camera manipulation skills that you learned last week to create a dungeon crawler camera that follows the ball down the lane, as shown in [this](https://youtu.be/Fmv4YFL3jnQ) video
- Write a script that uses the print function to display the number of pins that have been knocked over by the ball (using Debug.Log or print).


