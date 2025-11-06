# changelog
this file documents changes to the repository. entries are in reverse-chronological (newest first) order.


## v1.2.0
this version adds a few quality of life improvements and one new method for Quaternion math.

versions 1.2 and onward will have binaries included in releases.

### breaking changes
- Godot: (behavioral) nearly all usages of `System.MathF` and `System.Math` have been replaced with `Godot.Mathf`, which may result in some very very small changes in behavior.
- Godot: (breaking) renamed `ToVector2I(this Vector2)` extension method to `ToPoint` to keep names consistent with other versions of MathUtil.

### additions
- created this changelog!
- added `double` alternatives to most methods that return `float` or take `float` as a parameter.
- added `FacingDirection` method, which produces a Quaternion rotation from a facing direction and an up vector.

### technical changes
- msbuild: `Version` property is now defined.
- msbuild: `ImplicitUsings` property has been disabled, so that people wishing to directly include the `MathUtil.cs` file in their project will be less likely to run into import problems.
- MonoGame: converted `ToVector2` and `ToPoint` extension methods to regular static methods, because they are redundant with the engine's implementation.
- MonoGame & Numerics: the `Sign` method now uses `System.Math.Sign` instead of `System.MathF.Sign`.


## v1.1.0

- added `BasisFromNormal(Vector3, Vector3, Vector3)` method. The resulting matrix will not be orthonormalized in the MonoGame and System.Numerics versions.


## v1.0.0
initial version
