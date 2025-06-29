# 3D Vehicle Movement

A Unity project demonstrating a physics-based 3D vehicle system using Wheel Colliders. This project provides a basic but expandable framework for car movement, steering, braking, and suspension in a realistic environment.

## Features

- ✅ Physics-based vehicle movement using Unity's `WheelCollider`
- ✅ Working suspension system with adjustable spring/damper settings
- ✅ Motor, steering, and braking controls
- ✅ Visual wheel mesh alignment to match collider rotation
- ✅ Simple terrain for testing vehicle dynamics
- ✅ Modular code for easy extension (e.g. add new vehicle types)
- ✅ Anti-roll script to prevent the vehicle from tilting

## Prerequisite

- Unity 6000.0.45f1

## Getting Started

**Clone the Repository:**
```bash
git clone https://github.com/PhiBeo/3D-Vehicle-Movement.git
```

OR

**[Download](https://github.com/PhiBeo/3D-Vehicle-Movement/archive/refs/heads/main.zip) the project**


## Project Timeline (6 weeks)
- Week 1: 
  - Functional moving vehicle with adjustable motor force, brake, and steer
  - The vehicle works, but the mass of the rigid body, motor force and friction need to be adjusted to prevent the car from flipping over
  - Need to add more features to the main script, and make it easier to adjust the value of individual wheels and the main component.
- Week 2-3:
  - Get the demo track built for the test run
  - Implement a small script for the obstacles
 
### Track layout
 ![](Images/RaceTrack.png)

### Red Obstacle
 ![](Images/RedCone.png)

### Speed Boost
![](Images/SpeedBoost.png)

 
- Week 4:
  - Continue to work on some small mechanics for the obstacle and boost
  - Add Cinemachine to the project and make the camera easier to deal with
  - Add a timer and a stop to track how fast the player did

### Mud piles
![](Images/MudPile.png)

### Following Cam and Timer
![](Images/FollowCam.gif)

### Time Stopper
![](Images/TimerStop.gif)


- Week 5-6:
  - Adjust the car physics and make it tilt less when turning
  - Fix issue where the car will roll too much when going over a bump
  - Add more colliders to the car to prevent the wheel collider from getting stuck in the wall
  - Fix issue with the camera becoming blurry when tracking a fast-moving object
 
### Car Components
![](Images/CarComponent.png)


## Final Result
![](Images/FullRun.gif)

## References
- __Unity: Prevent Wheel Collider Slipping/Drifting_: [Youtube](https://www.youtube.com/watch?v=bUTZLCkZd04)
- _How to make Car More Stable in Unity (Anti Roll bars) 2021_: [Youtube](https://www.youtube.com/watch?v=BwL3Dm8GJtQ)
- _Unity3D How To: Driving With Wheel Colliders_: [Youtube](https://www.youtube.com/watch?v=j6_SMdWeGFI)
- Cinemachine camera blur issue solution: [Unity Discussion](https://discussions.unity.com/t/unity-objects-blurring-when-camera-moves/154916) 
