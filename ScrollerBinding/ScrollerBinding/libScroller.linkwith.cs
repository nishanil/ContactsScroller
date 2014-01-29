using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libScroller.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV6 , Frameworks = "AudioToolbox", ForceLoad = true)]
