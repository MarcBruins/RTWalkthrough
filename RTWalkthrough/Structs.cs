using System;
using ObjCRuntime;

namespace RTWalkthrough
{
	[Native]
	public enum RTWalkthroughAnimationType : long
	{
		Linear,
		Curve,
		Zoom,
		InOut
	}
}
