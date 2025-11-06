#!/usr/bin/env bash

VERSION=1.2.0

rm -rf ./bin
mkdir ./bin

# dotnet publish
dotnet restore /tl:off
dotnet test /tl:off --no-build --verbosity normal
dotnet publish MathUtil.sln --no-restore /tl:off /p:Version=$VERSION

# collect binaries into one place
cp ./MathUtil.Godot/.godot/mono/temp/bin/Release/publish/MathUtil.Godot.{dll,pdb} ./bin/
cp ./MathUtil.MonoGame/bin/Release/net8.0/publish/MathUtil.MonoGame.{dll,pdb} ./bin/
cp ./MathUtil.Numerics/bin/Release/net8.0/publish/MathUtil.Numerics.{dll,pdb} ./bin/
