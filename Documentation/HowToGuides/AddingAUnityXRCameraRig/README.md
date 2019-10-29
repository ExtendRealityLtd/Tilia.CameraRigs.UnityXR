# Adding A UnityXR CameraRig

> * Level: Beginner
>
> * Reading Time: 2 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

The UnityXR CameraRig prefab provides a camera that tracks the HMD rotation and position along with any available XR controllers.

The outcome of this How-To Guide is to learn how to add the UnityXR CameraRig prefab to the scene and configure it for the tracking space type you require.

## Prerequisites

* [Install the Tilia.CameraRigs.UnityXR] package dependency in to your [Unity] project.

## Let's Start

### Step 1

Expand the `Tilia CameraRigs UnityXR` Package directory in the Unity Project window and select then `Packages -> Tilia CameraRigs UnityXR -> Runtime -> Prefabs` directory then drag and drop the `CameraRigs.UnityXR` prefab into the Hierarchy window.

![Adding Prefab To Scene](assets/images/AddingPrefabToScene.png)

### Step 2

Delete the `Main Camera` GameObject from the Unity Hierarchy window as the `CameraRigs.UnityXR` prefab contains a `Main Camera` for the Scene.

### Step 3

Select the `CameraRigs.UnityXR` GameObject in the Hierarchy window and change the `Unity XR Configuration` component to suit your Tracking Space requirements.

* Ensure the `Tracking Space Type` is set to:
  * `Room Scale` for XR devices that support 6 degrees of freedom tracking (the ability to move around your play area).
  * `Stationary` for XR devices that support 3 degrees of freedom tracking (only the ability to look around but not move within your play area).

![Configure Tracking Space Type](assets/images/ConfigureTrackingSpaceType.png)

### Done

Now you have a UnityXR CameraRig in your scene. If you play the Unity scene you will see that the game Main Camera is tracking the XR HMD and if there is a connected left and/or right XR controller then they will be tracking the Left/Right Anchors of the UnityXR CameraRig.

![Prefab In Scene](assets/images/PrefabInScene.png)

[Install the Tilia.CameraRigs.UnityXR]: ../Installation/README.md
[Unity]: https://unity3d.com/