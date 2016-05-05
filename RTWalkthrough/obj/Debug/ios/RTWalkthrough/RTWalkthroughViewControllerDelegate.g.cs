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
	[Protocol (Name = "RTWalkthroughViewControllerDelegate", WrapperType = typeof (RTWalkthroughViewControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WalkthroughControllerDidClose", Selector = "walkthroughControllerDidClose:", ParameterType = new Type [] { typeof (RTWalkthrough.RTWalkthroughViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WalkthroughControllerWentNext", Selector = "walkthroughControllerWentNext:", ParameterType = new Type [] { typeof (RTWalkthrough.RTWalkthroughViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WalkthroughControllerWentPrev", Selector = "walkthroughControllerWentPrev:", ParameterType = new Type [] { typeof (RTWalkthrough.RTWalkthroughViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WalkthroughController", Selector = "walkthroughController:didChangeToPage:", ParameterType = new Type [] { typeof (RTWalkthrough.RTWalkthroughViewController), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	public interface IRTWalkthroughViewControllerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class RTWalkthroughViewControllerDelegate_Extensions {
		[CompilerGenerated]
		public static void WalkthroughControllerDidClose (this IRTWalkthroughViewControllerDelegate This, RTWalkthroughViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("walkthroughControllerDidClose:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void WalkthroughControllerWentNext (this IRTWalkthroughViewControllerDelegate This, RTWalkthroughViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("walkthroughControllerWentNext:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void WalkthroughControllerWentPrev (this IRTWalkthroughViewControllerDelegate This, RTWalkthroughViewController controller)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("walkthroughControllerWentPrev:"), controller.Handle);
		}
		
		[CompilerGenerated]
		public static void WalkthroughController (this IRTWalkthroughViewControllerDelegate This, RTWalkthroughViewController controller, global::System.nint page)
		{
			if (controller == null)
				throw new ArgumentNullException ("controller");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("walkthroughController:didChangeToPage:"), controller.Handle, page);
		}
		
	}
	
	internal sealed class RTWalkthroughViewControllerDelegateWrapper : BaseWrapper, IRTWalkthroughViewControllerDelegate {
		public RTWalkthroughViewControllerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public RTWalkthroughViewControllerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace RTWalkthrough {
	[Protocol]
	[Register("RTWalkthroughViewControllerDelegate", false)]
	[Model]
	public unsafe partial class RTWalkthroughViewControllerDelegate : NSObject, IRTWalkthroughViewControllerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public RTWalkthroughViewControllerDelegate () : base (NSObjectFlag.Empty)
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
		protected RTWalkthroughViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RTWalkthroughViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("walkthroughController:didChangeToPage:")]
		[CompilerGenerated]
		public virtual void WalkthroughController (RTWalkthroughViewController controller, global::System.nint page)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("walkthroughControllerDidClose:")]
		[CompilerGenerated]
		public virtual void WalkthroughControllerDidClose (RTWalkthroughViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("walkthroughControllerWentNext:")]
		[CompilerGenerated]
		public virtual void WalkthroughControllerWentNext (RTWalkthroughViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("walkthroughControllerWentPrev:")]
		[CompilerGenerated]
		public virtual void WalkthroughControllerWentPrev (RTWalkthroughViewController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class RTWalkthroughViewControllerDelegate */
}
