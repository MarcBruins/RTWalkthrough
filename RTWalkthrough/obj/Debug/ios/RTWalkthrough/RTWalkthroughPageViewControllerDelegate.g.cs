//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace RTWalkthrough {
	[Protocol (Name = "RTWalkthroughPageViewControllerDelegate", WrapperType = typeof (RTWalkthroughPageViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WalkthroughPageRequestsClosing", Selector = "walkthroughPageRequestsClosing:", ParameterType = new Type [] { typeof (RTWalkthrough.RTWalkthroughPageViewController) }, ParameterByRef = new bool [] { false })]
	public interface IRTWalkthroughPageViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class RTWalkthroughPageViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void WalkthroughPageRequestsClosing (this IRTWalkthroughPageViewControllerDelegate This, RTWalkthroughPageViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("walkthroughPageRequestsClosing:"), controller.Handle);
		}
		
	}
	
	internal sealed class RTWalkthroughPageViewControllerDelegateWrapper : BaseWrapper, IRTWalkthroughPageViewControllerDelegate {
		public RTWalkthroughPageViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public RTWalkthroughPageViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace RTWalkthrough {
	[Protocol]
	[Register("RTWalkthroughPageViewControllerDelegate", false)]
	[Model]
	public unsafe partial class RTWalkthroughPageViewControllerDelegate : NSObject, IRTWalkthroughPageViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RTWalkthroughPageViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected RTWalkthroughPageViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RTWalkthroughPageViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("walkthroughPageRequestsClosing:")]
		[CompilerGenerated]
		public virtual void WalkthroughPageRequestsClosing (RTWalkthroughPageViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class RTWalkthroughPageViewControllerDelegate */
}
