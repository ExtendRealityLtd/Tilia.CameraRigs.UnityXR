namespace Tilia.CameraRigs.UnityXR
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;

    /// <summary>
    /// Provides a way to configure settings within the Unity Engine in XR namespace.
    /// </summary>
    public class UnityXRConfigurator : MonoBehaviour
    {
        /// <summary>
        /// Represents the type of physical space available for XR.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public TrackingSpaceType TrackingSpaceType { get; set; } = TrackingSpaceType.RoomScale;
        /// <summary>
        /// Automatically set the Unity Physics Fixed TimeStep value based on the headset render frequency.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool LockPhysicsUpdateRateToRenderFrequency { get; set; } = true;

        /// <summary>
        /// Sets <see cref="TrackingSpaceType"/>.
        /// </summary>
        /// <param name="trackingSpaceTypeIndex">The index of the <see cref="UnityEngine.XR.TrackingSpaceType"/>.</param>
        public virtual void SetTrackingSpaceType(int trackingSpaceTypeIndex)
        {
            TrackingSpaceType = EnumExtensions.GetByIndex<TrackingSpaceType>(trackingSpaceTypeIndex);
        }

        protected virtual void OnEnable()
        {
            UpdateTrackingSpaceType();
        }

        protected virtual void Update()
        {
            UpdateFixedDeltaTime();
        }

        /// <summary>
        /// Updates the tracking space type.
        /// </summary>
        protected virtual void UpdateTrackingSpaceType()
        {
            XRDevice.SetTrackingSpaceType(TrackingSpaceType);
        }

        /// <summary>
        /// Updates the fixed delta time to the appropriate value.
        /// </summary>
        protected virtual void UpdateFixedDeltaTime()
        {
            if (LockPhysicsUpdateRateToRenderFrequency
                && Time.timeScale > 0.0f
                && !string.IsNullOrEmpty(XRSettings.loadedDeviceName))
            {
                Time.fixedDeltaTime = Time.timeScale / XRDevice.refreshRate;
            }
        }

        /// <summary>
        /// Called after <see cref="TrackingSpaceType"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(TrackingSpaceType))]
        protected virtual void OnAfterTrackingSpaceTypeChange()
        {
            UpdateTrackingSpaceType();
        }

        /// <summary>
        /// Called after <see cref="LockPhysicsUpdateRateToRenderFrequency"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LockPhysicsUpdateRateToRenderFrequency))]
        protected virtual void OnAfterLockPhysicsUpdateRateToRenderFrequencyChange()
        {
            UpdateFixedDeltaTime();
        }
    }
}