### Introduction To Section 2 ###

In this section we will be dealing with a rigid body, and the effect of forces
on it.
  1. Unbalanced forces lead to accelerations.
  2. Accelerations lead to a change in velocity.
  3. Velocity determines the change in position.
  
We will be working backwards through this list, starting with position and
eventually creating components to model the effect of various forces on our
game object.

### Section 2 Assets ###



### Section Notes PDF ###



### Newton's 1st Law ###

+ Introducing Sir Isaac Newton 
+ Newton's First Law 
+ About the FixedUpdate() loop 
+ Updating transform.position
+ [Using FixedUpdate() - Execution Order of Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html)

### Summing The Forces ###

+ using System.Collections.Generic; 
+ Create a public list of forces, forceVectorList; 
+ Create AddForces () so sum the forces. 
+ Debug.LogError () if we have a net force. 
+ Otherwise continue to update the position.

### Newton's 2nd Law ###

+ 2nd Law Defined
+ Write Code For Acceleration
+ Publicly expose float mass
+ Create UpdateVelocity () method
+ Modify velocityVector every FixedUpdate
+ Remove Debug.LogError() code

### Newton's 3rd Law ###

+ Defining Newton's Third Law. 
+ Examples of why it's important to consider. 
+ Introducing our trail drawing code. 
+ Switching trail direction. 
+ Recap of Newton's laws

### Physics Engine Architecture ###

+ What we're trying to achieve. 
+ Why it's important to get this “right”. 
+ Re-orgainse list iteration for variable forces. 
+ Bring DrawTrails.cs into PhysicsEngine.cs. 
+ Move the forces into separate components.

### DOWNLOAD Unity Project ###



### SI Units & Dimensions ###

+ About Units and Dimensions. 
+ Why it's worth thinking about them. 
+ Where to annotate our units. 
+ Prepare our RocketEngine.cs class.
+ [SI base unit - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/SI_base_unit)

### Rocket Science 101 ###

+ The thrust of a rocket engine. 
+ Modelling rocket engines and fuel burn. 
+ An introduction to “delta V”.  
+ [Rocket engine - Wikipedia, the free encyclopedia](https://en.wikipedia.org/wiki/Rocket_engine)

### Modelling Gravity ###

+ Review the universal gravitation equation* 
+ Create a method for it in Unity. 
+ Check we get realistic force values. 
+ [Gravitational constant](https://en.wikipedia.org/wiki/Gravitational_constant)

### Back Down To Earth ###

+ Setup a football field “on Earth”. 
+ Test gravitation matches real values. 
+ Explore parabolic flight. 
+ Set scene for air resistance.

### Air Resistance ###

+ Design a simple formula for air resistance. 
+ Create an Air Drag component. 
+ Test flight against reference ball. 
+ Tweak to get similar results to Unity's engine.
+ [Drag (physics)](https://en.wikipedia.org/wiki/Drag_(physics))

### Script Execution Order ###

+ Expand on Unity's script execution order* 
+ Demonstrate our bug at “high” speeds. 
+ Show how this relates to fixed update time. 
+ Move Universal Gravity to separate object. 
+ [Execution Order of Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html)

### Making A Simple Game ###

+ Make a simple hit-the-target game. 
+ Add a cylinder to represent a rocket launcher. 
+ Write Launcher.cs class.

### Finishing & Tidying Up ###

+ Re-introduce Universal Gravitation. 
+ Review the overall structure of what we've done.

### Section 2 Wrap-Up ###

**WHAT YOU'VE LEARNT...**
+ Basic physics engine architecture / trade-offs. 
+ A foundation in Newton's Laws of Motion. 
+ Dimensional checking as a tool. 
+ How to distill information from Wikipedia etc. 
+ How to create components for various forces.
