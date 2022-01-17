namespace Tilia.CameraRigs.UnityXR
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Utility;

    /// <summary>
    /// Provides the description for a UnityXR CameraRig node element.
    /// </summary>
    public class UnityXRNodeRecord : DeviceDetailsRecord
    {
        /// <summary>
        /// The source property to match against.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public XRNode NodeType { get; set; }

        /// <inheritdoc/>
        public override XRNode XRNodeType
        {
            get
            {
                return NodeType;
            }
            protected set { NodeType = value; }
        }
        /// <inheritdoc/>
        public override bool IsConnected { get => XRDeviceProperties.IsTracked(NodeType); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => 0; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Manufacturer { get => XRDeviceProperties.Manufacturer(NodeType); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override string Model
        {
            get
            {
                if (NodeType == XRNode.Head && !SystemInfo.deviceModel.ToLower().Contains("system product name"))
                {
                    return SystemInfo.deviceModel;
                }
                else
                {
                    return XRDeviceProperties.Model(NodeType);

                }
            }
            protected set => throw new System.NotImplementedException();
        }
        /// <inheritdoc/>
        public override SpatialTrackingType TrackingType
        {
            get
            {
                if (XRDeviceProperties.HasPositionalTracking(NodeType) && XRDeviceProperties.HasRotationalTracking(NodeType))
                {
                    return SpatialTrackingType.RotationAndPosition;
                }
                else if (XRDeviceProperties.HasRotationalTracking(NodeType))
                {
                    return SpatialTrackingType.RotationOnly;
                }
                else
                {
                    return SpatialTrackingType.None;
                }
            }
            protected set => throw new System.NotImplementedException();
        }
        /// <inheritdoc/>
        public override float BatteryLevel
        {
            get
            {
                if (NodeType == XRNode.Head)
                {
                    return SystemInfo.batteryLevel;
                }
                else
                {
                    return XRDeviceProperties.BatteryLevel(NodeType);

                }
            }
            protected set => throw new System.NotImplementedException();
        }
        /// <inheritdoc/>
        public override BatteryStatus BatteryChargeStatus { get => BatteryStatus.Unknown; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// The last known battery charge status.
        /// </summary>
        protected BatteryStatus lastKnownBatteryStatus;
        /// <summary>
        /// The last known is connected status.
        /// </summary>
        protected bool lastKnownIsConnected;
        /// <summary>
        /// The last known tracking type.
        /// </summary>
        protected SpatialTrackingType lastKnownTrackingType;

        /// <summary>
        /// Sets the <see cref="NodeType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="XRNode"/>.</param>
        public virtual void SetNodeType(int index)
        {
            NodeType = EnumExtensions.GetByIndex<XRNode>(index);
        }

        /// <inheritdoc/>
        protected override bool HasBatteryChargeStatusChanged()
        {
            bool hasChanged = BatteryChargeStatus != lastKnownBatteryStatus;
            if (hasChanged)
            {
                BatteryChargeStatusChanged?.Invoke(BatteryChargeStatus);
            }
            lastKnownBatteryStatus = BatteryChargeStatus;
            return hasChanged;
        }

        /// <inheritdoc/>
        protected override bool HasIsConnectedChanged()
        {
            bool hasChanged = IsConnected != lastKnownIsConnected;
            if (hasChanged)
            {
                ConnectionStatusChanged?.Invoke(IsConnected);
            }
            lastKnownIsConnected = IsConnected;
            return hasChanged;
        }

        /// <inheritdoc/>
        protected override bool HasTrackingTypeChanged()
        {
            bool hasChanged = TrackingType != lastKnownTrackingType;
            if (hasChanged)
            {
                TrackingTypeChanged?.Invoke(TrackingType);
            }
            lastKnownTrackingType = TrackingType;
            return hasChanged;
        }
    }
}