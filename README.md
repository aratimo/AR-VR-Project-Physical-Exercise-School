# AR-VR-Project-Physical-Exercise-School

> VR Simulator built with Unity3D.

## Contributors:

- [Arati Mohapatra](https://github.com/aratimo)
- [Rogeshwaran Perumal](https://github.com/Rogeshwaran)
- [Madhullika R](https://github.com/106121071)

## Features

- Immersive School Environment: Experience a lifelike school environment in VR.
- Six Degrees of Freedom (6DoF): Move freely within the virtual environment in all directions.
- Interactive Instructor Guidance: Interact with an instructor guiding you through various physical exercises.
- Exercise Following: Follow along with exercises demonstrated by the instructor.
- Computer Vision Integration: Utilizes standalone computer vision technology to detect and track exercise movements.
- Exercise Rep Counter: Automatically counts exercise repetitions based on detected movements.

## Instructions for Execution for Unity

### Software Dependencies

Unity Version used: Unity 2022.3.11

### Getting Started

#### 1. Clone the Repository

```
git clone https://github.com/aratimo/AR-VR-Project-Physical-Exercise-School.git
```
#### 2. Unity Setup

- Launch Unity and open the cloned project.
- Check and set the required Unity version for the project.

#### 3. Importing External Assets

- Download the Environment Folder from [here](https://drive.google.com/drive/folders/1O44h3biVvEuBDfPRtmVmfVWL2_dkiTVd?usp=sharing) and drag it into the Assets folder in Unity.

### Usage

Go to Assets -> Scenes -> SchoolSceneDay1.unity and drag it to the Hierarchy pane (left side in default layout).

#### Launching the Simulator

- Navigate to the Game pane and make sure the Display is set to Display 3, and then hit the Play Button.

#### Navigating the Simulator

- Use mouse controls to look around, as well as up and down.
- Use the WASD keys to navigate around the environment.
- Once the instructor is visible, use the 'f' button to start the Forward Raises exercise and the 'b' button to start the Bicep Curls exercise.
- Press 't' to stop the exercise at any point in time.

### Troubleshooting

- If the Ground texture is not loaded by default, click on 'Terrain' in the Hierarchy pane (under SchoolSceneDay1) and manually set Terrain Data to 'SchoolTerrain' in the Inspector Panel.
  
