using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace RTWalkthrough
{
	// @interface RTWalkthroughPageViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface RTWalkthroughPageViewController
	{
		// @property (nonatomic) CGPoint speed;
		[Export("speed", ArgumentSemantic.Assign)]
		CGPoint Speed { get; set; }

		// @property (nonatomic) CGPoint speedVariance;
		[Export("speedVariance", ArgumentSemantic.Assign)]
		CGPoint SpeedVariance { get; set; }

		// @property (nonatomic) RTWalkthroughAnimationType animationType;
		[Export("animationType", ArgumentSemantic.Assign)]
		RTWalkthroughAnimationType AnimationType { get; set; }

		// @property (nonatomic) BOOL animateAlpha;
		[Export("animateAlpha")]
		bool AnimateAlpha { get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		RTWalkthroughPageViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<RTWalkthroughPageViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @protocol RTWalkthroughPageViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RTWalkthroughPageViewControllerDelegate
	{
		// @optional -(void)walkthroughPageRequestsClosing:(RTWalkthroughPageViewController *)controller;
		[Export("walkthroughPageRequestsClosing:")]
		void WalkthroughPageRequestsClosing(RTWalkthroughPageViewController controller);
	}

	// @interface RTWalkthroughViewController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface RTWalkthroughViewController
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		RTWalkthroughViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<RTWalkthroughViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) NSInteger currentPage;
		[Export("currentPage")]
		nint CurrentPage { get; }

		// -(void)addViewController:(UIViewController *)vc;
		[Export("addViewController:")]
		void AddViewController(UIViewController vc);
	}

	// @protocol RTWalkthroughViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RTWalkthroughViewControllerDelegate
	{
		// @optional -(void)walkthroughControllerDidClose:(RTWalkthroughViewController *)controller;
		[Export("walkthroughControllerDidClose:")]
		void WalkthroughControllerDidClose(RTWalkthroughViewController controller);

		// @optional -(void)walkthroughControllerWentNext:(RTWalkthroughViewController *)controller;
		[Export("walkthroughControllerWentNext:")]
		void WalkthroughControllerWentNext(RTWalkthroughViewController controller);

		// @optional -(void)walkthroughControllerWentPrev:(RTWalkthroughViewController *)controller;
		[Export("walkthroughControllerWentPrev:")]
		void WalkthroughControllerWentPrev(RTWalkthroughViewController controller);

		// @optional -(void)walkthroughController:(RTWalkthroughViewController *)controller didChangeToPage:(NSInteger)page;
		[Export("walkthroughController:didChangeToPage:")]
		void WalkthroughController(RTWalkthroughViewController controller, nint page);
	}

	// @protocol RTWalkthroughPage <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RTWalkthroughPage
	{
		// @required -(void)walkthroughDidScrollToPosition:(CGFloat)position offset:(CGFloat)offset;
		[Abstract]
		[Export("walkthroughDidScrollToPosition:offset:")]
		void Offset(nfloat position, nfloat offset);
	}
}
