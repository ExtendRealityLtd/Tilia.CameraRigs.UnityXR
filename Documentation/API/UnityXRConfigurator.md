# Class UnityXRConfigurator

Provides a way to configure settings within the Unity Engine in XR namespace.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [LockPhysicsUpdateRateToRenderFrequency]
  * [TrackingSpaceType]
* [Methods]
  * [OnAfterLockPhysicsUpdateRateToRenderFrequencyChange()]
  * [OnAfterTrackingSpaceTypeChange()]
  * [OnEnable()]
  * [Update()]
  * [UpdateFixedDeltaTime()]
  * [UpdateTrackingSpaceType()]

## Details

##### Inheritance

* System.Object
* UnityXRConfigurator

##### Namespace

* [Tilia.CameraRigs.UnityXR]

##### Syntax

```
public class UnityXRConfigurator : MonoBehaviour
```

### Properties

#### LockPhysicsUpdateRateToRenderFrequency

Automatically set the Unity Physics Fixed Timestep value based on the headset render frequency.

##### Declaration

```
public bool LockPhysicsUpdateRateToRenderFrequency { get; set; }
```

#### TrackingSpaceType

Represents the type of physical space available for XR.

##### Declaration

```
public TrackingSpaceType TrackingSpaceType { get; set; }
```

### Methods

#### OnAfterLockPhysicsUpdateRateToRenderFrequencyChange()

Called after [LockPhysicsUpdateRateToRenderFrequency] has been changed.

##### Declaration

```
protected virtual void OnAfterLockPhysicsUpdateRateToRenderFrequencyChange()
```

#### OnAfterTrackingSpaceTypeChange()

Called after [TrackingSpaceType] has been changed.

##### Declaration

```
protected virtual void OnAfterTrackingSpaceTypeChange()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### Update()

##### Declaration

```
protected virtual void Update()
```

#### UpdateFixedDeltaTime()

Updates the fixed delta time to the appropriate value.

##### Declaration

```
protected virtual void UpdateFixedDeltaTime()
```

#### UpdateTrackingSpaceType()

Updates the tracking space type.

##### Declaration

```
protected virtual void UpdateTrackingSpaceType()
```

[Tilia.CameraRigs.UnityXR]: README.md
[LockPhysicsUpdateRateToRenderFrequency]: UnityXRConfigurator.md#LockPhysicsUpdateRateToRenderFrequency
[TrackingSpaceType]: UnityXRConfigurator.md#TrackingSpaceType
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[LockPhysicsUpdateRateToRenderFrequency]: #LockPhysicsUpdateRateToRenderFrequency
[TrackingSpaceType]: #TrackingSpaceType
[Methods]: #Methods
[OnAfterLockPhysicsUpdateRateToRenderFrequencyChange()]: #OnAfterLockPhysicsUpdateRateToRenderFrequencyChange
[OnAfterTrackingSpaceTypeChange()]: #OnAfterTrackingSpaceTypeChange
[OnEnable()]: #OnEnable
[Update()]: #Update
[UpdateFixedDeltaTime()]: #UpdateFixedDeltaTime
[UpdateTrackingSpaceType()]: #UpdateTrackingSpaceType
