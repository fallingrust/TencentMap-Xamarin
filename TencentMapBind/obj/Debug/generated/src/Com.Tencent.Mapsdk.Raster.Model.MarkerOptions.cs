using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/MarkerOptions", DoNotGenerateAcw=true)]
	public sealed partial class MarkerOptions : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/field[@name='id']"
		[Register ("id")]
		protected string Id {
			get {
				const string __id = "id.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "id.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/MarkerOptions", typeof (MarkerOptions));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal MarkerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/constructor[@name='MarkerOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarkerOptions ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				const string __id = "getAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AnchorU {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getAnchorU' and count(parameter)=0]"
			[Register ("getAnchorU", "()F", "GetGetAnchorUHandler")]
			get {
				const string __id = "getAnchorU.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AnchorV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getAnchorV' and count(parameter)=0]"
			[Register ("getAnchorV", "()F", "GetGetAnchorVHandler")]
			get {
				const string __id = "getAnchorV.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.Animations.Animation HidingAnination {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getHidingAnination' and count(parameter)=0]"
			[Register ("getHidingAnination", "()Landroid/view/animation/Animation;", "GetGetHidingAninationHandler")]
			get {
				const string __id = "getHidingAnination.()Landroid/view/animation/Animation;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.Animations.Animation InfoWindowHideAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getInfoWindowHideAnimation' and count(parameter)=0]"
			[Register ("getInfoWindowHideAnimation", "()Landroid/view/animation/Animation;", "GetGetInfoWindowHideAnimationHandler")]
			get {
				const string __id = "getInfoWindowHideAnimation.()Landroid/view/animation/Animation;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.Animations.Animation InfoWindowShowAnimation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getInfoWindowShowAnimation' and count(parameter)=0]"
			[Register ("getInfoWindowShowAnimation", "()Landroid/view/animation/Animation;", "GetGetInfoWindowShowAnimationHandler")]
			get {
				const string __id = "getInfoWindowShowAnimation.()Landroid/view/animation/Animation;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsDraggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				const string __id = "isDraggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsGps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='isGps' and count(parameter)=0]"
			[Register ("isGps", "()Z", "GetIsGpsHandler")]
			get {
				const string __id = "isGps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.View MarkerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getMarkerView' and count(parameter)=0]"
			[Register ("getMarkerView", "()Landroid/view/View;", "GetGetMarkerViewHandler")]
			get {
				const string __id = "getMarkerView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/tencent/mapsdk/raster/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()F", "GetGetRotationHandler")]
			get {
				const string __id = "getRotation.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Views.Animations.Animation ShowingAnination {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getShowingAnination' and count(parameter)=0]"
			[Register ("getShowingAnination", "()Landroid/view/animation/Animation;", "GetGetShowingAninationHandler")]
			get {
				const string __id = "getShowingAnination.()Landroid/view/animation/Animation;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				const string __id = "getSnippet.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='alpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alpha", "(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeAlpha (float p0)
		{
			const string __id = "alpha.(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='anchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("anchor", "(FF)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions Anchor (float p0, float p1)
		{
			const string __id = "anchor.(FF)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='draggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("draggable", "(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions Draggable (bool p0)
		{
			const string __id = "draggable.(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor']]"
		[Register ("icon", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeIcon (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0)
		{
			const string __id = "icon.(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='infoWindowHideAnimation' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("infoWindowHideAnimation", "(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeInfoWindowHideAnimation (global::Android.Views.Animations.Animation p0)
		{
			const string __id = "infoWindowHideAnimation.(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='infoWindowShowAnimation' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("infoWindowShowAnimation", "(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeInfoWindowShowAnimation (global::Android.Views.Animations.Animation p0)
		{
			const string __id = "infoWindowShowAnimation.(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='markerView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("markerView", "(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeMarkerView (global::Android.Views.View p0)
		{
			const string __id = "markerView.(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='position' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("position", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokePosition (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			const string __id = "position.(Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='rotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("rotation", "(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeRotation (float p0)
		{
			const string __id = "rotation.(F)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='setHidingAnination' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("setHidingAnination", "(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions SetHidingAnination (global::Android.Views.Animations.Animation p0)
		{
			const string __id = "setHidingAnination.(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='setShowingAnination' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
		[Register ("setShowingAnination", "(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions SetShowingAnination (global::Android.Views.Animations.Animation p0)
		{
			const string __id = "setShowingAnination.(Landroid/view/animation/Animation;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='snippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("snippet", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeSnippet (string p0)
		{
			const string __id = "snippet.(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='tag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("tag", "(Ljava/lang/Object;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeTag (global::Java.Lang.Object p0)
		{
			const string __id = "tag.(Ljava/lang/Object;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='title' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("title", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions InvokeTitle (string p0)
		{
			const string __id = "title.(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='MarkerOptions']/method[@name='visible' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("visible", "(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions Visible (bool p0)
		{
			const string __id = "visible.(Z)Lcom/tencent/mapsdk/raster/model/MarkerOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
