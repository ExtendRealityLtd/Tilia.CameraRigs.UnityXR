# Class UnityXRNodeRecord

Provides the description for a UnityXR CameraRig node element.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [lastKnownBatteryStatus]
  * [lastKnownIsConnected]
  * [lastKnownTrackingType]
* [Properties]
  * [BatteryChargeStatus]
  * [BatteryLevel]
  * [IsConnected]
  * [Manufacturer]
  * [Model]
  * [NodeType]
  * [Priority]
  * [TrackingType]
  * [XRNodeType]
* [Methods]
  * [HasBatteryChargeStatusChanged()]
  * [HasIsConnectedChanged()]
  * [HasTrackingTypeChanged()]
  * [SetNodeType(Int32)]

## Details

##### Inheritance

* System.Object
* UnityXRNodeRecord

##### Namespace

* [Tilia.CameraRigs.UnityXR]

##### Syntax

```
public class UnityXRNodeRecord : DeviceDetailsRecord
```

### Fields

#### lastKnownBatteryStatus

The last known battery charge status.

##### Declaration

```
protected BatteryStatus lastKnownBatteryStatus
```

#### lastKnownIsConnected

The last known is connected status.

##### Declaration

```
protected bool lastKnownIsConnected
```

#### lastKnownTrackingType

The last known tracking type.

##### Declaration

```
protected SpatialTrackingType lastKnownTrackingType
```

### Properties

#### BatteryChargeStatus

##### Declaration

```
public override BatteryStatus BatteryChargeStatus { get; protected set; }
```

#### BatteryLevel

##### Declaration

```
public override float BatteryLevel { get; protected set; }
```

#### IsConnected

##### Declaration

```
public override bool IsConnected { get; protected set; }
```

#### Manufacturer

##### Declaration

```
public override string Manufacturer { get; protected set; }
```

#### Model

##### Declaration

```
public override string Model { get; protected set; }
```

#### NodeType

The Node Type for the record.

##### Declaration

```
public XRNode NodeType { get; set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### TrackingType

##### Declaration

```
public override SpatialTrackingType TrackingType { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### HasBatteryChargeStatusChanged()

##### Declaration

```
protected override bool HasBatteryChargeStatusChanged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

#### HasIsConnectedChanged()

##### Declaration

```
protected override bool HasIsConnectedChanged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

#### HasTrackingTypeChanged()

##### Declaration

```
protected override bool HasTrackingTypeChanged()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | n/a |

#### SetNodeType(Int32)

Sets the [NodeType].

##### Declaration

```
public virtual void SetNodeType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the XRNode. |

[Tilia.CameraRigs.UnityXR]: README.md
[NodeType]: UnityXRNodeRecord.md#NodeType
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[lastKnownBatteryStatus]: #lastKnownBatteryStatus
[lastKnownIsConnected]: #lastKnownIsConnected
[lastKnownTrackingType]: #lastKnownTrackingType
[Properties]: #Properties
[BatteryChargeStatus]: #BatteryChargeStatus
[BatteryLevel]: #BatteryLevel
[IsConnected]: #IsConnected
[Manufacturer]: #Manufacturer
[Model]: #Model
[NodeType]: #NodeType
[Priority]: #Priority
[TrackingType]: #TrackingType
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[HasBatteryChargeStatusChanged()]: #HasBatteryChargeStatusChanged
[HasIsConnectedChanged()]: #HasIsConnectedChanged
[HasTrackingTypeChanged()]: #HasTrackingTypeChanged
[SetNodeType(Int32)]: #SetNodeTypeInt32
