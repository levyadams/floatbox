# Floatbox - Example project for unity

Floatbox is a example/tutorial for http://wiki.unity3d.com/index.php/DepthMask, but with updated code and a working example!

## What is floatbox for?

There are a million uses, but in this example we use the NewRenderQueue.cs file to render the standard water asset AFTER everything else. When we attach the DepthMask.shader to the cube we are using, we are telling unity that anything drawn behind this object should not be shown at all.

More info obviously here ---> http://wiki.unity3d.com/index.php/DepthMask <---