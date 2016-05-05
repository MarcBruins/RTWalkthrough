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
	[Protocol (Name = "RTWalkthroughPage", WrapperType = typeof (RTWalkthroughPageWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Offset", Selector = "walkthroughDidScrollToPosition:offset:", ParameterType = new Type [] { typeof (nfloat), typeof (nfloat) }, ParameterByRef = new bool [] { false, false })]
	public interface IRTWalkthroughPage : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("walkthroughDidScrollToPosition:offset:")]
		[Preserve (Conditional = true)]
		void Offset (global::System.nfloat position, global::System.nfloat offset);
		
	}
	
	internal sealed class RTWalkthroughPageWrapper : BaseWrapper, IRTWalkthroughPage {
		public RTWalkthroughPageWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public RTWalkthroughPageWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("walkthroughDidScrollToPosition:offset:")]
		[CompilerGenerated]
		public void Offset (global::System.nfloat position, global::System.nfloat offset)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat_nfloat (this.Handle, Selector.GetHandle ("walkthroughDidScrollToPosition:offset:"), position, offset);
		}
		
	}
}
namespace RTWalkthrough {
	[Protocol]
	[Register("RTWalkthroughPage", false)]
	[Model]
	public unsafe abstract partial class RTWalkthroughPage : NSObject, IRTWalkthroughPage {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected RTWalkthroughPage () : base (NSObjectFlag.Empty)
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
		protected RTWalkthroughPage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal RTWalkthroughPage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("walkthroughDidScrollToPosition:offset:")]
		[CompilerGenerated]
		public abstract void Offset (global::System.nfloat position, global::System.nfloat offset);
	} /* class RTWalkthroughPage */
}
