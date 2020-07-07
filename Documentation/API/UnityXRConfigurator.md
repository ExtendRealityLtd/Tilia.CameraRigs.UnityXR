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
  * [SetTrackingSpaceType(Int32)]
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

Automatically set the Unity Physics Fixed TimeStep value based on the headset render frequency.

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

#### SetTrackingSpaceType(Int32)

Sets [TrackingSpaceType].

##### Declaration

```
public virtual void SetTrackingSpaceType(int trackingSpaceTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | trackingSpaceTypeIndex | The index of the UnityEngine.XR.TrackingSpaceType. |

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
[SetTrackingSpaceType(Int32)]: #SetTrackingSpaceTypeInt32
[Update()]: #Update
[UpdateFixedDeltaTime()]: #UpdateFixedDeltaTime
[UpdateTrackingSpaceType()]: #UpdateTrackingSpaceType
