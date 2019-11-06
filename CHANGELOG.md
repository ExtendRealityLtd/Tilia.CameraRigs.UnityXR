# Changelog

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/compare/v1.0.2...v1.0.3) (2019-11-06)

#### Bug Fixes

* **prefab:** provide correct velocity source properties ([bc5d867](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/commit/bc5d867a60b0972845397361b460d974a3ba94df))
  > The Source and RelativeTo properties on the RightHandAnchor AverageVelocityEstimator were set to the incorrect references.
  > 
  > These have now been updated to the correct reference.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/compare/v1.0.1...v1.0.2) (2019-11-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.6.0 to 1.7.0 ([b289c96](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/commit/b289c96456c75c7c329c6e1a40f67a24fb247221))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.6.0 to 1.7.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.6.0...v1.7.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/compare/v1.0.0...v1.0.1) (2019-11-05)

#### Bug Fixes

* **README.md:** add separator between package namespace and title ([d6992a0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/commit/d6992a08f3a9868080e64e7bfe69f1e2dd8e653d))
  > Using the `Namespace -> Title` format makes it easier and clearer to understand the separation between the project namespace and the specific project tile.
  > 
  > The outline colour on images has also been changed to magenta as this seems to stand out the best on a range of devices.

## 1.0.0 (2019-10-29)

#### Features

* **structure:** create initial prefab and user guides ([7bd8819](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/commit/7bd881914b5ecb3b0309707b84ccee415e9b80ed))
  > The structure of the repository has been created with all the required files for the package, the prefab and the documentation.

#### Bug Fixes

* **package.json:** include Documentation directory with package ([6ed9224](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/commit/6ed9224309579abb22bc5292cfb563fa154c1c0a))
  > The Documentation directory should be included with the package so the built package has the required documentation for users to refer to when the package is installed.
